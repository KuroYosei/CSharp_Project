using Library.DynamicUserControl;
using Library.User;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library
{
    public partial class BuyForm : Form
    {
        DataStore dataStore = new DataStore();
        public BuyForm(DataStore data)
        {
            InitializeComponent();
            dataStore = data;
        }

        int price, quantity;
        MySqlDataReader reader = null;

        private void BuyForm_Load(object sender, EventArgs e)
        {
            if (txtQuantity.Text == "1")
            {
                btnQuantityMinus.Enabled = false;
                lblShowPrice.Text = price.ToString();
            }
            else
            {
                btnQuantityMinus.Enabled = true;
            }

            //connection open
            MySqlConnection cn = Dataconnection.connect();

            //get data from bookdetail
            MySqlCommand cmd = new MySqlCommand("select*from bookdetail where bid = @bid", cn);

            //value assign to cmd
            cmd.Parameters.AddWithValue("@bid", dataStore.bid);

            MySqlDataReader reader = cmd.ExecuteReader();


            if (reader.Read())
            {
                price = int.Parse(reader["price"].ToString());
                quantity = int.Parse(reader["quantity"].ToString());

                //binary to image
                MemoryStream ms = new MemoryStream((byte[])reader["Image"]);
                pictureBox1.Image = new Bitmap(ms);

                //data from database to label
                lblShowTitle.Text = reader["b_name"].ToString();
                lblShowAuthorName.Text = reader["author_Name"].ToString();
                lblShowGenre.Text = reader["genre"].ToString();
                lblShowReleaseYear.Text = reader["releaseYear"].ToString();
                lblShowPrice.Text = price.ToString();
            }
            reader.Close();
            cn.Close();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Library", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(txtQuantity.Text))
                {
                    txtQuantity.Text = "1";
                }

                //check instock
                if (int.Parse(txtQuantity.Text) > quantity)
                {
                    MessageBox.Show($"Our of stock! \n{quantity} left in our inventory!", "Buy Form", MessageBoxButtons.OK);
                    return;
                }

                //connection open
                MySqlConnection cn = Dataconnection.connect();

                MySqlCommand query = new MySqlCommand("select count(*) from buyerhistory where uid=@uid && bid=@bid", cn);
                query.Parameters.AddWithValue("@uid", dataStore.uid);
                query.Parameters.AddWithValue("@bid", dataStore.bid);

                if (int.Parse(query.ExecuteScalar().ToString()) == 0)
                {
                    reader = query.ExecuteReader();
                    if (reader.Read())
                    {
                        //add data into buyerhistory
                        MySqlCommand cmd = new MySqlCommand("insert into buyerhistory values (@bid,@uid,@bName,@price,@quantity,@boughDate)", cn);

                        //value assign to cmd
                        cmd.Parameters.AddWithValue("@bid", dataStore.bid);
                        cmd.Parameters.AddWithValue("@uid", dataStore.uid);
                        cmd.Parameters.AddWithValue("@bName",lblShowTitle.Text);
                        cmd.Parameters.AddWithValue("@price", lblShowPrice.Text);
                        cmd.Parameters.AddWithValue("@quantity", txtQuantity.Text);

                        DateTime currentDate = DateTime.Now;
                        cmd.Parameters.AddWithValue("@boughDate", currentDate.ToString("yyyy-MM-dd"));
                        reader.Close();

                        if (Convert.ToBoolean(cmd.ExecuteNonQuery()))
                        {
                            MessageBox.Show("Thank You!", "Library", MessageBoxButtons.OK);
                            this.Close();
                        }
                    }
                }
                else
                {
                    MySqlCommand query2 = new MySqlCommand("update buyerhistory set bQuantity = (select bQuantity + @quantity),price=(select price + @price) where uid=@uid && bid=@bid", cn);
                    query2.Parameters.AddWithValue("@uid", dataStore.uid);
                    query2.Parameters.AddWithValue("@bid", dataStore.bid);
                    query2.Parameters.AddWithValue("@quantity", int.Parse(txtQuantity.Text));
                    query2.Parameters.AddWithValue("@price", int.Parse(lblShowPrice.Text));

                    if (Convert.ToBoolean(query2.ExecuteNonQuery()))
                    {
                        if (MessageBox.Show("Do you want a voucher?", "Library", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            MessageBox.Show($"Book Name is {lblShowTitle.Text}.\nAuthor Name is {lblShowAuthorName.Text}.\nPrice = {price.ToString()}.\nQuantity = {txtQuantity.Text}.\nTotal = {lblShowPrice.Text}");
                            MessageBox.Show("Thank You!", "Library", MessageBoxButtons.OK);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Thank You!", "Library", MessageBoxButtons.OK);
                            this.Close();
                        }
                    }
                }

                // reduce quantity
                MySqlCommand updateCmd = new MySqlCommand("update bookdetail set quantity = @quantity - @txtquantity where bid = @bid", cn);
                updateCmd.Parameters.AddWithValue("@quantity", quantity);
                updateCmd.Parameters.AddWithValue("@txtquantity", int.Parse(txtQuantity.Text));
                updateCmd.Parameters.AddWithValue("@bid", dataStore.bid);
                updateCmd.ExecuteNonQuery();

                cn.Close();
            }
            else
            {
                MessageBox.Show("Fail!", "Library", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantity.Text == "1")
            {
                btnQuantityMinus.Enabled = false;
                lblShowPrice.Text = price.ToString();
            }
            else
            {
                btnQuantityMinus.Enabled = true;
            }

            int result = 0;
            int num = price;
            int limit = int.Parse(txtQuantity.Text);

            for (int i = 0; i < limit; i++)
            {
                result += num;
                lblShowPrice.Text = result.ToString();
            }
        }

        private void btnQuantityPlus_Click(object sender, EventArgs e)
        {
            int plusQuantity = int.Parse(txtQuantity.Text) + 1;
            txtQuantity.Text = plusQuantity.ToString();
        }

        private void BuyForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BtnConfirm_Click(sender, e);
            }
            if (e.KeyChar == (char)Keys.Right)
            {
                btnQuantityPlus_Click(sender, e);
            }
            if (e.KeyChar == (char)Keys.Left)
            {
                btnQuantityMinus_Click(sender, e);
            }
        }

        private void btnQuantityMinus_Click(object sender, EventArgs e)
        {
            int minusQuantity = int.Parse(txtQuantity.Text) - 1;
            txtQuantity.Text = minusQuantity.ToString();
        }
    }
}
