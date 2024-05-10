namespace Library
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtLoginUserName = new System.Windows.Forms.TextBox();
            this.txtLoginPass = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.loginTimer = new System.Windows.Forms.Timer(this.components);
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.lblLoginUserName = new System.Windows.Forms.Label();
            this.lblLoginPass = new System.Windows.Forms.Label();
            this.signuppanel = new System.Windows.Forms.Panel();
            this.pboHidden2 = new System.Windows.Forms.PictureBox();
            this.pboShowPass2 = new System.Windows.Forms.PictureBox();
            this.pboHidden = new System.Windows.Forms.PictureBox();
            this.pboShowPass = new System.Windows.Forms.PictureBox();
            this.lblCheckPass = new System.Windows.Forms.Label();
            this.txtCheckPass = new System.Windows.Forms.TextBox();
            this.lblPhNo = new System.Windows.Forms.Label();
            this.signupcreateaccbtn = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pboHidden3 = new System.Windows.Forms.PictureBox();
            this.pboShowPass3 = new System.Windows.Forms.PictureBox();
            this.pboProfile = new System.Windows.Forms.PictureBox();
            this.signuppanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboHidden2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboShowPass2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboHidden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboShowPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboHidden3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboShowPass3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLoginUserName
            // 
            this.txtLoginUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.txtLoginUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLoginUserName.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginUserName.ForeColor = System.Drawing.Color.White;
            this.txtLoginUserName.Location = new System.Drawing.Point(457, 145);
            this.txtLoginUserName.Margin = new System.Windows.Forms.Padding(2);
            this.txtLoginUserName.Name = "txtLoginUserName";
            this.txtLoginUserName.Size = new System.Drawing.Size(128, 17);
            this.txtLoginUserName.TabIndex = 1;
            this.txtLoginUserName.Text = "Username";
            this.txtLoginUserName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtUsername_MouseClick);
            this.txtLoginUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLoginUserName_KeyPress);
            this.txtLoginUserName.MouseEnter += new System.EventHandler(this.txtUsername_MouseEnter);
            // 
            // txtLoginPass
            // 
            this.txtLoginPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.txtLoginPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLoginPass.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginPass.ForeColor = System.Drawing.Color.White;
            this.txtLoginPass.Location = new System.Drawing.Point(458, 194);
            this.txtLoginPass.Margin = new System.Windows.Forms.Padding(2);
            this.txtLoginPass.Name = "txtLoginPass";
            this.txtLoginPass.Size = new System.Drawing.Size(128, 17);
            this.txtLoginPass.TabIndex = 2;
            this.txtLoginPass.Text = "Password";
            this.txtLoginPass.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPassword_MouseClick);
            this.txtLoginPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLoginPass_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(458, 161);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(128, 1);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(458, 212);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(128, 1);
            this.panel2.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(420, 242);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(128, 22);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSignUp.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSignUp.Location = new System.Drawing.Point(420, 278);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(128, 24);
            this.btnSignUp.TabIndex = 6;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(73)))), ((int)(((byte)(54)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(73)))), ((int)(((byte)(54)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(631, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 24);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // loginTimer
            // 
            this.loginTimer.Tick += new System.EventHandler(this.loginTimer_Tick);
            // 
            // lblLoginUserName
            // 
            this.lblLoginUserName.AutoSize = true;
            this.lblLoginUserName.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginUserName.ForeColor = System.Drawing.Color.White;
            this.lblLoginUserName.Location = new System.Drawing.Point(372, 144);
            this.lblLoginUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoginUserName.Name = "lblLoginUserName";
            this.lblLoginUserName.Size = new System.Drawing.Size(72, 18);
            this.lblLoginUserName.TabIndex = 8;
            this.lblLoginUserName.Text = "Username";
            // 
            // lblLoginPass
            // 
            this.lblLoginPass.AutoSize = true;
            this.lblLoginPass.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginPass.ForeColor = System.Drawing.Color.White;
            this.lblLoginPass.Location = new System.Drawing.Point(372, 194);
            this.lblLoginPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoginPass.Name = "lblLoginPass";
            this.lblLoginPass.Size = new System.Drawing.Size(67, 18);
            this.lblLoginPass.TabIndex = 9;
            this.lblLoginPass.Text = "Password";
            // 
            // signuppanel
            // 
            this.signuppanel.Controls.Add(this.pboHidden2);
            this.signuppanel.Controls.Add(this.pboShowPass2);
            this.signuppanel.Controls.Add(this.pboHidden);
            this.signuppanel.Controls.Add(this.pboShowPass);
            this.signuppanel.Controls.Add(this.lblCheckPass);
            this.signuppanel.Controls.Add(this.txtCheckPass);
            this.signuppanel.Controls.Add(this.lblPhNo);
            this.signuppanel.Controls.Add(this.signupcreateaccbtn);
            this.signuppanel.Controls.Add(this.lblPassword);
            this.signuppanel.Controls.Add(this.lblEmail);
            this.signuppanel.Controls.Add(this.lblUserName);
            this.signuppanel.Controls.Add(this.txtPass);
            this.signuppanel.Controls.Add(this.txtPhone);
            this.signuppanel.Controls.Add(this.txtEmail);
            this.signuppanel.Controls.Add(this.txtUserName);
            this.signuppanel.Location = new System.Drawing.Point(328, 120);
            this.signuppanel.Margin = new System.Windows.Forms.Padding(2);
            this.signuppanel.Name = "signuppanel";
            this.signuppanel.Size = new System.Drawing.Size(306, 243);
            this.signuppanel.TabIndex = 19;
            // 
            // pboHidden2
            // 
            this.pboHidden2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboHidden2.Image = global::Library.Properties.Resources._22249_200;
            this.pboHidden2.Location = new System.Drawing.Point(264, 149);
            this.pboHidden2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pboHidden2.Name = "pboHidden2";
            this.pboHidden2.Size = new System.Drawing.Size(19, 20);
            this.pboHidden2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboHidden2.TabIndex = 16;
            this.pboHidden2.TabStop = false;
            this.pboHidden2.Click += new System.EventHandler(this.pboHidden2_Click);
            // 
            // pboShowPass2
            // 
            this.pboShowPass2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboShowPass2.Image = global::Library.Properties.Resources._6684701;
            this.pboShowPass2.Location = new System.Drawing.Point(264, 149);
            this.pboShowPass2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pboShowPass2.Name = "pboShowPass2";
            this.pboShowPass2.Size = new System.Drawing.Size(19, 20);
            this.pboShowPass2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboShowPass2.TabIndex = 15;
            this.pboShowPass2.TabStop = false;
            this.pboShowPass2.Click += new System.EventHandler(this.pboShowPass2_Click);
            // 
            // pboHidden
            // 
            this.pboHidden.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboHidden.Image = global::Library.Properties.Resources._22249_200;
            this.pboHidden.Location = new System.Drawing.Point(264, 117);
            this.pboHidden.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pboHidden.Name = "pboHidden";
            this.pboHidden.Size = new System.Drawing.Size(19, 20);
            this.pboHidden.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboHidden.TabIndex = 14;
            this.pboHidden.TabStop = false;
            this.pboHidden.Click += new System.EventHandler(this.pboHidden_Click);
            // 
            // pboShowPass
            // 
            this.pboShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboShowPass.Image = global::Library.Properties.Resources._6684701;
            this.pboShowPass.Location = new System.Drawing.Point(264, 117);
            this.pboShowPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pboShowPass.Name = "pboShowPass";
            this.pboShowPass.Size = new System.Drawing.Size(19, 20);
            this.pboShowPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboShowPass.TabIndex = 13;
            this.pboShowPass.TabStop = false;
            this.pboShowPass.Click += new System.EventHandler(this.pboShowPass_Click);
            // 
            // lblCheckPass
            // 
            this.lblCheckPass.AutoSize = true;
            this.lblCheckPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckPass.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCheckPass.Location = new System.Drawing.Point(38, 150);
            this.lblCheckPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCheckPass.Name = "lblCheckPass";
            this.lblCheckPass.Size = new System.Drawing.Size(91, 15);
            this.lblCheckPass.TabIndex = 12;
            this.lblCheckPass.Text = "Re-password";
            // 
            // txtCheckPass
            // 
            this.txtCheckPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.txtCheckPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCheckPass.ForeColor = System.Drawing.Color.White;
            this.txtCheckPass.Location = new System.Drawing.Point(136, 150);
            this.txtCheckPass.Margin = new System.Windows.Forms.Padding(2);
            this.txtCheckPass.Name = "txtCheckPass";
            this.txtCheckPass.Size = new System.Drawing.Size(129, 20);
            this.txtCheckPass.TabIndex = 4;
            this.txtCheckPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCheckPass_KeyPress);
            // 
            // lblPhNo
            // 
            this.lblPhNo.AutoSize = true;
            this.lblPhNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhNo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPhNo.Location = new System.Drawing.Point(38, 85);
            this.lblPhNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhNo.Name = "lblPhNo";
            this.lblPhNo.Size = new System.Drawing.Size(48, 15);
            this.lblPhNo.TabIndex = 10;
            this.lblPhNo.Text = "Phone";
            // 
            // signupcreateaccbtn
            // 
            this.signupcreateaccbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.signupcreateaccbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.signupcreateaccbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.signupcreateaccbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupcreateaccbtn.Location = new System.Drawing.Point(40, 188);
            this.signupcreateaccbtn.Margin = new System.Windows.Forms.Padding(2);
            this.signupcreateaccbtn.Name = "signupcreateaccbtn";
            this.signupcreateaccbtn.Size = new System.Drawing.Size(152, 28);
            this.signupcreateaccbtn.TabIndex = 5;
            this.signupcreateaccbtn.Text = "Create Account";
            this.signupcreateaccbtn.UseVisualStyleBackColor = false;
            this.signupcreateaccbtn.Click += new System.EventHandler(this.signupcreateaccbtn_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPassword.Location = new System.Drawing.Point(38, 118);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 15);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEmail.Location = new System.Drawing.Point(38, 53);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 15);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUserName.Location = new System.Drawing.Point(38, 20);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(45, 15);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "Name";
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPass.ForeColor = System.Drawing.Color.White;
            this.txtPass.Location = new System.Drawing.Point(136, 117);
            this.txtPass.Margin = new System.Windows.Forms.Padding(2);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(129, 20);
            this.txtPass.TabIndex = 3;
            this.txtPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPass_KeyPress);
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.ForeColor = System.Drawing.Color.White;
            this.txtPhone.Location = new System.Drawing.Point(136, 84);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(129, 20);
            this.txtPhone.TabIndex = 2;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress_1);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(136, 52);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(129, 20);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.ForeColor = System.Drawing.Color.White;
            this.txtUserName.Location = new System.Drawing.Point(136, 20);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(129, 20);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserName_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Library.Properties.Resources.pexels_olena_bohovyk_3646105;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 372);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // pboHidden3
            // 
            this.pboHidden3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboHidden3.Image = global::Library.Properties.Resources._22249_200;
            this.pboHidden3.Location = new System.Drawing.Point(590, 193);
            this.pboHidden3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pboHidden3.Name = "pboHidden3";
            this.pboHidden3.Size = new System.Drawing.Size(19, 20);
            this.pboHidden3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboHidden3.TabIndex = 18;
            this.pboHidden3.TabStop = false;
            this.pboHidden3.Click += new System.EventHandler(this.pboHidden3_Click);
            // 
            // pboShowPass3
            // 
            this.pboShowPass3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboShowPass3.Image = global::Library.Properties.Resources._6684701;
            this.pboShowPass3.Location = new System.Drawing.Point(590, 193);
            this.pboShowPass3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pboShowPass3.Name = "pboShowPass3";
            this.pboShowPass3.Size = new System.Drawing.Size(19, 20);
            this.pboShowPass3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboShowPass3.TabIndex = 17;
            this.pboShowPass3.TabStop = false;
            this.pboShowPass3.Click += new System.EventHandler(this.pboShowPass3_Click);
            // 
            // pboProfile
            // 
            this.pboProfile.Image = ((System.Drawing.Image)(resources.GetObject("pboProfile.Image")));
            this.pboProfile.Location = new System.Drawing.Point(431, 9);
            this.pboProfile.Margin = new System.Windows.Forms.Padding(2);
            this.pboProfile.Name = "pboProfile";
            this.pboProfile.Size = new System.Drawing.Size(117, 108);
            this.pboProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboProfile.TabIndex = 0;
            this.pboProfile.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(73)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(654, 372);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.signuppanel);
            this.Controls.Add(this.pboHidden3);
            this.Controls.Add(this.pboShowPass3);
            this.Controls.Add(this.lblLoginPass);
            this.Controls.Add(this.lblLoginUserName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtLoginPass);
            this.Controls.Add(this.txtLoginUserName);
            this.Controls.Add(this.pboProfile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.signuppanel.ResumeLayout(false);
            this.signuppanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboHidden2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboShowPass2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboHidden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboShowPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboHidden3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboShowPass3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pboProfile;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtLoginUserName;
        private System.Windows.Forms.TextBox txtLoginPass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Timer loginTimer;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Label lblLoginUserName;
        private System.Windows.Forms.Label lblLoginPass;
        private System.Windows.Forms.PictureBox pboHidden3;
        private System.Windows.Forms.PictureBox pboShowPass3;
        private System.Windows.Forms.Panel signuppanel;
        private System.Windows.Forms.PictureBox pboHidden2;
        private System.Windows.Forms.PictureBox pboShowPass2;
        private System.Windows.Forms.PictureBox pboHidden;
        private System.Windows.Forms.PictureBox pboShowPass;
        private System.Windows.Forms.Label lblCheckPass;
        private System.Windows.Forms.TextBox txtCheckPass;
        private System.Windows.Forms.Label lblPhNo;
        private System.Windows.Forms.Button signupcreateaccbtn;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

