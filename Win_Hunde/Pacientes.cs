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
    public partial class Pacientes : Form
    {
        ProxyPaciente.ServicioPacienteClient servicioPaciente = new ProxyPaciente.ServicioPacienteClient();
        public Pacientes()
        {
            InitializeComponent();
        }

        private void Pacientes_Load(object sender, EventArgs e)
        {
            try
            {
                dtgPaciente.AutoGenerateColumns = false;
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void CargarDatos()
        {

            dtgPaciente.DataSource = servicioPaciente.ListarPacientes();
            lblRegClientes.Text = dtgPaciente.Rows.Count.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                PacienteAgregar pacienteAgregar = new PacienteAgregar();
                pacienteAgregar.ShowDialog();
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
                PacienteActualizar pacienteActualizar = new PacienteActualizar();
                String strCodigo = dtgPaciente.CurrentRow.Cells[0].Value.ToString();
                pacienteActualizar.Codigo = strCodigo;
                pacienteActualizar.ShowDialog();
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
    }
}
