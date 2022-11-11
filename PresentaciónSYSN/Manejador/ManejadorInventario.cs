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
    public class ManejadorInventario
    {
        Base b = new Base("localhost", "root", "", "sysn");

        public Tuple<bool, string> ValidarInventario(Inventario dato)
        {
            bool error = true;
            string cadenaErrores = "";

            if (dato._Id == 0 ||dato._Id == 0)
            {
                cadenaErrores = cadenaErrores + "El campo id no puede ser vacio \n";
                error = false;
            }
            else
            {
                if (dato._Producto.Length == 0 || dato._Producto == null)
                {
                    cadenaErrores = cadenaErrores + "El campo de producto no puede ser vacio \n";
                    error = false;
                }
                else
                {
                    if (dato._tipo.Length == 0 || dato._tipo == null)
                    {
                        cadenaErrores = cadenaErrores + "El campo tipo no puede ser vacio \n";
                        error = false;
                    }
                    else
                    {
                        if (dato._Cantidad.Length == 0 || dato._Cantidad == null)
                        {
                            cadenaErrores = cadenaErrores + "El campo cantidad no puede ser vacio \n";
                            error = false;
                        }
                    }
                }
            }

            var valida = new Tuple<bool, string>(error, cadenaErrores);
            return valida;
        }

        public string Guardar(Inventario dato)
        {
            string r = "";
            try
            {
                r = b.Comando(string.Format("insert into Inventario values({0},'{1}','{2}','{3}')", dato._Id, dato._Producto,
                dato._tipo, dato._Cantidad));
            }
            catch (Exception ex)
            {

                Console.WriteLine("Falló en guardar los datos" + ex.Message);
            }
            return r;
        }
        public void Mostrar(DataGridView dtgI, string dato)
        {
            dtgI.DataSource = b.Mostrar(string.Format("select * from Inventario where Producto like '%{0}%'", dato), "inventario").Tables["inventario"];
            dtgI.AutoResizeColumns();
        }
        public string Borrar(Inventario dato)
        {
            string r = "";
            DialogResult rs = MessageBox.Show("Estas seguro de eliminar " + dato._Producto, "Atencion!",
                MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                r = b.Comando(string.Format("delete from Inventario where id='{0}'", dato._Id));
            }
            else
            {
                Console.WriteLine("Falló en eliminar");
            }
            return r;
        }
    }
}
