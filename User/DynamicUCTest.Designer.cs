namespace Library
{
    partial class DynamicUCTest
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblType = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.linkLabelLogout = new System.Windows.Forms.LinkLabel();
            this.detailPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblBookName = new System.Windows.Forms.Label();
            this.lblAuthorName = new System.Windows.Forms.Label();
            this.lblRYear = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblGenre2 = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblAName = new System.Windows.Forms.Label();
            this.lblReleaseYear = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBuy = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.detailPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(73)))), ((int)(((byte)(54)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.lblType);
            this.panel1.Controls.Add(this.cboType);
            this.panel1.Controls.Add(this.lblSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.linkLabelLogout);
            this.panel1.Controls.Add(this.detailPanel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(294, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 534);
            this.panel1.TabIndex = 0;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(7, 15);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(49, 20);
            this.lblType.TabIndex = 18;
            this.lblType.Text = "Type";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "Author",
            "Book",
            "Genre"});
            this.cboType.Location = new System.Drawing.Point(64, 13);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(150, 24);
            this.cboType.TabIndex = 1;
            this.cboType.Text = "Select Type";
            this.cboType.SelectedIndexChanged += new System.EventHandler(this.cboType_SelectedIndexChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(224, 16);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(68, 20);
            this.lblSearch.TabIndex = 17;
            this.lblSearch.Text = "Search";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(300, 14);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(150, 22);
            this.txtSearch.TabIndex = 16;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Library.Properties.Resources.add_to_cart;
            this.pictureBox2.Location = new System.Drawing.Point(508, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // linkLabelLogout
            // 
            this.linkLabelLogout.ActiveLinkColor = System.Drawing.Color.LightCoral;
            this.linkLabelLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(142)))), ((int)(((byte)(112)))));
            this.linkLabelLogout.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabelLogout.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(142)))), ((int)(((byte)(112)))));
            this.linkLabelLogout.Location = new System.Drawing.Point(529, 9);
            this.linkLabelLogout.Name = "linkLabelLogout";
            this.linkLabelLogout.Size = new System.Drawing.Size(107, 30);
            this.linkLabelLogout.TabIndex = 13;
            this.linkLabelLogout.TabStop = true;
            this.linkLabelLogout.Text = "Logout";
            this.linkLabelLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabelLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogout_LinkClicked);
            // 
            // detailPanel
            // 
            this.detailPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(73)))), ((int)(((byte)(54)))));
            this.detailPanel.Controls.Add(this.panel3);
            this.detailPanel.Location = new System.Drawing.Point(222, 51);
            this.detailPanel.Name = "detailPanel";
            this.detailPanel.Size = new System.Drawing.Size(414, 480);
            this.detailPanel.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(142)))), ((int)(((byte)(112)))));
            this.panel3.Controls.Add(this.lblBookName);
            this.panel3.Controls.Add(this.lblAuthorName);
            this.panel3.Controls.Add(this.lblRYear);
            this.panel3.Controls.Add(this.lblTitle);
            this.panel3.Controls.Add(this.lblGenre2);
            this.panel3.Controls.Add(this.lblGenre);
            this.panel3.Controls.Add(this.lblAName);
            this.panel3.Controls.Add(this.lblReleaseYear);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(9, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(405, 480);
            this.panel3.TabIndex = 13;
            // 
            // lblBookName
            // 
            this.lblBookName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(142)))), ((int)(((byte)(112)))));
            this.lblBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(73)))), ((int)(((byte)(54)))));
            this.lblBookName.Location = new System.Drawing.Point(33, 11);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(137, 34);
            this.lblBookName.TabIndex = 4;
            this.lblBookName.Text = "Book Name:";
            this.lblBookName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAuthorName
            // 
            this.lblAuthorName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(142)))), ((int)(((byte)(112)))));
            this.lblAuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthorName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(73)))), ((int)(((byte)(54)))));
            this.lblAuthorName.Location = new System.Drawing.Point(33, 74);
            this.lblAuthorName.Name = "lblAuthorName";
            this.lblAuthorName.Size = new System.Drawing.Size(137, 34);
            this.lblAuthorName.TabIndex = 5;
            this.lblAuthorName.Text = "Author Name:";
            this.lblAuthorName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRYear
            // 
            this.lblRYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(142)))), ((int)(((byte)(112)))));
            this.lblRYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(73)))), ((int)(((byte)(54)))));
            this.lblRYear.Location = new System.Drawing.Point(183, 198);
            this.lblRYear.Name = "lblRYear";
            this.lblRYear.Size = new System.Drawing.Size(124, 34);
            this.lblRYear.TabIndex = 10;
            this.lblRYear.Text = "year";
            this.lblRYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(142)))), ((int)(((byte)(112)))));
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(73)))), ((int)(((byte)(54)))));
            this.lblTitle.Location = new System.Drawing.Point(183, 19);
            this.lblTitle.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(212, 62);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Title";
            // 
            // lblGenre2
            // 
            this.lblGenre2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(142)))), ((int)(((byte)(112)))));
            this.lblGenre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(73)))), ((int)(((byte)(54)))));
            this.lblGenre2.Location = new System.Drawing.Point(183, 137);
            this.lblGenre2.Name = "lblGenre2";
            this.lblGenre2.Size = new System.Drawing.Size(124, 34);
            this.lblGenre2.TabIndex = 8;
            this.lblGenre2.Text = "genre";
            this.lblGenre2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGenre
            // 
            this.lblGenre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(142)))), ((int)(((byte)(112)))));
            this.lblGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(73)))), ((int)(((byte)(54)))));
            this.lblGenre.Location = new System.Drawing.Point(33, 137);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(137, 34);
            this.lblGenre.TabIndex = 7;
            this.lblGenre.Text = "Genre:";
            this.lblGenre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAName
            // 
            this.lblAName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(142)))), ((int)(((byte)(112)))));
            this.lblAName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(73)))), ((int)(((byte)(54)))));
            this.lblAName.Location = new System.Drawing.Point(183, 81);
            this.lblAName.Name = "lblAName";
            this.lblAName.Size = new System.Drawing.Size(124, 34);
            this.lblAName.TabIndex = 6;
            this.lblAName.Text = "author name";
            // 
            // lblReleaseYear
            // 
            this.lblReleaseYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(142)))), ((int)(((byte)(112)))));
            this.lblReleaseYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReleaseYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(73)))), ((int)(((byte)(54)))));
            this.lblReleaseYear.Location = new System.Drawing.Point(33, 198);
            this.lblReleaseYear.Name = "lblReleaseYear";
            this.lblReleaseYear.Size = new System.Drawing.Size(137, 34);
            this.lblReleaseYear.TabIndex = 9;
            this.lblReleaseYear.Text = "Release Year:";
            this.lblReleaseYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(73)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.btnBorrow);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnBuy);
            this.panel2.Location = new System.Drawing.Point(20, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 477);
            this.panel2.TabIndex = 12;
            // 
            // btnBorrow
            // 
            this.btnBorrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(142)))), ((int)(((byte)(112)))));
            this.btnBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(73)))), ((int)(((byte)(54)))));
            this.btnBorrow.Location = new System.Drawing.Point(31, 309);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(150, 37);
            this.btnBorrow.TabIndex = 11;
            this.btnBorrow.Text = "Borrow";
            this.btnBorrow.UseVisualStyleBackColor = false;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox1.Location = new System.Drawing.Point(31, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(142)))), ((int)(((byte)(112)))));
            this.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(73)))), ((int)(((byte)(54)))));
            this.btnBuy.Location = new System.Drawing.Point(31, 247);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(150, 37);
            this.btnBuy.TabIndex = 1;
            this.btnBuy.Text = "Add to Cart";
            this.btnBuy.UseVisualStyleBackColor = false;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(142)))), ((int)(((byte)(112)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 51);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(310, 483);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(12, 14);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(59, 20);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "label1";
            // 
            // DynamicUCTest
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(73)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(933, 534);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DynamicUCTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DynamicUserControl";
            this.Load += new System.EventHandler(this.DynamicUCTest_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.detailPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel detailPanel;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel linkLabelLogout;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label lblAuthorName;
        private System.Windows.Forms.Label lblRYear;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblGenre2;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblAName;
        private System.Windows.Forms.Label lblReleaseYear;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cboType;
    }
}