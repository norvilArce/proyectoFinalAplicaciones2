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
    public partial class SupervisorProveedor : Form
    {

        ProxyProveedor1.ServicioProveedorClient objServProv = new ProxyProveedor1.ServicioProveedorClient();
        public SupervisorProveedor()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
           
            try
            {

                dtgSupervisor.DataSource = objServProv.ConsultarSupervisor();
                    //(cboSupervisor.SelectedValue.ToString());

                if (dtgSupervisor.Rows.Count == 0)
                {
                    throw new Exception("El proveedor no registra Supervisador");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error:" + ex.Message);
            }
        }

        private void SupervisorProveedor_Load(object sender, EventArgs e)
        {
            try
            {
                cboSupervisor.DataSource = objServProv.ConsultarSupervisor();
                cboSupervisor.ValueMember = "cod_prov";
                cboSupervisor.DisplayMember = "rep_ven_prov";
            }
            catch (Exception ex)
            {
                throw new Exception("Error:" + ex.Message);
            }
        }
    }
}
