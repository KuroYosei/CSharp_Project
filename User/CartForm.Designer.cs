namespace Library.User
{
    partial class CartForm
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
            this.FlpCart = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.pboClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboClose)).BeginInit();
            this.SuspendLayout();
            // 
            // FlpCart
            // 
            this.FlpCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FlpCart.Location = new System.Drawing.Point(0, 36);
            this.FlpCart.Name = "FlpCart";
            this.FlpCart.Size = new System.Drawing.Size(362, 403);
            this.FlpCart.TabIndex = 0;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(12, 7);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(62, 24);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(80, 7);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 24);
            this.lblPrice.TabIndex = 3;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Black;
            this.btnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnConfirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.LightBlue;
            this.btnConfirm.Location = new System.Drawing.Point(277, 445);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(81, 35);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // pboClose
            // 
            this.pboClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboClose.Image = global::Library.Properties.Resources.error;
            this.pboClose.Location = new System.Drawing.Point(335, 6);
            this.pboClose.Name = "pboClose";
            this.pboClose.Size = new System.Drawing.Size(23, 24);
            this.pboClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboClose.TabIndex = 1;
            this.pboClose.TabStop = false;
            this.pboClose.Click += new System.EventHandler(this.pboClose_Click);
            // 
            // CartForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(362, 483);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.pboClose);
            this.Controls.Add(this.FlpCart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CartForm";
            this.Load += new System.EventHandler(this.CartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FlpCart;
        private System.Windows.Forms.PictureBox pboClose;
        private System.Windows.Forms.Label lblTotal;
        public System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnConfirm;
    }
}