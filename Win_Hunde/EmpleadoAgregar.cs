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
    public partial class EmpleadoAgregar : Form
    {
        ProxyEmpleado.ServicioEmpleadoClient empleadoClient = new ProxyEmpleado.ServicioEmpleadoClient();
        ProxyRol.ServicioRolClient rolClient = new ProxyRol.ServicioRolClient();
        ProxyUbigeo.ServicioUbigeoClient ubigeoClient = new ProxyUbigeo.ServicioUbigeoClient();
        ProxyEmpleado.Empleado empleado = new ProxyEmpleado.Empleado();
        public EmpleadoAgregar()
        {
            InitializeComponent();
        }

        private void EmpleadoAgregar_Load(object sender, EventArgs e)
        {
            try
            {
                cargarSupervisores();
                cargarRoles();
                cargarUbigeo("14", "01", "01");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido el error: " + ex.Message);
            }
        }

        private void cargarSupervisores()
        {
            cbSup.DataSource = empleadoClient.ListarSupervisores();
            cbSup.ValueMember = "cod_emp";
            cbSup.DisplayMember = "nom_ape";
        }
        private void cargarRoles() 
        { 
            cboRoles.DataSource = rolClient.listarRoles();
            cboRoles.ValueMember = "cod_rol";
            cboRoles.DisplayMember = "nom_rol";
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

                empleado.nom_emp = txtNom.Text.Trim();
                empleado.ape_emp = txtApe.Text.Trim();
                empleado.sueldo = Convert.ToInt16(txtSueldo.Text);
                empleado.id_ubigeo = cbDepa.SelectedValue.ToString()
                    + cbProv.SelectedValue.ToString()
                    + cbDist.SelectedValue.ToString();
                empleado.dir_emp = txtDir.Text.Trim();
                empleado.fecha_ingreso = dtpFecIng.Value;
                empleado.email_emp = txtEmail.Text.Trim();
                empleado.cod_rol = Convert.ToInt16(cboRoles.SelectedValue);
                empleado.cod_supervisor = cbSup.SelectedValue.ToString();
                empleado.estado_emp = Convert.ToBoolean(chkActivo.Checked);
                empleado.us_ureg_emp = clsCredenciales.Usuario;
                empleado.tipo_emp= Convert.ToInt16(optSup.Checked ? 1 : 2);

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