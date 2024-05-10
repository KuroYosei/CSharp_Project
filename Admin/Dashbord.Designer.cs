namespace Library
{
    partial class Dashbord
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dbPanel = new System.Windows.Forms.Panel();
            this.linklblLogout = new System.Windows.Forms.LinkLabel();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.rentBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(142)))), ((int)(((byte)(112)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksToolStripMenuItem,
            this.studentToolStripMenuItem,
            this.orderToolStrip,
            this.rentBookToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MaximumSize = new System.Drawing.Size(1285, 516);
            this.menuStrip1.MinimumSize = new System.Drawing.Size(0, 50);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1285, 50);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dbPanel
            // 
            this.dbPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(73)))), ((int)(((byte)(54)))));
            this.dbPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbPanel.Location = new System.Drawing.Point(0, 50);
            this.dbPanel.MaximumSize = new System.Drawing.Size(1285, 516);
            this.dbPanel.Name = "dbPanel";
            this.dbPanel.Size = new System.Drawing.Size(1285, 516);
            this.dbPanel.TabIndex = 1;
            // 
            // linklblLogout
            // 
            this.linklblLogout.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(73)))), ((int)(((byte)(54)))));
            this.linklblLogout.AutoSize = true;
            this.linklblLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(142)))), ((int)(((byte)(112)))));
            this.linklblLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblLogout.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linklblLogout.LinkColor = System.Drawing.Color.White;
            this.linklblLogout.Location = new System.Drawing.Point(1195, 15);
            this.linklblLogout.Name = "linklblLogout";
            this.linklblLogout.Size = new System.Drawing.Size(78, 25);
            this.linklblLogout.TabIndex = 0;
            this.linklblLogout.TabStop = true;
            this.linklblLogout.Text = "Logout";
            this.linklblLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblLogout_LinkClicked);
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newBooksToolStripMenuItem,
            this.viewBooksToolStripMenuItem});
            this.booksToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.booksToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.booksToolStripMenuItem.Image = global::Library.Properties.Resources.agenda;
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(101, 48);
            this.booksToolStripMenuItem.Text = "Books";
            // 
            // newBooksToolStripMenuItem
            // 
            this.newBooksToolStripMenuItem.Image = global::Library.Properties.Resources.add;
            this.newBooksToolStripMenuItem.Name = "newBooksToolStripMenuItem";
            this.newBooksToolStripMenuItem.Size = new System.Drawing.Size(211, 28);
            this.newBooksToolStripMenuItem.Text = "Add new books";
            this.newBooksToolStripMenuItem.Click += new System.EventHandler(this.newBooksToolStripMenuItem_Click);
            // 
            // viewBooksToolStripMenuItem
            // 
            this.viewBooksToolStripMenuItem.Image = global::Library.Properties.Resources.research;
            this.viewBooksToolStripMenuItem.Name = "viewBooksToolStripMenuItem";
            this.viewBooksToolStripMenuItem.Size = new System.Drawing.Size(211, 28);
            this.viewBooksToolStripMenuItem.Text = "View books";
            this.viewBooksToolStripMenuItem.Click += new System.EventHandler(this.viewBooksToolStripMenuItem_Click);
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.studentToolStripMenuItem.Image = global::Library.Properties.Resources.user;
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(90, 48);
            this.studentToolStripMenuItem.Text = "User";
            this.studentToolStripMenuItem.Click += new System.EventHandler(this.studentToolStripMenuItem_Click);
            // 
            // orderToolStrip
            // 
            this.orderToolStrip.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.orderToolStrip.Image = global::Library.Properties.Resources.investor;
            this.orderToolStrip.Name = "orderToolStrip";
            this.orderToolStrip.Size = new System.Drawing.Size(157, 48);
            this.orderToolStrip.Text = "Buyer Record";
            this.orderToolStrip.Click += new System.EventHandler(this.orderToolStrip_Click);
            // 
            // rentBookToolStripMenuItem
            // 
            this.rentBookToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rentBookToolStripMenuItem.Image = global::Library.Properties.Resources.paper;
            this.rentBookToolStripMenuItem.Name = "rentBookToolStripMenuItem";
            this.rentBookToolStripMenuItem.Size = new System.Drawing.Size(134, 48);
            this.rentBookToolStripMenuItem.Text = "Rent Book";
            this.rentBookToolStripMenuItem.Click += new System.EventHandler(this.rentBookToolStripMenuItem_Click);
            // 
            // Dashbord
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(73)))), ((int)(((byte)(54)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1285, 575);
            this.Controls.Add(this.linklblLogout);
            this.Controls.Add(this.dbPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dashbord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashbord";
            this.Load += new System.EventHandler(this.Dashbord_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel dbPanel;
        private System.Windows.Forms.ToolStripMenuItem orderToolStrip;
        private System.Windows.Forms.ToolStripMenuItem rentBookToolStripMenuItem;
        private System.Windows.Forms.LinkLabel linklblLogout;
    }
}