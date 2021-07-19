
namespace Win_Hunde
{
    partial class Pacientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblRegClientes = new System.Windows.Forms.Label();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dtgPaciente = new System.Windows.Forms.DataGridView();
            this.cod_pac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_pac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.str_sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.longitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRegClientes
            // 
            this.lblRegClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegClientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRegClientes.Location = new System.Drawing.Point(814, 421);
            this.lblRegClientes.Name = "lblRegClientes";
            this.lblRegClientes.Size = new System.Drawing.Size(54, 23);
            this.lblRegClientes.TabIndex = 23;
            // 
            // lblRegistros
            // 
            this.lblRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegistros.AutoSize = true;
            this.lblRegistros.Location = new System.Drawing.Point(733, 421);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(54, 13);
            this.lblRegistros.TabIndex = 24;
            this.lblRegistros.Text = "Registros:";
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(793, 462);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(712, 462);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 21;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Location = new System.Drawing.Point(631, 462);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 22;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dtgPaciente
            // 
            this.dtgPaciente.AllowUserToAddRows = false;
            this.dtgPaciente.AllowUserToDeleteRows = false;
            this.dtgPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgPaciente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPaciente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_pac,
            this.nom_pac,
            this.tipo,
            this.raza,
            this.color,
            this.str_sexo,
            this.longitud,
            this.peso,
            this.observacions});
            this.dtgPaciente.Location = new System.Drawing.Point(12, 17);
            this.dtgPaciente.Name = "dtgPaciente";
            this.dtgPaciente.ReadOnly = true;
            this.dtgPaciente.RowHeadersVisible = false;
            this.dtgPaciente.RowTemplate.Height = 24;
            this.dtgPaciente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPaciente.Size = new System.Drawing.Size(856, 396);
            this.dtgPaciente.TabIndex = 19;
            // 
            // cod_pac
            // 
            this.cod_pac.DataPropertyName = "cod_pac";
            this.cod_pac.FillWeight = 68.52792F;
            this.cod_pac.HeaderText = "Codigo";
            this.cod_pac.MinimumWidth = 10;
            this.cod_pac.Name = "cod_pac";
            this.cod_pac.ReadOnly = true;
            // 
            // nom_pac
            // 
            this.nom_pac.DataPropertyName = "nom_pac";
            this.nom_pac.FillWeight = 85.51138F;
            this.nom_pac.HeaderText = "Nombre";
            this.nom_pac.Name = "nom_pac";
            this.nom_pac.ReadOnly = true;
            // 
            // tipo
            // 
            this.tipo.DataPropertyName = "tipo";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.tipo.DefaultCellStyle = dataGridViewCellStyle1;
            this.tipo.FillWeight = 85.51138F;
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            // 
            // raza
            // 
            this.raza.DataPropertyName = "raza";
            this.raza.FillWeight = 85.51138F;
            this.raza.HeaderText = "Raza";
            this.raza.Name = "raza";
            this.raza.ReadOnly = true;
            // 
            // color
            // 
            this.color.DataPropertyName = "color";
            dataGridViewCellStyle2.NullValue = null;
            this.color.DefaultCellStyle = dataGridViewCellStyle2;
            this.color.FillWeight = 85.51138F;
            this.color.HeaderText = "Color";
            this.color.Name = "color";
            this.color.ReadOnly = true;
            // 
            // str_sexo
            // 
            this.str_sexo.DataPropertyName = "str_sexo";
            this.str_sexo.FillWeight = 85.51138F;
            this.str_sexo.HeaderText = "Sexo";
            this.str_sexo.Name = "str_sexo";
            this.str_sexo.ReadOnly = true;
            // 
            // longitud
            // 
            this.longitud.DataPropertyName = "longitud";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            this.longitud.DefaultCellStyle = dataGridViewCellStyle3;
            this.longitud.FillWeight = 110.7284F;
            this.longitud.HeaderText = "Longitud (cm)";
            this.longitud.Name = "longitud";
            this.longitud.ReadOnly = true;
            // 
            // peso
            // 
            this.peso.DataPropertyName = "peso";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            this.peso.DefaultCellStyle = dataGridViewCellStyle4;
            this.peso.FillWeight = 84.28542F;
            this.peso.HeaderText = "Peso (Kg)";
            this.peso.Name = "peso";
            this.peso.ReadOnly = true;
            // 
            // observacions
            // 
            this.observacions.DataPropertyName = "observaciones";
            this.observacions.FillWeight = 208.9013F;
            this.observacions.HeaderText = "Observaciones";
            this.observacions.Name = "observacions";
            this.observacions.ReadOnly = true;
            // 
            // Pacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 497);
            this.Controls.Add(this.lblRegClientes);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dtgPaciente);
            this.Name = "Pacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pacientes";
            this.Load += new System.EventHandler(this.Pacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPaciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegClientes;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dtgPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_pac;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_pac;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn raza;
        private System.Windows.Forms.DataGridViewTextBoxColumn color;
        private System.Windows.Forms.DataGridViewTextBoxColumn str_sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn longitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacions;
    }
}