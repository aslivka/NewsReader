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
            this.ShowAllButton = new System.Windows.Forms.Button();
            this.SearchInputBox = new System.Windows.Forms.TextBox();
            this.ArticleResultsBox = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Search = new System.Windows.Forms.TabPage();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.Setup = new System.Windows.Forms.TabPage();
            this.ApplyChanges_Button = new System.Windows.Forms.Button();
            this.SiteSelectionList = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Search.SuspendLayout();
            this.Setup.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(178, 24);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // ShowAllButton
            // 
            this.ShowAllButton.Location = new System.Drawing.Point(284, 24);
            this.ShowAllButton.Name = "ShowAllButton";
            this.ShowAllButton.Size = new System.Drawing.Size(140, 23);
            this.ShowAllButton.TabIndex = 1;
            this.ShowAllButton.Text = "Show All Results";
            this.ShowAllButton.UseVisualStyleBackColor = true;
            this.ShowAllButton.Click += new System.EventHandler(this.ShowAllButton_Click);
            // 
            // SearchInputBox
            // 
            this.SearchInputBox.Location = new System.Drawing.Point(45, 24);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Search);
            this.tabControl1.Controls.Add(this.Setup);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(807, 538);
            this.tabControl1.TabIndex = 4;
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Search.Controls.Add(this.ButtonExit);
            this.Search.Controls.Add(this.ShowAllButton);
            this.Search.Controls.Add(this.SearchInputBox);
            this.Search.Controls.Add(this.ArticleResultsBox);
            this.Search.Controls.Add(this.SearchButton);
            this.Search.Location = new System.Drawing.Point(4, 22);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(799, 512);
            this.Search.TabIndex = 0;
            this.Search.Text = "Search";
            // 
            // ButtonExit
            // 
            this.ButtonExit.Location = new System.Drawing.Point(318, 460);
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
            this.Setup.Size = new System.Drawing.Size(799, 512);
            this.Setup.TabIndex = 1;
            this.Setup.Text = "Setup";
            // 
            // ApplyChanges_Button
            // 
            this.ApplyChanges_Button.Location = new System.Drawing.Point(48, 356);
            this.ApplyChanges_Button.Name = "ApplyChanges_Button";
            this.ApplyChanges_Button.Size = new System.Drawing.Size(103, 23);
            this.ApplyChanges_Button.TabIndex = 2;
            this.ApplyChanges_Button.Text = "Apply Changes";
            this.ApplyChanges_Button.UseVisualStyleBackColor = true;
            this.ApplyChanges_Button.Click += new System.EventHandler(this.ApplyChanges_Button_Click);
            // 
            // SiteSelectionList
            // 
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
            this.SiteSelectionList.Location = new System.Drawing.Point(39, 65);
            this.SiteSelectionList.Name = "SiteSelectionList";
            this.SiteSelectionList.Size = new System.Drawing.Size(112, 259);
            this.SiteSelectionList.TabIndex = 1;
            this.SiteSelectionList.SelectedIndexChanged += new System.EventHandler(this.SiteSelectionList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Site selection";
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 562);
            this.Controls.Add(this.tabControl1);
            this.Name = "SearchForm";
            this.Text = "NewsReader 1.0";
            this.tabControl1.ResumeLayout(false);
            this.Search.ResumeLayout(false);
            this.Search.PerformLayout();
            this.Setup.ResumeLayout(false);
            this.Setup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button ShowAllButton;
        private System.Windows.Forms.TextBox SearchInputBox;
        private System.Windows.Forms.RichTextBox ArticleResultsBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Search;
        private System.Windows.Forms.TabPage Setup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox SiteSelectionList;
        private System.Windows.Forms.Button ApplyChanges_Button;
        private System.Windows.Forms.Button ButtonExit;
    }
}

