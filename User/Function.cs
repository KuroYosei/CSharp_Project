using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.DynamicUserControl
{
    internal class Function
    {
        DataStore dataStore = new DataStore();
        public bool SaveItems(Image img, string bookName, string authorName, string genre, int releaseYear)
        {
            try
            {
                DynamicUCTest duc = new DynamicUCTest(dataStore);
                return duc.AddItemsToTable(img, bookName, authorName, genre, releaseYear);
            }
            catch (Exception ex)
            {
                DialogResult result = MessageBox.Show(ex.ToString());
                return false;
            }
        }

        public DataTable GetItems()
        {
            try
            {
                DynamicUCTest duc = new DynamicUCTest(dataStore);
                return duc.ReadItemsTable();
            }
            catch (Exception ex)
            {
                DialogResult result = MessageBox.Show(ex.ToString());
                return null;
            }
        }
    }
}
