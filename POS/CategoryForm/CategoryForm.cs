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

namespace POS
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }
        private String ID, NAMA;
        public void set_id(string id)
        {
            this.ID = id;
        }
        public void set_nama(string nama)
        {
            this.NAMA = nama;
        }
        void view()
        {
            try
            {
                Category Data = new Category();
                CategoryGridView.DataSource = Data.getCategory();
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void Categories_Load(object sender, EventArgs e)
        {
            try
            {
                view();
            }
            catch(InvalidOperationException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void searchCategory_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string param = searchCategory.Text.ToString();
                if(param == "")
                {
                    view();
                }
                else
                {
                    Category query = new Category();
                    CategoryGridView.DataSource = query.searchCategory(param);
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void SaveCategory_Click(object sender, EventArgs e)
        {
            AddCategory fm = new AddCategory();
            fm.FormClosed += FormTambahKategoriClosed;
            fm.Show();
            //this.Hide();
        }
        public void FormTambahKategoriClosed(object sender, FormClosedEventArgs e)
        {
            view();
        }
        private void CategoryGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string param = CategoryGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            set_id(param);
        }
        private void CategoryGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            Category category = new Category();
            category.KODE = ID;
            category.Destroy(category);
            view();
        }
        private void CategoriesForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if(e.KeyCode == Keys.F1)
            {
                AddCategory fm = new AddCategory();
                fm.FormClosed += FormTambahKategoriClosed;
                fm.Show();
            }
            if (CategoryGridView.Focused)
            {
                if (CategoryGridView.SelectedCells.Count > 0)
                {
                    int rowIndex = CategoryGridView.SelectedCells[0].RowIndex;
                    String kode = CategoryGridView.Rows[rowIndex].Cells[1].Value.ToString();
                    set_id(kode);
                }
            }
        }

        private void CategoryGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.ColumnIndex == 0)
                {
                    view();
                }
                else
                {
                    int rowIndex = CategoryGridView.SelectedCells[0].RowIndex;
                    String kode = CategoryGridView.Rows[rowIndex].Cells[1].Value.ToString();
                    String name = CategoryGridView.Rows[rowIndex].Cells[2].Value.ToString();
                    Category category = new Category();
                    category.KODE = kode;
                    category.NAMA = name;
                    category.Update(category, this.ID);
                    view();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Gagal merubah data");
            }
        }

        private void CategoriesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomeForm fm = new HomeForm();
            fm.Show();
        }
    }
}
