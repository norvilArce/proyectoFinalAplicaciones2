using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Win_Hunde;

namespace Win_Hubde
{
    public partial class MDIPrincipal : Form
    {
        DateTime horaentrada = new DateTime();

        public MDIPrincipal()
        {
            InitializeComponent();
        }

        private void MDIPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MDIPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Esta a punto de salir de la aplicacion ¿Desea Continuar?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = "Menu Principal - Veterinaria Hunde - " + DateTime.Now.ToString();
            lblHora.Text = "Tiempo de sesion : " + DateTime.Now.Subtract(horaentrada).ToString().Substring(0,8);
        }

        private void MDIPrincipal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = clsCredenciales.Usuario;
            horaentrada = DateTime.Now;
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmpleadoLista empleadoLista = new EmpleadoLista();
            empleadoLista.MdiParent = this;
            empleadoLista.Show();
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProveedorConsulta proveedorConsulta = new ProveedorConsulta();
            proveedorConsulta.MdiParent = this;
            proveedorConsulta.Show();
        }
    }
}