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
    public partial class EmpleadoLista : Form
    {
        ProxyEmpleado.ServicioEmpleadoClient empleadoClient = new ProxyEmpleado.ServicioEmpleadoClient();
        public EmpleadoLista()
        {
            InitializeComponent();
        }

        private void EmpleadoLista_Load(object sender, EventArgs e)
        {
            try
            {
                dtgEmpleado.AutoGenerateColumns = false;
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void CargarDatos()
        {
            dtgEmpleado.DataSource = empleadoClient.ListarEmpleados();
            lblRegistros.Text = dtgEmpleado.Rows.Count.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                EmpleadoAgregar empleadoAgregar = new EmpleadoAgregar();
                empleadoAgregar.ShowDialog();
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
                EmpleadoActualizar empleadoActualizar = new EmpleadoActualizar();

                String strCodigo = dtgEmpleado.CurrentRow.Cells[0].Value.ToString();
                empleadoActualizar.Codigo = strCodigo;
                empleadoActualizar.ShowDialog();
                // Refrescamos la vista en memoria y cargamos los datos
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
