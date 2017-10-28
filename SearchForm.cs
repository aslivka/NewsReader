using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using NewsArticle;
using NewsSite;

namespace NewsReader
{
    public partial class SearchForm : Form
    {
        public string searchResults;
        int siteCount;
        List<SiteArticles> totalSiteList = new List<SiteArticles>();

        //Ars Technica
        //BBC News
        //CNN
        //Google News
        //New York Times
        //Reuters
        //Techcrunch
        //TechRadar
        //The Economist
        //USA Today
        string[] allSources = new string[]{ "ars-technica", "bbc-news", "cnn", "google-news",
                   "the-new-york-times", "reuters", "techcrunch", "techradar",
                    "the-economist", "usa-today"};
       List<string> selectedSources = new List<string>();
       List<ArticleJSON> articles = new List<ArticleJSON>();

        public SearchForm()
        {
            InitializeComponent();

        }

        private void ShowAllButton_Click(object sender, EventArgs e)
        {
            string apiKey = "0392c544d8b147a4ae0ffb4e424a897c";
            string sortBy = "top";
            int numberOfSites = selectedSources.Count;
            
            for(int i = 0; i < numberOfSites; i++)
            {
                string articleData = string.Empty;
                SiteArticles site1 = new SiteArticles();
                site1.ConnectToSite(selectedSources[i], apiKey, sortBy);
                site1.DownloadArticles();
                totalSiteList.Add(site1);
                
           }     

            siteCount = totalSiteList.Count();
              DisplaySites(totalSiteList);
        }

        //private void ArticleResultsBox_TextChanged(object sender, EventArgs e)
        //{

        //}
        private void DisplaySites(List<SiteArticles> sites)
        {
            //System.Text.StringBuilder newText = new System.Text.StringBuilder();

            for (int i = 0; i < sites.Count; i++)
            {
                ArticleResultsBox.DeselectAll();
                ArticleResultsBox.SelectionFont = new Font(ArticleResultsBox.SelectionFont, FontStyle.Bold);
                ArticleResultsBox.AppendText("Source: " + sites[i].getSource() + "\n");
                int articleCount = sites[i].getArticles().Count;
                ArticleResultsBox.AppendText(sites[i].DisplayArticles(sites[i].getArticles(), articleCount));
                ArticleResultsBox.AppendText("\n");
             }
        }


        private void SiteSelectionList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ApplyChanges_Button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < SiteSelectionList.CheckedIndices.Count; i++)
            {
                int currentIndex = SiteSelectionList.CheckedIndices[i];
                selectedSources.Add(allSources[currentIndex]);
            }
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
