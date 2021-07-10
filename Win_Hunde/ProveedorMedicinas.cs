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
    public partial class ProveedorMedicinas : Form
    {

        ProxyProveedor1.ServicioProveedorClient objServProv = new ProxyProveedor1.ServicioProveedorClient();

        public ProveedorMedicinas()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                ProxyProveedor1.ServicioProveedorClient objServProv = new ProxyProveedor1.ServicioProveedorClient();
                ProxyProveedor1.ProveedorBE objProveedorBE = new ProxyProveedor1.ProveedorBE();


                objProveedorBE = objServProv.ConsultarMedicinaProveedor(txtTipo.Text.Trim());
                lblMedicina.Text = objProveedorBE.cod_med;
                lblNomMed.Text = objProveedorBE.nombre_medicina;


                dtgProveedor.DataSource = objServProv.ConsultarEstadoProveedorMedicina();
                //(cboSupervisor.SelectedValue.ToString());

                if (dtgProveedor.Rows.Count == 0)
                {
                    throw new Exception("El proveedor no registra datos");
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnConsultar2_Click(object sender, EventArgs e) //ignorar
        {
            try
            {

                dtgProveedor.DataSource = objServProv.ConsultarEstadoProveedorMedicina();
                //(cboSupervisor.SelectedValue.ToString());

                if (dtgProveedor.Rows.Count == 0)
                {
                    throw new Exception("El proveedor no registra datos");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error:" + ex.Message);
            }
        }

        private void ProveedorMedicinas_Load(object sender, EventArgs e)
        {
            try
            {
                cboProveedor.DataSource = objServProv.ConsultarProveedores();
                cboProveedor.ValueMember = "cod_med";
                cboProveedor.DisplayMember = "estado_medicina";
            }
            catch (Exception ex)
            {
                throw new Exception("Error:" + ex.Message);
            }
        }
    }
}
