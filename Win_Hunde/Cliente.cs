using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Hunde
{
    public partial class Clientes : Form
    {
        ProxyCliente.ServicioClienteClient clienteClient = new ProxyCliente.ServicioClienteClient();

        public Clientes()
        {
            InitializeComponent();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            try
            {
                dtgCliente.AutoGenerateColumns = false;
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void CargarDatos()
        {
            dtgCliente.DataSource = clienteClient.ListarClientes();
            lblRegClientes.Text = dtgCliente.Rows.Count.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteAgregar clienteAgregar = new ClienteAgregar();
                clienteAgregar.ShowDialog();
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteActualizar clienteActualizar = new ClienteActualizar();
                String strCodigo = dtgCliente.CurrentRow.Cells[0].Value.ToString();
                clienteActualizar.Codigo = strCodigo;
                clienteActualizar.ShowDialog();
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
