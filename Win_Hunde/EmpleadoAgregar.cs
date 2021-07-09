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
    public partial class EmpleadoAgregar : Form
    {
        ProxyEmpleado.ServicioEmpleadoClient empleadoClient = new ProxyEmpleado.ServicioEmpleadoClient();
        ProxyEmpleado.Empleado empleado = new ProxyEmpleado.Empleado();
        public EmpleadoAgregar()
        {
            InitializeComponent();
        }

        private void EmpleadoAgregar_Load(object sender, EventArgs e)
        {
            try
            {
                //cboSupervisor.DataSource = objVendedor.GetAllVendedorSupervisores();
                //cboSupervisor.ValueMember = "cod_ven";
                //cboSupervisor.DisplayMember = "Apell_Nombres";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido el error: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {                                
                if (txtNom.Text == "")
                {
                    throw new Exception("Debe ingresar un nombre");
                }

                if (txtApe.Text == "")
                {
                    throw new Exception("Debe ingresar un apellido");
                }

                
                empleado.nom_empleado = txtNom.Text.Trim();
                empleado.ape_empleado = txtApe.Text.Trim();
                empleado.sueldo = Convert.ToInt16(txtSueldo.Text);
                empleado.fecha_ingreso = dtpFecIng.Value;
                empleado.email_emp = txtEmail.Text.Trim();
                empleado.rol_emp = Convert.ToInt16(cboRoles.SelectedIndex);
                empleado.cod_supervisor = "S" + txtSup.Text;
                empleado.estado_emp =Convert.ToBoolean(chkActivo.Checked);

                // Y tras la asignacion, insertamos el nuevo vendedor empleando el servicio. Codifique
                if (empleadoClient.InsertarEmpleado(empleado))
                {
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido el error: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
