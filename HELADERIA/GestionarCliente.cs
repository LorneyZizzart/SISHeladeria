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
    class GestionarCliente
    {
        MySqlConnection conexionBD = new MySqlConnection();

        //PARA OBTENER EL CLIENTE POR SU CARNET
        public MySqlDataReader BuscarCarnet(Cliente cliente)
        {
            BDConexion cn = new BDConexion();
            conexionBD = cn.ObtenerConexion();
            MySqlDataReader obtenerDatos = null;

            string buscarCliente = "SELECT id_Cliente, nombre, apellidos, carnet " +
                                   "FROM cliente " +
                                   "WHERE carnet = " + cliente.Carnet;

            /*
            SELECT id_Cliente, nombre, apellidos, carnet
            FROM cliente
            WHERE carnet = 1111111;
             * */

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexionBD;
                cmd.CommandText = buscarCliente;
                obtenerDatos = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error en la consulta" + ex.Message);
            }
            return obtenerDatos;
        }
        //PARA OBTENER EL CLIENTE POR SU NIT
        public MySqlDataReader BuscarNIT(Cliente cliente)
        {
            BDConexion cn = new BDConexion();
            conexionBD = cn.ObtenerConexion();
            MySqlDataReader obtenerDatos = null;

            string buscarCliente = "SELECT id_Cliente, nombre, apellidos " +
                                   "FROM cliente " +
                                   "WHERE nit = " + cliente.NIT;

            /*
            SELECT id_Cliente, nombre, apellidos, nit
            FROM cliente
            WHERE nit = 99999999;
             * */

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexionBD;
                cmd.CommandText = buscarCliente;
                obtenerDatos = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error en la consulta" + ex.Message);
            }
            return obtenerDatos;
        }
        //PARA VERIFICAR SI TIENE CARNET Y NIT CON SU CARNET
        public MySqlDataReader BuscarCARNET_CARNETNIT(Cliente cliente)
        {
            BDConexion cn = new BDConexion();
            conexionBD = cn.ObtenerConexion();
            MySqlDataReader obtenerDatos = null;

            string buscarCliente = "SELECT id_Cliente, nombre, apellidos, carnet, nit " +
                                   "FROM cliente " +
                                   "WHERE carnet = " + cliente.Carnet;

            /*
            SELECT id_Cliente, nombre, apellidos, carnet, nit 
            FROM cliente
            WHERE nit = 99999999;
             * */

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexionBD;
                cmd.CommandText = buscarCliente;
                obtenerDatos = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error en la consulta" + ex.Message);
            }
            return obtenerDatos;
        }
        //PARA VERIFICAR SI TIENE CARNET Y NIT CON SU nit
        public MySqlDataReader BuscarNIT_CARNET(Cliente cliente)
        {
            BDConexion cn = new BDConexion();
            conexionBD = cn.ObtenerConexion();
            MySqlDataReader obtenerDatos = null;

            string buscarCliente = "SELECT id_Cliente, nombre, apellidos, carnet, nit" +
                                   "FROM cliente " +
                                   "WHERE nit = " + cliente.NIT;

            /*
            SELECT id_Cliente, nombre, apellidos, carnet, nit 
            FROM cliente
            WHERE nit = 99999999;
             * */

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexionBD;
                cmd.CommandText = buscarCliente;
                obtenerDatos = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error en la consulta" + ex.Message);
            }
            return obtenerDatos;
        }
        //PARA verificar si tiene carnet  o NIT con su numero de carnet
        public MySqlDataReader VerificarCarnet(Cliente cliente)
        {
            BDConexion cn = new BDConexion();
            conexionBD = cn.ObtenerConexion();
            MySqlDataReader obtenerDatos = null;

            string buscarCliente = "SELECT tieneCarnet, tieneNIT " +
                                   "FROM cliente " +
                                   "WHERE carnet = " + cliente.Carnet;

            /*
            SELECT tieneCarnet, tieneNIT
            FROM cliente
            WHERE nit = 99999999;
             * */

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexionBD;
                cmd.CommandText = buscarCliente;
                obtenerDatos = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error en la consulta" + ex.Message);
            }
            return obtenerDatos;
        }
        //para verificar si tiene carnet O NIT con su nuemro de nit
        public MySqlDataReader VerificarNIT(Cliente cliente)
        {
            BDConexion cn = new BDConexion();
            conexionBD = cn.ObtenerConexion();
            MySqlDataReader obtenerDatos = null;

            string buscarCliente = "SELECT tieneCarnet, tieneNIT " +
                                   "FROM cliente " +
                                   "WHERE nit = " + cliente.NIT;

            /*
            SELECT tieneCarnet, tieneNIT
            FROM cliente
            WHERE nit = 99999999;
             * */

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexionBD;
                cmd.CommandText = buscarCliente;
                obtenerDatos = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error en la consulta" + ex.Message);
            }
            return obtenerDatos;
        }
        //PARA VER LAS LISTA DE PEDIDOS QUE SE REALIZARON
        public DataTable MostrarClientes()
        {
            DataTable Datos = new DataTable();
            BDConexion cn = new BDConexion();
            MySqlDataAdapter datosObtenidos = new MySqlDataAdapter();
            conexionBD = cn.ObtenerConexion();

            string consultaListaPedidos = "SELECT nombre as NOMBRE, apellidos as APELLIDOS, carnet as CARNET, nit as NIT     FROM cliente";

            /*[CONSULTA]
             SELECT nombre as NOMBRE, apellidos as APELLIDOS, carnet as CARNET, nit as NIT
             FROM cliente;
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
    }
}
