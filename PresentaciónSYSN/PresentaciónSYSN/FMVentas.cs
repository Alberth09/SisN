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
    public partial class FMVentas : Form
    {
        ManejadorVentas mv;
        int i = 0;
        public static Ventas dato;
        public FMVentas()
        {
            InitializeComponent();
            mv = new ManejadorVentas();
            dato = new Ventas(0, "", "", "");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(mv.Guardar(new Ventas(int.Parse(txtID.Text), txtCliente.Text, txtProducto.Text, txtCantidad.Text)));
            Actualizar();
        }
        void Actualizar()
        {
            mv.Mostrar(dtgV, txtBuscar.Text);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void dtgV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dato._Id = int.Parse(dtgV.Rows[i].Cells[0].Value.ToString());
            dato._FKProducto = dtgV.Rows[i].Cells[1].Value.ToString();
        }

        private void dtgV_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgV.RowCount > 0)
            {
                string r = mv.Borrar(dato);
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
