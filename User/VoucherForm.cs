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

namespace Library.User
{
    public partial class VoucherForm : Form
    {
        DataStore dataStore = new DataStore();
        public VoucherForm(DataStore data)
        {
            InitializeComponent();
            dataStore = data;
        }

        int result = 0;

        private void VoucherForm_Load(object sender, EventArgs e)
        {
            MySqlConnection cn = Dataconnection.connect();
            MySqlCommand query = new MySqlCommand("select b.b_name,h.bQuantity,h.price from bookdetail b join buyerhistory h on b.bid = h.bid where h.uid = @uid;", cn);
            query.Parameters.AddWithValue("@uid", dataStore.uid);
            MySqlDataReader reader = query.ExecuteReader();

            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader["b_name"], reader["bQuantity"], reader["price"]);
                result += int.Parse(reader["price"].ToString());
            }
            lblPrice.Text = result.ToString();

            DynamicUCTest myObj = new DynamicUCTest(dataStore);
            lblUserName.Text = myObj.getUserName();
        }
    }
}
