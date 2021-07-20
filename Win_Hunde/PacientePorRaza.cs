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
    public partial class PacientePorRaza : Form
    {
        ProxyPaciente.ServicioPacienteClient servicioPaciente = new ProxyPaciente.ServicioPacienteClient();
        ProxyRaza.ServicioRazaClient servicioRaza = new ProxyRaza.ServicioRazaClient();
        public PacientePorRaza()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                dtgPaciente.AutoGenerateColumns = false;
                dtgPaciente.DataSource = servicioPaciente.ConsultarPacientesPorRaza(Convert.ToInt16(cboRazas.SelectedValue));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PacientePorRaza_Load(object sender, EventArgs e)
        {
            try
            {
                cboRazas.DataSource = servicioRaza.listarRazas();
                cboRazas.ValueMember = "cod_raza";
                cboRazas.DisplayMember = "nom_raza";
            }
            catch (Exception ex)
            {
                throw new Exception("Error:" + ex.Message);
            }
        }
    }
}
