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
        Base b = new Base("localhost", "root", "", "Sy");

        public string Guardar(Productos dato)
        {
            string r = "";
            try
            {
                r = b.Comando(string.Format("insert into Producto values({0},'{1}','{2}','{3}','{4}','{5}','{6}')", dato._Id, dato._Producto,
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
            dtgP.DataSource = b.Mostrar(string.Format("select * from Producto where Producto like '%{0}%'", dato), "Producto").Tables["Producto"];
            dtgP.AutoResizeColumns();
        }
        public string Borrar(Productos dato)
        {
            string r = "";
            DialogResult rs = MessageBox.Show("Estas seguro de eliminar " + dato._Producto, "Atencion!",
                MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                r = b.Comando(string.Format("delete from Producto where Producto= '{0}'", dato._Producto));
            }
            else
            {
                Console.WriteLine("Falló en eliminar");
            }
            return r;
        }
    }
}
