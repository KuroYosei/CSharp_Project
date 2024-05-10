using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.DynamicUserControl
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private Image icon;
        private string bookName;
        public string AuthorName { get; set; }
        public string Genre { get; set; }
        public int ReleaseYear { get; set; }

        public Image Icon
        {
            get { return icon; }
            set { icon = value; pictureBox1.Image = icon; }
        }
        public string BookName
        {
            get { return bookName; }
            set { bookName = value; lblTitle.Text = bookName; }
        }

        private void UserControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
