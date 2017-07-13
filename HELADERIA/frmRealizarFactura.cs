using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HELADERIA
{
    public partial class frmRealizarFactura : Form
    {
        Cliente cliente = new Cliente();
        //Lo instanciamos la clase para buscar el número de Pedido
        GestionarPedido buscarPedido = new GestionarPedido();
        //Para utilizar los atributos de un Pedido para la busque del número de un pedido
        int idCliente;
        GestionarCliente gtrCliente = new GestionarCliente();
        Pedido pedidos = new Pedido();
        //Para validar total de la compra a que sea mayor a 5 y avilitar el # de factura y cod de control
        bool facturaAvilitada = false;
        public frmRealizarFactura()
        {
            InitializeComponent();
        }

        private void txtCarnet_TextChanged(object sender, EventArgs e)
        {

        }

        private void MostrarDatos_CarnetNIT()
        {
            MySqlDataReader obtenerCLiente = gtrCliente.BuscarCARNET_CARNETNIT(cliente);

            if (obtenerCLiente.HasRows && txtCarnet.Text != null)
            {
                while (obtenerCLiente.Read())
                {
                    idCliente = Convert.ToInt32(obtenerCLiente.GetString(0));
                    txtNombre.Text = obtenerCLiente.GetString(1);
                    txtApellidos.Text = obtenerCLiente.GetString(2);
                    txtNIT.Text = obtenerCLiente.GetString(4);
                }
            }
            else
            {
                VaciarCampos();
                txtNIT.Text = "";
            }
        }

        private void MostrarDatos_Carnet()
        {
            MySqlDataReader obtenerCLiente = gtrCliente.BuscarCarnet(cliente);

            if (obtenerCLiente.HasRows && txtCarnet.Text != null)
            {
                while (obtenerCLiente.Read())
                {
                    idCliente = Convert.ToInt32(obtenerCLiente.GetString(0));
                    txtNombre.Text = obtenerCLiente.GetString(1);
                    txtApellidos.Text = obtenerCLiente.GetString(2);
                }
            }
            else
            {
                VaciarCampos();
                txtNIT.Text = "";
            }
        }

        private void VaciarCampos()
        {
            idCliente = 0;
            txtNombre.Text = "";
            txtApellidos.Text = "";
        }

        private void txtNIT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCarnet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtCarnet.Text != "" && txtCarnet.Text.Length <= 7)
            {
                cliente.Carnet = Convert.ToInt32(txtCarnet.Text);
                MySqlDataReader consultar = gtrCliente.VerificarCarnet(cliente);
                if (consultar.HasRows)
                {
                    while (consultar.Read())
                    {
                        if (consultar.GetBoolean(0) == true && consultar.GetBoolean(1) == false)
                        {
                            MostrarDatos_Carnet();
                        }
                        else if (consultar.GetBoolean(0) == true && consultar.GetBoolean(1) == true)
                        {
                            MostrarDatos_CarnetNIT();
                        }
                    }
                }
            }
            else
            {
                VaciarCampos();
                txtNIT.Text = "";
            }
        }

        private void txtNIT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtNIT.Text != "" && txtNIT.Text.Length <= 8)
            {
                cliente.NIT = Convert.ToInt32(txtNIT.Text);

                MySqlDataReader consultar = gtrCliente.VerificarNIT(cliente);
                if (consultar.HasRows)
                {
                    while (consultar.Read())
                    {
                        if (consultar.GetBoolean(0) == false && consultar.GetBoolean(1) == true)
                        {
                            MySqlDataReader obtenerCLiente = gtrCliente.BuscarNIT_CARNET(cliente);

                              if (obtenerCLiente.HasRows)
                            {
                                while (obtenerCLiente.Read())
                                {
                                    idCliente = Convert.ToInt32(obtenerCLiente.GetString(0));
                                    txtNombre.Text = obtenerCLiente.GetString(1);
                                    txtApellidos.Text = obtenerCLiente.GetString(2);
                                }
                            }
                            else
                            {
                                VaciarCampos();
                                txtCarnet.Text = "";
                            }
                        }
                        else if (consultar.GetBoolean(0) == true && consultar.GetBoolean(1) == true)
                        {
                            MySqlDataReader obtenerCLiente = gtrCliente.BuscarNIT_CARNET(cliente);

                            if (obtenerCLiente.HasRows)
                            {
                                while (obtenerCLiente.Read())
                                {
                                    idCliente = Convert.ToInt32(obtenerCLiente.GetString(0));
                                    txtNombre.Text = obtenerCLiente.GetString(1);
                                    txtApellidos.Text = obtenerCLiente.GetString(2);
                                    txtCarnet.Text = obtenerCLiente.GetString(4);
                                }
                            }
                            else
                            {
                                VaciarCampos();
                                txtCarnet.Text = "";
                            }
                        }
                    }
                }
            }
            else
            {
                VaciarCampos();
            }
        }
    }
}
