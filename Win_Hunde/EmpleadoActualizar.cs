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
    public partial class EmpleadoActualizar : Form
    {
        ProxyEmpleado.ServicioEmpleadoClient empleadoClient = new ProxyEmpleado.ServicioEmpleadoClient();
        ProxyEmpleado.Empleado empleado = new ProxyEmpleado.Empleado();

        private String _Codigo;
        public String Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }

        }

        public EmpleadoActualizar()
        {
            InitializeComponent();
        }

        private void EmpleadoActualizar_Load(object sender, EventArgs e)
        {
            try
            {

                // Mostramos los datos del vendedor a consultar en base al codigo del vendedor seleccionado
                empleado = empleadoClient.ConsultarEmpleado(Codigo);
                lblCodigo.Text = Codigo;
                txtNom.Text = empleado.nom_empleado;
                txtApe.Text = empleado.ape_empleado;
                txtSueldo.Text = empleado.sueldo.ToString();
                dtpFecIng.Value = empleado.fecha_ingreso;
                cboRoles.SelectedIndex = empleado.rol_emp;
                txtEmail.Text = empleado.email_emp;
                txtSup.Text = empleado.cod_supervisor;
                chkActivo.Checked = empleado.estado_emp;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
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

                empleado.cod_emp = Codigo;                            
                empleado.nom_empleado = txtNom.Text.Trim();
                empleado.ape_empleado = txtApe.Text.Trim();
                empleado.sueldo = Convert.ToInt16(txtSueldo.Text);
                empleado.fecha_ingreso = dtpFecIng.Value;
                empleado.email_emp = txtEmail.Text.Trim();
                empleado.rol_emp = Convert.ToInt16(cboRoles.SelectedIndex);
                empleado.estado_emp = Convert.ToBoolean(chkActivo.Checked);
                empleado.cod_supervisor = txtSup.Text;

                //por mientras hasta corregir bd y servicios
                empleado.usu_ult_modificacion_emp = "admi";
                empleado.fecha_ult_modificacion_emp = DateTime.Now;

                if (empleadoClient.ActualizarEmpleado(empleado))
                {
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
