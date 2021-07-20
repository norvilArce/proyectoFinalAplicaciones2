
namespace Win_Hunde
{
    partial class medicinasPorProveedor
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
            this.txtCod = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblDir = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblRUC = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblRep = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblNM = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dtgMedicinas = new System.Windows.Forms.DataGridView();
            this.cod_med = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_medicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMedicinas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(149, 12);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(56, 20);
            this.txtCod.TabIndex = 36;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(240, 7);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(136, 23);
            this.btnConsultar.TabIndex = 35;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblDir
            // 
            this.lblDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDir.Location = new System.Drawing.Point(98, 130);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(279, 19);
            this.lblDir.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Direccion";
            // 
            // lblRUC
            // 
            this.lblRUC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRUC.Location = new System.Drawing.Point(98, 74);
            this.lblRUC.Name = "lblRUC";
            this.lblRUC.Size = new System.Drawing.Size(145, 19);
            this.lblRUC.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "RUC:";
            // 
            // lblRep
            // 
            this.lblRep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRep.Location = new System.Drawing.Point(98, 160);
            this.lblRep.Name = "lblRep";
            this.lblRep.Size = new System.Drawing.Size(211, 19);
            this.lblRep.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 161);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "Representante:";
            // 
            // lblEmail
            // 
            this.lblEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEmail.Location = new System.Drawing.Point(98, 189);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(206, 19);
            this.lblEmail.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(54, 190);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Email:";
            // 
            // lblTel
            // 
            this.lblTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTel.Location = new System.Drawing.Point(98, 102);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(94, 19);
            this.lblTel.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Telefono:";
            // 
            // lblNM
            // 
            this.lblNM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNM.Location = new System.Drawing.Point(98, 45);
            this.lblNM.Name = "lblNM";
            this.lblNM.Size = new System.Drawing.Size(278, 19);
            this.lblNM.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Razon Social:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Ingrese codigo proveedor:";
            // 
            // lblRegistros
            // 
            this.lblRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegistros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRegistros.Location = new System.Drawing.Point(302, 429);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(74, 23);
            this.lblRegistros.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Registros:";
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(282, 468);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(95, 23);
            this.btnSalir.TabIndex = 38;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dtgMedicinas
            // 
            this.dtgMedicinas.AllowUserToAddRows = false;
            this.dtgMedicinas.AllowUserToDeleteRows = false;
            this.dtgMedicinas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgMedicinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMedicinas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_med,
            this.nombre_medicina,
            this.precio});
            this.dtgMedicinas.Location = new System.Drawing.Point(16, 226);
            this.dtgMedicinas.Name = "dtgMedicinas";
            this.dtgMedicinas.ReadOnly = true;
            this.dtgMedicinas.RowHeadersVisible = false;
            this.dtgMedicinas.RowTemplate.Height = 24;
            this.dtgMedicinas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgMedicinas.Size = new System.Drawing.Size(361, 200);
            this.dtgMedicinas.TabIndex = 37;
            // 
            // cod_med
            // 
            this.cod_med.DataPropertyName = "cod_med";
            this.cod_med.HeaderText = "Codigo";
            this.cod_med.Name = "cod_med";
            this.cod_med.ReadOnly = true;
            this.cod_med.Width = 70;
            // 
            // nombre_medicina
            // 
            this.nombre_medicina.DataPropertyName = "nombre_medicina";
            this.nombre_medicina.HeaderText = "Nombre";
            this.nombre_medicina.MinimumWidth = 100;
            this.nombre_medicina.Name = "nombre_medicina";
            this.nombre_medicina.ReadOnly = true;
            this.nombre_medicina.Width = 187;
            // 
            // precio
            // 
            this.precio.DataPropertyName = "precio";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            this.precio.DefaultCellStyle = dataGridViewCellStyle1;
            this.precio.HeaderText = "Precio(S/.)";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // medicinasPorProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 498);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dtgMedicinas);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.lblDir);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblRUC);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblRep);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblNM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "medicinasPorProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medicinas por Proveedor";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.medicinasPorProveedor_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMedicinas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblDir;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblRUC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblRep;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblNM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dtgMedicinas;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_med;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_medicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
    }
}