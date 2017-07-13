using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Windows.Forms;
using System.Data;

namespace HELADERIA
{
    class GestionarPedido
    {
        MySqlConnection conexionBD = new MySqlConnection();
        string auxNumPedido;
        public DataTable MostrarPedido(Pedido pedido)
        {
            DataTable Datos = new DataTable();
            BDConexion cn = new BDConexion();
            MySqlDataAdapter datosObtenidos = new MySqlDataAdapter();
            conexionBD = cn.ObtenerConexion();

            string consultaProductos =  " SELECT p.nombre as PRODUCTO, pe.cantidad as CANTIDAD, pe.mesa AS 'NUMERO DE MESA'" +
                                        " FROM producto p, pedido pe " +
                                        " WHERE p.id_Producto = pe.id_Producto " +
                                        " AND pe.numeroPedido = "+pedido.NumeroPedido;

            /*[CONSULTA]
             SELECT p.nombre as PRODUCTO, pe.cantidad as CANTIDAD, pe.mesa AS 'NUMERO DE MESA' 
             FROM producto p, pedido pe 
             WHERE p.id_Producto = pe.id_Producto 
             AND pe.numeroPedido = 2;
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
                MessageBox.Show("Error en la consulta a la tabla 'PEDIDOS' " + ex.Message);
            }
            return Datos;
        }

        public static int Agregar(Pedido pedido, int tipoPedido)
        {
            int retorno = 0;
            BDConexion cn = new BDConexion();
            MySqlCommand cmd = new MySqlCommand();
            if (tipoPedido == 1)
            {
                cmd = new MySqlCommand(string.Format("INSERT INTO pedido (id_Producto, numeroPedido, mesa, cantidad, fechaHora) " +
                "VALUES({0}, {1}, {2}, {3}, '{4}')",
                pedido.Id_Producto, pedido.NumeroPedido, pedido.Mesa, pedido.Cantidad, pedido.FechaHora),
                cn.ObtenerConexion());                
            }
            else if (tipoPedido == 2 || tipoPedido == 3)
            {
                cmd = new MySqlCommand(string.Format("INSERT INTO pedido (id_Producto, numeroPedido, cantidad, fechaHora) " +
                "VALUES({0}, {1}, {2}, '{3}')",
                pedido.Id_Producto, pedido.NumeroPedido, pedido.Cantidad, pedido.FechaHora),
                cn.ObtenerConexion()); 
            }

            retorno = cmd.ExecuteNonQuery();

            return retorno;
        }

        public static int AgregarListaPedidos(ListaPedidos lista)
        {
            int retorno = 0;
            BDConexion cn = new BDConexion();

            MySqlCommand cmd = new MySqlCommand(string.Format("INSERT INTO lista_pedido(id_TipoPedido, id_Pedido, id_Usuario, pagoTotal, pendiente) " +
            "VALUES ({0}, {1}, {2}, '{3}', {4})",
            lista.Id_TipoPedido, lista.Id_Pedido, lista.Id_Usuario, lista.PagoTotal, lista.Pendiente),
            cn.ObtenerConexion());
            retorno = cmd.ExecuteNonQuery();

            return retorno;
        }

        public MySqlDataReader ObtenerNumeroPedido()
        {
            BDConexion cn = new BDConexion();
            conexionBD = cn.ObtenerConexion();
            MySqlDataReader obtenerDatos = null;

            string consultaProducto = " SELECT MAX(numeroPedido) " +
                                      " FROM pedido";

            /*
             SELECT MAX(numeroPedido) 
             FROM pedido;
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
        //PARA VER LAS LISTA DE PEDIDOS QUE SE REALIZARON
        public DataTable MostrarListaPedidos()
        {
            DataTable Datos = new DataTable();
            BDConexion cn = new BDConexion();
            MySqlDataAdapter datosObtenidos = new MySqlDataAdapter();
            conexionBD = cn.ObtenerConexion();

            string consultaListaPedidos = "SELECT lp.id_ListaPedido as CODIGO, t.tipo as 'TIPO DE PEDIDO', p.numeroPedido as 'NUMERO DE PEDIDO', u.usuario as 'PERSONAL DE ATENCION', lp.pagoTotal as 'TOTAL A CANCELAR', lp.pendiente as 'PENDIENTE' " +
                                       "FROM lista_pedido lp, tipo_pedido t, pedido p, usuario u " +
                                       "WHERE lp.id_TipoPedido = t.id_TipoPedido " +
                                       "AND lp.id_Pedido = p.id_Pedido " +
                                       "AND lp.id_Usuario = u.id_Usuario " +
                                       "ORDER BY lp.id_ListaPedido";

            /*[CONSULTA]
             SELECT lp.id_ListaPedido as CODIGO, t.tipo as 'TIPO DE PEDIDO', p.numeroPedido as 'NUMERO DE PEDIDO', u.usuario as 'PERSONAL DE ATENCION', lp.pendiente as 'PENDIENTE'
             FROM lista_pedido lp, tipo_pedido t, pedido p, usuario u
             WHERE lp.id_TipoPedido = t.id_TipoPedido
             AND lp.id_Pedido = p.id_Pedido
             AND lp.id_Usuario = u.id_Usuario
             ORDER BY lp.id_ListaPedido ;
             * */

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexionBD;
                cmd.CommandText = consultaListaPedidos;
                datosObtenidos.SelectCommand = cmd;
                datosObtenidos.Fill(Datos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la consulta a la tabla 'LISTA DE PEDIDOS' " + ex.Message);
            }
            return Datos;
        }
        //PARA OBTENER el id del ultimo pedido
        public MySqlDataReader ObtenerUltimoNumeroPedido(Pedido pedido)
        {
            BDConexion cn = new BDConexion();
            conexionBD = cn.ObtenerConexion();
            MySqlDataReader obtenerDatos = null;

            string consultaProducto = "SELECT MAX(id_Pedido) " +
                                      "FROM pedido " +
                                      "WHERE numeroPedido = " + pedido.NumeroPedido;

            /*
             SELECT MAX(id_Pedido) 
             FROM pedido
             WHERE numeroPedido = 30;
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

        public static int AgregarFactura(Empleado usuario, Cliente cliente, ListaPedidos lista, string efectivo, string fecha)
        {
            int retorno = 0;
            BDConexion cn = new BDConexion();

            MySqlCommand cmd = new MySqlCommand(string.Format("INSERT INTO factura(id_Usuario, id_Cliente, id_ListaPedido, numeroFactura, codigoControl, efectivo, fechaCancelacion) " +
            "VALUES ({0}, {1}, {2}, {3}, '{4}', '{5}', '{6}')",
            usuario.Id_Employees, cliente.Id_Cliente, lista.Id_ListaPedido, null, null, efectivo, fecha),
            cn.ObtenerConexion());

            retorno = cmd.ExecuteNonQuery();

            return retorno;
        }

        //PARA VER LAS LISTA DE PEDIDOS QUE SE REALIZARON
        public DataTable MostrarFacturas()
        {
            DataTable Datos = new DataTable();
            BDConexion cn = new BDConexion();
            MySqlDataAdapter datosObtenidos = new MySqlDataAdapter();
            conexionBD = cn.ObtenerConexion();

            string consultaListaPedidos = "SELECT f.id_Factura as CODIGO, u.usuario as 'NOMBRE DEL CAJERO', concat_ws(' ', c.nombre, c.apellidoPaterno, c.apellidoMaterno) as 'NOMBRE DEL CLIENTE', f.efectivo as 'EFECTIVO', f.fechaCancelacion as 'FECHA DE CANCELACION' " +
                                       "FROM factura f, usuario u, cliente c, lista_pedido lp " +
                                       "WHERE f.id_Usuario = u.id_Usuario " +
                                       "AND f.id_Cliente = c.id_Cliente " +
                                       "AND f.id_ListaPedido = lp.id_ListaPedido "+
                                       "ORDER BY f.id_Factura";

            /*[CONSULTA]
             SELECT f.id_Factura as CODIGO, u.usuario as 'NOMBRE DEL CAJERO', concat_ws(' ', c.nombre, c.apellidoPaterno, c.apellidoMaterno) as 'NOMBRE DEL CLIENTE', f.efectivo as 'EFECTIVO', f.fechaCancelacion as 'FECHA DE CANCELACION'
             FROM factura f, usuario u, cliente c, lista_pedido lp
             WHERE f.id_Usuario = u.id_Usuario
             AND f.id_Cliente = c.id_Cliente
             AND f.id_ListaPedido = lp.id_ListaPedido;
             * */

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexionBD;
                cmd.CommandText = consultaListaPedidos;
                datosObtenidos.SelectCommand = cmd;
                datosObtenidos.Fill(Datos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la consulta a la tabla 'LISTA DE PEDIDOS' " + ex.Message);
            }
            return Datos;
        }
        //BUSCAR POR EL NUMERO DE PEDIDO
        public DataTable BuscarPedidos(int pedido)
        {
            DataTable Datos = new DataTable();
            BDConexion cn = new BDConexion();
            MySqlDataAdapter datosObtenidos = new MySqlDataAdapter();
            conexionBD = cn.ObtenerConexion();

            string consultaListaPedidos = "SELECT lp.id_ListaPedido as CODIGO, t.tipo as 'TIPO DE PEDIDO', p.numeroPedido as 'NUMERO DE PEDIDO', u.usuario as 'PERSONAL DE ATENCION', lp.pagoTotal as 'TOTAL A CANCELAR', lp.pendiente as 'PENDIENTE' " +
                                       "FROM lista_pedido lp, tipo_pedido t, pedido p, usuario u " +
                                       "WHERE lp.id_TipoPedido = t.id_TipoPedido " +
                                       "AND lp.id_Pedido = p.id_Pedido " +
                                       "AND lp.id_Usuario = u.id_Usuario " +
                                       "AND p.numeroPedido LIKE '%" + pedido + "%'";

            /*[CONSULTA]
             SELECT lp.id_ListaPedido as CODIGO, t.tipo as 'TIPO DE PEDIDO', p.numeroPedido as 'NUMERO DE PEDIDO', u.usuario as 'PERSONAL DE ATENCION', lp.pendiente as 'PENDIENTE'
             FROM lista_pedido lp, tipo_pedido t, pedido p, usuario u
             WHERE lp.id_TipoPedido = t.id_TipoPedido
             AND lp.id_Pedido = p.id_Pedido
             AND lp.id_Usuario = u.id_Usuario
             AND p.numeroPedido LIKE '%1%';
             * */

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexionBD;
                cmd.CommandText = consultaListaPedidos;
                datosObtenidos.SelectCommand = cmd;
                datosObtenidos.Fill(Datos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la consulta a la tabla 'LISTA DE PEDIDOS' " + ex.Message);
            }
            return Datos;
        }

