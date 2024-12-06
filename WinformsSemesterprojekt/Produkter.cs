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
    public partial class Produkter : Form
    {
        public Produkter()
        {
            InitializeComponent();
        }

        private void btnMainmenu_Click(object sender, EventArgs e)
        {
            Hovedmenu hovedmenu = new Hovedmenu();
            hovedmenu.Show();
            this.Hide();
        }
    }
}
