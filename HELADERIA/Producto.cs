using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HELADERIA
{
    class Producto
    {
        public int Id_Producto { get; set; }
        public int Id_TipoProducto { get; set; }
        public string Nombre { get; set; }
        public string Precio { get; set; }
        public string Descripcion { get; set; }
        public object Imagen { get; set; }
        public bool Activo { get; set; }

        public Producto() { }

        public Producto(int id_Producto, string nombre, int id_TipoProducto, string precio, string descripcion, object imagen)
        {
            this.Id_Producto = id_Producto;
            this.Nombre = nombre;
            this.Id_TipoProducto = id_TipoProducto;
            this.Precio = precio;
            this.Descripcion = descripcion;
            this.Imagen = imagen;
        }


    }
}
