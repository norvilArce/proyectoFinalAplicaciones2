
namespace Win_Hunde
{
    partial class EmpleadoActualizar
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSup = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.cboRoles = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.dtpFecIng = new System.Windows.Forms.DateTimePicker();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtApe = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.grpDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.txtSueldo);
            this.grpDatos.Controls.Add(this.lblCodigo);
            this.grpDatos.Controls.Add(this.label8);
            this.grpDatos.Controls.Add(this.txtSup);
            this.grpDatos.Controls.Add(this.label7);
            this.grpDatos.Controls.Add(this.chkActivo);
            this.grpDatos.Controls.Add(this.cboRoles);
            this.grpDatos.Controls.Add(this.btnGuardar);
            this.grpDatos.Controls.Add(this.Label1);
            this.grpDatos.Controls.Add(this.dtpFecIng);
            this.grpDatos.Controls.Add(this.txtNom);
            this.grpDatos.Controls.Add(this.txtEmail);
            this.grpDatos.Controls.Add(this.txtApe);
            this.grpDatos.Controls.Add(this.label6);
            this.grpDatos.Controls.Add(this.label5);
            this.grpDatos.Controls.Add(this.Label2);
            this.grpDatos.Controls.Add(this.Label3);
            this.grpDatos.Controls.Add(this.Label4);
            this.grpDatos.Controls.Add(this.btnCancelar);
            this.grpDatos.Location = new System.Drawing.Point(12, 12);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(331, 363);
            this.grpDatos.TabIndex = 2;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos";
            // 
            // lblCodigo
            // 
            this.lblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCodigo.Location = new System.Drawing.Point(116, 21);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(64, 20);
            this.lblCodigo.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(18, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "Codigo:";
            // 
            // txtSup
            // 
            this.txtSup.Location = new System.Drawing.Point(116, 254);
            this.txtSup.MaxLength = 3;
            this.txtSup.Name = "txtSup";
            this.txtSup.Size = new System.Drawing.Size(62, 20);
            this.txtSup.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(18, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Rol:";
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Checked = true;
            this.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivo.Location = new System.Drawing.Point(116, 292);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(62, 17);
            this.chkActivo.TabIndex = 17;
            this.chkActivo.Text = "Activo?";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // cboRoles
            // 
            this.cboRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoles.FormattingEnabled = true;
            this.cboRoles.Items.AddRange(new object[] {
            "Veterinario",
            "Baños",
            "Administrador"});
            this.cboRoles.Location = new System.Drawing.Point(116, 182);
            this.cboRoles.Name = "cboRoles";
            this.cboRoles.Size = new System.Drawing.Size(129, 21);
            this.cboRoles.TabIndex = 16;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(144, 325);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(72, 24);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(16, 51);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(64, 16);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Nombre:";
            // 
            // dtpFecIng
            // 
            this.dtpFecIng.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecIng.Location = new System.Drawing.Point(116, 147);
            this.dtpFecIng.Name = "dtpFecIng";
            this.dtpFecIng.Size = new System.Drawing.Size(120, 20);
            this.dtpFecIng.TabIndex = 9;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(116, 51);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(192, 20);
            this.txtNom.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(116, 221);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(192, 20);
            this.txtEmail.TabIndex = 14;
            // 
            // txtApe
            // 
            this.txtApe.Location = new System.Drawing.Point(116, 83);
            this.txtApe.Name = "txtApe";
            this.txtApe.Size = new System.Drawing.Size(192, 20);
            this.txtApe.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(14, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Cod. Supervisor:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(16, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Email:";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(16, 83);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(64, 16);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Apellido:";
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(16, 115);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(64, 16);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "Sueldo:";
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(16, 147);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(64, 16);
            this.Label4.TabIndex = 8;
            this.Label4.Text = "F. Ingreso:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(236, 325);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(72, 24);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(116, 115);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(62, 20);
            this.txtSueldo.TabIndex = 24;
            // 
            // EmpleadoActualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 384);
            this.Controls.Add(this.grpDatos);
            this.Name = "EmpleadoActualizar";
            this.Text = "EmpleadoActualizar";
            this.Load += new System.EventHandler(this.EmpleadoActualizar_Load);
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox grpDatos;
        internal System.Windows.Forms.TextBox txtSup;
        internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.ComboBox cboRoles;
        internal System.Windows.Forms.Button btnGuardar;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.DateTimePicker dtpFecIng;
        internal System.Windows.Forms.TextBox txtNom;
        internal System.Windows.Forms.TextBox txtEmail;
        internal System.Windows.Forms.TextBox txtApe;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button btnCancelar;
        internal System.Windows.Forms.Label lblCodigo;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.TextBox txtSueldo;
    }
}