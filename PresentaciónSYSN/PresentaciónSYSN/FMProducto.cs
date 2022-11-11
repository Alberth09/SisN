using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejador;
using Entidad;

namespace PresentaciónSYSN
{
    public partial class FMProducto : Form
    {
        ManejadorProductos mp;
        int i = 0;
        public static Productos dato;
        public FMProducto()
        {
            InitializeComponent();
            mp = new ManejadorProductos();
            dato = new Productos(0, "", "", "", 0, 0,"");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(mp.Guardar(new Productos(int.Parse(txtID.Text), txtProducto.Text, txtP_Compra.Text,
                txtTipo.Text, int.Parse(txtMinimo.Text), int.Parse(txtMaximo.Text), txtMinimo.Text)));
            Actualizar();
        }
        void Actualizar()
        {
            mp.Mostrar(dtgP, txtBuscar.Text);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void dtgP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dato._Id = int.Parse(dtgP.Rows[i].Cells[0].Value.ToString());
            dato._Producto = dtgP.Rows[i].Cells[1].Value.ToString();
        }

        private void dtgP_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgP.RowCount > 0)
            {
                string r = mp.Borrar(dato);
                if (!string.IsNullOrEmpty(r))
                    MessageBox.Show(r);
            }
            else
            {
                MessageBox.Show("Dedes eligir un registro");
            }
            Actualizar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
