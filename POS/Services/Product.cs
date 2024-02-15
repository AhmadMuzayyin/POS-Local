using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using POS.Services;
using System.Data;

namespace POS.Services
{
    class Product
    {
        private String id, category_id, code, name, created_at, updated_at;
        Created_Updated timestamps = new Created_Updated();
        
        public string Id { get => id; set => id = value; }
        public string Category_id { get => category_id; set => category_id = value; }
        public string Kode { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
        private Connection DB = new Connection();
        public DataTable getProduct()
        {
            DataTable Product = new DataTable();
            string sql = "SELECT products.id, categories.name category, products.code, products.name, " +
                "products.created_at, products.updated_at FROM `products` " +
                "LEFT JOIN categories ON products.category_id = categories.id;";
            MySqlConnection conn = DB.GetConnection();
            DB.openConnection();
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = command.ExecuteReader();
            Product.Load(reader);
            DB.closeConnection();
            return Product;
        }
        public DataTable searchProduct(string param)
        {
            DataTable Tabel = new DataTable();
            MySqlConnection conn = DB.GetConnection();
            DB.openConnection();
            String sql = "SELECT products.id, categories.name category, products.code, products.name, " +
                "products.created_at, products.updated_at FROM products LEFT JOIN categories ON products.category_id = categories.id " +
                "WHERE products.id LIKE @param OR categories.name LIKE @param OR products.code LIKE @param OR products.name " +
                "LIKE @param OR products.created_at LIKE @param OR products.updated_at LIKE @param";
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
        public void StoreProduct(Product product)
        {
            try
            {
                if (product.Name == "")
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
                    command.CommandText = "INSERT INTO products (code, name, created_at, updated_at) VALUES(@code,@name,@created_at,@updated_at)";
                    String code = "";
                    if (product.Kode == "")
                    {
                        code = Code.Random();
                    }
                    else
                    {
                        code = product.Kode;
                    }
                    command.Parameters.AddWithValue("@code", code);
                    command.Parameters.AddWithValue("@name", product.Name);
                    command.Parameters.AddWithValue("@created_at", timestamps.created_at);
                    command.Parameters.AddWithValue("@updated_at", timestamps.updated_at);
                    command.Prepare();
                    command.ExecuteNonQuery();
                    DB.closeConnection();
                    MessageBox.Show("Berhasil menyimpan data!");
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Gagal menyimpan data " + e.ToString());
            }
        }
        public void Update(Product product, String param)
        {
            try
            {
                if (product.Name == "" || product.Kode == "")
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
                    if (product.Kode == param)
                    {
                        command.CommandText = "UPDATE products SET name = @name, updated_at = @updated_at WHERE code = @param";
                    }
                    else
                    {
                        command.CommandText = "UPDATE products SET code = @code, name = @name, updated_at = @updated_at WHERE code = @param";
                    }
                    command.Parameters.AddWithValue("@param", param);
                    command.Parameters.AddWithValue("@code", product.Kode);
                    command.Parameters.AddWithValue("@name", product.Name);
                    command.Parameters.AddWithValue("@updated_at", timestamps.updated_at);
                    command.Prepare();
                    command.ExecuteNonQuery();
                    DB.closeConnection();
                    MessageBox.Show("Berhasil mengubah data!");
                }
            }
            catch (MySqlException e)
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
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
