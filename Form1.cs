using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.User_Control;
using MySql.Data.MySqlClient;
using static System.Net.Mime.MediaTypeNames;

namespace Library
{
    public partial class Form1 : Form
    {
        private DataStore dataStore = new DataStore();

        public Form1(DataStore data)
        {
            InitializeComponent();
            signuppanel.Visible = false;
            dataStore = data;
        }

        int count, attempt;
        MySqlDataReader reader = null;

        void disable()
        {
            if (attempt == 3)
            {
                MessageBox.Show("you have made too many attempts! \nPlease try again.", "Attempts", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                attempt = 0;

                count = 30;

                loginTimer.Enabled = true;
                btnLogin.Enabled = false;
                txtLoginPass.Enabled = false;
                txtLoginUserName.Enabled = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsername_MouseEnter(object sender, EventArgs e)
        {
            if (txtLoginUserName.Text == "Username")
            {
                txtLoginUserName.Clear();
            }
        }

        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtLoginUserName.Text == "Username")
            {
                txtLoginUserName.Clear();
            }
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtLoginPass.Text == "Password")
            {
                txtLoginPass.Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            attempt = 0;
            txtUserName.Focus();

            //hide password
            txtPass.UseSystemPasswordChar = true;
            txtCheckPass.UseSystemPasswordChar = true;
            txtLoginPass.UseSystemPasswordChar = true;

            pboHidden.Hide();
            pboHidden2.Hide();
            pboHidden3.Hide();
        }

        private void loginTimer_Tick(object sender, EventArgs e)
        {
            if (count == 0)
            {
                loginTimer.Enabled = false;
                btnLogin.Enabled = true;
                txtLoginPass.Enabled = true;
                txtLoginUserName.Enabled = true;
                btnLogin.Text = "Login";
                txtLoginUserName.Focus();
            }
            else
            {
                btnLogin.Text = "log in" + count;
                count = count - 1;
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            signuppanel.Visible = true;
            txtUserName.Focus();
        }

        //phone textbox digit only
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Suppress the key press
            }
        }

        //show password

        private void pboShowPass_Click(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = false;
            pboShowPass.Hide();
            pboHidden.Show();
        }

        private void pboShowPass2_Click(object sender, EventArgs e)
        {
            txtCheckPass.UseSystemPasswordChar = false;
            pboShowPass2.Hide();
            pboHidden2.Show();
        }

        private void pboShowPass3_Click(object sender, EventArgs e)
        {
            txtLoginPass.UseSystemPasswordChar = false;
            pboHidden3.Show();
            pboShowPass3.Hide();
        }

        //hide password

        private void pboHidden_Click(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
            pboHidden.Hide();
            pboShowPass.Show();
        }

        private void pboHidden2_Click(object sender, EventArgs e)
        {
            txtCheckPass.UseSystemPasswordChar = true;
            pboHidden2.Hide();
            pboShowPass2.Show();
        }

        private void pboHidden3_Click(object sender, EventArgs e)
        {
            txtLoginPass.UseSystemPasswordChar = true;
            pboHidden3.Hide();
            pboShowPass3.Show();
        }

