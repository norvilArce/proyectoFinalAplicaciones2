using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Hunde
{
    public partial class pacienteFechas : Form
    {
        public pacienteFechas()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            
            try
            {
                ProxyPaciente.ServicioPacienteClient servicioPaciente = new ProxyPaciente.ServicioPacienteClient();
                ProxyConsulta.ServicioConsultaClient servicesConsultas = new ProxyConsulta.ServicioConsultaClient();
                ProxyPaciente.PacienteBE paciente = new ProxyPaciente.PacienteBE();

                paciente = servicioPaciente.ConsultarPacientes(txtCodigoPaciente.Text.Trim());

                txtNombre.Text = paciente.nom_pac;
                txtTipo.Text = paciente.tipo;
                txtRaza.Text = paciente.raza;
                txtFec_nac.Text = paciente.fec_nac_pac.ToString().Substring(0, 10);
                txtColor.Text = paciente.color;
                txtPeso.Text = paciente.peso.ToString();
                txtUlt_vis.Text = paciente.ult_vis_pac.ToString().Substring(0, 10);
                txtObservacion.Text= paciente.observaciones;

                MemoryStream fotoStream = new MemoryStream(paciente.foto);
                pbFoto.Image = Image.FromStream(fotoStream);

                Int16 sexo = Convert.ToInt16(paciente.sexo);
                if (sexo == 1)
                {
                    txtSexo.Text = "Macho";
                }
                else if (sexo == 2) 
                {
                    txtSexo.Text = "Hembra";
                }
                else
                {
                    txtSexo.Text = "No sabe no opina";
                }

                dtgConsultas.AutoGenerateColumns = false;
                dtgConsultas.DataSource = servicesConsultas.ConsultasPorMascotaEntreFechas(txtCodigoPaciente.Text.Trim(), dtpFI.Value.Date, dtpFF.Value.Date);
                lblRegistros.Text = dtgConsultas.Rows.Count.ToString();
            }
            catch (Exception ex)

            {
                MessageBox.Show("Error:" + ex.Message);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pacienteFechas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnConsultar.PerformClick();
            }
        }
    }
}
