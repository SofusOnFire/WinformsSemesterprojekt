using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformsSemesterprojekt.Models;

namespace WinformsSemesterprojekt
{
    public partial class Products : Form
    {
        public BindingList<Product> ProductList { get; set; } = new BindingList<Product>();
        public Products()
        {
            Product stol = new Product(1, "Stol", 49, 20);
            Product bord = new Product(2, "Bord", 99, 5);
            ProductList.Add(stol);
            ProductList.Add(bord);

            InitializeComponent();

            productView.DataSource = ProductList;
        }

        private void btnMainmenu_Click(object sender, EventArgs e)
        {
            Hovedmenu hovedmenu = new Hovedmenu();
            hovedmenu.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
