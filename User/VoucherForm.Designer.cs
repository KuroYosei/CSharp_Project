namespace Library.User
{
    partial class VoucherForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dv_BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dv_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dv_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dv_BookName,
            this.dv_Quantity,
            this.dv_Price});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(492, 402);
            this.dataGridView1.TabIndex = 0;
            // 
            // dv_BookName
            // 
            this.dv_BookName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dv_BookName.HeaderText = "BookName";
            this.dv_BookName.MinimumWidth = 6;
            this.dv_BookName.Name = "dv_BookName";
            // 
            // dv_Quantity
            // 
            this.dv_Quantity.HeaderText = "Quantity";
            this.dv_Quantity.MinimumWidth = 6;
            this.dv_Quantity.Name = "dv_Quantity";
            this.dv_Quantity.Width = 125;
            // 
            // dv_Price
            // 
            this.dv_Price.HeaderText = "Price";
            this.dv_Price.MinimumWidth = 6;
            this.dv_Price.Name = "dv_Price";
            this.dv_Price.Width = 125;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(12, 15);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(77, 18);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "Username";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(368, 15);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(45, 18);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(419, 15);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(42, 18);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price";
            // 
            // VoucherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(492, 450);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VoucherForm";
            this.Text = "VoucherForm";
            this.Load += new System.EventHandler(this.VoucherForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dv_BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dv_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dv_Price;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPrice;
    }
}