        public DataTable BuscarTipoPedido(string pedido)
        {
            DataTable Datos = new DataTable();
            BDConexion cn = new BDConexion();
            MySqlDataAdapter datosObtenidos = new MySqlDataAdapter();
            conexionBD = cn.ObtenerConexion();

            string consultaListaPedidos = "SELECT lp.id_ListaPedido as CODIGO, t.tipo as 'TIPO DE PEDIDO', p.numeroPedido as 'NUMERO DE PEDIDO', u.usuario as 'PERSONAL DE ATENCION', lp.pagoTotal as 'TOTAL A CANCELAR', lp.pendiente as 'PENDIENTE' " +
                                       "FROM lista_pedido lp, tipo_pedido t, pedido p, usuario u " +
                                       "WHERE lp.id_TipoPedido = t.id_TipoPedido " +
                                       "AND lp.id_Pedido = p.id_Pedido " +
                                       "AND lp.id_Usuario = u.id_Usuario " +
                                       "AND t.tipo = '" + pedido + "'";

            /*[CONSULTA]
             SELECT lp.id_ListaPedido as CODIGO, t.tipo as 'TIPO DE PEDIDO', p.numeroPedido as 'NUMERO DE PEDIDO', u.usuario as 'PERSONAL DE ATENCION', lp.pendiente as 'PENDIENTE'
             FROM lista_pedido lp, tipo_pedido t, pedido p, usuario u
             WHERE lp.id_TipoPedido = t.id_TipoPedido
             AND lp.id_Pedido = p.id_Pedido
             AND lp.id_Usuario = u.id_Usuario
             AND t.tipo = 'Sucursal';
             * */

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexionBD;
                cmd.CommandText = consultaListaPedidos;
                datosObtenidos.SelectCommand = cmd;
                datosObtenidos.Fill(Datos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la consulta a la tabla 'LISTA DE PEDIDOS' " + ex.Message);
            }
            return Datos;
        }
        //PARA BUSCAR EL PEDIDO CON EL # DE PEDIDO
        public DataTable BuscarNroPedido(string numPedido)
        {
         

            if (Convert.ToInt32(numPedido.Length) <= 1)
            {
                auxNumPedido = "000" + numPedido;
            }
            else if (Convert.ToInt32(numPedido.Length) == 2)
            {
                auxNumPedido = "00" + numPedido;
            }
            else if (Convert.ToInt32(numPedido.Length) == 3)
            {
                auxNumPedido = "0" + numPedido;
            }
            else if (Convert.ToInt32(numPedido.Length) >= 4)
            {
                auxNumPedido = numPedido;
            }
            DataTable Datos = new DataTable();
            BDConexion cn = new BDConexion();
            MySqlDataAdapter datosObtenidos = new MySqlDataAdapter();
            conexionBD = cn.ObtenerConexion();

            string consultaListaPedidos = "SELECT pr.nombre as PRODUCTO, pr.precio as PRECIO, pr.descripcion as DESCRIPCION, pe.cantidad as CANTIDAD " +
                           "FROM pedido pe, producto pr " +
                           "WHERE pe.id_Producto = pr.id_Producto " +
                           "AND pe.numeroPedido = " + auxNumPedido;

            //string consultaListaPedidos = "SELECT (@rownum:=@rownum+1) as NUMERO, pr.nombre as PRODUCTO, pr.precio as PRECIO, pr.descripcion as DESCRIPCION, pe.cantidad as CANTIDAD " +
            //                           "FROM (SELECT @rownum:=0) r, pedido pe, producto pr " +
            //                           "WHERE pe.id_Producto = pr.id_Producto " +
            //                           "AND pe.numeroPedido = " + pedido.NumeroPedido;

            /*[CONSULTA]
                          SELECT pr.nombre as PRODUCTO, pr.precio as PRECIO, pr.descripcion as DESCRIPCION, pe.cantidad as CANTIDAD
             FROM pedido pe, producto pr
             WHERE pe.id_Producto = pr.id_Producto
             AND pe.numeroPedido = '0001';
             * 
             SELECT (@rownum:=@rownum+1) as NUMERO, pr.nombre as PRODUCTO, pr.precio as PRECIO, pr.descripcion as DESCRIPCION, pe.cantidad as CANTIDAD
             FROM (SELECT @rownum:=0) r, pedido pe, producto pr
             WHERE pe.id_Producto = pr.id_Producto
             AND pe.numeroPedido = 2; 
             * */

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexionBD;
                cmd.CommandText = consultaListaPedidos;
                datosObtenidos.SelectCommand = cmd;
                datosObtenidos.Fill(Datos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la consulta al obtener los datos de PEDIDOS " + ex.Message, "Error");
            }
            return Datos;
        }
        //PARA OBTENER EL TOTAL A CANCELAR PARA LA FACTURACION
        public MySqlDataReader PagoTotal(string numPedido)
        {
            BDConexion cn = new BDConexion();
            conexionBD = cn.ObtenerConexion();
            MySqlDataReader obtenerDatos = null;

            string consultaPago = "SELECT SUM(ls.pagoTotal) as TOTAL " +
                                  "FROM lista_pedido ls, pedido pe " +
                                  "WHERE ls.id_Pedido = pe.id_Pedido " +
                                  "AND pe.numeroPedido = " + numPedido;

            /*[CONSULTA]
             SELECT SUM(ls.pagoTotal) as TOTAL
             FROM lista_pedido ls, pedido pe
             WHERE ls.id_Pedido = pe.id_Pedido
             AND pe.numeroPedido = 3;
             * */

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexionBD;
                cmd.CommandText = consultaPago;
                obtenerDatos = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error en la consulta" + ex.Message);
            }
            return obtenerDatos;
        }
    }
}
