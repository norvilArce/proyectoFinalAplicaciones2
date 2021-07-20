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
    public partial class FrmLogin : Form
    {
        Int16 intentos = 0;
        Int16 tiempo = 20;

        ProxyUsuario.ServicioUsuarioClient servicioUsuarioClient = new ProxyUsuario.ServicioUsuarioClient();
        ProxyUsuario.Usuario usuario = new ProxyUsuario.Usuario();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtLogin.Text.Trim() != "" & txtPassword.Text.Trim() != "")
                {
                    usuario = servicioUsuarioClient.ConsultarUsuario(txtLogin.Text);

                    if (usuario.login_usuario == null) 
                    {
                        MessageBox.Show("Usuario no existe",
                        "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        intentos += 1;
                        ValidaAccesos(intentos);
                    }
                    else
                    {
                        if (txtLogin.Text == usuario.login_usuario & txtPassword.Text == usuario.pass_usuario) 
                        {
                            this.Hide();
                            timer1.Enabled = false;
                            clsCredenciales.Usuario = usuario.login_usuario;
                            clsCredenciales.Password = usuario.pass_usuario;
                            clsCredenciales.Nivel = usuario.niv_usuario;
                            MDIPrincipal mdi = new MDIPrincipal();
                            mdi.ShowDialog();
                        } 
                        else
                        {
                            MessageBox.Show("Usuario o Password incorrectos",
                                "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            intentos += 1;
                            ValidaAccesos(intentos);
                        }
                    }                    
                }
                else
                {
                    MessageBox.Show("Los campos no pueden estar vacios",
                        "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intentos += 1;
                    ValidaAccesos(intentos);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ValidaAccesos(Int16 intIntentos)
        {
            if (intentos == 3)
            {
                MessageBox.Show("Lo sentimos,  sobrepaso el numero de intentos",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            tiempo -= 1;
            this.Text = "Ingrese su login y contraseña. Le quedan...." + tiempo;
            if (tiempo == 0)
            {
                MessageBox.Show("Lo sentimos, sobrepaso el tiempo de espera",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Enabled = false;
            Application.Exit();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnAceptar.PerformClick();
            }
        }
    }
}
