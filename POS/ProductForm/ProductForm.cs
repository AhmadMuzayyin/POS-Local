using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS.Services;

namespace POS.ProductForm
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }
        private String ID;
        public void set_id(string id)
        {
            this.ID = id;
        }
        void view()
        {
            try
            {
                Product product = new Product();
                ProductGridView.DataSource = product.getProduct();
            } catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        private void ProductForm_Load(object sender, EventArgs e)
        {
            view();
        }

        private void ProductForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomeForm fm = new HomeForm();
            fm.Show();
        }

        private void ProductForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (ProductGridView.Focused)
            {
                if (ProductGridView.SelectedCells.Count > 0)
                {
                    int rowIndex = ProductGridView.SelectedCells[0].RowIndex;
                    ProductGridView.Rows[rowIndex].Cells[1].ReadOnly = true;
                    String kode = ProductGridView.Rows[rowIndex].Cells[2].Value.ToString();
                    set_id(kode);
                }
            }
        }

        private void searchCategory_TextChanged(object sender, EventArgs e)
        {
            String param = searchCategory.Text;
            if (param == "")
            {
                view();
            }
            else
            {
                Product product = new Product();
                ProductGridView.DataSource = product.searchProduct(param);
            }
        }

        private void ProductGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 1)
                {
                    view();
                } else
                {
                    if (e.ColumnIndex == 0 || e.ColumnIndex == 1)
                    {
                        MessageBox.Show("Untuk merubah category silahkan tekan F2");
                        view();
                    }
                    else
                    {
                        int rowIndex = ProductGridView.SelectedCells[0].RowIndex;
                        String kode = ProductGridView.Rows[rowIndex].Cells[2].Value.ToString();
                        String name = ProductGridView.Rows[rowIndex].Cells[3].Value.ToString();
                        Product product = new Product();
                        product.Kode = kode;
                        product.Name = name;
                        product.Update(product, this.ID);
                        view();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Gagal merubah data!");
            }
        }

        private void ProductGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == 0 || e.ColumnIndex == 1)
            {
                MessageBox.Show("Untuk merubah category silahkan tekan F2");
                view();
            }
        }

        private void ProductGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProductGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            view();
        }
    }
}
