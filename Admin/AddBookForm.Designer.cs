namespace Library.DynamicUserControl
{
    partial class AddBookForm
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
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtReleaseYear = new System.Windows.Forms.TextBox();
            this.lblReleaseYear = new System.Windows.Forms.Label();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.lblAuthorName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.lblBookName = new System.Windows.Forms.Label();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(1594, 937);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 10;
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(178, 197);
            this.txtGenre.Multiline = true;
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(190, 34);
            this.txtGenre.TabIndex = 17;
            // 
            // lblGenre
            // 
            this.lblGenre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.ForeColor = System.Drawing.Color.Black;
            this.lblGenre.Location = new System.Drawing.Point(44, 197);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(112, 34);
            this.lblGenre.TabIndex = 22;
            this.lblGenre.Text = "Genre";
            this.lblGenre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtReleaseYear
            // 
            this.txtReleaseYear.Location = new System.Drawing.Point(178, 267);
            this.txtReleaseYear.Multiline = true;
            this.txtReleaseYear.Name = "txtReleaseYear";
            this.txtReleaseYear.Size = new System.Drawing.Size(190, 34);
            this.txtReleaseYear.TabIndex = 18;
            // 
            // lblReleaseYear
            // 
            this.lblReleaseYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblReleaseYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReleaseYear.ForeColor = System.Drawing.Color.Black;
            this.lblReleaseYear.Location = new System.Drawing.Point(44, 267);
            this.lblReleaseYear.Name = "lblReleaseYear";
            this.lblReleaseYear.Size = new System.Drawing.Size(112, 34);
            this.lblReleaseYear.TabIndex = 21;
            this.lblReleaseYear.Text = "Release Year";
            this.lblReleaseYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Location = new System.Drawing.Point(178, 127);
            this.txtAuthorName.Multiline = true;
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(190, 34);
            this.txtAuthorName.TabIndex = 16;
            // 
            // lblAuthorName
            // 
            this.lblAuthorName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblAuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthorName.ForeColor = System.Drawing.Color.Black;
            this.lblAuthorName.Location = new System.Drawing.Point(44, 127);
            this.lblAuthorName.Name = "lblAuthorName";
            this.lblAuthorName.Size = new System.Drawing.Size(112, 34);
            this.lblAuthorName.TabIndex = 19;
            this.lblAuthorName.Text = "Author Name";
            this.lblAuthorName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightBlue;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(472, 307);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(114, 34);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.Black;
            this.btnUpload.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUpload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.ForeColor = System.Drawing.Color.LightBlue;
            this.btnUpload.Location = new System.Drawing.Point(436, 267);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(150, 34);
            this.btnUpload.TabIndex = 12;
            this.btnUpload.Text = "Upload Image";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click_1);
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(178, 57);
            this.txtBookName.Multiline = true;
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(190, 34);
            this.txtBookName.TabIndex = 14;
            // 
            // lblBookName
            // 
            this.lblBookName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookName.ForeColor = System.Drawing.Color.Black;
            this.lblBookName.Location = new System.Drawing.Point(47, 57);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(109, 34);
            this.lblBookName.TabIndex = 15;
            this.lblBookName.Text = "Book Name";
            this.lblBookName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pb1
            // 
            this.pb1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pb1.InitialImage = null;
            this.pb1.Location = new System.Drawing.Point(436, 51);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(150, 200);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 13;
            this.pb1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.lblGenre);
            this.panel2.Controls.Add(this.lblReleaseYear);
            this.panel2.Controls.Add(this.lblBookName);
            this.panel2.Controls.Add(this.lblAuthorName);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.txtReleaseYear);
            this.panel2.Controls.Add(this.txtGenre);
            this.panel2.Controls.Add(this.pb1);
            this.panel2.Controls.Add(this.txtAuthorName);
            this.panel2.Controls.Add(this.btnUpload);
            this.panel2.Controls.Add(this.txtBookName);
            this.panel2.Location = new System.Drawing.Point(28, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(652, 496);
            this.panel2.TabIndex = 11;
            // 
            // AddBookForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(708, 546);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBookForm";
            this.Load += new System.EventHandler(this.AddBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox txtReleaseYear;
        private System.Windows.Forms.Label lblReleaseYear;
        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.Label lblAuthorName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Panel panel2;
    }
}