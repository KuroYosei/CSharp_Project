using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Admin
{
    public partial class UpdateUserInfo : Form
    {
        public UpdateUserInfo()
        {
            InitializeComponent();
        }

        public int Uid { get; set; }
        public string Username { get; set; }
        public string Type { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }

        private void UpdateUserInfo_Load(object sender, EventArgs e)
        {
            txtUsername.Text = Username;
            txtEmail.Text = Email;
            txtType.Text = Type;
            txtPhone.Text = PhoneNo.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MySqlConnection cn = Dataconnection.connect();

            MySqlCommand query = new MySqlCommand("update userdata set username=@userName, email=@email, type=@type, phone=@phoneNo where uid = @uid", cn);
            query.Parameters.AddWithValue("@username", txtUsername.Text);
            query.Parameters.AddWithValue("@email", txtEmail.Text);
            query.Parameters.AddWithValue("@type", txtType.Text);
            query.Parameters.AddWithValue("@phoneNo", txtPhone.Text);
            query.Parameters.AddWithValue("@uid", Uid);
            if (Convert.ToBoolean(query.ExecuteNonQuery()))
            {
                MessageBox.Show("Update Success!", "Update Userinfo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
