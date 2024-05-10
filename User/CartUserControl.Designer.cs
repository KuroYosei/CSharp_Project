namespace Library.User
{
    partial class CartUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pboList = new System.Windows.Forms.PictureBox();
            this.pboDelete = new System.Windows.Forms.PictureBox();
            this.lblProductDetail = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(82, 0);
            this.lblTitle.MaximumSize = new System.Drawing.Size(200, 0);
            this.lblTitle.MinimumSize = new System.Drawing.Size(200, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(200, 20);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(142)))), ((int)(((byte)(112)))));
            this.panel1.Controls.Add(this.pboList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(76, 85);
            this.panel1.TabIndex = 3;
            // 
            // pboList
            // 
            this.pboList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pboList.Location = new System.Drawing.Point(0, 0);
            this.pboList.Name = "pboList";
            this.pboList.Size = new System.Drawing.Size(76, 85);
            this.pboList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboList.TabIndex = 1;
            this.pboList.TabStop = false;
            // 
            // pboDelete
            // 
            this.pboDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboDelete.Image = global::Library.Properties.Resources.trash_can_icon_24;
            this.pboDelete.Location = new System.Drawing.Point(311, 26);
            this.pboDelete.Name = "pboDelete";
            this.pboDelete.Size = new System.Drawing.Size(30, 30);
            this.pboDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboDelete.TabIndex = 5;
            this.pboDelete.TabStop = false;
            this.pboDelete.Click += new System.EventHandler(this.pboDelete_Click);
            // 
            // lblProductDetail
            // 
            this.lblProductDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProductDetail.AutoSize = true;
            this.lblProductDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductDetail.Location = new System.Drawing.Point(82, 48);
            this.lblProductDetail.MaximumSize = new System.Drawing.Size(200, 0);
            this.lblProductDetail.MinimumSize = new System.Drawing.Size(200, 0);
            this.lblProductDetail.Name = "lblProductDetail";
            this.lblProductDetail.Size = new System.Drawing.Size(200, 20);
            this.lblProductDetail.TabIndex = 6;
            this.lblProductDetail.Text = "Title";
            this.lblProductDetail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CartUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblProductDetail);
            this.Controls.Add(this.pboDelete);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.Name = "CartUserControl";
            this.Size = new System.Drawing.Size(362, 85);
            this.Load += new System.EventHandler(this.CartUserControl_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pboList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pboDelete;
        public System.Windows.Forms.Label lblProductDetail;
    }
}
