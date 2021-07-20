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
    public partial class medicinasPorProveedor : Form
    {
        public medicinasPorProveedor()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                ProxyProveedor.ServicioProveedorClient objServProv = new ProxyProveedor.ServicioProveedorClient();
                ProxyProveedor.ProveedorBE objProveedorBE = new ProxyProveedor.ProveedorBE();

                ProxyMedicina.ServicioMedicinaClient medicinaClient = new ProxyMedicina.ServicioMedicinaClient();

                objProveedorBE = objServProv.ConsultarProveedorPorCodigo(txtCod.Text.Trim());

                if (objProveedorBE != null)
                {
                    lblNM.Text = objProveedorBE.raz_soc;
                    lblDir.Text = objProveedorBE.dir_prov;
                    lblRUC.Text = objProveedorBE.ruc_prov;
                    lblTel.Text = objProveedorBE.tel_prov;
                    lblEmail.Text = objProveedorBE.email_prov;
                    lblRep.Text = objProveedorBE.rep_ven_prov;
                    dtgMedicinas.AutoGenerateColumns = false;
                    dtgMedicinas.DataSource = medicinaClient.ConsultarMedicinaProveedor(txtCod.Text.Trim());
                    lblRegistros.Text = dtgMedicinas.Rows.Count.ToString();
                }
                else
                {
                    lblNM.Text = "";
                    lblDir.Text = "";
                    lblRUC.Text = "";
                    lblTel.Text = "";
                    lblEmail.Text = "";
                    lblRep.Text = "";
                    MessageBox.Show("No se encuentra proveedor con codigo " + txtCod.Text,
                        "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void medicinasPorProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnConsultar.PerformClick();
            }
        }
    }
}
