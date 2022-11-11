using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Ventas
    {
        public int _Id { get; set; }
        public string _FKProducto { get; set; }
        public string _FKNombre { get; set; }
        public string _Cantidad { get; set; }

        public Ventas(int id, string fkproducto, string fknombre,string cantidad)
        {
            _Id = id;
            _FKProducto = fkproducto;
            _FKNombre = fknombre;
            _Cantidad = cantidad;
        }
        public Ventas()
        {

        }
    }
}
