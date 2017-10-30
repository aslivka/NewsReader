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
using NewsCollection;

namespace NewsReader
{
    public partial class SearchForm : Form
    {
        public string searchResults;
        int siteCount = 0;
        int totalArticleCount = 0;
        List<SiteData> totalSiteList = new List<SiteData>();

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

        public SearchForm()
        {
            InitializeComponent();
            updateStatusBar();
        }
        private void DownloadFeeds_Click(object sender, EventArgs e)
        {
            string sortBy = "top";
            int numberOfSites = selectedSources.Count;

            for (int i = 0; i < numberOfSites; i++)
            {
                SiteData site1 = new NewsAPISite();
                site1.setSiteUrl(selectedSources[i], sortBy);
                site1.downloadArticles();
                site1.deserializeArticles();
                totalSiteList.Add(site1);
            }

            siteCount = totalSiteList.Count();
            updateStatusBar();
            DisplaySites(totalSiteList);
        }
        
        private void DisplaySites(List<SiteData> sites)
        {
            for (int i = 0; i < siteCount; i++)
            {
                if(sites[i].getArticles() != null)
                {
                    ArticleResultsBox.DeselectAll();
                    ArticleResultsBox.SelectionFont = new Font(ArticleResultsBox.SelectionFont, FontStyle.Bold);
                    ArticleResultsBox.AppendText("Source: " + sites[i].getSource() + "\n");
                    //int articleCount = sites[i].getArticles().Count;
                    ArticleResultsBox.AppendText(sites[i].DisplayArticles(sites[i].getArticles()));
                }
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

        private void ArticleResultsBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateStatusBar()
        {
            System.Text.StringBuilder statusText = new System.Text.StringBuilder();
            updateTotalArticles();
            statusText.Append("Selected: " + siteCount + " sources.");
            statusText.Append(" / Downloaded: " + totalArticleCount + " articles.");
            statusLabel.Text = statusText.ToString();
        }

        private void updateTotalArticles()
        {
            totalArticleCount = 0;
            for(int i = 0; i < siteCount; i++)
            {
                totalArticleCount += totalSiteList[i].getArticleCount();
            } 
        }
    }
}
