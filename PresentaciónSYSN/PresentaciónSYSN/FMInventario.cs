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
    public partial class FMInventario : Form
    {
        ManejadorInventario mi;
        int i = 0;
        public static Inventario dato;
        public FMInventario()
        {
            InitializeComponent();
            mi = new ManejadorInventario();
            dato = new Inventario(0, "", "", "");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(mi.Guardar(new Inventario(int.Parse(txtID.Text), txtProducto.Text, txtCantidad.Text,
                txtTipo.Text)));
            Actualizar();
        }

        private void dtgI_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dato._Id = int.Parse(dtgI.Rows[i].Cells[0].Value.ToString());
            dato._Producto = dtgI.Rows[i].Cells[1].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgI.RowCount > 0)
            {
                string r = mi.Borrar(dato);
                if (!string.IsNullOrEmpty(r))
                    MessageBox.Show(r);
            }
            else
            {
                MessageBox.Show("Dedes eligir un registro");
            }
            Actualizar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void dtgI_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
        }
        void Actualizar()
        {
            mi.Mostrar(dtgI, txtBuscar.Text);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
