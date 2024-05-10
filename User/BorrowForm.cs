using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.User
{
    public partial class BorrowForm : Form
    {
        //get uid and bid
        DataStore dataStore = new DataStore();
        public BorrowForm(DataStore data)
        {
            InitializeComponent();
            dataStore = data;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //connection open
            MySqlConnection cn = Dataconnection.connect();

            //insert bid and uid to rentbook
            MySqlCommand insertCmd = new MySqlCommand("insert into rentbook(bid,uid) values (@bid,@uid)", cn);
            insertCmd.Parameters.AddWithValue("@bid", dataStore.bid);
            insertCmd.Parameters.AddWithValue("@uid", dataStore.uid);

            //run insertCmd
            insertCmd.ExecuteNonQuery();

            //isnert into rentbook db
            MySqlCommand cmd = new MySqlCommand("update rentbook set book_name = (select b_name from bookdetail where bid = @bid), rentDate = @rentDate, expectReturnDate = @returnDate, issue = @issue where bid = @bid", cn);
            
            //cmd assign value
            cmd.Parameters.AddWithValue("@rentDate", dtpBorrow.Text);
            cmd.Parameters.AddWithValue("@returnDate", dtpReturn.Text);
            cmd.Parameters.AddWithValue("@issue", txtIssue.Text);
            cmd.Parameters.AddWithValue("@bid", dataStore.bid);

            if (Convert.ToBoolean(cmd.ExecuteNonQuery()) == true)
            {
                MySqlCommand check_stock = new MySqlCommand("select rent_quantity from bookdetail where bid = @bid",cn);
                check_stock.Parameters.AddWithValue("@bid", dataStore.bid);
                MySqlDataReader reader = check_stock.ExecuteReader();

                if (reader.Read())
                {
                    int check_rent_quantity = int.Parse(reader["rent_quantity"].ToString());

                    if(check_rent_quantity == 1)
                    {
                        if (MessageBox.Show("Are you sure?", "Library", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            if (MessageBox.Show("Borrorw Success!", "Borrow Form", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                            {
                                reader.Close();
                                //reduce quantity bookdetail
                                MySqlCommand query2 = new MySqlCommand("update bookdetail set rent_quantity = (select rent_quantity) - 1 where bid = @bid", cn);
                                query2.Parameters.AddWithValue("@bid", dataStore.bid);
                                query2.ExecuteNonQuery();

                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Borrorw Fail!", "Borrow Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }

            cn.Close();
        }

        private void BorrowForm_Load(object sender, EventArgs e)
        {
            dtpReturn.Enabled = false;

            //borrowdate + 7
            DateTime selectedDate = dtpBorrow.Value;
            DateTime newDate = selectedDate.AddDays(7);
            dtpReturn.Value = newDate;

            //connection open
            MySqlConnection cn = Dataconnection.connect();

            //select image from bookdetail db
            MySqlCommand selectCmd = new MySqlCommand("select image from bookdetail where bid = @bid", cn);

            //selectCmd value assign
            selectCmd.Parameters.AddWithValue("@bid", dataStore.bid);

            MySqlDataReader reader = selectCmd.ExecuteReader();

            if (reader.Read())
            {
                //binary to image
                MemoryStream ms = new MemoryStream((byte[])reader["Image"]);
                pboBorrow.Image = new Bitmap(ms);
            }

            reader.Close();
            cn.Close();
        }

        private void dtpBorrow_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dtpBorrow.Value;
            DateTime newDate = selectedDate.AddDays(7);
            dtpReturn.Value = newDate;
        }
    }
}
