using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformsSemesterprojekt
{
    public partial class Hovedmenu : Form
    {
        public Hovedmenu()
        {
            InitializeComponent();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            Products produkter = new Products();
            produkter.Show();
            this.Hide();
        }
    }
}
