using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace POS
{
    class Connection
    {
        String param;
        MySqlConnection conn;
        public Connection()
        {
            this.param = "datasource=localhost;port=3306;username=root;password=root;database=kasir";
            this.conn = new MySqlConnection(param);
        }
        public MySqlConnection GetConnection()
        {
            return conn;
        }
        public void openConnection()
        {
            try
            {
                if(conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
            }catch(MySqlException e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void closeConnection()
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
