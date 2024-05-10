using Library.Admin.User_Control;
using Library.DynamicUserControl;
using Library.User_Control;
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

namespace Library
{
    public partial class Dashbord : Form
    {
        private DataStore dataStore = new DataStore();
        ViewBook vb = new ViewBook();

        public Dashbord(DataStore data)
        {
            InitializeComponent();
            dataStore = data;
        }

        private void Dashbord_Load(object sender, EventArgs e)
        {
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            dbPanel.Controls.Clear();
            dbPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addUserControl(vb);
        }

        private void newBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBookForm abs = new AddBookForm();
            abs.ShowDialog();
        }

        private void completeBookDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBook bd = new ViewBook();
            addUserControl(bd);
        }

        private void orderToolStrip_Click(object sender, EventArgs e)
        {
            BuyerHistory ob = new BuyerHistory(dataStore);
            addUserControl(ob);
        }

        private void rentBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RentBook rentBook = new RentBook(dataStore);
            addUserControl(rentBook);
        }

        private void linklblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1(dataStore);
            form1.Show();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInfo userInfo = new UserInfo();
            addUserControl(userInfo);
        }
    }
}
