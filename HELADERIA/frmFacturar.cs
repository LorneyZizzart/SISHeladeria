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
    public partial class frmFacturar : Form
    {
        Cliente cliente = new Cliente();
        Empleado usuario = new Empleado();
        ListaPedidos lista = new ListaPedidos();
        GestionarCliente buscarCliente = new GestionarCliente();
        int idCliente, idListaPedido;
        int posicion;

        public frmFacturar()
        {
            InitializeComponent();
            CargarListaPedidos();
            CargarFacturas();
        }

        public void CargarListaPedidos()
        {
            GestionarPedido mostrarListaPedido = new GestionarPedido();
            tblListaPedidos.DataSource = mostrarListaPedido.MostrarListaPedidos();
            tblListaPedidos.Refresh();
        }

        public void CargarFacturas()
        {
            GestionarPedido mostrarFacturas = new GestionarPedido();
            tblFacturas.DataSource = mostrarFacturas.MostrarFacturas();
            tblFacturas.Refresh();
        }

        private void txtCarnet_TextChanged(object sender, EventArgs e)
        {
            cliente.Carnet = Convert.ToInt32(txtCarnet.Text);
            MySqlDataReader obtenerCLiente = buscarCliente.BuscarCarnet(cliente);

            if (obtenerCLiente.HasRows && txtCarnet.Text != null)
            {
                while (obtenerCLiente.Read())
                {
                    idCliente = Convert.ToInt32(obtenerCLiente.GetString(0));
                    txtNombre.Text = obtenerCLiente.GetString(1);
                    txtApellidoPaterno.Text = obtenerCLiente.GetString(2);
                    txtApellidoMaterno.Text = obtenerCLiente.GetString(3);
                    txtCarnet.Text = obtenerCLiente.GetString(4);
                    QRcodeFacturas.Text = txtNombre.Text;
                    txtNombre.Text = QRcodeFacturas.Text;
                }
            }
        }

        private void tblListaPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = tblListaPedidos.CurrentRow.Index;
            idListaPedido = (int)tblListaPedidos[0, posicion].Value;
            txtCancelar.Text = tblListaPedidos[4, posicion].Value.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtCarnet.Text != null)
            {
                usuario.Id_Employees = 3;
                cliente.Id_Cliente = idCliente;
                lista.Id_ListaPedido = idListaPedido;
                string fecha = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day;

                int resultado = GestionarPedido.AgregarFactura(usuario, cliente, lista, txtCancelar.Text, fecha);
                if (resultado > 0)
                {
                    MessageBox.Show("La Facturación se ralizo exitosamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se logro guardar la facturación", "Error al registrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            CargarFacturas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPedidos frm = new frmPedidos();
            frm.Show();
            this.Hide();
        }

        private void btnBuscarPedido_Click(object sender, EventArgs e)
        {
            if (txtBuscarPedido.Text != "")
            {
                GestionarPedido buscar = new GestionarPedido();
                tblListaPedidos.DataSource = buscar.BuscarPedidos(Convert.ToInt32(txtBuscarPedido.Text));
                tblListaPedidos.Refresh();  
            }
            else
            {
                CargarListaPedidos();
            }

        }

        private void rdoPaMesa_CheckedChanged(object sender, EventArgs e)
        {
            GestionarPedido buscar = new GestionarPedido();
            tblListaPedidos.DataSource = buscar.BuscarTipoPedido("Sucursal");
            tblListaPedidos.Refresh();  
        }

        private void rdoPaLlevar_CheckedChanged(object sender, EventArgs e)
        {
            GestionarPedido buscar = new GestionarPedido();
            tblListaPedidos.DataSource = buscar.BuscarTipoPedido("Para llevar");
            tblListaPedidos.Refresh();  
        }

        private void rdoDomicilio_CheckedChanged(object sender, EventArgs e)
        {
            CargarListaPedidos();
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            frmFacturas frm = new frmFacturas();
            frm.Show();
            this.Hide();
        }
    }
}
