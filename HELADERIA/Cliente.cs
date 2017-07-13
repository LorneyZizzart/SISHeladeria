using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HELADERIA
{
    class Cliente
    {
        public int Id_Cliente { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public int Carnet { get; set; }
        public int NIT { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }

        public Cliente() { }
    }
}
