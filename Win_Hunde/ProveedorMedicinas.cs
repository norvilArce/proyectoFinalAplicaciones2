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

        ProxyProveedor.ServicioProveedorClient objServProv = new ProxyProveedor.ServicioProveedorClient();

        public ProveedorMedicinas()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                ProxyProveedor.ServicioProveedorClient objServProv = new ProxyProveedor.ServicioProveedorClient();
                ProxyProveedor.ProveedorBE objProveedorBE = new ProxyProveedor.ProveedorBE();




                dtgProveedor.DataSource = objServProv.ConsultarProveedores();
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

        private void ProveedorMedicinas_Load(object sender, EventArgs e)
        {
            try
            {
                cboProveedor.DataSource = objServProv.ConsultarProveedores();
                cboProveedor.ValueMember = "cod_prov";
                cboProveedor.DisplayMember = "rep_ven_prov";
            }
            catch (Exception ex)
            {
                throw new Exception("Error:" + ex.Message);
            }
        }
    }
}
