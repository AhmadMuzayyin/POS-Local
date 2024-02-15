using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
namespace POS.Services
{
    class Category
    {
        private String nama, code;
        Created_Updated timestamps = new Created_Updated();
        public String NAMA
        {
            get { return nama; }
            set { nama = value; }
        }
        public String KODE
        {
            get { return code; }
            set { code = value; }
        }
        private Connection DB = new Connection();
        public DataTable getCategory()
        {
            DataTable Category = new DataTable();
            string sql = "SELECT * FROM categories";
            MySqlConnection conn = DB.GetConnection();
            DB.openConnection();
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = command.ExecuteReader();
            Category.Load(reader);
            DB.closeConnection();
            return Category;
        }
        public DataTable searchCategory(string param)
        {
            DataTable Tabel = new DataTable();
            MySqlConnection conn = DB.GetConnection();
            DB.openConnection();
            String sql = "SELECT * FROM categories WHERE code LIKE @param OR name LIKE @param OR created_at LIKE @param OR updated_at LIKE @param";
            using (MySqlCommand command = new MySqlCommand(sql, conn))
            {
                command.Parameters.AddWithValue("@param", "%" + param + "%");
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    adapter.Fill(Tabel);
                }
            }
            DB.closeConnection();
            return Tabel;
        }
        public void StoreCategory(Category category)
        {
            try
            {
                if (category.NAMA == "")
                {
                    MessageBox.Show("Nama tidak boleh kososng");

                }
                else
                {
                    MySqlConnection conn = DB.GetConnection();
                    DB.openConnection();
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = conn;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "INSERT INTO categories (code, name, created_at, updated_at) VALUES(@code,@name,@created_at,@updated_at)";
                    String code = "";
                    if (category.KODE == "")
                    {
                        code = Code.Random();
                    }
                    else
                    {
                        code = category.KODE;
                    }
                    command.Parameters.AddWithValue("@code", code);
                    command.Parameters.AddWithValue("@name", category.NAMA);
                    command.Parameters.AddWithValue("@created_at", timestamps.created_at);
                    command.Parameters.AddWithValue("@updated_at", timestamps.updated_at);
                    command.Prepare();
                    command.ExecuteNonQuery();
                    DB.closeConnection();
                    MessageBox.Show("Berhasil menyimpan data!");
                }
            }catch(MySqlException e)
            {
                MessageBox.Show("Gagal menyimpan data " + e.ToString());
            }
        }
        public void Update(Category category, String param)
        {
            try
            {
                if(category.NAMA == "" || category.KODE == "")
                {
                    MessageBox.Show("Nama atau Kode tidak boleh kososng");
                }
                else
                {

                    MySqlConnection conn = DB.GetConnection();
                    DB.openConnection();
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = conn;
                    command.CommandType = CommandType.Text;
                    if (category.KODE == param)
                    {
                        command.CommandText = "UPDATE categories SET name = @name, updated_at = @updated_at WHERE code = @param";
                    }
                    else
                    {
                        command.CommandText = "UPDATE categories SET code = @code, name = @name, updated_at = @updated_at WHERE code = @param";
                    }
                    command.Parameters.AddWithValue("@param", param);
                    command.Parameters.AddWithValue("@code", category.code);
                    command.Parameters.AddWithValue("@name", category.NAMA);
                    command.Parameters.AddWithValue("@updated_at", timestamps.updated_at);
                    command.Prepare();
                    command.ExecuteNonQuery();
                    DB.closeConnection();
                    MessageBox.Show("Berhasil mengubah data!");
                }
            }
            catch(MySqlException e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void Destroy(Category category)
        {
            try
            {
                MySqlConnection conn = DB.GetConnection();
                DB.openConnection();
                MySqlCommand command = new MySqlCommand();
                command.Connection = conn;
                command.CommandType = CommandType.Text;
                command.CommandText = "DELETE FROM categories WHERE code = @code";
                command.Parameters.AddWithValue("@code", category.KODE);
                command.Prepare();
                command.ExecuteNonQuery();
                DB.closeConnection();
                MessageBox.Show("Berhasil menghapus data!");
            }catch(MySqlException e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
