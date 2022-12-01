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
using System.Drawing.Printing;

namespace PresentaciónSYSN
{
    public partial class FMCliente : Form
    {
        ManejadorClientes mc;
        int i = 0;
        public static Cliente dato;
        public FMCliente()
        {
            InitializeComponent();
            mc = new ManejadorClientes();
            dato = new Cliente(0, "", "", "", "");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(mc.Guardar(new Cliente(int.Parse(txtID.Text), txtNombre.Text, txtApellidos.Text, txtTelefono.Text,
                txtDireccion.Text)));
            Actualizar();
        }
        void Actualizar()
        {
            mc.Mostrar(dtgC, txtbuscar.Text);
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void dtgC_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            if (dtgC.RowCount > 0)
            {
                string r = mc.Borrar(dato);
                if (!string.IsNullOrEmpty(r))
                MessageBox.Show(r);
            }
            else
            {
                MessageBox.Show("Dedes eligir un registro");
            }
            Actualizar();

        }

        private void Pdf(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
           
        }

        private void dtgC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dato._ID = int.Parse(dtgC.Rows[i].Cells[0].Value.ToString());
            dato._Nombre = dtgC.Rows[i].Cells[1].Value.ToString();        
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtgC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
