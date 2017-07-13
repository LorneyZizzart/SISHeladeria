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
    class Usuario
    {
        MySqlConnection conexionBD = new MySqlConnection();

        public MySqlDataReader VerificarUsuario(Empleado usuario)
        {
            BDConexion cn = new BDConexion();
            conexionBD = cn.ObtenerConexion();
            MySqlDataReader recuperandoUsuarios = null;

            string consultaUsuario = " SELECT *" +
                                     " FROM usuario" +
                                     " WHERE usuario = '" + usuario.User + "'";

            /*
             SELECT *
             FROM usuarios;
             WHERE usuario = 'Jhonny';
             * */
            
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexionBD;
                cmd.CommandText = consultaUsuario;
                recuperandoUsuarios = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la consulta" + ex.Message);
            }
            return recuperandoUsuarios;
        }

        public DataTable MostrarTipoUsuarios(string tipoUsuario)
        {
            DataTable datos = new DataTable();
            BDConexion cn = new BDConexion();
            conexionBD = cn.ObtenerConexion();
            MySqlDataAdapter datosObtenidos = new MySqlDataAdapter();

            string consultaUsuario = " SELECT u.id_Usuario as CODIGO, tu.tipo as 'TIPO DE USUARIO', concat_ws(' ', e.nombre, e.apellidoPaterno, e.apellidoMaterno ) as 'NOMBRE COMPLETO', u.activo as SERVICIO " +
                                     " FROM usuario u, tipo_usuario tu, empleados e " +
                                     " WHERE u.id_TipoUsuario = tu.id_TipoUsuario" +
                                     " AND tu.tipo = '" + tipoUsuario + "'" +
                                     " AND u.id_Empleado = e.id_Empleado";

            /*
             SELECT u.id_Usuario as CODIGO, tu.tipo as 'TIPO DE USUARIO', concat_ws(' ', e.nombre, e.apellidoPaterno, e.apellidoMaterno ) as 'NOMBRE COMPLETO', u.activo as SERVICIO 
             FROM usuario u, tipo_usuario tu, empleados e
             WHERE u.id_TipoUsuario = tu.id_TipoUsuario 
             AND tu.tipo = 'Mesero'
             AND u.id_Empleado = e.id_Empleado;
             * */

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexionBD;
                cmd.CommandText = consultaUsuario;
                datosObtenidos.SelectCommand = cmd;
                datosObtenidos.Fill(datos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la consulta" + ex.Message);
            }
            return datos;
        }
    }
}
    