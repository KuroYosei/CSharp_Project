using Library.Admin;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.User_Control
{
    public partial class RentBook : UserControl
    {
        ReturnIssueForm returnIssueForm = new ReturnIssueForm();
        DataStore dataStore = new DataStore();
        public RentBook(DataStore data)
        {
            InitializeComponent();
            dataStore = data;
        }

        public int bid { get; set; }
        public int uid { get; set; }
        int getDay, result;

        private void RentBook_Load(object sender, EventArgs e)
        {
            //connection
            MySqlConnection cn = Dataconnection.connect();

            //get data from rentbook
            MySqlCommand cmd1 = new MySqlCommand("select * from rentbook", cn);

            MySqlDataReader reader = cmd1.ExecuteReader();

            while (reader.Read())
            {
                dgv1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5], reader[6], reader[7]);
                dgv1.Columns[3].DefaultCellStyle.Format = "MM/dd/yyyy";
                dgv1.Columns[4].DefaultCellStyle.Format = "MM/dd/yyyy";
                dgv1.Columns[5].DefaultCellStyle.Format = "MM/dd/yyyy";
            }
            reader.Close();
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dgv1.ClearSelection();

                //get row when click cell
                dgv1.CurrentCell = dgv1.Rows[e.RowIndex].Cells[1];
                dgv1.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;

                contextMenuStrip1.Show(MousePosition);

                DataGridViewRow row = this.dgv1.Rows[e.RowIndex];
                bid = int.Parse(row.Cells[0].Value.ToString());
                uid = int.Parse(row.Cells[1].Value.ToString());

                returnIssueForm.bid = bid;
                returnIssueForm.uid = uid;
                returnIssueForm.rentDate = row.Cells[2].Value.ToString();
                returnIssueForm.expectedReturnDate = row.Cells[3].Value.ToString();
                returnIssueForm.actualReturnDate = row.Cells[4].Value.ToString();
                returnIssueForm.rentIssue = row.Cells[5].Value.ToString();
                returnIssueForm.returnIssue = row.Cells[6].Value.ToString();
            }
            try
            {
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

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MySqlConnection cn = Dataconnection.connect();

            string sql = "delete from rentbook where bid = @bid && uid = @uid";
            MySqlCommand cmd = new MySqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@bid", bid);
            cmd.Parameters.AddWithValue("@uid", uid);

            if (MessageBox.Show("Are you sure want to delete this?", "Delete Form", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete Finish!", "Delete Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            cn.Close();
            btnRefresh_Click(sender, e);
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            returnIssueForm.ShowDialog();

            DateTime newTime = DateTime.Now;

            MySqlConnection cn = Dataconnection.connect();

            MySqlCommand cmd = new MySqlCommand("update rentbook set actualReturnDate=@date where bid = @bid && uid = @uid", cn);
            cmd.Parameters.AddWithValue("@date", newTime);
            cmd.Parameters.AddWithValue("@bid", bid);
            cmd.Parameters.AddWithValue("@uid", uid);
            cmd.ExecuteNonQuery();

            MySqlCommand query = new MySqlCommand("select expectReturnDate,actualReturnDate,returnIssue from rentbook where bid = @bid && uid = @uid", cn);
            query.Parameters.AddWithValue("@bid", bid);
            query.Parameters.AddWithValue("uid", uid);
            MySqlDataReader reader = query.ExecuteReader();

            if (reader.Read())
            {
                if (Convert.ToDateTime(reader["expectReturnDate"]) < Convert.ToDateTime(reader["actualReturnDate"]))
                {
                    TimeSpan expireDate = Convert.ToDateTime(reader["actualReturnDate"]) - Convert.ToDateTime(reader["expectReturnDate"]);
                    getDay = expireDate.Days;
                    result = 100 * getDay;

                    if (!string.IsNullOrEmpty(reader["returnIssue"].ToString()))
                    {
                        string error = reader["returnIssue"].ToString();
                        reader.Close();

                        MySqlCommand query2 = new MySqlCommand("select price from bookdetail where bid in (select bid from rentbook where bid=@bid)", cn);
                        query2.Parameters.AddWithValue("@bid", bid);
                        reader = query2.ExecuteReader();
                        if (reader.Read())
                        {
                            int penaltyFee = int.Parse(reader["price"].ToString()) / 2;
                            MessageBox.Show($"{getDay} is expired. So 1 day = 100. Total penalty fee is {result}.\nPenalty Fee is {penaltyFee} because of {error}.", "Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show($"{getDay} is expired. So 1 day = 100. Total penalty fee is {result}.", "Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(reader["returnIssue"].ToString()))
                    {
                        string error = reader["returnIssue"].ToString();
                        reader.Close();

                        MySqlCommand query2 = new MySqlCommand("select price from bookdetail where bid in (select bid from rentbook where bid=@bid)", cn);
                        query2.Parameters.AddWithValue("@bid", bid);
                        reader = query2.ExecuteReader();
                        if (reader.Read())
                        {
                            int penaltyFee = int.Parse(reader["price"].ToString()) / 2;
                            MessageBox.Show($"Return date is {getDay}.\nPenalty Fee is {penaltyFee} because of {error}.", "Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Finish");
                    }
                }

                reader.Close();

                MySqlCommand check_stock = new MySqlCommand("select rent_quantity from bookdetail where bid = @bid", cn);
                check_stock.Parameters.AddWithValue("@bid", bid);
                reader = check_stock.ExecuteReader();

                if (reader.Read())
                {
                    int check_rent_quantity = int.Parse(reader["rent_quantity"].ToString());
                    if (check_rent_quantity == 0)
                    {
                        reader.Close();
                        MySqlCommand addRentQuantity = new MySqlCommand("update bookdetail set rent_quantity = (select rent_quantity) + 1 where bid = @bid", cn);
                        addRentQuantity.Parameters.AddWithValue("@bid", bid);
                        addRentQuantity.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Already Return!", "Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            cn.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgv1.Rows.Clear();
            MySqlConnection cn = Dataconnection.connect();

            string sql = "select * from rentbook";
            MySqlCommand cmd = new MySqlCommand(sql, cn);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                dgv1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5], reader[6], reader[7]);
                dgv1.Columns[3].DefaultCellStyle.Format = "MM/dd/yyyy";
                dgv1.Columns[4].DefaultCellStyle.Format = "MM/dd/yyyy";
                dgv1.Columns[5].DefaultCellStyle.Format = "MM/dd/yyyy";
            }

            cn.Close();
        }

        private void txtUid_TextChanged(object sender, EventArgs e)
        {
            dgv1.Rows.Clear();
            MySqlConnection cn = Dataconnection.connect();

            string sql = "select * from rentbook where uid like '%" + txtUid.Text + "%'";
            MySqlCommand cmd = new MySqlCommand(sql, cn);
            MySqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                dgv1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5], reader[6], reader[7]);
                dgv1.Columns[3].DefaultCellStyle.Format = "MM/dd/yyyy";
                dgv1.Columns[4].DefaultCellStyle.Format = "MM/dd/yyyy";
                dgv1.Columns[5].DefaultCellStyle.Format = "MM/dd/yyyy";
            }

            cn.Close();
        }

        private void txtBid_TextChanged(object sender, EventArgs e)
        {
            dgv1.Rows.Clear();
            MySqlConnection cn = Dataconnection.connect();

            string sql = "select * from rentbook where bid like '%" + txtBid.Text + "%'";
            MySqlCommand cmd = new MySqlCommand(sql, cn);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                dgv1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5], reader[6], reader[7]);
                dgv1.Columns[3].DefaultCellStyle.Format = "MM/dd/yyyy";
                dgv1.Columns[4].DefaultCellStyle.Format = "MM/dd/yyyy";
                dgv1.Columns[5].DefaultCellStyle.Format = "MM/dd/yyyy";
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
    }
}
