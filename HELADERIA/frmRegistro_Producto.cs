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
    public partial class frmRegistro_Producto : Form
    {
        bool nombre = false, precio = false, validarNombre = false, activo = false;
        int tipoProducto;
        string ubicacion;
        //Instanciamos a la clase Producto para verificar que el producto no exista
        Producto producto = new Producto();
        //Instanciamos a la clase GestionarProducto para la buscqueda del prodcuto
        GestionarProducto buscarProducto = new GestionarProducto();

        public frmRegistro_Producto()
        {
            InitializeComponent();
            CargarProductos();
        }

        public void CargarProductos()
        {
            GestionarProducto mostrarProductos = new GestionarProducto();
            tblProductos.DataSource = mostrarProductos.MostrarProductos();
            tblProductos.Refresh();
            tblProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            //Le pasamos en nombre a verficar
            producto.Nombre = txtNombre.Text;
            //Instaciamos a metodo de Busque a travez de la clase Gestionar Producto
            MySqlDataReader obtenerProducto = buscarProducto.BuscarProducto(producto);
            //Validamos el campo txtnombre y si nuestra busqueda tiene datos como resultado
            if (obtenerProducto.HasRows && txtNombre.Text != null)
            {
                while (obtenerProducto.Read())
                {
                    //le datos el nombre obtenido a una variable auxiliar
                    string nombre = obtenerProducto.GetString(0);
                    //Comparamos si el nombre ya existe
                    if (producto.Nombre != nombre)
                    {
                        validarNombre = true;                        
                    }
                    else
                    {
                        MessageBox.Show("El nombre del producto ya se encuentra registrado", "Error en el Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        validarNombre = false;
                        txtNombre.Text = null;
                    }
                }
            }
            else
            {
                validarNombre = false;
            }
            obtenerProducto.Close();
            return;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se perimite letras", "Advetencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nombre = false;
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
                nombre = true;
            }
            return;
        }

        private void cboxTipoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxTipoProducto.SelectedItem.ToString() == "Helado")
            {
                tipoProducto = 1;
            }
            else if(cboxTipoProducto.SelectedItem.ToString() == "Plato de Comida")
            {
                tipoProducto = 2;
            }
            else if (cboxTipoProducto.SelectedItem.ToString() == "Bebida")
            {
                tipoProducto = 3;
            }
            else if (cboxTipoProducto.SelectedItem.ToString() == "Postre")
            {
                tipoProducto = 4;
            }
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }

            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < txtPrecio.Text.Length; i++)
            {
                if (txtPrecio.Text[i] == '.')
                    IsDec = true;

                if (IsDec && nroDec ++ >= 2)
                {
                    e.Handled = true;
                    return;
                }
            }

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                precio = true;
                e.Handled = false;
            }
            else if (e.KeyChar == 46)
            {
                precio = true;
                e.Handled = (IsDec) ? true : false;
            }
            else
            {
                MessageBox.Show("Solo se perimite números con dos decimales", "Advetencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                precio = false;
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxActivo.SelectedItem.ToString() == "SI")
            {
                activo = true;
            }
            else
            {
                activo = false;
            }
        }

        private void btnBuscarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();

            abrir.Title = "Abrir";
            abrir.Filter = "Archivo JPG|*.jpg";

            if (abrir.ShowDialog() == DialogResult.OK)
            {
                 pictureImagen.Image = Image.FromFile(abrir.FileName);
                 ubicacion = abrir.FileName;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (nombre == true && precio == true)
            {
                Producto producto = new Producto();
                producto.Nombre = txtNombre.Text;
                producto.Id_TipoProducto = tipoProducto;
                producto.Precio = txtPrecio.Text;
                producto.Descripcion = txtDescripcion.Text;
                producto.Imagen = ubicacion;
                producto.Activo = activo;

                //int resultado = 2;
                int resultado = GestionarProducto.Agregar(producto);
                //MessageBox.Show(producto.Precio.ToString());
                if (resultado > 0)
                {
                    MessageBox.Show("El Producto se registro exitosamente!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se logro registrar el Producto", "Error en el registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("No se lleno correctamento los campos requeridos", "Error en el registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CargarProductos();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmHome frm = new frmHome();
            frm.Show();
            this.Hide();
        }
    }
}
