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
    public class ManejadorVentas
    {
        Base b = new Base("127.0.0.1", "root", "", "Sy");

        public Tuple<bool, string> ValidarVenta(Ventas dato)
        {
            bool error = true;
            string cadenaErrores = "";

            if (dato._Id == 0 || dato._Id == 0)
            {
                cadenaErrores = cadenaErrores + "El campo id no puede ser vacio \n";
                error = false;
            }
            else
            {
                if (dato._FKNombre.Length == 0 || dato._FKNombre == null)
                {
                    cadenaErrores = cadenaErrores + "El campo del Nombre no puede ser vacio \n";
                    error = false;
                }
                else
                {
                    if (dato._FKProducto.Length == 0 || dato._FKProducto == null)
                    {
                        cadenaErrores = cadenaErrores + "El campo de Producto no puede ser vacio \n";
                        error = false;
                    }
                    else
                    {
                        if (dato._Cantidad.Length == 0 || dato._Cantidad == null)
                        {
                            cadenaErrores = cadenaErrores + "El campo de cantidad no puede ser vacio \n";
                            error = false;
                        }
                    }
                }
            }
            
            var valida = new Tuple<bool, string>(error, cadenaErrores);
            return valida;
        }
        public string Guardar(Ventas dato)
        {
            string r = "";
            try
            {
                r = b.Comando(string.Format("insert into Venta values({0},'{1}','{2}','{3}')", dato._Id, dato._FKNombre,
                dato._FKProducto, dato._Cantidad));
            }
            catch (Exception ex)
            {

                Console.WriteLine("Falló en guardar los datos" + ex.Message);
            }
            return r;
        }
        public void Mostrar(DataGridView dtgV, string dato)
        {
            dtgV.DataSource = b.Mostrar(string.Format("select * from Venta where ID like '%{0}%'", dato), "Venta").Tables["Venta"];
            dtgV.AutoResizeColumns();
        }
        public string Borrar(Ventas dato)
        {
            string r = "";
            DialogResult rs = MessageBox.Show("Estas seguro de eliminar " + dato._FKProducto, "Atencion!",
                MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                r = b.Comando(string.Format("delete from Venta where id='{0}'", dato._Id));
            }
            else
            {
                Console.WriteLine("Falló en eliminar");
            }
            return r;
        }
    }
}
