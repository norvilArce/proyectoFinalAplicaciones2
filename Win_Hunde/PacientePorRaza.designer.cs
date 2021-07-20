
namespace Win_Hunde
{
    partial class PacientePorRaza
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dtgPaciente = new System.Windows.Forms.DataGridView();
            this.cboRazas = new System.Windows.Forms.ComboBox();
            this.Cod_pac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_pac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_pac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Raza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fec_nac_pac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Raza:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(455, 56);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(212, 23);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
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
            this.Cod_pac,
            this.Nom_pac,
            this.tipo_pac,
            this.Raza,
            this.Fec_nac_pac,
            this.Sexo,
            this.Color,
            this.Peso});
            this.dtgPaciente.Location = new System.Drawing.Point(30, 115);
            this.dtgPaciente.Name = "dtgPaciente";
            this.dtgPaciente.ReadOnly = true;
            this.dtgPaciente.RowHeadersVisible = false;
            this.dtgPaciente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPaciente.Size = new System.Drawing.Size(857, 286);
            this.dtgPaciente.TabIndex = 13;
            // 
            // cboRazas
            // 
            this.cboRazas.FormattingEnabled = true;
            this.cboRazas.Location = new System.Drawing.Point(229, 58);
            this.cboRazas.Name = "cboRazas";
            this.cboRazas.Size = new System.Drawing.Size(121, 21);
            this.cboRazas.TabIndex = 14;
            // 
            // Cod_pac
            // 
            this.Cod_pac.DataPropertyName = "cod_pac";
            this.Cod_pac.HeaderText = "Codigo Paciente";
            this.Cod_pac.Name = "Cod_pac";
            this.Cod_pac.ReadOnly = true;
            // 
            // Nom_pac
            // 
            this.Nom_pac.DataPropertyName = "nom_pac";
            this.Nom_pac.HeaderText = "Nombre Paciente";
            this.Nom_pac.Name = "Nom_pac";
            this.Nom_pac.ReadOnly = true;
            // 
            // tipo_pac
            // 
            this.tipo_pac.DataPropertyName = "tipo";
            this.tipo_pac.HeaderText = "Tipo";
            this.tipo_pac.Name = "tipo_pac";
            this.tipo_pac.ReadOnly = true;
            // 
            // Raza
            // 
            this.Raza.DataPropertyName = "raza";
            this.Raza.HeaderText = "Raza";
            this.Raza.Name = "Raza";
            this.Raza.ReadOnly = true;
            // 
            // Fec_nac_pac
            // 
            this.Fec_nac_pac.DataPropertyName = "fec_nac_pac";
            this.Fec_nac_pac.HeaderText = "Fecha Nac. Paciente";
            this.Fec_nac_pac.Name = "Fec_nac_pac";
            this.Fec_nac_pac.ReadOnly = true;
            // 
            // Sexo
            // 
            this.Sexo.DataPropertyName = "str_sexo";
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            // 
            // Color
            // 
            this.Color.DataPropertyName = "color";
            this.Color.HeaderText = "Color";
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            // 
            // Peso
            // 
            this.Peso.DataPropertyName = "peso";
            this.Peso.HeaderText = "Peso";
            this.Peso.Name = "Peso";
            this.Peso.ReadOnly = true;
            // 
            // PacientePorRaza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 450);
            this.Controls.Add(this.cboRazas);
            this.Controls.Add(this.dtgPaciente);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.label1);
            this.Name = "PacientePorRaza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paciente por Raza de Perro";
            this.Load += new System.EventHandler(this.PacientePorRaza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPaciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dtgPaciente;
        private System.Windows.Forms.ComboBox cboRazas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_pac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_pac;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_pac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Raza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fec_nac_pac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso;
    }
}