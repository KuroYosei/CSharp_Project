namespace Library.User_Control
{
    partial class BuyerHistory
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.txtUid = new System.Windows.Forms.TextBox();
            this.lblUid = new System.Windows.Forms.Label();
            this.lblBid = new System.Windows.Forms.Label();
            this.txtBid = new System.Windows.Forms.TextBox();
            this.dv_bid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dv_uid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dv_BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dv_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dv_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dv_boughDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(142)))), ((int)(((byte)(112)))));
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 516);
            this.panel1.TabIndex = 4;
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(5, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(141, 42);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 28);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.closeToolStripMenuItem.Text = "Delete";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(73)))), ((int)(((byte)(54)))));
            this.dgv1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
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
            this.dv_uid,
            this.dv_BookName,
            this.dv_Price,
            this.dv_Quantity,
            this.dv_boughDate});
            this.dgv1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv1.Location = new System.Drawing.Point(152, 45);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowHeadersVisible = false;
            this.dgv1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv1.RowTemplate.Height = 24;
            this.dgv1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(1133, 471);
            this.dgv1.TabIndex = 7;
            this.dgv1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_CellMouseDown);
            // 
            // txtUid
            // 
            this.txtUid.Location = new System.Drawing.Point(220, 11);
            this.txtUid.Name = "txtUid";
            this.txtUid.Size = new System.Drawing.Size(158, 22);
            this.txtUid.TabIndex = 0;
            this.txtUid.Click += new System.EventHandler(this.txtUid_Click);
            this.txtUid.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblUid
            // 
            this.lblUid.AutoSize = true;
            this.lblUid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUid.ForeColor = System.Drawing.Color.White;
            this.lblUid.Location = new System.Drawing.Point(171, 12);
            this.lblUid.Name = "lblUid";
            this.lblUid.Size = new System.Drawing.Size(33, 18);
            this.lblUid.TabIndex = 9;
            this.lblUid.Text = "Uid";
            // 
            // lblBid
            // 
            this.lblBid.AutoSize = true;
            this.lblBid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBid.ForeColor = System.Drawing.Color.White;
            this.lblBid.Location = new System.Drawing.Point(393, 12);
            this.lblBid.Name = "lblBid";
            this.lblBid.Size = new System.Drawing.Size(32, 18);
            this.lblBid.TabIndex = 11;
            this.lblBid.Text = "Bid";
            // 
            // txtBid
            // 
            this.txtBid.Location = new System.Drawing.Point(442, 11);
            this.txtBid.Name = "txtBid";
            this.txtBid.Size = new System.Drawing.Size(158, 22);
            this.txtBid.TabIndex = 1;
            this.txtBid.Click += new System.EventHandler(this.txtBid_Click);
            this.txtBid.TextChanged += new System.EventHandler(this.txtBid_TextChanged);
            // 
            // dv_bid
            // 
            this.dv_bid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dv_bid.HeaderText = "Book ID";
            this.dv_bid.MinimumWidth = 6;
            this.dv_bid.Name = "dv_bid";
            this.dv_bid.ReadOnly = true;
            // 
            // dv_uid
            // 
            this.dv_uid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dv_uid.HeaderText = "User ID";
            this.dv_uid.MinimumWidth = 6;
            this.dv_uid.Name = "dv_uid";
            this.dv_uid.ReadOnly = true;
            // 
            // dv_BookName
            // 
            this.dv_BookName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dv_BookName.FillWeight = 200F;
            this.dv_BookName.HeaderText = "Book Name";
            this.dv_BookName.MinimumWidth = 6;
            this.dv_BookName.Name = "dv_BookName";
            this.dv_BookName.ReadOnly = true;
            // 
            // dv_Price
            // 
            this.dv_Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dv_Price.HeaderText = "Price";
            this.dv_Price.MinimumWidth = 6;
            this.dv_Price.Name = "dv_Price";
            this.dv_Price.ReadOnly = true;
            // 
            // dv_Quantity
            // 
            this.dv_Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dv_Quantity.HeaderText = "Quantity";
            this.dv_Quantity.MinimumWidth = 6;
            this.dv_Quantity.Name = "dv_Quantity";
            this.dv_Quantity.ReadOnly = true;
            // 
            // dv_boughDate
            // 
            this.dv_boughDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dv_boughDate.HeaderText = "Buy Date";
            this.dv_boughDate.MinimumWidth = 6;
            this.dv_boughDate.Name = "dv_boughDate";
            this.dv_boughDate.ReadOnly = true;
            // 
            // BuyerHistory
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(73)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.lblBid);
            this.Controls.Add(this.txtBid);
            this.Controls.Add(this.lblUid);
            this.Controls.Add(this.txtUid);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.panel1);
            this.Name = "BuyerHistory";
            this.Size = new System.Drawing.Size(1285, 516);
            this.Load += new System.EventHandler(this.OrderedBook_Load);
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.TextBox txtUid;
        private System.Windows.Forms.Label lblUid;
        private System.Windows.Forms.Label lblBid;
        private System.Windows.Forms.TextBox txtBid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dv_bid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dv_uid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dv_BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dv_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn dv_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dv_boughDate;
    }
}
