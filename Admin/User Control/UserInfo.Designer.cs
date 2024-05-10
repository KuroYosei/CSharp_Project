namespace Library.Admin.User_Control
{
    partial class UserInfo
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
            this.dv_Uid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dv_UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dv_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dv_Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dv_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dv_Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panel1.TabIndex = 6;
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
            this.contextMenuStrip1.Size = new System.Drawing.Size(128, 52);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
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
            this.dv_Uid,
            this.dv_UserName,
            this.dv_email,
            this.dv_Password,
            this.dv_Type,
            this.dv_Phone});
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
            this.dgv1.TabIndex = 8;
            this.dgv1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv1_CellMouseDown);
            // 
            // dv_Uid
            // 
            this.dv_Uid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dv_Uid.HeaderText = "Uid";
            this.dv_Uid.MinimumWidth = 6;
            this.dv_Uid.Name = "dv_Uid";
            this.dv_Uid.ReadOnly = true;
            // 
            // dv_UserName
            // 
            this.dv_UserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dv_UserName.HeaderText = "UserName";
            this.dv_UserName.MinimumWidth = 6;
            this.dv_UserName.Name = "dv_UserName";
            this.dv_UserName.ReadOnly = true;
            // 
            // dv_email
            // 
            this.dv_email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dv_email.HeaderText = "Email";
            this.dv_email.MinimumWidth = 6;
            this.dv_email.Name = "dv_email";
            this.dv_email.ReadOnly = true;
            // 
            // dv_Password
            // 
            this.dv_Password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dv_Password.HeaderText = "Password";
            this.dv_Password.MinimumWidth = 6;
            this.dv_Password.Name = "dv_Password";
            this.dv_Password.ReadOnly = true;
            // 
            // dv_Type
            // 
            this.dv_Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dv_Type.HeaderText = "Type";
            this.dv_Type.MinimumWidth = 6;
            this.dv_Type.Name = "dv_Type";
            this.dv_Type.ReadOnly = true;
            // 
            // dv_Phone
            // 
            this.dv_Phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dv_Phone.HeaderText = "PhoneNumber";
            this.dv_Phone.MinimumWidth = 6;
            this.dv_Phone.Name = "dv_Phone";
            this.dv_Phone.ReadOnly = true;
            // 
            // UserInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(73)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.panel1);
            this.Name = "UserInfo";
            this.Size = new System.Drawing.Size(1285, 516);
            this.Load += new System.EventHandler(this.UserInfo_Load);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dv_Uid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dv_UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dv_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn dv_Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn dv_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn dv_Phone;
    }
}
