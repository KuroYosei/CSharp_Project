using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Library.User_Control
{
    public partial class ViewBook : UserControl
    {
        //open connection function


        //declare variable
        UpdateViewBook uf = new UpdateViewBook();

        public ViewBook()
        {
            InitializeComponent();
        }

        //refresh button
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgv1.Rows.Clear();
            MySqlConnection cn = Dataconnection.connect();

            string sql = "select * from BookDetail";
            MySqlCommand cmd = new MySqlCommand(sql, cn);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                dgv1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5], reader[6], reader[7], reader[8]);
            }

            cn.Close();
        }

        private void ViewBook_Load(object sender, EventArgs e)
        {
            MySqlConnection cn = Dataconnection.connect();

            try
            {
                dgv1.Visible = true;
                dgv1.Rows.Clear();
                string sql = "select * from BookDetail";
                MySqlCommand cmd = new MySqlCommand(sql, cn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dgv1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5], reader[6], reader[7], reader[8]);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString(), "People", MessageBoxButtons.OK);
            }
            cn.Close();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uf.ShowDialog();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MySqlConnection cn = Dataconnection.connect();

            string sql = "delete from BookDetail where bid = '" + uf.id + "'";
            MySqlCommand cmd = new MySqlCommand(sql, cn);

            if (MessageBox.Show("Are you sure want to delete this?", "Delete Form", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                cmd.ExecuteReader();
                MessageBox.Show("Delete Finish!");
            }
            cn.Close();
        }

        private void dgv1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    dgv1.ClearSelection();
                    dgv1.CurrentCell = dgv1.Rows[e.RowIndex].Cells[1];
                    dgv1.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;

                    contextMenuStrip1.Show(MousePosition);

                    DataGridViewRow row = this.dgv1.Rows[e.RowIndex];
                    uf.id = int.Parse(row.Cells[0].Value.ToString());
                    uf.bname = row.Cells[1].Value.ToString();
                    uf.authorName = row.Cells[2].Value.ToString();
                    uf.genre = row.Cells[3].Value.ToString();
                    uf.releaseYear = row.Cells[4].Value.ToString();
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
    }
}
