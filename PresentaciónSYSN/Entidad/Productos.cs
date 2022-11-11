using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Productos
    {
        public int _Id { get; set; }
        public string _Producto { get; set; }
        public string _Precio_Compra { get; set; }
        public string _Precio_Venta { get; set; }
        public int _Minimo { get; set; }
        public int _Maximo { get; set; }
        public string _Tipo { get; set; }
        public Productos(int id, string producto, string precio_compra, string precio_venta, int minimo, int maximo, string tipo)
        {
            _Id = id;
            _Producto = producto;
            _Precio_Compra = precio_compra;
            _Precio_Venta = precio_venta;
            _Minimo = minimo;
            _Maximo = maximo;
            _Tipo = tipo;
            
        }
        public Productos()
        {

        }
    }
}
