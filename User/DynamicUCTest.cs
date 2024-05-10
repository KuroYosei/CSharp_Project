using Library.DynamicUserControl;
using Library.User;
using MySql.Data.MySqlClient;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//need to add function list
//buyerform make a slip
//add to cart

//need to do
//borrow form price
//buyerhistory same name validation
//add price and quantity to bookdetail db
//return date

namespace Library
{
    public partial class DynamicUCTest : Form
    {
        //data call from datastore
        DataStore dataStore = new DataStore();
        public DynamicUCTest(DataStore data)
        {
            InitializeComponent();
            dataStore = data;
        }

        //to call multiple reader
        MySqlDataReader reader = null;

        //add item to table
        public bool AddItemsToTable(Image img, string bookName, string authorName, string genre, int releaseYear)
        {
            MySqlConnection cn = Dataconnection.connect();
            string sql = "Insert into bookdetail(image,b_name,author_Name,genre,releaseYear) values (@img,@bookName,@authorName,@genre,@releaseYear)";

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@bookName", bookName.Trim());
                cmd.Parameters.AddWithValue("@authorName", authorName.Trim());
                cmd.Parameters.AddWithValue("@genre", genre.Trim());
                cmd.Parameters.AddWithValue("@releaseYear", releaseYear);

                //convert image to binary format
                MemoryStream ms = new MemoryStream();
                img.Save(ms, img.RawFormat);
                cmd.Parameters.AddWithValue("@img", ms.ToArray());
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                throw;
            }
        }

        //read items from table
        public DataTable ReadItemsTable()
        {
            MySqlConnection cn = Dataconnection.connect();
            string query = "select * from bookdetail";
            MySqlCommand cmd = new MySqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@text", txtSearch.Text);

            try
            {
                MySqlDataAdapter mda = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                mda.Fill(dt);
                return dt;
            }
            catch
            {
                throw;
            }
        }

