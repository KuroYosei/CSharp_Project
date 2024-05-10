using Library.User_Control;
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
    public partial class ReturnIssueForm : Form
    {
        public ReturnIssueForm()
        {
            InitializeComponent();
        }

        public int bid { get; set; }
        public int uid { get; set; }
        public string rentDate { get; set; }
        public string expectedReturnDate { get; set; }
        public string actualReturnDate { get; set; }
        public string rentIssue { get; set; }
        public string returnIssue { get; set; }

        private void ReturnIssueForm_Load(object sender, EventArgs e)
        {
            lblShowRentDate.Text = rentDate;
            lblShowExpectRD.Text = expectedReturnDate;
            lblShowActuralRD.Text = actualReturnDate;
            lblShowRentIssue.Text = rentIssue;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MySqlConnection cn = Dataconnection.connect();

            MySqlCommand query = new MySqlCommand("update rentbook set returnIssue = @returnIssue where uid=@uid && bid=@bid",cn);
            query.Parameters.AddWithValue("@returnIssue", txtReturnIssue.Text);
            query.Parameters.AddWithValue("@uid", uid);
            query.Parameters.AddWithValue("bid", bid);

            if (Convert.ToBoolean(query.ExecuteNonQuery()))
            {
                MessageBox.Show("Update Compelete!");
                this.Close();
            }
            cn.Close();
        }
    }
}
