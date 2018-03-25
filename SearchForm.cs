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
        public AppSettings currentSettings = new AppSettings();
        //public SourceCollection sourceList = new SourceCollection();
        private string searchResult = String.Empty;
        private int siteCount = 0;
        private  int totalArticleCount = 0;
        public List<SiteData> totalSiteList = new List<SiteData>();

        public SearchForm()
        {
            //Loading settings from file
            LoadSettings();

            //Converting from List to object array
            List<string> newList = currentSettings.getFormattedList();
            object[] updatedList = newList.Cast<object>().ToArray();

            InitializeComponent();

            //Updating controls to reflect loaded settings
            SiteSelectionList.Items.AddRange(updatedList);
            updateControlSettings();
        }

        public void LoadSettings()
        {
            AppSettings loadedSettings = new AppSettings();
            loadedSettings = loadedSettings.LoadFromFile(@"\program.config");
            currentSettings._currentBuildInfo = new BuildInfo();
            currentSettings.SaveSettings(loadedSettings);
        }

        private void DownloadFeeds_Click(object sender, EventArgs e)
        {
            string sortBy = "top";
            int numberOfSites = currentSettings._selectedSources.Count;

            clearFeedData();

            for (int i = 0; i < numberOfSites; i++)
            {
                SiteData site1 = new NewsAPISite();
                site1.setSiteUrl(currentSettings._selectedSources[i], sortBy);
                site1.downloadArticles();
                site1.deserializeArticles();
                totalSiteList.Add(site1);
            }
            updateStatusBar();
            DisplaySites(totalSiteList);
        }
        
        private void DisplaySites(List<SiteData> sites)
        {
            ArticleResultsBox.Clear();

            for (int i = 0; i < siteCount; i++)
            {
                if(sites[i].getArticles() != null)
                {
                    ArticleResultsBox.DeselectAll();
                    ArticleResultsBox.SelectionFont = new Font(ArticleResultsBox.SelectionFont, FontStyle.Bold);
                    ArticleResultsBox.AppendText("Source: " + sites[i].getSource() + "\n");
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
            //Adding selected sources and updating controls
            currentSettings._selectedSources.Clear();
            int currentIndex;

            for (int i = 0; i < SiteSelectionList.CheckedIndices.Count; i++)
            {
                currentIndex = SiteSelectionList.CheckedIndices[i];
                currentSettings._selectedSources.Add(currentSettings.getRawList()[currentIndex]);
            }
            totalSiteList.Clear();
            updateStatusBar();

            //Saving settings to file
            currentSettings._saveEnabled = getSaveEnabled();
            AppSettings newSettings = new AppSettings();
            if (currentSettings._saveEnabled)
            {
                newSettings.SaveSettings(this.currentSettings);
            }
            newSettings.SaveToFile(@"\program.config"); 
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
            siteCount = currentSettings._selectedSources.Count;
            updateArticleTotal();
            statusText.Append("Selected: " + siteCount + " sites.");
            statusText.Append(" / Downloaded: " + totalArticleCount + " articles.");
            statusLabel.Text = statusText.ToString();
        }

        private void updateControlSettings()
        {
            SaveSettings_checkBox.Checked = currentSettings._saveEnabled;

            if (currentSettings._saveEnabled)
            {
                int currentIndex;
                //Loading selected sources
                for (int i = 0; i < currentSettings._selectedSources.Count; i++)
                {
                    currentIndex = currentSettings.getRawList().IndexOf(currentSettings._selectedSources[i]);
                    SiteSelectionList.SetItemChecked(currentIndex, true);
                }
            }
            updateStatusBar();
        }

        private void updateArticleTotal()
        {
            totalArticleCount = 0;    
            if(totalSiteList.Count > 0)
            {
                for (int i = 0; i < siteCount; i++)
                {
                    totalArticleCount += totalSiteList[i].getArticleCount();
                }
            } 
        }

        private void clearFeedData()
        {
            totalSiteList.Clear();
            siteCount = 0;
            updateArticleTotal();
        }

        private void ArticleResultsBox_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        public bool getSaveEnabled()
        {
            return SaveSettings_checkBox.Checked;
        }

        public void setSaveEnabled(bool isEnabled)
        {
            SaveSettings_checkBox.Checked = isEnabled;
        }
    }
}
