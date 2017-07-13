using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace HELADERIA
{
    class GestionarProducto
    {
        MySqlConnection conexionBD = new MySqlConnection();
        
        //Mostrar por tipo de Producto
        public DataTable MostrarProductos(string tipoProducto)
        {
            DataTable Datos = new DataTable();
            BDConexion cn = new BDConexion();
            MySqlDataAdapter datosObtenidos = new MySqlDataAdapter();
            conexionBD = cn.ObtenerConexion();

            string consultaProductos = "SELECT id_Producto as CODIGO, tp.nombreProducto as 'TIPO DE PRODUCTO', nombre as 'NOMBRE', precio as 'PRECIO' " +
                                        "FROM producto p, tipo_producto tp " +
                                        "WHERE p.id_TipoProducto = tp.id_TipoProducto " +
                                        "AND tp.nombreProducto = '" + tipoProducto + "'" +
                                        "ORDER BY id_Producto";

            /*[CONSULTA]
             SELECT id_Producto as CODIGO, tp.nombreProducto as 'TIPO DE PRODUCTO', nombre as 'NOMBRE', precio as 'PRECIO', activo as ACTIVO, descripcion as DESCRIPCION
             FROM producto p, tipo_producto tp
             WHERE p.id_TipoProducto = tp.id_TipoProducto
             ORDER BY id_Producto
             * */

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexionBD;
                cmd.CommandText = consultaProductos;
                datosObtenidos.SelectCommand = cmd;
                datosObtenidos.Fill(Datos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la consulta a la tabla 'PRODUCTO' " + ex.Message);
            }
            return Datos;
        }

        public DataTable MostrarProductos()
        {
            DataTable Datos = new DataTable();
            BDConexion cn = new BDConexion();
            MySqlDataAdapter datosObtenidos = new MySqlDataAdapter();
            conexionBD = cn.ObtenerConexion();

            string consultaProductos = "SELECT id_Producto as CODIGO, tp.nombreProducto as 'TIPO DE PRODUCTO', nombre as 'NOMBRE', precio as 'PRECIO' " +
                                        "FROM producto p, tipo_producto tp " +
                                        "WHERE p.id_TipoProducto = tp.id_TipoProducto " +
                                        "ORDER BY id_Producto";

            /*[CONSULTA]
             SELECT id_Producto as CODIGO, tp.nombreProducto as 'TIPO DE PRODUCTO', nombre as 'NOMBRE', precio as 'PRECIO', activo as ACTIVO
             FROM producto p, tipo_producto tp
             WHERE p.id_TipoProducto = tp.id_TipoProducto
             ORDER BY id_Producto
             * */

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexionBD;
                cmd.CommandText = consultaProductos;
                datosObtenidos.SelectCommand = cmd;
                datosObtenidos.Fill(Datos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la consulta a la tabla 'PRODUCTO' " + ex.Message);
            }
            return Datos;
        }

        //MOSTRAR PRODUCTOS A LA VENTA
        public DataTable MostrarProductosEnVenta()
        {
            DataTable Datos = new DataTable();
            BDConexion cn = new BDConexion();
            MySqlDataAdapter datosObtenidos = new MySqlDataAdapter();
            conexionBD = cn.ObtenerConexion();

            string consultaProductos = "SELECT id_Producto as CODIGO, tp.nombreProducto as 'TIPO DE PRODUCTO', nombre as 'NOMBRE', precio as 'PRECIO' " +
                                        "FROM producto p, tipo_producto tp " +
                                        "WHERE p.id_TipoProducto = tp.id_TipoProducto " +
                                        "AND activo = TRUE " +
                                        "ORDER BY id_Producto";

            /*[CONSULTA]
             SELECT id_Producto as CODIGO, tp.nombreProducto as 'TIPO DE PRODUCTO', nombre as 'NOMBRE', precio as 'PRECIO', activo as ACTIVO, descripcion as DESCRIPCION
             FROM producto p, tipo_producto tp
             WHERE p.id_TipoProducto = tp.id_TipoProducto
             ORDER BY id_Producto
             * */

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexionBD;
                cmd.CommandText = consultaProductos;
                datosObtenidos.SelectCommand = cmd;
                datosObtenidos.Fill(Datos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la consulta a la tabla 'PRODUCTO' " + ex.Message);
            }
            return Datos;
        }

        //PARA MOSTRAR MAS DETALLES EN LOS PEDIDOS
        public MySqlDataReader ObtenerProducto(Producto producto)
        {
            BDConexion cn = new BDConexion();
            conexionBD = cn.ObtenerConexion();
            MySqlDataReader obtenerDatos = null;

            string consultaProducto = "SELECT p.id_Producto as CODIGO, tp.nombreProducto as 'TIPO DE PRODUCTO', p.nombre as 'NOMBRE', p.precio as 'PRECIO', p.descripcion as DESCRIPCION  " +
                                        "FROM producto p, tipo_Producto tp " +
                                        "WHERE p.id_TipoProducto = tp.id_TipoProducto " +
                                        "AND p.id_Producto = " + producto.Id_Producto;

            /*
             SELECT p.id_Producto as CODIGO, tp.nombreProducto as 'TIPO DE PRODUCTO', p.nombre as 'NOMBRE', p.precio as 'PRECIO', p.descripcion as DESCRIPCION 
             FROM producto p, tipo_Producto tp 
             WHERE p.id_TipoProducto = tp.id_TipoProducto 
             AND p.id_Producto = 1;
             * */

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexionBD;
                cmd.CommandText = consultaProducto;
                obtenerDatos = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error en la consulta" + ex.Message);
            }
            return obtenerDatos;
        }

        public static int Agregar(Producto producto)
        {
            int retorno = 0;
            BDConexion cn = new BDConexion();

            MySqlCommand cmd = new MySqlCommand(string.Format("INSERT INTO producto (nombre, id_TipoProducto, precio, descripcion, imagen, activo)" +
            "VALUE('{0}','{1}', '{2}', '{3}','{4}', {5})",
            producto.Nombre, producto.Id_TipoProducto, producto.Precio, producto.Descripcion, producto.Imagen, producto.Activo),
            cn.ObtenerConexion());

            retorno = cmd.ExecuteNonQuery();

            return retorno;

        }
        //PARA VERIFICAR SI EL PRODUCTO ES EXISTENTE
        public MySqlDataReader BuscarProducto(Producto producto)
        {
            BDConexion cn = new BDConexion();
            conexionBD = cn.ObtenerConexion();
            MySqlDataReader obtenerDatos = null;

            string consultaProducto = "SELECT nombre " +
                                        "FROM producto " +
                                        "WHERE nombre = '" + producto.Nombre + "'";

            /*
             SELECT nombre 
             FROM producto
             WHERE nombre = 'Silpancho';
             * */

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexionBD;
                cmd.CommandText = consultaProducto;
                obtenerDatos = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error en la consulta" + ex.Message);
            }
            return obtenerDatos;
        }
        //MOSTRAR TIPOI DE PRODUCTOS [frmPedido]
        public DataTable TipoProductos()
        {
            DataTable Datos = new DataTable();
            BDConexion cn = new BDConexion();
            MySqlDataAdapter datosObtenidos = new MySqlDataAdapter();
            conexionBD = cn.ObtenerConexion();

            string consultaProductos = "SELECT nombreProducto " +
                                        "FROM tipo_producto ";

            /*[CONSULTA]
             SELECT nombreProducto
             FROM tipo_producto;
             * */

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexionBD;
                cmd.CommandText = consultaProductos;
                datosObtenidos.SelectCommand = cmd;
                datosObtenidos.Fill(Datos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la consulta a la tabla 'TIPO DE PRODUCTOS' " + ex.Message);
            }
            return Datos;
        }
    }
}
