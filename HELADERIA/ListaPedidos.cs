using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HELADERIA
{
    class ListaPedidos
    {
        public int Id_ListaPedido { get; set; }
        public int Id_TipoPedido { get; set; }
        public int Id_Pedido { get; set; }
        public int Id_Usuario { get; set; }
        public string PagoTotal { get; set; }
        public bool Pendiente { get; set; }

        public ListaPedidos() { }

        public ListaPedidos(int id_TipoPedido, int id_Pedido, int id_Usuario, bool pendiente)
        {
            this.Id_TipoPedido = id_TipoPedido;
            this.Id_Pedido = id_Pedido;
            this.Id_Pedido = id_Pedido;
            this.Id_Usuario = id_Usuario;
            this.Pendiente = pendiente;
        }
    }
}
