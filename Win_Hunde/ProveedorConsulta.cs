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
    public partial class ProveedorConsulta : Form
    {
        public ProveedorConsulta()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                ProxyProveedor1.ServicioProveedorClient objServProv = new ProxyProveedor1.ServicioProveedorClient();
                ProxyProveedor1.ProveedorBE objProveedorBE = new ProxyProveedor1.ProveedorBE();

                
                objProveedorBE = objServProv.ConsultarProveedorPorCodigo(txtCod.Text.Trim());
                lblNM.Text = objProveedorBE.nom_prov;
                lblDir.Text = objProveedorBE.direccion_prov;
                lblRUC.Text = objProveedorBE.ruc_prov;
                lblTel.Text = objProveedorBE.tel_prov;
                lblEmail.Text = objProveedorBE.email_prov;
                lblRep.Text = objProveedorBE.rep_ven_prov;
                lblEst.Text = objProveedorBE.estado_prov.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
