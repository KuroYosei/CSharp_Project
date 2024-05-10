namespace Library.User_Control
{
    partial class RentBook
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBid = new System.Windows.Forms.Label();
            this.txtBid = new System.Windows.Forms.TextBox();
            this.lblUid = new System.Windows.Forms.Label();
            this.txtUid = new System.Windows.Forms.TextBox();
            this.dv_bid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dv_UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dv_bookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dv_RentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dv_ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dv_ActualReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dv_Issue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dv_ReturnIssue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(142)))), ((int)(((byte)(112)))));
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(152, 516);
            this.panel2.TabIndex = 7;
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(5, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(141, 42);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(73)))), ((int)(((byte)(54)))));
            this.dgv1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv1.ColumnHeadersHeight = 30;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dv_bid,
            this.dv_UserId,
            this.dv_bookName,
            this.dv_RentDate,
            this.dv_ReturnDate,
            this.dv_ActualReturnDate,
            this.dv_Issue,
            this.dv_ReturnIssue});
            this.dgv1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv1.Location = new System.Drawing.Point(152, 47);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersVisible = false;
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.RowTemplate.Height = 24;
            this.dgv1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv1.Size = new System.Drawing.Size(1133, 469);
            this.dgv1.TabIndex = 6;
            this.dgv1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.returnToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(120, 52);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.closeToolStripMenuItem.Text = "Delete";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // returnToolStripMenuItem
            // 
            this.returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            this.returnToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.returnToolStripMenuItem.Text = "Return";
            this.returnToolStripMenuItem.Click += new System.EventHandler(this.returnToolStripMenuItem_Click);
            // 
            // lblBid
            // 
            this.lblBid.AutoSize = true;
            this.lblBid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBid.ForeColor = System.Drawing.Color.White;
            this.lblBid.Location = new System.Drawing.Point(393, 14);
            this.lblBid.Name = "lblBid";
            this.lblBid.Size = new System.Drawing.Size(28, 15);
            this.lblBid.TabIndex = 15;
            this.lblBid.Text = "Bid";
            // 
            // txtBid
            // 
            this.txtBid.Location = new System.Drawing.Point(442, 13);
            this.txtBid.Name = "txtBid";
            this.txtBid.Size = new System.Drawing.Size(158, 20);
            this.txtBid.TabIndex = 13;
            this.txtBid.Click += new System.EventHandler(this.txtBid_Click);
            this.txtBid.TextChanged += new System.EventHandler(this.txtBid_TextChanged);
            // 
            // lblUid
            // 
            this.lblUid.AutoSize = true;
            this.lblUid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUid.ForeColor = System.Drawing.Color.White;
            this.lblUid.Location = new System.Drawing.Point(171, 14);
            this.lblUid.Name = "lblUid";
            this.lblUid.Size = new System.Drawing.Size(29, 15);
            this.lblUid.TabIndex = 14;
            this.lblUid.Text = "Uid";
            // 
            // txtUid
            // 
            this.txtUid.Location = new System.Drawing.Point(220, 13);
            this.txtUid.Name = "txtUid";
            this.txtUid.Size = new System.Drawing.Size(158, 20);
            this.txtUid.TabIndex = 12;
            this.txtUid.Click += new System.EventHandler(this.txtUid_Click);
            this.txtUid.TextChanged += new System.EventHandler(this.txtUid_TextChanged);
            // 
            // dv_bid
            // 
            this.dv_bid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dv_bid.FillWeight = 40F;
            this.dv_bid.HeaderText = "Book Id";
            this.dv_bid.MinimumWidth = 6;
            this.dv_bid.Name = "dv_bid";
            this.dv_bid.Width = 69;
            // 
            // dv_UserId
            // 
            this.dv_UserId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dv_UserId.FillWeight = 16.04278F;
            this.dv_UserId.HeaderText = "User Id";
            this.dv_UserId.MinimumWidth = 6;
            this.dv_UserId.Name = "dv_UserId";
            this.dv_UserId.Width = 66;
            // 
            // dv_bookName
            // 
            this.dv_bookName.HeaderText = "Book Name";
            this.dv_bookName.Name = "dv_bookName";
            // 
            // dv_RentDate
            // 
            this.dv_RentDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.dv_RentDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.dv_RentDate.FillWeight = 80F;
            this.dv_RentDate.HeaderText = "Rent Date";
            this.dv_RentDate.MinimumWidth = 7;
            this.dv_RentDate.Name = "dv_RentDate";
            // 
            // dv_ReturnDate
            // 
            this.dv_ReturnDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dv_ReturnDate.FillWeight = 80F;
            this.dv_ReturnDate.HeaderText = "Expected Return Date";
            this.dv_ReturnDate.MinimumWidth = 6;
            this.dv_ReturnDate.Name = "dv_ReturnDate";
            // 
            // dv_ActualReturnDate
            // 
            this.dv_ActualReturnDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dv_ActualReturnDate.FillWeight = 80F;
            this.dv_ActualReturnDate.HeaderText = "Actual Return Date";
            this.dv_ActualReturnDate.MinimumWidth = 6;
            this.dv_ActualReturnDate.Name = "dv_ActualReturnDate";
            // 
            // dv_Issue
            // 
            this.dv_Issue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dv_Issue.FillWeight = 150F;
            this.dv_Issue.HeaderText = "Rent Issue";
            this.dv_Issue.MinimumWidth = 6;
            this.dv_Issue.Name = "dv_Issue";
            // 
            // dv_ReturnIssue
            // 
            this.dv_ReturnIssue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dv_ReturnIssue.FillWeight = 120F;
            this.dv_ReturnIssue.HeaderText = "Return Issue";
            this.dv_ReturnIssue.MinimumWidth = 6;
            this.dv_ReturnIssue.Name = "dv_ReturnIssue";
            // 
            // RentBook
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(73)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.lblBid);
            this.Controls.Add(this.txtBid);
            this.Controls.Add(this.lblUid);
            this.Controls.Add(this.txtUid);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgv1);
            this.Name = "RentBook";
            this.Size = new System.Drawing.Size(1285, 516);
            this.Load += new System.EventHandler(this.RentBook_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.Label lblBid;
        private System.Windows.Forms.TextBox txtBid;
        private System.Windows.Forms.Label lblUid;
        private System.Windows.Forms.TextBox txtUid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dv_bid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dv_UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dv_bookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dv_RentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dv_ReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dv_ActualReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dv_Issue;
        private System.Windows.Forms.DataGridViewTextBoxColumn dv_ReturnIssue;
    }
}
