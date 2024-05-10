using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    internal class Dataconnection
    {
        public static MySqlConnection connect()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection("server=127.0.0.1;uid=root;pwd=root;database=Library");
                conn.Open();
                return conn;
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
