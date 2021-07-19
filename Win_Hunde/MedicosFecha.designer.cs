
namespace Win_Hunde
{
    partial class MedicosFecha
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dtgConsultas = new System.Windows.Forms.DataGridView();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.dtpFF = new System.Windows.Forms.DateTimePicker();
            this.dtpFI = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblSupervisor = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cod_cita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lo_trajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conducta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.est_nutricional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRegistros
            // 
            this.lblRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegistros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRegistros.Location = new System.Drawing.Point(617, 438);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(54, 23);
            this.lblRegistros.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(536, 438);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Registros:";
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(597, 477);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 20;
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
            this.mascota,
            this.tipo,
            this.raza,
            this.color,
            this.lo_trajo,
            this.conducta,
            this.est_nutricional,
            this.Observaciones});
            this.dtgConsultas.Location = new System.Drawing.Point(3, 166);
            this.dtgConsultas.Name = "dtgConsultas";
            this.dtgConsultas.ReadOnly = true;
            this.dtgConsultas.RowHeadersVisible = false;
            this.dtgConsultas.RowTemplate.Height = 24;
            this.dtgConsultas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgConsultas.Size = new System.Drawing.Size(668, 269);
            this.dtgConsultas.TabIndex = 19;
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(147, 29);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(100, 20);
            this.txtCod.TabIndex = 30;
            // 
            // dtpFF
            // 
            this.dtpFF.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFF.Location = new System.Drawing.Point(521, 29);
            this.dtpFF.Name = "dtpFF";
            this.dtpFF.Size = new System.Drawing.Size(109, 20);
            this.dtpFF.TabIndex = 28;
            // 
            // dtpFI
            // 
            this.dtpFI.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFI.Location = new System.Drawing.Point(325, 29);
            this.dtpFI.Name = "dtpFI";
            this.dtpFI.Size = new System.Drawing.Size(109, 20);
            this.dtpFI.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(479, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "F. Fin:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "F. Inicio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Ingrese codigo medico";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(521, 75);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(136, 24);
            this.btnConsultar.TabIndex = 31;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblSupervisor
            // 
            this.lblSupervisor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSupervisor.Location = new System.Drawing.Point(310, 131);
            this.lblSupervisor.Name = "lblSupervisor";
            this.lblSupervisor.Size = new System.Drawing.Size(145, 19);
            this.lblSupervisor.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(234, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Supervisor:";
            // 
            // lblSueldo
            // 
            this.lblSueldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSueldo.Location = new System.Drawing.Point(73, 132);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(145, 19);
            this.lblSueldo.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Sueldo:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDireccion.Location = new System.Drawing.Point(310, 73);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(145, 19);
            this.lblDireccion.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(239, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Direccion:";
            // 
            // lblEmail
            // 
            this.lblEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEmail.Location = new System.Drawing.Point(310, 101);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(145, 19);
            this.lblEmail.TabIndex = 36;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(260, 102);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 43;
            this.label13.Text = "email:";
            // 
            // lblRol
            // 
            this.lblRol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRol.Location = new System.Drawing.Point(73, 102);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(145, 19);
            this.lblRol.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 44;
            this.label11.Text = "Cargo:";
            // 
            // lblNom
            // 
            this.lblNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNom.Location = new System.Drawing.Point(73, 71);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(145, 19);
            this.lblNom.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Nombre";
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.Fecha.DefaultCellStyle = dataGridViewCellStyle1;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Hora
            // 
            this.Hora.DataPropertyName = "hora_consulta";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.Hora.DefaultCellStyle = dataGridViewCellStyle2;
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            // 
            // mascota
            // 
            this.mascota.DataPropertyName = "nom_pac";
            this.mascota.HeaderText = "Mascota";
            this.mascota.Name = "mascota";
            this.mascota.ReadOnly = true;
            // 
            // tipo
            // 
            this.tipo.DataPropertyName = "tipo_pac";
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            // 
            // raza
            // 
            this.raza.DataPropertyName = "raza_pac";
            this.raza.HeaderText = "Raza";
            this.raza.Name = "raza";
            this.raza.ReadOnly = true;
            // 
            // color
            // 
            this.color.DataPropertyName = "color_pac";
            this.color.HeaderText = "Color";
            this.color.Name = "color";
            this.color.ReadOnly = true;
            // 
            // lo_trajo
            // 
            this.lo_trajo.DataPropertyName = "nom_cli";
            this.lo_trajo.HeaderText = "Cliente";
            this.lo_trajo.Name = "lo_trajo";
            this.lo_trajo.ReadOnly = true;
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
            this.Observaciones.DataPropertyName = "observaciones";
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.ReadOnly = true;
            // 
            // MedicosFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 506);
            this.Controls.Add(this.lblSupervisor);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblSueldo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.dtpFF);
            this.Controls.Add(this.dtpFI);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dtgConsultas);
            this.Name = "MedicosFecha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Citas de medicos por fecha";
            this.Load += new System.EventHandler(this.Consultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dtgConsultas;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.DateTimePicker dtpFF;
        private System.Windows.Forms.DateTimePicker dtpFI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblSupervisor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_cita;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn mascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn raza;
        private System.Windows.Forms.DataGridViewTextBoxColumn color;
        private System.Windows.Forms.DataGridViewTextBoxColumn lo_trajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn conducta;
        private System.Windows.Forms.DataGridViewTextBoxColumn est_nutricional;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
    }
}