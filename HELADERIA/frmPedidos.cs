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
    public partial class frmPedidos : Form
    {
        int posicion, id_Producto, id_Usuario,
            //variable auxiliar para obtener el numero de pedido que sigue
            codigoPedido,
            //Creamos una variable auxiliar para el tipo de pedido
            tipoPedido;
        bool cantidad = false;
        ListaPedidos lista = new ListaPedidos();
        GestionarProducto gtrProducto = new GestionarProducto();

        GestionarPedido datosPedido = new GestionarPedido();

        Producto producto = new Producto();
        Usuario usuario = new Usuario();
        Pedido pedido = new Pedido();

        public frmPedidos()
        {
            InitializeComponent();
            CargarNumeroPedido();
            CargarProductos();
            CargarMeseros();
            CargarListaPedidos();
            CargarTipoProducto();
            CargarPedido();
        }
        public void CargarTipoProducto()
        {
            cboxTipoProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxTipoProducto.DataSource = gtrProducto.TipoProductos();
            cboxTipoProducto.DisplayMember = "nombreProducto";
        }
        public void CargarListaPedidos()
        {
            GestionarPedido mostrarListaPedidos = new GestionarPedido();
            tblListaDePedidos.DataSource = mostrarListaPedidos.MostrarListaPedidos();
            tblListaDePedidos.Refresh();
            tblListaDePedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void CargarProductos() 
        {
            GestionarProducto mostrarProductos = new GestionarProducto();
            tblProducto.DataSource = mostrarProductos.MostrarProductosEnVenta();
            tblProducto.Refresh();
            tblProducto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        //Para mostrar todos los pedidos depende al numero de pedido
        public void CargarPedido()
        {
            GestionarPedido mostrarPedidos = new GestionarPedido();
            //
            pedido.NumeroPedido = lblNumeroPedido.Text;
            tblLista_Pedidos.DataSource = mostrarPedidos.MostrarPedido(pedido);
            tblLista_Pedidos.Refresh();
        }

        //Para mostrar todos los meseros en una tabla
        public void CargarMeseros()
        {
            //Mostrar todos los meseros en una tabla
            tblUsuarios.DataSource = usuario.MostrarTipoUsuarios("Mesero");
            //refrescar la Tabla de Meseros
            tblUsuarios.Refresh();
            tblUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        //Para recibir el numero de Peiddo automaticamente
        public void CargarNumeroPedido()
        {
            //Para obtenerIdPedido
            GestionarPedido datosObtenido = new GestionarPedido();
            //consultar el ultimo numero de pedido
            MySqlDataReader obtenerNumeroPedido = datosObtenido.ObtenerNumeroPedido();
            //Mostrar los datos obtenidos
            if (obtenerNumeroPedido.HasRows)
            {
                //Leer los datos obtenidos
                while (obtenerNumeroPedido.Read())
                {
                    //declaramos una variable donde se obtendra el ultimo numero de pedido
                    int numeroPedido = Convert.ToInt32(obtenerNumeroPedido.GetInt32(0));
                    //Para mostrar o registrar un nuevo pedido lo incrementamos
                    numeroPedido++;
                    //Mostrar en el lblNumeroPedido el numero de pedido
                    lblNumeroPedido.Text = numeroPedido.ToString();
                    //Para obtener el numero de Pedido para luego hacer una busqueda del Pedido siguiente
                    codigoPedido = numeroPedido;
                }
            }
        }

        private void tblProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = tblProducto.CurrentRow.Index;
            int codigoProducto = (int)tblProducto[0, posicion].Value;
            producto.Id_Producto = codigoProducto;
            MySqlDataReader obtenerProducto = gtrProducto.ObtenerProducto(producto);

            if (obtenerProducto.HasRows)
            {
                while (obtenerProducto.Read())
                {
                    id_Producto = Convert.ToInt32(obtenerProducto.GetString(0));
                    lblTipo_Producto.Text = obtenerProducto.GetString(1);
                    lblNombre_Producto.Text = obtenerProducto.GetString(2);
                    lblPrecio_Producto.Text = obtenerProducto.GetString(3);
                    txtCantidad.Text = null;
                }
                obtenerProducto.Close();
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void tblUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = tblUsuarios.CurrentRow.Index;
            id_Usuario = (int)tblUsuarios[0, posicion].Value;
        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            int valorAgregado;
            valorAgregado = Convert.ToInt32(lblNumero_Mesa.Text);

            if (valorAgregado > 1)
            {
                valorAgregado--;
                
            }

            lblNumero_Mesa.Text = valorAgregado.ToString();
        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            int valorAgregado;
            valorAgregado = Convert.ToInt32(lblNumero_Mesa.Text);

            if (valorAgregado  < 20)
            {
                valorAgregado++;

            }

            lblNumero_Mesa.Text = valorAgregado.ToString();
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se perimite Numeros", "Advetencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cantidad = false;
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
                cantidad = true;
            }
            return;
        }

        private void cboxTipoPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxTipoPedido.SelectedItem.ToString() == "Para la mesa")
            {
                tipoPedido = 1;
                lblNumero_Mesa.Text = "1";
                groupBoxMeseros.Text = "MESERO EN SERVICIO";
                //Mostrar todos los meseros en una tabla
                tblUsuarios.DataSource = usuario.MostrarTipoUsuarios("Mesero");
                //refrescar la Tabla de Meseros
                tblUsuarios.Refresh();
                id_Usuario = (int)tblUsuarios[0, posicion].Value;
            }
            else if (cboxTipoPedido.SelectedItem.ToString() == "A domicilio")
            {
                tipoPedido = 2;
                lblNumero_Mesa.Text = null;
                groupBoxMeseros.Text = "RECEPCIONISTAS EN SERVICIO";
                //Mostrar todos los meseros en una tabla
                tblUsuarios.DataSource = usuario.MostrarTipoUsuarios("Recepcionista");
                //refrescar la Tabla de Meseros
                tblUsuarios.Refresh();
                id_Usuario = (int)tblUsuarios[0, posicion].Value;
            }
            else if (cboxTipoPedido.SelectedItem.ToString() == "Para llevar")
            {
                tipoPedido = 3;
                lblNumero_Mesa.Text = null;
                id_Usuario = 3;
                groupBoxMeseros.Text = "CAJERO EN SERVICIO";
                //Mostrar todos los meseros en una tabla
                tblUsuarios.DataSource = usuario.MostrarTipoUsuarios("Cajero");
                //refrescar la Tabla de Meseros
                tblUsuarios.Refresh();
            }
            CargarProductos();
            tblUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(DateTime.Now.Year + " " + DateTime.Now.Month + " " + DateTime.Now.Day + " " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second);
            Pedido pedido = new Pedido();

            if (cantidad == true)
            {
                pedido.Id_Producto = id_Producto;
                pedido.NumeroPedido = lblNumeroPedido.Text;
                //Para validar el tipo de Pedido
                if (lblNumero_Mesa.Text != "")
                {
                    pedido.Mesa = Convert.ToInt32(lblNumero_Mesa.Text);                    
                }
                else
                {
                    pedido.Mesa = Convert.ToInt32(null);
                }

                pedido.Cantidad = Convert.ToInt32(txtCantidad.Text);
                pedido.FechaHora = Convert.ToString(DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day+" "+DateTime.Now.Hour+":"+DateTime.Now.Minute+":"+DateTime.Now.Second);
                //MessageBox.Show(pedido.Id_Producto.ToString());
                int resultado = GestionarPedido.Agregar(pedido, tipoPedido);
                //Multiplicaon la cantidad de pedido del producto por el precio
                double mul = double.Parse(txtCantidad.Text) * double.Parse(lblPrecio_Producto.Text.Replace(".", ","));
                //DONDE SUMAMOS EL TOTAL A CANCELAR
                double pagar = mul + double.Parse(lblPrecioTotal.Text);
                lblPrecioTotal.Text = pagar.ToString();
            }
            CargarPedido();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cantidad == true)
            {
                //PARA OBTENER los id_Pedido de los que sta en la LISTA DE PEDIDOS
                //Asignamos mediante el numero de pedido  los id_Pedido a buscar
                pedido.NumeroPedido = lblNumeroPedido.Text;

                //Instanciamos a la clase GestionarPedido para utilizar el metodo de busqueda de los ultimos pedidos
                MySqlDataReader obtenerIds = datosPedido.ObtenerUltimoNumeroPedido(pedido);
                if (obtenerIds.HasRows)
                {
                    while (obtenerIds.Read())
                    {
                        pedido.NumeroPedido = obtenerIds.GetString(0);
                    }
                }

                if (tblLista_Pedidos.DataSource != null)
                {
                    lista.Id_TipoPedido = tipoPedido;
                    lista.Id_Pedido = Convert.ToInt32(pedido.NumeroPedido);
                    lista.Id_Usuario = id_Usuario;
                    lista.PagoTotal = lblPrecioTotal.Text;
                    lista.Pendiente = true;

                    int resultado = GestionarPedido.AgregarListaPedidos(lista);

                    if (resultado > 0)
                    {
                        MessageBox.Show("El PEDIDO se realizo exitosamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se logro registrar el PEDIDO", "Error al registrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                CargarListaPedidos();
                btnListar.Enabled = false;
            }
        }

        private void tblLista_Pedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNuevoPedido_Click(object sender, EventArgs e)
        {
            CargarNumeroPedido();
            CargarPedido();
            txtCantidad.Text = null;
            lblPrecioTotal.Text = "0";
            btnListar.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmFacturas frm = new frmFacturas();
            frm.Show();
            this.Hide();
        }

        private void frmPedidos_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmHome frm = new frmHome();
            frm.Show();
            this.Hide();
        }

        private void cboxTipoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            tblProducto.DataSource = gtrProducto.MostrarProductos(cboxTipoProducto.Text);
            tblProducto.Refresh();
        }

        private void tblProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
