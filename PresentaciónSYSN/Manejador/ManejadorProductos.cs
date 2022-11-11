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
    public class ManejadorProductos
    {
        Base b = new Base("localhost", "root", "", "sysn");

        public Tuple<bool, string> ValidarProductos(Productos dato)
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
                if (dato._Producto.Length == 0 || dato._Producto == null)
                {
                    cadenaErrores = cadenaErrores + "El campo producto no puede ser vacio \n";
                    error = false;
                }
                else
                {
                    if (dato._Precio_Compra.Length == 0 || dato._Precio_Compra == null)
                    {
                        cadenaErrores = cadenaErrores + "El campo P.de Compra no puede ser vacio \n";
                        error = false;
                    }
                    else
                    {
                        if (dato._Precio_Venta.Length == 0 || dato._Precio_Venta == null)
                        {
                            cadenaErrores = cadenaErrores + "El campo P.de Venta no puede ser vacio \n";
                            error = false;
                        }
                        else
                        {
                            if (dato._Precio_Venta.Length == 0 || dato._Precio_Venta == null)
                            {
                                cadenaErrores = cadenaErrores + "El campo P.de Venta no puede ser vacio \n";
                                error = false;
                            }
                            else
                            {
                                if (dato._Minimo == 0 || dato._Minimo == 0)
                                {
                                    cadenaErrores = cadenaErrores + "El campo minimo no puede ser vacio \n";
                                    error = false;
                                }
                                else
                                {
                                    if (dato._Maximo == 0 || dato._Maximo == 0)
                                    {
                                        cadenaErrores = cadenaErrores + "El campo maximo no puede ser vacio \n";
                                        error = false;
                                    }
                                    else
                                    {
                                        if (dato._Tipo.Length == 0 || dato._Tipo == null)
                                        {
                                            cadenaErrores = cadenaErrores + "El campo tipo no puede ser vacio \n";
                                            error = false;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }


            var valida = new Tuple<bool, string>(error, cadenaErrores);
            return valida;
        }
        public string Guardar(Productos dato)
        {
            string r = "";
            try
            {
                r = b.Comando(string.Format("insert into Productos values({0},'{1}','{2}','{3}','{4}','{5}','{6}')", dato._Id, dato._Producto,
               dato._Precio_Compra, dato._Precio_Venta, dato._Maximo, dato._Minimo, dato._Tipo));
            }
            catch (Exception ex)
            {

                Console.WriteLine("Falló en guardar los datos" + ex.Message);
            }
            return r;
        }
        public void Mostrar(DataGridView dtgP, string dato)
        {
            dtgP.DataSource = b.Mostrar(string.Format("select * from Productos where Producto like '%{0}%'", dato), "Productos").Tables["Productos"];
            dtgP.AutoResizeColumns();
        }
        public string Borrar(Productos dato)
        {
            string r = "";
            DialogResult rs = MessageBox.Show("Estas seguro de eliminar " + dato._Producto, "Atencion!",
                MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                r = b.Comando(string.Format("delete from Productos where Producto= '{0}'", dato._Producto));
            }
            else
            {
                Console.WriteLine("Falló en eliminar");
            }
            return r;
        }
    }
}
