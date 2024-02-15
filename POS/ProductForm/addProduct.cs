using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.ProductForm
{
    public partial class addProduct : Form
    {
        public event Action FormClosedTrigger;
        public addProduct()
        {
            InitializeComponent();
        }
        private void addProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
