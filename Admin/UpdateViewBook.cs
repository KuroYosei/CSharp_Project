using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
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

namespace Library
{
    public partial class UpdateViewBook : Form
    {
        public int id { get; set; }
        public string bname { get; set; }
        public string authorName { get; set; }
        public string releaseYear { get; set; }
        public string genre { get; set; }

        public UpdateViewBook()
        {
            InitializeComponent();
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            txtBookName.Text = bname;
            txtAuthorName.Text = authorName;
            txtReleaseYear.Text = releaseYear;
            txtGenre.Text = genre;

            //get image from database
            MySqlConnection cn = Dataconnection.connect();

            MySqlCommand cmd = new MySqlCommand("select image,price,quantity from bookdetail where bid = '" + id + "'", cn);
            MySqlDataReader reader = cmd.ExecuteReader();
            
            if (reader.Read())
            {
                //binary to image
                MemoryStream ms = new MemoryStream((byte[])reader["Image"]);
                pboUpdate.Image = new Bitmap(ms);

                txtPrice.Text = reader["price"].ToString();
                txtQuantity.Text = reader["quantity"].ToString();
            }

            cn.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //connection open
            MySqlConnection cn = Dataconnection.connect();

            MySqlCommand cmd = new MySqlCommand("update bookdetail set b_name=@bookName, author_Name=@authorName, genre=@genre, releaseYear=@releaseYear, image=@image , price=@price, quantity=@quantity, rent_quantity = @rentQuantity where bid=@bid", cn);
            cmd.Parameters.AddWithValue("@bookName", txtBookName.Text);
            cmd.Parameters.AddWithValue("@authorName", txtAuthorName.Text);
            cmd.Parameters.AddWithValue("@genre", txtGenre.Text);
            cmd.Parameters.AddWithValue("@releaseYear", txtReleaseYear.Text);
            cmd.Parameters.AddWithValue("@rentQuantity", txt_rentQuantity.Text);

            //image to binary 
            MemoryStream ms = new MemoryStream();
            pboUpdate.Image.Save(ms, pboUpdate.Image.RawFormat);
            cmd.Parameters.AddWithValue("@image", ms.ToArray());

            cmd.Parameters.AddWithValue("@price", int.Parse(txtPrice.Text));
            cmd.Parameters.AddWithValue("@quantity", int.Parse(txtQuantity.Text));
            cmd.Parameters.AddWithValue("@bid", id);

            DialogResult dr = MessageBox.Show("Are you sure want to update this?", "Update Form", MessageBoxButtons.OKCancel);

            if (dr == DialogResult.OK)
            {
                cmd.ExecuteReader();
                MessageBox.Show("Update Complete!", "Update Form", MessageBoxButtons.OK);
                this.Close();
            } else
            {
                txtBookName.Focus();
            }

            //connection close
            cn.Close();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(ofd.FileName);
                pboUpdate.Image = img;
            }
        }
    }
}
