using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using NewsCollection;
using System.Windows.Forms;

namespace NewsCollection
{
      public abstract class SiteData
    {
        protected List<ArticleJSON> _articles = new List<ArticleJSON>();
        protected string _source;
        protected string _siteUrl;
        protected int _numArticles;
       
        virtual public void setSiteUrl(string source, string sortBy) { }
        virtual public void setSiteUrl(string siteUrl) { }
        virtual public void downloadArticles() { }
        virtual public void deserializeArticles() { }
        virtual public string DisplayArticles(List<ArticleJSON> articles)
        {
            return "";
        }

        public List<ArticleJSON> getArticles()
        {
            return _articles;
        }

        public string getSource()
        {
            return _source;
        }

        public int getArticleCount()
        {
            return _numArticles;
        }

    }

    public class NewsAPISite : SiteData
    {
        private string _articleData = string.Empty;
        private string _apiKey = "0392c544d8b147a4ae0ffb4e424a897c";
        private string _sortBy;
      
        public override void setSiteUrl(string source, string sortBy)
        {
            //Creating http url
            _source = source;
            _sortBy = sortBy;
            _siteUrl = @"https://newsapi.org/v1/articles?source=" + _source + "&sortBy="
                + _sortBy + "&apiKey=" + _apiKey;
        }

        public override void setSiteUrl(string siteUrl)
        {
            //Creating http url
            this._siteUrl = siteUrl;
        }

        public override void downloadArticles()
        {
             //Sending HTTP get request
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_siteUrl);

                //Enabling decompression
                request.AutomaticDecompression = DecompressionMethods.GZip;

                //Receiving JSON data as string
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                if(HttpStatusCode.OK == response.StatusCode)
                    {
                        using (Stream stream = response.GetResponseStream())
                        using (StreamReader reader = new StreamReader(stream))
                        {
                            _articleData = reader.ReadToEnd();
                            response.Close();
                            reader.Close();
                        }
                    }
            }
            
            //Catching connection issues
            catch (WebException e)
            {
                using (WebResponse response = e.Response)
                {
                    HttpWebResponse httpResponse = (HttpWebResponse)response;

                    string message = "Error code: " + httpResponse.StatusCode.ToString() + "\n";
                    string caption = "Connection Error";
                                       
                    using (Stream data = response.GetResponseStream())
                    {
                        string text = new StreamReader(data).ReadToEnd();
                        message = message + text;
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(message, caption, buttons, MessageBoxIcon.Error);
                    }
                }
            }
         }

         private string formatJSONList(string strSource, string strStart)
            {
                int Start, End;
                if (strSource.Contains(strStart))
                {
                    Start = strSource.IndexOf(strStart, 0);
                    End = strSource.Length - 1;
                    int offset = strStart.Length + 2;
                    int newLength = End - Start - offset;

                    string newString = strSource.Substring(Start + offset, newLength);
                    return newString;
                }
                else
                {
                    return "";
                }
            }

        public override void deserializeArticles()
        {
            //Creating list of Article objects from JSON string data
            string FormattedArticleData = formatJSONList(_articleData, "articles");
            _articles = JsonConvert.DeserializeObject<List<ArticleJSON>>(FormattedArticleData);
            _numArticles = _articles.Count;
        }

          public override string DisplayArticles(List<ArticleJSON> articles)
        {
            System.Text.StringBuilder newText = new System.Text.StringBuilder();
           
            for (int i = 0; i < _numArticles; i++)
            {
                newText.Append("\n" + (i + 1).ToString() + ": ");
                newText.Append(articles[i].Title + "\n");
                newText.Append(articles[i].URL + "\n");
            }
            return newText.ToString();
        }

    }
}
