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
    public partial class PacienteActualizar : Form
    {
        ProxyColor.ServicioColorClient servicioColor = new ProxyColor.ServicioColorClient();
        ProxyTipoPaciente.ServicioTipoPacienteClient servicioTipo = new ProxyTipoPaciente.ServicioTipoPacienteClient();
        ProxyRaza.ServicioRazaClient servicioRaza = new ProxyRaza.ServicioRazaClient();
        ProxyPaciente.ServicioPacienteClient servicioPaciente = new ProxyPaciente.ServicioPacienteClient();
        ProxyPaciente.PacienteBE paciente = new ProxyPaciente.PacienteBE();

        private String _Codigo;
        private String[] sexos = { "Seleccione", "Macho", "Hembra" };
        public String Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }

        public PacienteActualizar()
        {
            InitializeComponent();
        }

        private void PacienteActualizar_Load(object sender, EventArgs e)
        {
            paciente = servicioPaciente.ConsultarPacientes(Codigo);
            Int16 codTipo = Convert.ToInt16(servicioTipo.TipoPorRaza(paciente.cod_raza).cod_tipo);

            txtNom.Text = paciente.nom_pac;
            dtpFecNac.Value = paciente.fec_nac_pac;

            cargarRazas(codTipo, paciente.cod_raza);
            cargarTipo(codTipo);
            cargarSexo(paciente.sexo);
            cargarColor(paciente.cod_color);

            txtLong.Text = paciente.longitud.ToString();
            txtPeso.Text = paciente.peso.ToString();
            txtObs.Text = paciente.observaciones;

            if (paciente.foto != null)
            {
                MemoryStream fotoStream = new MemoryStream(paciente.foto);
                pbFoto.Image = Image.FromStream(fotoStream);
            }            

            chkEstado.Checked = Convert.ToBoolean(paciente.est_pac);
        }

        private void cargarColor(Int16 codColor)
        {
            cbColor.DataSource = servicioColor.ListarColores();
            cbColor.ValueMember = "cod_color";
            cbColor.DisplayMember = "nom_color";
            cbColor.SelectedValue = codColor;
        }

        private void cargarSexo(Int16 codSexo)
        {
            cbSexo.DataSource = sexos;
            cbSexo.SelectedIndex = codSexo;
        }

        private void cargarTipo(Int16 codTipo)
        {
            cbTipo.DataSource = servicioTipo.listarTipos();
            cbTipo.ValueMember = "cod_tipo";
            cbTipo.DisplayMember = "nom_tipo";
            cbTipo.SelectedValue = codTipo;
        }
        private void cargarRazas(Int16 codTipo, Int16 codRaza)
        {
            cbRaza.DataSource = servicioRaza.listarRazasPorTipo(codTipo);
            cbRaza.ValueMember = "cod_raza";
            cbRaza.DisplayMember = "nom_raza";
            cbRaza.SelectedValue = codRaza;
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
                pbFoto.Image = Image.FromFile(openFileDialog1.FileName);
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
                if (txtNom.Text == String.Empty)
                {
                    throw new Exception("El nombre es obligatorio");
                }

                if (openFileDialog1.FileName != "openFileDialog1")
                {
                    //manejamos la imagen
                    String strRutaFoto = openFileDialog1.FileName;
                    FileStream fileFoto = new FileStream(strRutaFoto, FileMode.Open, FileAccess.Read);
                    byte[] imagenbuffer = new byte[fileFoto.Length - 1];

                    if (paciente.foto != imagenbuffer)
                    {
                        //se llena la matriz imageBuffer con el contenido de la imagen o foto
                        fileFoto.Read(imagenbuffer, 0, imagenbuffer.Length);
                        //cerramos y destruimos la instrncia de filestream
                        fileFoto.Close();
                        fileFoto.Dispose();
                        
                        paciente.foto = imagenbuffer;
                    }
                }

                //asignamops las propiedades
                paciente.nom_pac = txtNom.Text.Trim();
                paciente.cod_raza = Convert.ToInt16(cbRaza.SelectedValue);
                paciente.fec_nac_pac = dtpFecNac.Value;
                paciente.sexo = Convert.ToInt16(cbSexo.SelectedIndex);
                paciente.cod_color = Convert.ToInt16(cbColor.SelectedValue);
                paciente.longitud = Convert.ToDouble(txtLong.Text.Trim());
                paciente.peso = Convert.ToDouble(txtPeso.Text.Trim());
                paciente.observaciones = txtObs.Text.Trim();
                paciente.est_pac = Convert.ToInt16(chkEstado.Checked);

                paciente.ult_vis_pac = DateTime.Now;
                paciente.cod_pac = Codigo;

                //grabamos
                if (servicioPaciente.ActualizarPaciente(paciente))
                {
                    MessageBox.Show("Registro grabado exitosamente");
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
        }

        private void cbTipo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cargarRazas(Convert.ToInt16(cbTipo.SelectedValue), 1);
        }

        
    }
}
