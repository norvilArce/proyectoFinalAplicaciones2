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
    public partial class MedicosFecha : Form
    {
        public MedicosFecha()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                ProxyEmpleado.ServicioEmpleadoClient servicioEmpleado = new ProxyEmpleado.ServicioEmpleadoClient();
                ProxyEmpleado.Empleado empleado = new ProxyEmpleado.Empleado();

                ProxyConsulta.ServicioConsultaClient consultasClient = new ProxyConsulta.ServicioConsultaClient();

                empleado = servicioEmpleado.ConsultarEmpleado(txtCod.Text.Trim());

                lblNom.Text = empleado.nom_emp + ' ' + empleado.ape_emp;
                lblRol.Text = empleado.rol;
                lblSueldo.Text = empleado.sueldo.ToString();
                lblDireccion.Text = empleado.dir_emp;
                lblSupervisor.Text = servicioEmpleado.ConsultarEmpleado(empleado.cod_supervisor).nom_emp + ' ' + servicioEmpleado.ConsultarEmpleado(empleado.cod_supervisor).ape_emp;
                lblEmail.Text = empleado.email_emp;

                dtgConsultas.AutoGenerateColumns = false;
                dtgConsultas.DataSource = consultasClient.ConsultasPorMedicoEntreFechas(txtCod.Text, dtpFI.Value.Date, dtpFF.Value.Date);
                lblRegistros.Text = dtgConsultas.Rows.Count.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Consultas_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
