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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
            CargarRegistroCliente();
        }

        private void CargarRegistroCliente()
        {
            GestionarCliente gtr = new GestionarCliente();

            dataGridView1.DataSource = gtr.MostrarClientes();
            dataGridView1.Refresh();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmHome frm = new frmHome();
            frm.Show();
            this.Hide();
        }
    }
}
