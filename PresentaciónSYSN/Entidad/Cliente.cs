using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Cliente
    {
        public int _ID { get; set; }
        public string _Nombre { get; set; }
        public string _Apellidos { get; set; }
        public string _Telefono { get; set; }
        public string _Estado { get; set; }
        public string _Direccion { get; set; }
        public Cliente(int id, string nombre, string apellidos, string telefono, string estado, string direccion)
        {
            _ID = id;
            _Nombre = nombre;
            _Apellidos = apellidos;
            _Telefono = telefono;
            _Estado = estado;
            _Direccion = direccion;
        }
    }
}
