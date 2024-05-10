using Library.DynamicUserControl;
using MySql.Data.MySqlClient;
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

namespace Library.User
{
    public partial class CartForm : Form
    {
        DataStore dataStore = new DataStore();
        public CartForm(DataStore data)
        {
            InitializeComponent();
            dataStore = data;
        }

        MySqlDataReader reader = null;
        int quantity,price,result;

        public DataTable readItem()
        {
            MySqlConnection cn = Dataconnection.connect();
            string query = "select bid,image,b_name,price from bookdetail b where bid in(select bid from buyerhistory where uid = @uid);";
            MySqlCommand cmd = new MySqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@uid", dataStore.uid);

            try
            {

                MySqlCommand query2 = new MySqlCommand("select bQuantity,price from buyerhistory where uid = @uid", cn);
                query2.Parameters.AddWithValue("@uid", dataStore.uid);

                reader = query2.ExecuteReader();

                while (reader.Read())
                {
                    result += int.Parse(reader["price"].ToString());
                    quantity = int.Parse(reader["bQuantity"].ToString());
                }

                lblPrice.Text = result.ToString();
                
                reader.Close();

                MySqlDataAdapter mda = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                mda.Fill(dt);
                return dt;
            }
            catch { throw; }
        }

        private void CartForm_Load(object sender, EventArgs e)
        {
            ControlBox = false;
            CartUserControl();

            if (FlpCart.Controls.Count == 0)
            {
                btnConfirm.Visible = false;
            } 
            else
            {
                btnConfirm.Visible = true;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure?","Cart",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                VoucherForm myObj = new VoucherForm(dataStore);
                myObj.ShowDialog();

                MySqlConnection cn = Dataconnection.connect();
                MySqlCommand query = new MySqlCommand("insert into buyerrecord select * from buyerhistory where uid=@uid",cn);
                query.Parameters.AddWithValue("@uid", dataStore.uid);
                if (Convert.ToBoolean(query.ExecuteNonQuery()))
                {
                    MessageBox.Show("Thank You!");
                    MySqlCommand query2 = new MySqlCommand("delete from buyerhistory where uid=@uid",cn);
                    query2.Parameters.AddWithValue("@uid", dataStore.uid);
                    query2.ExecuteNonQuery();
                    this.Close();
                }
            } else
            {
                MessageBox.Show("Thank you!");
            }
        }

        private void CartUserControl()
        {
            FlpCart.Controls.Clear();
            DataTable dt = readItem();

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    CartUserControl[] ArrayItems = new CartUserControl[dt.Rows.Count];
                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            ArrayItems[i] = new CartUserControl(dataStore);
                            //binary to img
                            MemoryStream ms = new MemoryStream((byte[])row["Image"]);
                            ArrayItems[i].Img = new Bitmap(ms);
                            ArrayItems[i].Title = row["b_name"].ToString();

                            MySqlConnection cn = Dataconnection.connect();

                            MySqlCommand query = new MySqlCommand("select bQuantity,price from buyerhistory where uid = @uid && bid in (select bid from bookdetail where b_name = @bookName)", cn);
                            query.Parameters.AddWithValue("@uid", dataStore.uid);
                            query.Parameters.AddWithValue("@bookName", ArrayItems[i].Title);

                            MySqlDataReader reader = query.ExecuteReader();

                            while (reader.Read())
                            {
                                ArrayItems[i].ProductDetail = $"Item = {int.Parse(reader["bQuantity"].ToString())}, Price = {int.Parse(reader["price"].ToString())}";
                            }

                            FlpCart.Controls.Add(ArrayItems[i]);
                        }
                    }
                }
            }
        }

        private void pboClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
