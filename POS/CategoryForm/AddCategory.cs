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
    public partial class AddCategory : Form
    {
        public event Action FormClosedTrigger;
        public AddCategory()
        {
            InitializeComponent();
        }

        private void AddCategory_Load(object sender, EventArgs e)
        {
            
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            if (textName.Text == "")
            {
                MessageBox.Show("Nama tidak boleh kosong");
                textName.Focus();
            }
            else
            {
                Category category = new Category();
                category.KODE = textCode.Text;
                category.NAMA = textName.Text;
                category.StoreCategory(category);
                textCode.Text = "";
                textName.Text = "";
                textCode.Focus();
            }
        }

        private void AddCategory_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormClosedTrigger?.Invoke();
        }

        private void textCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                TextBox currentTextBox = (TextBox)ActiveControl;
                TextBox nextTextBox = null;
                foreach (Control control in this.Controls)
                {
                    if (control is TextBox && control.TabIndex > currentTextBox.TabIndex)
                    {
                        nextTextBox = (TextBox)control;
                        break;
                    }
                }
                if (nextTextBox != null)
                {
                    nextTextBox.Focus();
                }
            }
        }

        private void AddCategory_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
