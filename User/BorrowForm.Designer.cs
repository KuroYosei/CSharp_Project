namespace Library.User
{
    partial class BorrowForm
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
            this.pboBorrow = new System.Windows.Forms.PictureBox();
            this.lblBorrow = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.dtpBorrow = new System.Windows.Forms.DateTimePicker();
            this.pboPanel = new System.Windows.Forms.Panel();
            this.dtpReturn = new System.Windows.Forms.DateTimePicker();
            this.lblReturn = new System.Windows.Forms.Label();
            this.lblIssue = new System.Windows.Forms.Label();
            this.txtIssue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboBorrow)).BeginInit();
            this.pboPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pboBorrow
            // 
            this.pboBorrow.Location = new System.Drawing.Point(18, 17);
            this.pboBorrow.Name = "pboBorrow";
            this.pboBorrow.Size = new System.Drawing.Size(160, 179);
            this.pboBorrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboBorrow.TabIndex = 0;
            this.pboBorrow.TabStop = false;
            // 
            // lblBorrow
            // 
            this.lblBorrow.AutoSize = true;
            this.lblBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrow.ForeColor = System.Drawing.Color.White;
            this.lblBorrow.Location = new System.Drawing.Point(260, 54);
            this.lblBorrow.Name = "lblBorrow";
            this.lblBorrow.Size = new System.Drawing.Size(130, 25);
            this.lblBorrow.TabIndex = 1;
            this.lblBorrow.Text = "Borrow Date";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Black;
            this.btnConfirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.LightBlue;
            this.btnConfirm.Location = new System.Drawing.Point(18, 388);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(160, 39);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // dtpBorrow
            // 
            this.dtpBorrow.CustomFormat = "yyyy-MM-dd";
            this.dtpBorrow.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBorrow.Location = new System.Drawing.Point(413, 56);
            this.dtpBorrow.Name = "dtpBorrow";
            this.dtpBorrow.Size = new System.Drawing.Size(200, 22);
            this.dtpBorrow.TabIndex = 3;
            this.dtpBorrow.ValueChanged += new System.EventHandler(this.dtpBorrow_ValueChanged);
            // 
            // pboPanel
            // 
            this.pboPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(142)))), ((int)(((byte)(112)))));
            this.pboPanel.Controls.Add(this.pboBorrow);
            this.pboPanel.Controls.Add(this.btnConfirm);
            this.pboPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.pboPanel.Location = new System.Drawing.Point(0, 0);
            this.pboPanel.Name = "pboPanel";
            this.pboPanel.Size = new System.Drawing.Size(200, 450);
            this.pboPanel.TabIndex = 4;
            // 
            // dtpReturn
            // 
            this.dtpReturn.CustomFormat = "yyyy-MM-dd";
            this.dtpReturn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReturn.Location = new System.Drawing.Point(413, 117);
            this.dtpReturn.Name = "dtpReturn";
            this.dtpReturn.Size = new System.Drawing.Size(200, 22);
            this.dtpReturn.TabIndex = 6;
            // 
            // lblReturn
            // 
            this.lblReturn.AutoSize = true;
            this.lblReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturn.ForeColor = System.Drawing.Color.White;
            this.lblReturn.Location = new System.Drawing.Point(260, 115);
            this.lblReturn.Name = "lblReturn";
            this.lblReturn.Size = new System.Drawing.Size(126, 25);
            this.lblReturn.TabIndex = 5;
            this.lblReturn.Text = "Return Date";
            // 
            // lblIssue
            // 
            this.lblIssue.AutoSize = true;
            this.lblIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssue.ForeColor = System.Drawing.Color.White;
            this.lblIssue.Location = new System.Drawing.Point(267, 202);
            this.lblIssue.Name = "lblIssue";
            this.lblIssue.Size = new System.Drawing.Size(119, 25);
            this.lblIssue.TabIndex = 9;
            this.lblIssue.Text = "Book Issue";
            // 
            // txtIssue
            // 
            this.txtIssue.Location = new System.Drawing.Point(413, 180);
            this.txtIssue.Multiline = true;
            this.txtIssue.Name = "txtIssue";
            this.txtIssue.Size = new System.Drawing.Size(200, 72);
            this.txtIssue.TabIndex = 10;
            // 
            // BorrowForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(73)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIssue);
            this.Controls.Add(this.lblIssue);
            this.Controls.Add(this.dtpReturn);
            this.Controls.Add(this.lblReturn);
            this.Controls.Add(this.pboPanel);
            this.Controls.Add(this.dtpBorrow);
            this.Controls.Add(this.lblBorrow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BorrowForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BorrowForm";
            this.Load += new System.EventHandler(this.BorrowForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboBorrow)).EndInit();
            this.pboPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pboBorrow;
        private System.Windows.Forms.Label lblBorrow;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.DateTimePicker dtpBorrow;
        private System.Windows.Forms.Panel pboPanel;
        private System.Windows.Forms.DateTimePicker dtpReturn;
        private System.Windows.Forms.Label lblReturn;
        private System.Windows.Forms.Label lblIssue;
        private System.Windows.Forms.TextBox txtIssue;
    }
}