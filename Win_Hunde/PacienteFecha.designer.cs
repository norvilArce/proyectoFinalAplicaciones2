
namespace Win_Hunde
{
    partial class pacienteFechas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

         #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoPaciente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpFI = new System.Windows.Forms.DateTimePicker();
            this.dtpFF = new System.Windows.Forms.DateTimePicker();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dtgConsultas = new System.Windows.Forms.DataGridView();
            this.cod_cita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conducta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.est_nutricional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFec_nac = new System.Windows.Forms.TextBox();
            this.txtUlt_vis = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese código paciente:";
            // 
            // txtCodigoPaciente
            // 
            this.txtCodigoPaciente.Location = new System.Drawing.Point(170, 26);
            this.txtCodigoPaciente.MaxLength = 4;
            this.txtCodigoPaciente.Name = "txtCodigoPaciente";
            this.txtCodigoPaciente.Size = new System.Drawing.Size(62, 20);
            this.txtCodigoPaciente.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "F. Inicio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(475, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "F. Fin:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(629, 24);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(255, 23);
            this.btnConsultar.TabIndex = 6;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(270, 72);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(167, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tipo Paciente:";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(270, 101);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.ReadOnly = true;
            this.txtTipo.Size = new System.Drawing.Size(100, 20);
            this.txtTipo.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(167, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Raza:";
            // 
            // txtRaza
            // 
            this.txtRaza.Location = new System.Drawing.Point(270, 127);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.ReadOnly = true;
            this.txtRaza.Size = new System.Drawing.Size(100, 20);
            this.txtRaza.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(385, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Fecha Nacimiento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(387, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Sexo:";
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(490, 104);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.ReadOnly = true;
            this.txtSexo.Size = new System.Drawing.Size(100, 20);
            this.txtSexo.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(167, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Color:";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(270, 153);
            this.txtColor.Name = "txtColor";
            this.txtColor.ReadOnly = true;
            this.txtColor.Size = new System.Drawing.Size(100, 20);
            this.txtColor.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(387, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Peso:";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(490, 131);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.ReadOnly = true;
            this.txtPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPeso.TabIndex = 20;
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(726, 72);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.ReadOnly = true;
            this.txtObservacion.Size = new System.Drawing.Size(153, 108);
            this.txtObservacion.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(387, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Ultima visita:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(639, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Observaciones:";
            // 
            // dtpFI
            // 
            this.dtpFI.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFI.Location = new System.Drawing.Point(359, 23);
            this.dtpFI.Name = "dtpFI";
            this.dtpFI.Size = new System.Drawing.Size(81, 20);
            this.dtpFI.TabIndex = 25;
            // 
            // dtpFF
            // 
            this.dtpFF.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFF.Location = new System.Drawing.Point(517, 23);
            this.dtpFF.Name = "dtpFF";
            this.dtpFF.Size = new System.Drawing.Size(89, 20);
            this.dtpFF.TabIndex = 26;
            // 
            // pbFoto
            // 
            this.pbFoto.Location = new System.Drawing.Point(18, 61);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(121, 125);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 27;
            this.pbFoto.TabStop = false;
            // 
            // lblRegistros
            // 
            this.lblRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegistros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRegistros.Location = new System.Drawing.Point(825, 442);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(54, 23);
            this.lblRegistros.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(744, 442);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Registros:";
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(805, 481);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 29;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dtgConsultas
            // 
            this.dtgConsultas.AllowUserToAddRows = false;
            this.dtgConsultas.AllowUserToDeleteRows = false;
            this.dtgConsultas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgConsultas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConsultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_cita,
            this.Fecha,
            this.Hora,
            this.Medico,
            this.conducta,
            this.est_nutricional,
            this.Observaciones});
            this.dtgConsultas.Location = new System.Drawing.Point(18, 192);
            this.dtgConsultas.Name = "dtgConsultas";
            this.dtgConsultas.ReadOnly = true;
            this.dtgConsultas.RowHeadersVisible = false;
            this.dtgConsultas.RowTemplate.Height = 24;
            this.dtgConsultas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgConsultas.Size = new System.Drawing.Size(861, 247);
            this.dtgConsultas.TabIndex = 28;
            // 
            // cod_cita
            // 
            this.cod_cita.DataPropertyName = "cod_cita";
            this.cod_cita.HeaderText = "Codigo";
            this.cod_cita.Name = "cod_cita";
            this.cod_cita.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "fec_consulta";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.Fecha.DefaultCellStyle = dataGridViewCellStyle3;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Hora
            // 
            this.Hora.DataPropertyName = "hora_consulta";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.Hora.DefaultCellStyle = dataGridViewCellStyle4;
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            // 
            // Medico
            // 
            this.Medico.DataPropertyName = "nom_emp";
            this.Medico.HeaderText = "Medico";
            this.Medico.Name = "Medico";
            this.Medico.ReadOnly = true;
            // 
            // conducta
            // 
            this.conducta.DataPropertyName = "conduta";
            this.conducta.HeaderText = "Conducta";
            this.conducta.Name = "conducta";
            this.conducta.ReadOnly = true;
            // 
            // est_nutricional
            // 
            this.est_nutricional.DataPropertyName = "est_nutricional";
            this.est_nutricional.HeaderText = "Estado";
            this.est_nutricional.Name = "est_nutricional";
            this.est_nutricional.ReadOnly = true;
            // 
            // Observaciones
            // 
            this.Observaciones.DataPropertyName = "Observaciones";
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.ReadOnly = true;
            // 
            // txtFec_nac
            // 
            this.txtFec_nac.Location = new System.Drawing.Point(490, 72);
            this.txtFec_nac.Name = "txtFec_nac";
            this.txtFec_nac.ReadOnly = true;
            this.txtFec_nac.Size = new System.Drawing.Size(100, 20);
            this.txtFec_nac.TabIndex = 32;
            // 
            // txtUlt_vis
            // 
            this.txtUlt_vis.Location = new System.Drawing.Point(490, 160);
            this.txtUlt_vis.Name = "txtUlt_vis";
            this.txtUlt_vis.ReadOnly = true;
            this.txtUlt_vis.Size = new System.Drawing.Size(100, 20);
            this.txtUlt_vis.TabIndex = 33;
            // 
            // pacienteFechas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 508);
            this.Controls.Add(this.txtUlt_vis);
            this.Controls.Add(this.txtFec_nac);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dtgConsultas);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.dtpFF);
            this.Controls.Add(this.dtpFI);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRaza);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigoPaciente);
            this.Controls.Add(this.label1);
            this.Name = "pacienteFechas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Citas de pacientes por fecha";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pacienteFechas_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoPaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRaza;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpFI;
        private System.Windows.Forms.DateTimePicker dtpFF;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dtgConsultas;
        private System.Windows.Forms.TextBox txtFec_nac;
        private System.Windows.Forms.TextBox txtUlt_vis;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_cita;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medico;
        private System.Windows.Forms.DataGridViewTextBoxColumn conducta;
        private System.Windows.Forms.DataGridViewTextBoxColumn est_nutricional;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
    }
}