        private void signupcreateaccbtn_Click(object sender, EventArgs e)
        {
            DynamicUCTest duc = new DynamicUCTest(dataStore);

            string username = txtUserName.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string password = txtPass.Text;
            string cpassword = txtCheckPass.Text;

            //validation pattern
            string namePattern = @"^[a-zA-Z0-9]{6,12}$";
            string passPattern = @"^(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8}$";
            string emailPattern = @"^[a-zA-Z0-9._%+]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            string phonePattern = @"^[0-9]{11}$";

            if (string.IsNullOrEmpty(username)) //username null validation
            {
                MessageBox.Show("Please enter your Name!", "Signup Username Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
                return;
            }
            else if (!Regex.IsMatch(username, namePattern)) //username format validation
            {
                MessageBox.Show("At least 6 characters long & At most 12 characters long.", "Signup Username Validation Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(email)) //email null validation
            {
                MessageBox.Show("PLease enter your Email!", "Signup Email Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }
            else if (!Regex.IsMatch(email, emailPattern)) //email format validation
            {
                MessageBox.Show("Unvalid Email", "Signup Email Validation Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(phone)) //phone number null validation
            {
                MessageBox.Show("PLease enter your Phone Number!", "Signup Phone Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return;
            }
            else if (!Regex.IsMatch(phone, phonePattern)) //phone number must start with 09 validation
            {
                MessageBox.Show("Phone Number must have 11 number!", "Signup Phone Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(password)) //password null validation
            {
                MessageBox.Show("PLease enter your Password!!", "Signup Password Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPass.Focus();
                return;
            }
            else if (!Regex.IsMatch(password, passPattern)) //password format validation
            {
                MessageBox.Show("At least 8 characters long. \n Contain at least one Uppercase letter. \n Contain at least one digit. \n Contain at least special one character.", "Signup Password Validation Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPass.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(cpassword)) //check password null validation
            {
                MessageBox.Show("PLease enter your Re-password!", "Signup Re-password Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCheckPass.Focus();
                return;
            }
            else if (password != cpassword) // password & checkpassowrd match validation
            {
                MessageBox.Show("Password and Re-password doesn't match.", "Signup Password Match Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCheckPass.Focus();
            }
            else if (!string.IsNullOrEmpty(username))
            {
                //username already exist or not validation
                //connection open
                MySqlConnection cn = Dataconnection.connect();

                //get username from userdata
                MySqlCommand query = new MySqlCommand("select username,email from userdata", cn);
                reader = query.ExecuteReader();

                while (reader.Read())
                {
                    if (username == reader["username"].ToString())
                    {
                        MessageBox.Show("Username already exist.", "Username Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtUserName.Focus();
                        return;
                    }
                    else if (email == reader["email"].ToString())
                    {
                        MessageBox.Show("Email already exist.", "Username Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtEmail.Focus();
                        return;
                    }
                }
                reader.Close();

                MySqlCommand cmd = new MySqlCommand("insert into userdata(username,email,password,phone,type) values (@username,@email,@password,@phone,@type)", cn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@type", "member");
                if (Convert.ToBoolean(cmd.ExecuteNonQuery()))
                {
                    if (MessageBox.Show("Create Account Success!", "Signup Form", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        signuppanel.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("Create Account Fail!", "Signup Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                signupcreateaccbtn_Click(sender, e);
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                signupcreateaccbtn_Click(sender, e);
            }
        }

        private void txtPhone_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                signupcreateaccbtn_Click(sender, e);
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                signupcreateaccbtn_Click(sender, e);
            }
        }

        private void txtCheckPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                signupcreateaccbtn_Click(sender, e);
            }
        }

        private void txtLoginUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void txtLoginPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MySqlConnection cn = Dataconnection.connect();

            string username = txtLoginUserName.Text;
            string password = txtLoginPass.Text;

            //get account from userdata
            string query = "select * from userdata where username = @username && password = @password";

            MySqlCommand cmd = new MySqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            reader = cmd.ExecuteReader();

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter your Name!", "Login Username Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLoginUserName.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter your Password!", "Login Password Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLoginPass.Focus();
                return;
            }
            else
            {
                if (reader.Read())
                {

                    dataStore.uid = int.Parse(reader["uid"].ToString());
                    BuyerHistory orderedBook = new BuyerHistory(dataStore);

                    string type = reader["type"].ToString();
                    if (type == "Admin")
                    {
                        Dashbord ds = new Dashbord(dataStore);
                        ds.ShowDialog();
                        this.Hide();
                    }
                    else
                    {
                        //for userDashboard             

                        DynamicUCTest duc = new DynamicUCTest(dataStore);
                        this.Hide();
                        duc.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Account doesn't exist.", "Login fail", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtLoginUserName.Clear();
                    txtLoginPass.Clear();
                    txtLoginUserName.Focus();
                    attempt = attempt + 1;
                    disable();
                }
            }
        }
    }
}
