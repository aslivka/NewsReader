using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using NewsArticle;
using System.Windows.Forms;

namespace NewsSite
{
    class SiteArticles
    {
        private string _articleData = string.Empty;
        private string _apiKey;
        List<ArticleJSON> _articles;
        string _source, _sortBy;


      
        public void ConnectToSite(string source, string apiKey, string sortBy)
        {
            //Creating http url
            this._source = source;
            this._sortBy = sortBy;
            this._apiKey = apiKey;
            string httpUrl = @"https://newsapi.org/v1/articles?source=" + source + "&sortBy="
                + sortBy + "&apiKey=" + apiKey;

            //Sending HTTP get request
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(httpUrl);

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
                                       
                    // Displays the MessageBox.
                    //MessageBox.Show(message, caption, buttons);

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

         private static string formatJSONList(string strSource, string strStart)
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


        public void DownloadArticles()
        {
            _articles = GetDeserializedArticles(_articleData);
        }

        public List<ArticleJSON> GetDeserializedArticles(string articleData)
        {
            string FormattedArticleData = formatJSONList(articleData, "articles");
            //Creating list of Article objects from JSON string data
             return (JsonConvert.DeserializeObject<List<ArticleJSON>>(FormattedArticleData));
        }

        public string getSource()
        {
            return _source;
        }

        public List<ArticleJSON> getArticles()
        {
            return _articles;
        }
        
        public string DisplayArticles(List<ArticleJSON> articles, int articleCount)
        {
            System.Text.StringBuilder newText = new System.Text.StringBuilder();
           
            for (int i = 0; i < articleCount; i++)
            {
                newText.Append("\n" + (i + 1).ToString() + ": ");
                newText.Append(articles[i].Title + "\n");
            }
            return newText.ToString();
        }



    }
}
