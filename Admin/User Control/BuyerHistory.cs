using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.User_Control
{
    public partial class BuyerHistory : UserControl
    {
        //declare variable
        ViewBook vb = new ViewBook();
        private DataStore dataStore = new DataStore();

        public BuyerHistory(DataStore data)
        {
            InitializeComponent();
            dataStore = data;
        }

        public int bid { get; set; }
        public int uid { get; set; }
        public string bookName { get; set; }
        MySqlDataReader reader = null;

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgv1.Rows.Clear();
            MySqlConnection cn = Dataconnection.connect();
                        
            reader.Close();

            
            string sql = "select * from buyerrecord";
            MySqlCommand cmd = new MySqlCommand(sql, cn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dgv1.Rows.Add(reader[0], reader[1], bookName,reader[3], reader[4], Convert.ToDateTime(reader[5]).ToString("yyyy-MM-dd"));
            }
            cn.Close();
        }

        private void OrderedBook_Load(object sender, EventArgs e)
        {
            dgv1.Visible = false;
            //connection open
            MySqlConnection cn = Dataconnection.connect();

            try
            {
                dgv1.Visible = true;
                dgv1.Rows.Clear();

                string sql = "select * from buyerrecord;";
                MySqlCommand cmd = new MySqlCommand(sql, cn);
                MySqlDataReader reader = cmd.ExecuteReader();

                //insert into datagridview
                while (reader.Read())
                {
                    dgv1.Rows.Add(reader["bid"], reader["uid"], reader["b_name"], reader["price"], reader["quantity"], Convert.ToDateTime(reader["boughDate"]).ToString("yyyy-MM-dd"));
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString(), "People", MessageBoxButtons.OK);
            }
            //connectoin close
            cn.Close();
        }

        private void dgv_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    dgv1.ClearSelection();

                    //get row
                    dgv1.CurrentCell = dgv1.Rows[e.RowIndex].Cells[1];
                    dgv1.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;

                    contextMenuStrip1.Show(MousePosition);

                    DataGridViewRow row = this.dgv1.Rows[e.RowIndex];
                    bid = int.Parse(row.Cells[0].Value.ToString());
                    uid = int.Parse(row.Cells[1].Value.ToString());
                }
            }
            catch
            {
                DialogResult dr = MessageBox.Show("Error!", "Error Box", MessageBoxButtons.OKCancel);

                if (dr == DialogResult.OK)
                {
                    contextMenuStrip1.Visible = false;
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgv1.Rows.Clear();
            MySqlConnection cn = Dataconnection.connect();

            string sql = "select * from buyerrecord where uid like '%" + txtUid.Text+ "%'";
            MySqlCommand cmd = new MySqlCommand(sql, cn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dgv1.Rows.Add(reader[0], reader[1], bookName, reader[3], reader[4], Convert.ToDateTime(reader[5]).ToString("yyyy-MM-dd"));
            }
            cn.Close();
        }

        private void txtBid_TextChanged(object sender, EventArgs e)
        {
            dgv1.Rows.Clear();
            MySqlConnection cn = Dataconnection.connect();

            string sql = "select * from buyerrecord where bid like '%" + txtBid.Text + "%'";
            MySqlCommand cmd = new MySqlCommand(sql, cn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dgv1.Rows.Add(reader[0], reader[1], bookName, reader[3], reader[4], Convert.ToDateTime(reader[5]).ToString("yyyy-MM-dd"));
            }
            cn.Close();
        }

        private void txtUid_Click(object sender, EventArgs e)
        {
            txtBid.Clear();
        }

        private void txtBid_Click(object sender, EventArgs e)
        {
            txtUid.Clear();
        }

        public void getBookName()
        {
            MySqlConnection cn = Dataconnection.connect();
            MySqlCommand query = new MySqlCommand("select b_name from bookdetail where bid in (select bid from buyerrecord)", cn);
            query.Parameters.AddWithValue("bid", bid);
            reader = query.ExecuteReader();
            while (reader.Read())
            {
                bookName = reader["b_name"].ToString();
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MySqlConnection cn = Dataconnection.connect();
            MySqlCommand query = new MySqlCommand("delete from buyerrecord where uid=@uid && bid=@bid",cn);
            query.Parameters.AddWithValue("@uid", uid);
            query.Parameters.AddWithValue("@bid", bid);
            if(MessageBox.Show("Are you sure!","Delete Form",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Convert.ToBoolean(query.ExecuteNonQuery()))
                {
                    MessageBox.Show("Success!");
                }
                else
                {
                    MessageBox.Show("Fail!");
                }
            }
        }
    }
}
