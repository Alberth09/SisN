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
        Base b = new Base("127.0.0.1", "root", "", "SYSN");

        public Tuple<bool, string> ValidarProductos(Cliente dato)
        {
            bool error = true;
            string cadenaErrores = "";

            if (dato._ID == 0 || dato._ID == 0)
            {
                cadenaErrores = cadenaErrores + "El campo id no puede ser vacio \n";
                error = false;
            }
            else
            {
                if (dato._Nombre.Length == 0 || dato._Nombre == null)
                {
                    cadenaErrores = cadenaErrores + "El campo nombre no puede ser vacio \n";
                    error = false;
                }
                else
                {
                    if (dato._Apellidos.Length == 0 || dato._Apellidos == null)
                    {
                        cadenaErrores = cadenaErrores + "El campo apellidos no puede ser vacio \n";
                        error = false;
                    }
                    else
                    {
                        if (dato._Telefono.Length == 0 || dato._Telefono == null)
                        {
                            cadenaErrores = cadenaErrores + "El campo telefono no puede ser vacio \n";
                            error = false;
                        }
                        else
                        {
                            if (dato._Estado.Length == 0 || dato._Estado == null)
                            {
                                cadenaErrores = cadenaErrores + "El campo estado no puede ser vacio \n";
                                error = false;
                            }
                            else
                            {
                                if (dato._Direccion.Length == 0 || dato._Direccion == null)
                                {
                                    cadenaErrores = cadenaErrores + "El campo direccion no puede ser vacio \n";
                                    error = false;
                                }
                            }
                        }
                    }
                }
            }


            var valida = new Tuple<bool, string>(error, cadenaErrores);
            return valida;
        }
        public string Guardar(Cliente dato)
        {
            string r = "";
            try
            {
                r = b.Comando(string.Format("insert into Cliente values({0},'{1}','{2}','{3}','{4}','{5}')", dato._ID, dato._Nombre,
                dato._Apellidos, dato._Telefono, dato._Estado, dato._Direccion));
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
