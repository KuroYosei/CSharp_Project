namespace Library.User_Control
{
    partial class ViewBook
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.dv_Bid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dv_BName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dv_Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dv_Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dv_ReleaseYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dv_Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.dv_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dv_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dv_rent_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panel1.TabIndex = 3;
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
            this.updateToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(124, 52);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.closeToolStripMenuItem.Text = "Delete";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(73)))), ((int)(((byte)(54)))));
            this.dgv1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv1.ColumnHeadersHeight = 30;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dv_Bid,
            this.dv_BName,
            this.dv_Author,
            this.dv_Genre,
            this.dv_ReleaseYear,
            this.dv_Image,
            this.dv_price,
            this.dv_quantity,
            this.dv_rent_quantity});
            this.dgv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv1.Location = new System.Drawing.Point(152, 0);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowHeadersVisible = false;
            this.dgv1.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.dgv1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv1.RowTemplate.Height = 24;
            this.dgv1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(1133, 516);
            this.dgv1.TabIndex = 5;
            this.dgv1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv1_CellMouseDown);
            // 
            // dv_Bid
            // 
            this.dv_Bid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dv_Bid.HeaderText = "Book_ID";
            this.dv_Bid.MinimumWidth = 6;
            this.dv_Bid.Name = "dv_Bid";
            this.dv_Bid.ReadOnly = true;
            // 
            // dv_BName
            // 
            this.dv_BName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dv_BName.HeaderText = "Book_Name";
            this.dv_BName.MinimumWidth = 6;
            this.dv_BName.Name = "dv_BName";
            this.dv_BName.ReadOnly = true;
            // 
            // dv_Author
            // 
            this.dv_Author.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dv_Author.HeaderText = "Author";
            this.dv_Author.MinimumWidth = 6;
            this.dv_Author.Name = "dv_Author";
            this.dv_Author.ReadOnly = true;
            // 
            // dv_Genre
            // 
            this.dv_Genre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dv_Genre.HeaderText = "Genre";
            this.dv_Genre.MinimumWidth = 6;
            this.dv_Genre.Name = "dv_Genre";
            this.dv_Genre.ReadOnly = true;
            // 
            // dv_ReleaseYear
            // 
            this.dv_ReleaseYear.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dv_ReleaseYear.HeaderText = "Release Year";
            this.dv_ReleaseYear.MinimumWidth = 6;
            this.dv_ReleaseYear.Name = "dv_ReleaseYear";
            this.dv_ReleaseYear.ReadOnly = true;
            // 
            // dv_Image
            // 
            this.dv_Image.HeaderText = "Image";
            this.dv_Image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dv_Image.MinimumWidth = 6;
            this.dv_Image.Name = "dv_Image";
            this.dv_Image.ReadOnly = true;
            this.dv_Image.Width = 125;
            // 
            // dv_price
            // 
            this.dv_price.HeaderText = "Price";
            this.dv_price.MinimumWidth = 6;
            this.dv_price.Name = "dv_price";
            this.dv_price.ReadOnly = true;
            this.dv_price.Width = 125;
            // 
            // dv_quantity
            // 
            this.dv_quantity.HeaderText = "Quantity";
            this.dv_quantity.MinimumWidth = 6;
            this.dv_quantity.Name = "dv_quantity";
            this.dv_quantity.ReadOnly = true;
            this.dv_quantity.Width = 125;
            // 
            // dv_rent_quantity
            // 
            this.dv_rent_quantity.HeaderText = "rent_quantity";
            this.dv_rent_quantity.Name = "dv_rent_quantity";
            this.dv_rent_quantity.ReadOnly = true;
            // 
            // ViewBook
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(73)))), ((int)(((byte)(54)))));
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.panel1);
            this.Name = "ViewBook";
            this.Size = new System.Drawing.Size(1285, 516);
            this.Load += new System.EventHandler(this.ViewBook_Load);
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dv_Bid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dv_BName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dv_Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn dv_Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dv_ReleaseYear;
        private System.Windows.Forms.DataGridViewImageColumn dv_Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn dv_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn dv_quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dv_rent_quantity;
    }
}
