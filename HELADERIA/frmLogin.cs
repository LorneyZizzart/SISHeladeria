using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HELADERIA
{
    public partial class frmLogin : Form
    {
        bool userValido = false, passwordValido = false;
        Usuario usuario = new Usuario();
        Empleado empleado = new Empleado();
        int tipoUsuario = 0;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

            empleado.User = txtUser.Text;

            MySqlDataReader obtenerUsuario = usuario.VerificarUsuario(empleado);

            if (obtenerUsuario.HasRows && txtUser.Text != null)
            {
                while (obtenerUsuario.Read())
                {
                    pictureUser.Image = Image.FromFile(@"F:\6 Semestre\1.- Analisis y  Diseño II\1.- Tareas\HELADERIA\HELADERIA\img\Bien.ico");
                    pictureUser.SizeMode = PictureBoxSizeMode.CenterImage;
                    userValido = true;
                }
            }
            else
            {
                pictureUser.Image = Image.FromFile(@"F:\6 Semestre\1.- Analisis y  Diseño II\1.- Tareas\HELADERIA\HELADERIA\img\Error.ico");
                pictureUser.SizeMode = PictureBoxSizeMode.CenterImage;
                userValido = false;
            }
            obtenerUsuario.Close();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            empleado.Password = txtPassword.Text;
            MySqlDataReader obternerPassword = usuario.VerificarUsuario(empleado);

            if (obternerPassword.HasRows && txtPassword.Text != null)
            {
                while (obternerPassword.Read())
                {
                    tipoUsuario = Convert.ToInt32(obternerPassword.GetString(2));
                    string name = obternerPassword.GetString(3);
                    string pass = obternerPassword.GetString(4);


                    if (empleado.User == name && empleado.Password == pass)
                    {
                        picturePassword.Image = Image.FromFile(@"F:\6 Semestre\1.- Analisis y  Diseño II\1.- Tareas\HELADERIA\HELADERIA\img\Bien.ico");
                        picturePassword.SizeMode = PictureBoxSizeMode.CenterImage;
                        passwordValido = true;
                    }
                    else
                    {
                        picturePassword.Image = Image.FromFile(@"F:\6 Semestre\1.- Analisis y  Diseño II\1.- Tareas\HELADERIA\HELADERIA\img\Error.ico");
                        picturePassword.SizeMode = PictureBoxSizeMode.CenterImage;
                        passwordValido = false;
                    }
                }
            }
            else
            {
                picturePassword.Image = Image.FromFile(@"F:\6 Semestre\1.- Analisis y  Diseño II\1.- Tareas\HELADERIA\HELADERIA\img\Error.ico");
                picturePassword.SizeMode = PictureBoxSizeMode.CenterImage;
                passwordValido = false;
            }
            obternerPassword.Close();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (userValido == true && passwordValido == true && tipoUsuario == 1)
            {
                frmHome frm = new frmHome();
                frm.Show();
                this.Hide();
            }
            else if (userValido == true && passwordValido == true && tipoUsuario == 2)
            {
                frmPedidos frm = new frmPedidos();
                frm.Show();
                this.Hide();
            }
            else if (userValido == true && passwordValido == true && tipoUsuario == 3)
            {
                frmFacturar frm = new frmFacturar();
                frm.Show();
                this.Hide();
            }
            else if (userValido == true && passwordValido == true && tipoUsuario == 4)
            {
                frmPedidos frm = new frmPedidos();
                frm.Show();
                this.Hide();
            }
            else
            {
                if (txtUser.Text == "" && txtPassword.Text == "")
                {
                    MessageBox.Show("Debe ser llenado los campos requerido");
                }
                else
                    MessageBox.Show("Usuario Invalido");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
