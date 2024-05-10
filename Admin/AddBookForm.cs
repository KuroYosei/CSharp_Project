using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.DynamicUserControl
{
    public partial class AddBookForm : Form
    {
        //animation
        Timer timer1;

        public AddBookForm()
        {
            InitializeComponent();
            timer1 = new Timer();
            timer1.Tick += timer1_Tick;
        }

        private void AddBookForm_Load(object sender, EventArgs e)
        {

        }

        //animation
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(this.Opacity > 0)
            {
                this.Opacity -= 1;
            }
            else
            {
                timer1.Stop();
                Application.Exit();
            }
        }

        private void btnUpload_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(ofd.FileName);
                pb1.Image = img;
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            Function function = new Function();

            MySqlConnection cn = Dataconnection.connect();
            MySqlCommand cmd = new MySqlCommand("select b_name from bookdetail", cn);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                if(txtBookName.Text == reader["b_name"].ToString())
                {
                    MessageBox.Show("Book is already exist!");
                    return;
                } else
                {
                    MessageBox.Show("Add Success");
                }
            }

            if (function.SaveItems(pb1.Image, txtBookName.Text, txtAuthorName.Text, txtGenre.Text, int.Parse(txtReleaseYear.Text)))
            {
                if (MessageBox.Show("Do you want to add another book?", "Add Book Form", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    timer1.Start();
                    AddBookForm abs = new AddBookForm();
                    abs.Show();
                    abs.BringToFront();
                }
                else
                {
                    timer1.Start();
                }
            }
            else
            {
                MessageBox.Show("Fail!");
            }
            cn.Close();
        }
    }
}
