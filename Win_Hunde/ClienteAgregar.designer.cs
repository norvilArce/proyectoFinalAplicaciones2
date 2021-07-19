namespace Win_Hunde
{
    partial class ClienteAgregar
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
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.optDueno = new System.Windows.Forms.RadioButton();
            this.optFam = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.cbDist = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbDepa = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbProv = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mskDNI = new System.Windows.Forms.MaskedTextBox();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.txtApe = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.optDueno);
            this.grpDatos.Controls.Add(this.optFam);
            this.grpDatos.Controls.Add(this.label10);
            this.grpDatos.Controls.Add(this.cbDist);
            this.grpDatos.Controls.Add(this.label6);
            this.grpDatos.Controls.Add(this.cbDepa);
            this.grpDatos.Controls.Add(this.label11);
            this.grpDatos.Controls.Add(this.cbProv);
            this.grpDatos.Controls.Add(this.txtEmail);
            this.grpDatos.Controls.Add(this.label9);
            this.grpDatos.Controls.Add(this.txtCel);
            this.grpDatos.Controls.Add(this.label8);
            this.grpDatos.Controls.Add(this.mskDNI);
            this.grpDatos.Controls.Add(this.chkActivo);
            this.grpDatos.Controls.Add(this.btnGuardar);
            this.grpDatos.Controls.Add(this.Label1);
            this.grpDatos.Controls.Add(this.txtNom);
            this.grpDatos.Controls.Add(this.txtDir);
            this.grpDatos.Controls.Add(this.txtApe);
            this.grpDatos.Controls.Add(this.label5);
            this.grpDatos.Controls.Add(this.Label2);
            this.grpDatos.Controls.Add(this.Label3);
            this.grpDatos.Controls.Add(this.btnCancelar);
            this.grpDatos.Location = new System.Drawing.Point(12, 12);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(330, 402);
            this.grpDatos.TabIndex = 1;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos";
            // 
            // optDueno
            // 
            this.optDueno.Checked = true;
            this.optDueno.Location = new System.Drawing.Point(19, 321);
            this.optDueno.Name = "optDueno";
            this.optDueno.Size = new System.Drawing.Size(77, 24);
            this.optDueno.TabIndex = 36;
            this.optDueno.TabStop = true;
            this.optDueno.Text = "Dueño";
            // 
            // optFam
            // 
            this.optFam.Location = new System.Drawing.Point(114, 321);
            this.optFam.Name = "optFam";
            this.optFam.Size = new System.Drawing.Size(77, 24);
            this.optFam.TabIndex = 37;
            this.optFam.Text = "Familiar";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(19, 244);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 16);
            this.label10.TabIndex = 35;
            this.label10.Text = "Distrito:";
            // 
            // cbDist
            // 
            this.cbDist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDist.FormattingEnabled = true;
            this.cbDist.Location = new System.Drawing.Point(108, 241);
            this.cbDist.Name = "cbDist";
            this.cbDist.Size = new System.Drawing.Size(129, 21);
            this.cbDist.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(19, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "Departamento:";
            // 
            // cbDepa
            // 
            this.cbDepa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepa.FormattingEnabled = true;
            this.cbDepa.Location = new System.Drawing.Point(108, 183);
            this.cbDepa.Name = "cbDepa";
            this.cbDepa.Size = new System.Drawing.Size(129, 21);
            this.cbDepa.TabIndex = 32;
            this.cbDepa.SelectionChangeCommitted += new System.EventHandler(this.cbDepa_SelectionChangeCommitted);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(19, 215);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 16);
            this.label11.TabIndex = 31;
            this.label11.Text = "Provincia:";
            // 
            // cbProv
            // 
            this.cbProv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProv.FormattingEnabled = true;
            this.cbProv.Location = new System.Drawing.Point(108, 212);
            this.cbProv.Name = "cbProv";
            this.cbProv.Size = new System.Drawing.Size(129, 21);
            this.cbProv.TabIndex = 30;
            this.cbProv.SelectionChangeCommitted += new System.EventHandler(this.cbProv_SelectionChangeCommitted);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(108, 150);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(192, 20);
            this.txtEmail.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(20, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Email:";
            // 
            // txtCel
            // 
            this.txtCel.Location = new System.Drawing.Point(108, 119);
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(192, 20);
            this.txtCel.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(20, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Tel. celular:";
            // 
            // mskDNI
            // 
            this.mskDNI.Location = new System.Drawing.Point(108, 89);
            this.mskDNI.Mask = "########";
            this.mskDNI.Name = "mskDNI";
            this.mskDNI.Size = new System.Drawing.Size(83, 20);
            this.mskDNI.TabIndex = 22;
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Checked = true;
            this.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivo.Location = new System.Drawing.Point(248, 326);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(68, 17);
            this.chkActivo.TabIndex = 17;
            this.chkActivo.Text = "¿Activo?";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(156, 363);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(72, 24);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(20, 28);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(64, 16);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Nombre:";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(108, 24);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(192, 20);
            this.txtNom.TabIndex = 1;
            // 
            // txtDir
            // 
            this.txtDir.Location = new System.Drawing.Point(108, 277);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(192, 20);
            this.txtDir.TabIndex = 14;
            // 
            // txtApe
            // 
            this.txtApe.Location = new System.Drawing.Point(108, 56);
            this.txtApe.Name = "txtApe";
            this.txtApe.Size = new System.Drawing.Size(192, 20);
            this.txtApe.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(19, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Direccion:";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(20, 59);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(64, 24);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Apellido:";
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(20, 89);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(37, 17);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "DNI:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(248, 363);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(72, 24);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ClienteAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 423);
            this.Controls.Add(this.grpDatos);
            this.Name = "ClienteAgregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClienteAgregar";
            this.Load += new System.EventHandler(this.EmpleadoAgregar_Load);
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.CheckBox chkActivo;
        internal System.Windows.Forms.Button btnGuardar;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtNom;
        internal System.Windows.Forms.TextBox txtDir;
        internal System.Windows.Forms.TextBox txtApe;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.MaskedTextBox mskDNI;
        internal System.Windows.Forms.TextBox txtEmail;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.TextBox txtCel;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbDist;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbDepa;
        internal System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbProv;
        internal System.Windows.Forms.RadioButton optDueno;
        internal System.Windows.Forms.RadioButton optFam;
    }
}