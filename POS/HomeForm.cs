using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{

    public partial class HomeForm : Form
    {
        Connection DB = new Connection();
        public HomeForm()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
        private void MenuCategory_Click(object sender, EventArgs e)
        {
            var formCategory = new CategoriesForm();
            formCategory.Show();
            this.Close();
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HomeForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                CategoriesForm fm = new CategoriesForm();
                fm.Show();
                this.Hide();
            }
        }
    }
}
