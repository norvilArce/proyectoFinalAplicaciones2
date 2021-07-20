using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Win_Hubde;

namespace Win_Hunde
{
    public partial class EmpleadoActualizar : Form
    {
        ProxyEmpleado.ServicioEmpleadoClient empleadoClient = new ProxyEmpleado.ServicioEmpleadoClient();
        ProxyRol.ServicioRolClient rolClient = new ProxyRol.ServicioRolClient();
        ProxyUbigeo.ServicioUbigeoClient ubigeoClient = new ProxyUbigeo.ServicioUbigeoClient();
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
                empleado = empleadoClient.ConsultarEmpleado(Codigo);
                lblCodigo.Text = Codigo;
                txtNom.Text = empleado.nom_emp;
                txtApe.Text = empleado.ape_emp;
                txtSueldo.Text = empleado.sueldo.ToString();
                txtDir.Text = empleado.dir_emp;
                dtpFecIng.Value = empleado.fecha_ingreso;
                txtEmail.Text = empleado.email_emp;

                cargarRoles(empleado.cod_rol);
                cargarSupervisores(empleado.cod_supervisor);
                cargarUbigeo(empleado.id_ubigeo.Substring(0, 2), empleado.id_ubigeo.Substring(2, 2), empleado.id_ubigeo.Substring(4, 2));

                chkActivo.Checked = empleado.estado_emp;

                if (empleado.tipo_emp == 1)
                {
                    optSup.Checked = true;
                    optEmp.Checked = false;
                }
                else
                {
                    optSup.Checked = false;
                    optEmp.Checked = true;
                }

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
                empleado.nom_emp = txtNom.Text.Trim();
                empleado.ape_emp = txtApe.Text.Trim();
                empleado.sueldo = Convert.ToInt16(txtSueldo.Text);
                empleado.fecha_ingreso = dtpFecIng.Value;
                empleado.email_emp = txtEmail.Text.Trim();
                empleado.estado_emp = Convert.ToBoolean(chkActivo.Checked);
                empleado.usu_ult_modificacion_emp = clsCredenciales.Usuario;
                empleado.fecha_ult_modificacion_emp = DateTime.Now;

                empleado.id_ubigeo = cbDepa.SelectedValue.ToString()
                    + cbProv.SelectedValue.ToString()
                    + cbDist.SelectedValue.ToString();
                empleado.dir_emp = txtDir.Text.Trim();
                empleado.fecha_ingreso = dtpFecIng.Value;
                empleado.email_emp = txtEmail.Text.Trim();
                empleado.cod_rol = Convert.ToInt16(cboRoles.SelectedValue);
                empleado.cod_supervisor = cbSup.SelectedValue.ToString();
                empleado.estado_emp = Convert.ToBoolean(chkActivo.Checked);
                empleado.tipo_emp = Convert.ToInt16(optSup.Checked ? 1 : 2);

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
        private void cargarSupervisores(String codSup)
        {
            cbSup.DataSource = empleadoClient.ListarSupervisores();
            cbSup.ValueMember = "cod_emp";
            cbSup.DisplayMember = "nom_ape";
            cbSup.SelectedValue = codSup;
        }
        private void cargarRoles(Int16 codRol)
        {
            cboRoles.DataSource = rolClient.listarRoles();
            cboRoles.ValueMember = "cod_rol";
            cboRoles.DisplayMember = "nom_rol";
            cboRoles.SelectedValue = codRol;
        }

        private void cargarUbigeo(String IdDepa, String IdProv, String IdDist)
        {
            cbDepa.DataSource = ubigeoClient.UbigeoDepartamentos();
            cbDepa.ValueMember = "id_depa";
            cbDepa.DisplayMember = "departamento";
            cbDepa.SelectedValue = IdDepa;

            cbProv.DataSource = ubigeoClient.Ubigeo_ProvinciasDepartamento(IdDepa);
            cbProv.ValueMember = "id_prov";
            cbProv.DisplayMember = "provincia";
            cbProv.SelectedValue = IdProv;

            cbDist.DataSource = ubigeoClient.Ubigeo_DistritosProvinciaDepartamento(IdDepa, IdProv);
            cbDist.ValueMember = "Id_dist";
            cbDist.DisplayMember = "distrito";
            cbDist.SelectedValue = IdDist;
        }

        private void cbDepa_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cargarUbigeo(cbDepa.SelectedValue.ToString(), "01", "01");
        }

        private void cbProv_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cargarUbigeo(cbDepa.SelectedValue.ToString(), cbProv.SelectedValue.ToString(), "01");
        }
    }
}