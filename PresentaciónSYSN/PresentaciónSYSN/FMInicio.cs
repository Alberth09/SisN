using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentaciónSYSN
{
    public partial class FMInicio : Form
    {
        public FMInicio()
        {
            InitializeComponent();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            FMInventario fi = new FMInventario();
            fi.ShowDialog();
        }

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            FMProducto fp = new FMProducto();
            fp.ShowDialog();
        }

        private void toolStripLabel6_Click(object sender, EventArgs e)
        {
            FMCliente fc = new FMCliente();
            fc.ShowDialog();
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            FMVentas fv = new FMVentas();
            fv.ShowDialog();
        }
    }
}