        private void GenerateUserControl()
        {
            flowLayoutPanel1.Controls.Clear();
            Function function = new Function();
            DataTable dt = function.GetItems();

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    UserControl1[] ArrayItems = new UserControl1[dt.Rows.Count];
                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            ArrayItems[i] = new UserControl1();
                            //binary to img
                            MemoryStream ms = new MemoryStream((byte[])row["Image"]);
                            ArrayItems[i].Icon = new Bitmap(ms);
                            ArrayItems[i].BookName = row["b_name"].ToString();
                            ArrayItems[i].AuthorName = row["author_name"].ToString();
                            ArrayItems[i].Genre = row["genre"].ToString();
                            ArrayItems[i].ReleaseYear = int.Parse(row["releaseYear"].ToString());

                            flowLayoutPanel1.Controls.Add(ArrayItems[i]);
                            ArrayItems[i].Click += new System.EventHandler(this.UserControl_Click);
                        }
                    }
                }
            }
        }

        //click event from usercontrol1
        void UserControl_Click(object sender, System.EventArgs e)
        {
            //user control object to acess controls used in it 
            UserControl1 uc = (UserControl1)sender;
            CartForm cartForm = new CartForm(dataStore);

            pictureBox1.Image = uc.Icon;
            lblTitle.Text = uc.BookName;
            lblAName.Text = uc.AuthorName;
            lblGenre2.Text = uc.Genre;
            lblRYear.Text = uc.ReleaseYear.ToString();
            ShowPanel();
        }

        private void ShowPanel()
        {
            panel1.Visible = true;
            detailPanel.Visible = true;
        }
        private void hidepanel()
        {
            panel1.Visible = false;
            detailPanel.Visible = false;
        }

        string name;
        public string getUserName()
        {
            //connection open
            MySqlConnection cn = Dataconnection.connect();


            //get username from userdata
            MySqlCommand cmd = new MySqlCommand("select username from userdata where uid = '" + dataStore.uid + "'", cn);

            reader = cmd.ExecuteReader();


            if (reader.Read())
            {
                name = reader["username"].ToString();
                lblUserName.Text = name;
            }
            reader.Close();
            cn.Close();
            return name;
        }

        public void getBookID()
        {
            //connection open
            MySqlConnection cn = Dataconnection.connect();

            //get bid from bookdetail
            MySqlCommand cmd = new MySqlCommand("select bid from bookdetail where b_name='" + lblTitle.Text + "'", cn);

            reader = cmd.ExecuteReader();

            if (reader.Read()) dataStore.bid = int.Parse(reader["bid"].ToString());
        }

        private void DynamicUCTest_Load(object sender, EventArgs e)
        {
            getUserName();
            GenerateUserControl();
            detailPanel.Visible = false;
            txtSearch.Visible = false;

        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Please select a item!");
                return;
            }

            getBookID();

            MySqlConnection cn = Dataconnection.connect();

            MySqlCommand check_stock = new MySqlCommand("select rent_quantity from bookdetail where bid = @bid", cn);
            check_stock.Parameters.AddWithValue("@bid", dataStore.bid);
            MySqlDataReader reader = check_stock.ExecuteReader();

            if (reader.Read())
            {
                int check_rent_quantity = int.Parse(reader["rent_quantity"].ToString());

                if (check_rent_quantity == 0)
                {
                    MessageBox.Show("Someone already borrowed it!");
                }
                else
                {
                    BorrowForm borrorwForm = new BorrowForm(dataStore);
                    borrorwForm.ShowDialog();
                }
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Please select a item!");
                return;
            }

            getBookID();
            BuyForm buyForm = new BuyForm(dataStore);
            buyForm.ShowDialog();

        }

        private void linkLabelLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1(dataStore);
            form1.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CartForm cf = new CartForm(dataStore);
            cf.ShowDialog();
        }

        public DataTable GetSearchItem()
        {
            MySqlConnection cn = Dataconnection.connect();
            DataTable dt = new DataTable();

            if (cboType.SelectedIndex == 0)
            {
                string query = "select * from bookdetail where author_name like '%" + txtSearch.Text + "%'";
                MySqlCommand cmd = new MySqlCommand(query, cn);
                MySqlDataAdapter mda = new MySqlDataAdapter(cmd);
                try
                {
                    mda.Fill(dt);
                }
                catch
                {
                    throw;
                }
            }
            else if (cboType.SelectedIndex == 1)
            {
                string query = "select * from bookdetail where b_name like '%" + txtSearch.Text + "%'";
                MySqlCommand cmd = new MySqlCommand(query, cn);
                MySqlDataAdapter mda = new MySqlDataAdapter(cmd);
                try
                {
                    mda.Fill(dt);
                }
                catch
                {
                    throw;
                }
            }
            else if (cboType.SelectedIndex == 2)
            {
                string query = "select * from bookdetail where genre like '%" + txtSearch.Text + "%'";
                MySqlCommand cmd = new MySqlCommand(query, cn);
                MySqlDataAdapter mda = new MySqlDataAdapter(cmd);
                try
                {
                    mda.Fill(dt);
                }
                catch
                {
                    throw;
                }
            }
            return dt;
        }

        //search function
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            DataTable dt = GetSearchItem();

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    UserControl1[] ArrayItems = new UserControl1[dt.Rows.Count];
                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            ArrayItems[i] = new UserControl1();
                            //binary to img
                            MemoryStream ms = new MemoryStream((byte[])row["Image"]);
                            ArrayItems[i].Icon = new Bitmap(ms);
                            ArrayItems[i].BookName = row["b_name"].ToString();
                            ArrayItems[i].AuthorName = row["author_name"].ToString();
                            ArrayItems[i].Genre = row["genre"].ToString();
                            ArrayItems[i].ReleaseYear = int.Parse(row["releaseYear"].ToString());

                            flowLayoutPanel1.Controls.Add(ArrayItems[i]);
                            ArrayItems[i].Click += new System.EventHandler(this.UserControl_Click);
                        }
                    }
                }
            }
        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // index author,bookname,genre
            if (cboType.SelectedIndex == 0)
            {
                txtSearch.Clear();
                txtSearch.Visible = true;
            }
            else if (cboType.SelectedIndex == 1)
            {
                txtSearch.Clear();
                txtSearch.Visible = true;
            }
            else if (cboType.SelectedIndex == 2)
            {
                txtSearch.Visible = true;
                txtSearch.Clear();
            }
        }
    }
}
