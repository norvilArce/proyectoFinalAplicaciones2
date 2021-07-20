using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Hunde
{
    public partial class PacienteAgregar : Form
    {
        ProxyColor.ServicioColorClient servicioColor = new ProxyColor.ServicioColorClient();
        ProxyTipoPaciente.ServicioTipoPacienteClient servicioTipo = new ProxyTipoPaciente.ServicioTipoPacienteClient();
        ProxyRaza.ServicioRazaClient servicioRaza = new ProxyRaza.ServicioRazaClient();
        ProxyPaciente.ServicioPacienteClient servicioPaciente = new ProxyPaciente.ServicioPacienteClient();

        private String[] sexos = { "Seleccione", "Macho", "Hembra" };
        public PacienteAgregar()
        {
            InitializeComponent();
        }

        private void PacienteAgregar_Load(object sender, EventArgs e)
        {
            cargarCombos();
        }

        private void cargarCombos()
        {
            cbColor.DataSource = servicioColor.ListarColores();
            cbColor.ValueMember = "cod_color";
            cbColor.DisplayMember = "nom_color";

            cbTipo.DataSource = servicioTipo.listarTipos();
            cbTipo.ValueMember = "cod_tipo";
            cbTipo.DisplayMember = "nom_tipo";

            cbSexo.DataSource = sexos;

            cargarRazas(1);
        }

        private void cargarRazas(Int16 codTipo)
        {
            cbRaza.DataSource = servicioRaza.listarRazasPorTipo(codTipo);
            cbRaza.ValueMember = "cod_raza";
            cbRaza.DisplayMember = "nom_raza";
        }

        private void cbTipo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cargarRazas(Convert.ToInt16(cbTipo.SelectedValue));
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                //cargamos la imagen
                openFileDialog1.Filter = "Text Files (*.JPG)| *.JPG";
                openFileDialog1.ShowDialog();
                pcbFoto.Image = Image.FromFile(openFileDialog1.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                ProxyPaciente.PacienteBE paciente = new ProxyPaciente.PacienteBE();

                if (txtNom.Text == String.Empty)
                {
                    throw new Exception("El nombre es obligatorio");
                }
                if (openFileDialog1.FileName == String.Empty)
                {
                    throw new Exception("La foto es obligatoria");
                }

                //manejamos la imagen
                String strRutaFoto = openFileDialog1.FileName;
                FileStream fileFoto = new FileStream(strRutaFoto, FileMode.Open, FileAccess.Read);
                byte[] imagenbuffer = new byte[fileFoto.Length - 1];

                //se llena la matriz imageBuffer con el contenido de la imagen o foto
                fileFoto.Read(imagenbuffer, 0, imagenbuffer.Length);
                //cerramos y destruimos la instrncia de filestream
                fileFoto.Close();
                fileFoto.Dispose();

                //asignamops las propiedades
                paciente.nom_pac = txtNom.Text.Trim();
                paciente.cod_raza = Convert.ToInt16(cbRaza.SelectedValue);
                paciente.fec_nac_pac = dtpFecNac.Value;
                paciente.sexo = Convert.ToInt16(cbSexo.SelectedIndex);
                paciente.cod_color = Convert.ToInt16(cbColor.SelectedValue);
                paciente.longitud = Convert.ToDouble(txtLong.Text);
                paciente.peso = Convert.ToDouble(txtPeso.Text);
                paciente.foto = imagenbuffer;
                paciente.observaciones = txtObs.Text.Trim();
                paciente.est_pac = Convert.ToInt16(chkEstado.Checked);

                //grabamos
                if (servicioPaciente.InsertarPaciente(paciente))
                {
                    MessageBox.Show("Registro grabado exitosamente"+txtLong.Text);
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
