using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;
using Entidad;

namespace Manejador
{
    public class ManejadorClientes
    {
        Base b = new Base("127.0.0.1", "root", "", "Sy");

        public string Guardar(Cliente dato)
        {
            string r = "";
            try
            {
                r = b.Comando(string.Format("insert into Cliente values({0},'{1}','{2}','{3}','{4}')", dato._ID, dato._Nombre,
                dato._Apellidos, dato._Telefono, dato._Direccion));
            }
            catch (Exception ex)
            {

                Console.WriteLine("Falló en guardar los datos" + ex.Message);
            }
            return r;
        }
        public void Mostrar(DataGridView dtgC, string dato)
        {
            dtgC.DataSource = b.Mostrar(string.Format("select * from Cliente where Nombre like '%{0}%'", dato), "Cliente").Tables["Cliente"];
            dtgC.AutoResizeColumns();
        }
        public string Borrar(Cliente dato)
        {
            string r = "";
            DialogResult rs = MessageBox.Show("Estas seguro de eliminar " + dato._Nombre, "Atencion!",
                MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                r = b.Comando(string.Format("delete from Cliente where Nombre='{0}'", dato._Nombre));

            }
            else
            {
                Console.WriteLine("Falló en eliminar");
            }
            return r;
        }
    }
}
