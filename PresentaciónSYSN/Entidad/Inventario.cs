using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Inventario
    {
        public int _Id { get; set; } 
        public string _Producto { get; set; }
        public string _tipo { get; set; }
        public string _Cantidad { get; set; }

        public Inventario (int id, string producto, string tipo,string cantidad)
        {
            _Id = id;
            _Producto = producto;
            _tipo = tipo;
            _Cantidad = cantidad;
        }
        public Inventario()
        {

        }

    }
}
