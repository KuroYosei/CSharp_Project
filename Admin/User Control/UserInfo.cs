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

namespace Library.Admin.User_Control
{
    public partial class UserInfo : UserControl
    {
        public UserInfo()
        {
            InitializeComponent();
        }

        UpdateUserInfo updateUserInfo = new UpdateUserInfo();

        private void UserInfo_Load(object sender, EventArgs e)
        {
            MySqlConnection cn = Dataconnection.connect();
            MySqlCommand cmd = new MySqlCommand("select * from userdata",cn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dgv1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5]);
            }
            cn.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgv1.Rows.Clear();
            MySqlConnection cn = Dataconnection.connect();
            MySqlCommand cmd = new MySqlCommand("select * from userdata", cn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dgv1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5]);
            }
            cn.Close();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MySqlConnection cn = Dataconnection.connect();
            MySqlCommand cmd = new MySqlCommand($"delete from userdata where uid = {updateUserInfo.Uid}",cn);

            if(MessageBox.Show("Are you sure?","Delete Userinfo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Convert.ToBoolean(cmd.ExecuteNonQuery()) == true)
                {
                    MessageBox.Show("Delete Success!");
                } else
                {
                    MessageBox.Show("Delete Fail!");
                }
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
                    dgv1.CurrentCell = dgv1.Rows[e.RowIndex].Cells[0];
                    //dgv1.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;

                    contextMenuStrip1.Show(MousePosition);

                    DataGridViewRow row = this.dgv1.Rows[e.RowIndex];
                    updateUserInfo.Uid = int.Parse(row.Cells[0].Value.ToString());
                    updateUserInfo.Username = row.Cells[1].Value.ToString();
                    updateUserInfo.Email = row.Cells[2].Value.ToString();
                    updateUserInfo.Type = row.Cells[4].Value.ToString();
                    updateUserInfo.PhoneNo = row.Cells[5].Value.ToString();
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

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateUserInfo.ShowDialog();
        }
    }
}
