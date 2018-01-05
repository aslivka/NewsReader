using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsReader
{
    partial class SearchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.SearchButton = new System.Windows.Forms.Button();
            this.BtnDownloadFeeds = new System.Windows.Forms.Button();
            this.SearchInputBox = new System.Windows.Forms.TextBox();
            this.ArticleResultsBox = new System.Windows.Forms.RichTextBox();
            this.tabMenu1 = new System.Windows.Forms.TabControl();
            this.Search = new System.Windows.Forms.TabPage();
            this.searchIntrLabel = new System.Windows.Forms.Label();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.Setup = new System.Windows.Forms.TabPage();
            this.ApplyChanges_Button = new System.Windows.Forms.Button();
            this.SiteSelectionList = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.statusLabel = new System.Windows.Forms.Label();
            this.statusLabel2 = new System.Windows.Forms.Label();
            this.SaveSettings_checkBox = new System.Windows.Forms.CheckBox();
            this.tabMenu1.SuspendLayout();
            this.Search.SuspendLayout();
            this.Setup.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(158, 32);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(74, 30);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // BtnDownloadFeeds
            // 
            this.BtnDownloadFeeds.Location = new System.Drawing.Point(272, 32);
            this.BtnDownloadFeeds.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDownloadFeeds.Name = "BtnDownloadFeeds";
            this.BtnDownloadFeeds.Size = new System.Drawing.Size(110, 30);
            this.BtnDownloadFeeds.TabIndex = 1;
            this.BtnDownloadFeeds.Text = "Download Feeds";
            this.BtnDownloadFeeds.UseVisualStyleBackColor = true;
            this.BtnDownloadFeeds.Click += new System.EventHandler(this.DownloadFeeds_Click);
            // 
            // SearchInputBox
            // 
            this.SearchInputBox.Location = new System.Drawing.Point(26, 38);
            this.SearchInputBox.Margin = new System.Windows.Forms.Padding(2);
            this.SearchInputBox.Name = "SearchInputBox";
            this.SearchInputBox.Size = new System.Drawing.Size(100, 20);
            this.SearchInputBox.TabIndex = 2;
            // 
            // ArticleResultsBox
            // 
            this.ArticleResultsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ArticleResultsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArticleResultsBox.Location = new System.Drawing.Point(26, 86);
            this.ArticleResultsBox.Margin = new System.Windows.Forms.Padding(0);
            this.ArticleResultsBox.Name = "ArticleResultsBox";
            this.ArticleResultsBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ArticleResultsBox.Size = new System.Drawing.Size(666, 386);
            this.ArticleResultsBox.TabIndex = 3;
            this.ArticleResultsBox.Text = "";
            this.ArticleResultsBox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.ArticleResultsBox_LinkClicked);
            this.ArticleResultsBox.TextChanged += new System.EventHandler(this.ArticleResultsBox_TextChanged);
            // 
            // tabMenu1
            // 
            this.tabMenu1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMenu1.Controls.Add(this.Search);
            this.tabMenu1.Controls.Add(this.Setup);
            this.tabMenu1.ImageList = this.imageList1;
            this.tabMenu1.Location = new System.Drawing.Point(-5, 2);
            this.tabMenu1.Margin = new System.Windows.Forms.Padding(2);
            this.tabMenu1.Multiline = true;
            this.tabMenu1.Name = "tabMenu1";
            this.tabMenu1.Padding = new System.Drawing.Point(0, 0);
            this.tabMenu1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabMenu1.SelectedIndex = 0;
            this.tabMenu1.Size = new System.Drawing.Size(728, 563);
            this.tabMenu1.TabIndex = 4;
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Search.Controls.Add(this.searchIntrLabel);
            this.Search.Controls.Add(this.ButtonExit);
            this.Search.Controls.Add(this.BtnDownloadFeeds);
            this.Search.Controls.Add(this.SearchInputBox);
            this.Search.Controls.Add(this.ArticleResultsBox);
            this.Search.Controls.Add(this.SearchButton);
            this.Search.ImageIndex = 0;
            this.Search.Location = new System.Drawing.Point(4, 32);
            this.Search.Margin = new System.Windows.Forms.Padding(0);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(720, 527);
            this.Search.TabIndex = 0;
            this.Search.Text = "Search";
            // 
            // searchIntrLabel
            // 
            this.searchIntrLabel.AutoSize = true;
            this.searchIntrLabel.Location = new System.Drawing.Point(26, 12);
            this.searchIntrLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.searchIntrLabel.Name = "searchIntrLabel";
            this.searchIntrLabel.Size = new System.Drawing.Size(115, 13);
            this.searchIntrLabel.TabIndex = 5;
            this.searchIntrLabel.Text = "Enter search keywords";
            // 
            // ButtonExit
            // 
            this.ButtonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonExit.Location = new System.Drawing.Point(613, 484);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(79, 35);
            this.ButtonExit.TabIndex = 4;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // Setup
            // 
            this.Setup.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Setup.Controls.Add(this.SaveSettings_checkBox);
            this.Setup.Controls.Add(this.ApplyChanges_Button);
            this.Setup.Controls.Add(this.SiteSelectionList);
            this.Setup.Controls.Add(this.label1);
            this.Setup.ImageIndex = 1;
            this.Setup.Location = new System.Drawing.Point(4, 32);
            this.Setup.Margin = new System.Windows.Forms.Padding(0);
            this.Setup.Name = "Setup";
            this.Setup.Size = new System.Drawing.Size(720, 527);
            this.Setup.TabIndex = 1;
            this.Setup.Text = "Settings";
            // 
            // ApplyChanges_Button
            // 
            this.ApplyChanges_Button.Location = new System.Drawing.Point(278, 451);
            this.ApplyChanges_Button.Margin = new System.Windows.Forms.Padding(2);
            this.ApplyChanges_Button.Name = "ApplyChanges_Button";
            this.ApplyChanges_Button.Size = new System.Drawing.Size(103, 24);
            this.ApplyChanges_Button.TabIndex = 2;
            this.ApplyChanges_Button.Text = "Apply Changes";
            this.ApplyChanges_Button.UseVisualStyleBackColor = true;
            this.ApplyChanges_Button.Click += new System.EventHandler(this.ApplyChanges_Button_Click);
            // 
            // SiteSelectionList
            // 
            this.SiteSelectionList.CheckOnClick = true;
            this.SiteSelectionList.FormattingEnabled = true;
            this.SiteSelectionList.Location = new System.Drawing.Point(38, 51);
            this.SiteSelectionList.Margin = new System.Windows.Forms.Padding(2);
            this.SiteSelectionList.Name = "SiteSelectionList";
            this.SiteSelectionList.Size = new System.Drawing.Size(112, 259);
            this.SiteSelectionList.TabIndex = 1;
            this.SiteSelectionList.SelectedIndexChanged += new System.EventHandler(this.SiteSelectionList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Site selection list";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "search-13-64.png");
            this.imageList1.Images.SetKeyName(1, "icon_settings.png");
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.statusLabel.BackColor = System.Drawing.SystemColors.Control;
            this.statusLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.statusLabel.CausesValidation = false;
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(56, 564);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.statusLabel.MaximumSize = new System.Drawing.Size(500, 22);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(500, 22);
            this.statusLabel.TabIndex = 7;
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusLabel2
            // 
            this.statusLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.statusLabel2.BackColor = System.Drawing.SystemColors.Control;
            this.statusLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.statusLabel2.CausesValidation = false;
            this.statusLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel2.Location = new System.Drawing.Point(2, 564);
            this.statusLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.statusLabel2.MaximumSize = new System.Drawing.Size(53, 24);
            this.statusLabel2.Name = "statusLabel2";
            this.statusLabel2.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.statusLabel2.Size = new System.Drawing.Size(53, 22);
            this.statusLabel2.TabIndex = 8;
            this.statusLabel2.Text = "Status";
            this.statusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SaveSettings_checkBox
            // 
            this.SaveSettings_checkBox.AutoSize = true;
            this.SaveSettings_checkBox.Location = new System.Drawing.Point(37, 391);
            this.SaveSettings_checkBox.Name = "SaveSettings_checkBox";
            this.SaveSettings_checkBox.Size = new System.Drawing.Size(141, 17);
            this.SaveSettings_checkBox.TabIndex = 3;
            this.SaveSettings_checkBox.Text = "Save All Settings To File";
            this.SaveSettings_checkBox.UseVisualStyleBackColor = true;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(716, 588);
            this.Controls.Add(this.statusLabel2);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.tabMenu1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(900, 980);
            this.MinimumSize = new System.Drawing.Size(732, 620);
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "NewsReader 1.0";
            this.tabMenu1.ResumeLayout(false);
            this.Search.ResumeLayout(false);
            this.Search.PerformLayout();
            this.Setup.ResumeLayout(false);
            this.Setup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button BtnDownloadFeeds;
        private System.Windows.Forms.TextBox SearchInputBox;
        private System.Windows.Forms.RichTextBox ArticleResultsBox;
        private System.Windows.Forms.TabControl tabMenu1;
        private System.Windows.Forms.TabPage Search;
        private System.Windows.Forms.TabPage Setup;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.CheckedListBox SiteSelectionList;
        private System.Windows.Forms.Button ApplyChanges_Button;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Label searchIntrLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label statusLabel2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.CheckBox SaveSettings_checkBox;
    }
}

