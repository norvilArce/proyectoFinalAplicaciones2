using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Win_Hunde;

namespace Win_Hubde
{
    public partial class MDIPrincipal : Form
    {
        DateTime horaentrada = new DateTime();

        public MDIPrincipal()
        {
            InitializeComponent();
        }

        private void MDIPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MDIPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Esta a punto de salir de la aplicacion ¿Desea Continuar?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = "Menu Principal - Veterinaria Hunde - " + DateTime.Now.ToString();
            lblHora.Text = "Tiempo de sesion : " + DateTime.Now.Subtract(horaentrada).ToString().Substring(0,8);
        }

        private void MDIPrincipal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = clsCredenciales.Usuario;
            horaentrada = DateTime.Now;
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmpleadoLista empleadoLista = new EmpleadoLista();
            empleadoLista.MdiParent = this;
            empleadoLista.Show();
        }

        private void pacientesPorFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pacienteFechas pacienteFecha = new pacienteFechas();
            pacienteFecha.MdiParent = this;
            pacienteFecha.Show();
        }

        private void buscarPorCodigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            medicinasPorProveedor proveedorConsulta = new medicinasPorProveedor();
            proveedorConsulta.MdiParent = this;
            proveedorConsulta.Show();
        }

        private void pacientesPorRazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PacientePorRaza pacientePorRaza = new PacientePorRaza();
            pacientePorRaza.MdiParent = this;
            pacientePorRaza.Show();
        }

        private void porMascotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MedicosFecha medicosFecha = new MedicosFecha();
            medicosFecha.MdiParent = this;
            medicosFecha.Show();
        }

        private void medicinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProveedorMedicinas proveedorMedicinas = new ProveedorMedicinas();
            proveedorMedicinas.MdiParent = this;
            proveedorMedicinas.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.MdiParent = this;
            clientes.Show();
        }

        private void porMedicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pacienteFechas pacienteFechas = new pacienteFechas();
            pacienteFechas.MdiParent = this;
            pacienteFechas.Show();
        }

        private void pacientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Pacientes pacientes = new Pacientes();
            pacientes.MdiParent = this;
            pacientes.Show();
        }
    }
}