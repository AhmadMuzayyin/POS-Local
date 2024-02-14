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
    public partial class CategoriesForm : Form
    {
        public CategoriesForm()
        {
            InitializeComponent();
        }

        void view()
        {
            Category Data = new Category();
            CategoryGridView.DataSource = Data.getCategory();
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
        private String ID;
        public void set_id(string id)
        {
            this.ID = id;
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
            //MessageBox.Show(this.ID);
            category.Destroy(category);
            view();
        }
        private void CategoryGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            string param = CategoryGridView.CurrentCell.Value.ToString();
            MessageBox.Show(param);
        }
        private void CategoriesForm_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if(e.KeyCode == Keys.F2)
            {
                AddCategory fm = new AddCategory();
                fm.FormClosed += FormTambahKategoriClosed;
                fm.Show();
            }
        }

        private void CategoriesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomeForm fm = new HomeForm();
            fm.Show();
        }
    }
}
