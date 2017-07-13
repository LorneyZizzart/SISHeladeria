using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HELADERIA
{
    class Pedido
    {
        public int Id_Pedido { get; set; }
        public int Id_Producto { get; set; }
        public string NumeroPedido { get; set; }
        public int Mesa { get; set; }
        public int Cantidad { get; set; }
        public string FechaHora { get; set; }

        public Pedido() { }

        public Pedido(int id_Pedido, int id_Producto, int cantidad, string fecha)
        {
            this.Id_Pedido = id_Pedido;
            this.Id_Producto = id_Producto;
            this.Cantidad = cantidad;
            this.FechaHora = fecha;
        }
    }
}
