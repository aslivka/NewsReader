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
            this.SearchButton = new System.Windows.Forms.Button();
            this.BtnDownloadFeeds = new System.Windows.Forms.Button();
            this.SearchInputBox = new System.Windows.Forms.TextBox();
            this.ArticleResultsBox = new System.Windows.Forms.RichTextBox();
            this.tabMenu1 = new System.Windows.Forms.TabControl();
            this.Search = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.Setup = new System.Windows.Forms.TabPage();
            this.ApplyChanges_Button = new System.Windows.Forms.Button();
            this.SiteSelectionList = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabMenu1.SuspendLayout();
            this.Search.SuspendLayout();
            this.Setup.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(160, 36);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // BtnDownloadFeeds
            // 
            this.BtnDownloadFeeds.Location = new System.Drawing.Point(289, 28);
            this.BtnDownloadFeeds.Name = "BtnDownloadFeeds";
            this.BtnDownloadFeeds.Size = new System.Drawing.Size(110, 30);
            this.BtnDownloadFeeds.TabIndex = 1;
            this.BtnDownloadFeeds.Text = "Download Feeds";
            this.BtnDownloadFeeds.UseVisualStyleBackColor = true;
            this.BtnDownloadFeeds.Click += new System.EventHandler(this.DownloadFeeds_Click);
            // 
            // SearchInputBox
            // 
            this.SearchInputBox.Location = new System.Drawing.Point(45, 38);
            this.SearchInputBox.Name = "SearchInputBox";
            this.SearchInputBox.Size = new System.Drawing.Size(100, 20);
            this.SearchInputBox.TabIndex = 2;
            // 
            // ArticleResultsBox
            // 
            this.ArticleResultsBox.Location = new System.Drawing.Point(45, 74);
            this.ArticleResultsBox.Name = "ArticleResultsBox";
            this.ArticleResultsBox.Size = new System.Drawing.Size(623, 371);
            this.ArticleResultsBox.TabIndex = 3;
            this.ArticleResultsBox.Text = "";
            this.ArticleResultsBox.TextChanged += new System.EventHandler(this.ArticleResultsBox_TextChanged);
            // 
            // tabMenu1
            // 
            this.tabMenu1.Controls.Add(this.Search);
            this.tabMenu1.Controls.Add(this.Setup);
            this.tabMenu1.Location = new System.Drawing.Point(-5, 0);
            this.tabMenu1.Multiline = true;
            this.tabMenu1.Name = "tabMenu1";
            this.tabMenu1.Padding = new System.Drawing.Point(0, 0);
            this.tabMenu1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabMenu1.SelectedIndex = 0;
            this.tabMenu1.Size = new System.Drawing.Size(724, 530);
            this.tabMenu1.TabIndex = 4;
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Search.Controls.Add(this.label2);
            this.Search.Controls.Add(this.ButtonExit);
            this.Search.Controls.Add(this.BtnDownloadFeeds);
            this.Search.Controls.Add(this.SearchInputBox);
            this.Search.Controls.Add(this.ArticleResultsBox);
            this.Search.Controls.Add(this.SearchButton);
            this.Search.Location = new System.Drawing.Point(4, 22);
            this.Search.Margin = new System.Windows.Forms.Padding(0);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(716, 504);
            this.Search.TabIndex = 0;
            this.Search.Text = "Search";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter search keywords";
            // 
            // ButtonExit
            // 
            this.ButtonExit.Location = new System.Drawing.Point(589, 451);
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
            this.Setup.Controls.Add(this.ApplyChanges_Button);
            this.Setup.Controls.Add(this.SiteSelectionList);
            this.Setup.Controls.Add(this.label1);
            this.Setup.Location = new System.Drawing.Point(4, 22);
            this.Setup.Name = "Setup";
            this.Setup.Padding = new System.Windows.Forms.Padding(3);
            this.Setup.Size = new System.Drawing.Size(716, 504);
            this.Setup.TabIndex = 1;
            this.Setup.Text = "Settings";
            // 
            // ApplyChanges_Button
            // 
            this.ApplyChanges_Button.Location = new System.Drawing.Point(280, 451);
            this.ApplyChanges_Button.Name = "ApplyChanges_Button";
            this.ApplyChanges_Button.Size = new System.Drawing.Size(103, 23);
            this.ApplyChanges_Button.TabIndex = 2;
            this.ApplyChanges_Button.Text = "Apply Changes";
            this.ApplyChanges_Button.UseVisualStyleBackColor = true;
            this.ApplyChanges_Button.Click += new System.EventHandler(this.ApplyChanges_Button_Click);
            // 
            // SiteSelectionList
            // 
            this.SiteSelectionList.CheckOnClick = true;
            this.SiteSelectionList.FormattingEnabled = true;
            this.SiteSelectionList.Items.AddRange(new object[] {
            "Ars Technica",
            "BBC News",
            "CNN",
            "Google News",
            "New York Times",
            "Reuters",
            "Techcrunch",
            "TechRadar",
            "The Economist",
            "USA Today"});
            this.SiteSelectionList.Location = new System.Drawing.Point(39, 51);
            this.SiteSelectionList.Name = "SiteSelectionList";
            this.SiteSelectionList.Size = new System.Drawing.Size(112, 259);
            this.SiteSelectionList.TabIndex = 1;
            this.SiteSelectionList.SelectedIndexChanged += new System.EventHandler(this.SiteSelectionList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Site selection";
            // 
            // statusLabel
            // 
            this.statusLabel.Location = new System.Drawing.Point(54, 533);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(300, 13);
            this.statusLabel.TabIndex = 7;
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 526);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(716, 25);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 20);
            this.toolStripStatusLabel1.Text = "Status";
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 551);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabMenu1);
            this.MaximumSize = new System.Drawing.Size(732, 590);
            this.Name = "SearchForm";
            this.Text = "NewsReader 1.0";
            this.tabMenu1.ResumeLayout(false);
            this.Search.ResumeLayout(false);
            this.Search.PerformLayout();
            this.Setup.ResumeLayout(false);
            this.Setup.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.CheckedListBox SiteSelectionList;
        private System.Windows.Forms.Button ApplyChanges_Button;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

