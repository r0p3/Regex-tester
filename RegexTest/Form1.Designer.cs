namespace RegexTest
{
    partial class Form1
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
            this.lblText = new System.Windows.Forms.Label();
            this.tbPattern = new System.Windows.Forms.TextBox();
            this.lblPattern = new System.Windows.Forms.Label();
            this.lblMatchedCount = new System.Windows.Forms.Label();
            this.rbMatchedText = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblPatterns = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.PatternName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PatternPattern = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbPatternName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUnselect = new System.Windows.Forms.Button();
            this.tbText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(9, 9);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(60, 13);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "Text to test";
            // 
            // tbPattern
            // 
            this.tbPattern.Location = new System.Drawing.Point(6, 244);
            this.tbPattern.Name = "tbPattern";
            this.tbPattern.Size = new System.Drawing.Size(260, 20);
            this.tbPattern.TabIndex = 2;
            // 
            // lblPattern
            // 
            this.lblPattern.AutoSize = true;
            this.lblPattern.Location = new System.Drawing.Point(6, 228);
            this.lblPattern.Name = "lblPattern";
            this.lblPattern.Size = new System.Drawing.Size(41, 13);
            this.lblPattern.TabIndex = 3;
            this.lblPattern.Text = "Pattern";
            // 
            // lblMatchedCount
            // 
            this.lblMatchedCount.AutoSize = true;
            this.lblMatchedCount.Location = new System.Drawing.Point(3, 267);
            this.lblMatchedCount.Name = "lblMatchedCount";
            this.lblMatchedCount.Size = new System.Drawing.Size(47, 13);
            this.lblMatchedCount.TabIndex = 5;
            this.lblMatchedCount.Text = "Count: 0";
            // 
            // rbMatchedText
            // 
            this.rbMatchedText.Location = new System.Drawing.Point(6, 283);
            this.rbMatchedText.Name = "rbMatchedText";
            this.rbMatchedText.Size = new System.Drawing.Size(257, 200);
            this.rbMatchedText.TabIndex = 6;
            this.rbMatchedText.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(197, 531);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Enabled = false;
            this.btnLoad.Location = new System.Drawing.Point(823, 531);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 9;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblPatterns
            // 
            this.lblPatterns.AutoSize = true;
            this.lblPatterns.Location = new System.Drawing.Point(278, 35);
            this.lblPatterns.Name = "lblPatterns";
            this.lblPatterns.Size = new System.Drawing.Size(46, 13);
            this.lblPatterns.TabIndex = 10;
            this.lblPatterns.Text = "Patterns";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PatternName,
            this.PatternPattern});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(278, 51);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(620, 474);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // PatternName
            // 
            this.PatternName.Text = "Name";
            this.PatternName.Width = 117;
            // 
            // PatternPattern
            // 
            this.PatternPattern.Text = "Pattern";
            this.PatternPattern.Width = 500;
            // 
            // tbPatternName
            // 
            this.tbPatternName.Location = new System.Drawing.Point(12, 505);
            this.tbPatternName.Name = "tbPatternName";
            this.tbPatternName.Size = new System.Drawing.Size(260, 20);
            this.tbPatternName.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(742, 531);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(857, 10);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(41, 13);
            this.lblSearch.TabIndex = 15;
            this.lblSearch.Text = "Search";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(624, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 20);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 489);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Save pattern name";
            // 
            // btnUnselect
            // 
            this.btnUnselect.Enabled = false;
            this.btnUnselect.Location = new System.Drawing.Point(661, 531);
            this.btnUnselect.Name = "btnUnselect";
            this.btnUnselect.Size = new System.Drawing.Size(75, 23);
            this.btnUnselect.TabIndex = 17;
            this.btnUnselect.Text = "Unselect";
            this.btnUnselect.UseVisualStyleBackColor = true;
            this.btnUnselect.Click += new System.EventHandler(this.btnUnselect_Click);
            // 
            // tbText
            // 
            this.tbText.Location = new System.Drawing.Point(9, 25);
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(257, 200);
            this.tbText.TabIndex = 18;
            this.tbText.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 563);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.btnUnselect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbPatternName);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lblPatterns);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rbMatchedText);
            this.Controls.Add(this.lblMatchedCount);
            this.Controls.Add(this.lblPattern);
            this.Controls.Add(this.tbPattern);
            this.Controls.Add(this.lblText);
            this.Name = "Form1";
            this.Text = "Regex Tester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.TextBox tbPattern;
        private System.Windows.Forms.Label lblPattern;
        private System.Windows.Forms.Label lblMatchedCount;
        private System.Windows.Forms.RichTextBox rbMatchedText;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblPatterns;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader PatternName;
        private System.Windows.Forms.ColumnHeader PatternPattern;
        private System.Windows.Forms.TextBox tbPatternName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUnselect;
        private System.Windows.Forms.RichTextBox tbText;
    }
}

