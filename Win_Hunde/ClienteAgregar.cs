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
    public partial class ClienteAgregar : Form
    {
        ProxyCliente.ServicioClienteClient clienteClient = new ProxyCliente.ServicioClienteClient();
        ProxyUbigeo.ServicioUbigeoClient ubigeoClient = new ProxyUbigeo.ServicioUbigeoClient();
        ProxyCliente.ClienteBE clienteBE = new ProxyCliente.ClienteBE();

        public ClienteAgregar()
        {
            InitializeComponent();
        }

        private void EmpleadoAgregar_Load(object sender, EventArgs e)
        {
            try
            {
                cargarUbigeo("14", "01", "01");
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
                    throw new Exception("Debe ingresar un nombre.");
                }

                if (txtApe.Text == "")
                {
                    throw new Exception("Debe ingresar un apellido paterno.");
                }


                clienteBE.nom_cliente = txtNom.Text.Trim();
                clienteBE.ape_cliente = txtApe.Text.Trim();
                clienteBE.direccion_cliente = txtDir.Text.Trim();
                clienteBE.cel_cliente = txtCel.Text.Trim();
                clienteBE.email_cliente = txtEmail.Text.Trim();
                clienteBE.es_dueno = Convert.ToInt16(optDueno.Checked ? 1 : 2);
                clienteBE.id_ubigeo = cbDepa.SelectedValue.ToString()
                    + cbProv.SelectedValue.ToString()
                    + cbDist.SelectedValue.ToString();
                clienteBE.dni_cliente = mskDNI.Text.Trim();
                clienteBE.usu_reg_cli = clsCredenciales.Usuario;
                clienteBE.estado_cli = Convert.ToInt16(chkActivo.Checked);
                
                if (clienteClient.InsertarCliente(clienteBE))
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
        private void cbProv_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cargarUbigeo(cbDepa.SelectedValue.ToString(), cbProv.SelectedValue.ToString(), "01");
        }

        private void cbDepa_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cargarUbigeo(cbDepa.SelectedValue.ToString(), "01", "01");
        }
    }
}
