namespace Win_Hunde
{
    partial class Clientes
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
            this.dtgCliente = new System.Windows.Forms.DataGridView();
            this.lblRegClientes = new System.Windows.Forms.Label();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cod_cli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidos_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cel_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgCliente
            // 
            this.dtgCliente.AllowUserToAddRows = false;
            this.dtgCliente.AllowUserToDeleteRows = false;
            this.dtgCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_cli,
            this.apellidos_nombre,
            this.dni_cliente,
            this.direccion_cliente,
            this.cel_cliente,
            this.email_cliente,
            this.dueno,
            this.estado});
            this.dtgCliente.Location = new System.Drawing.Point(12, 12);
            this.dtgCliente.Name = "dtgCliente";
            this.dtgCliente.ReadOnly = true;
            this.dtgCliente.RowHeadersVisible = false;
            this.dtgCliente.RowTemplate.Height = 24;
            this.dtgCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCliente.Size = new System.Drawing.Size(759, 396);
            this.dtgCliente.TabIndex = 13;
            // 
            // lblRegClientes
            // 
            this.lblRegClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegClientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRegClientes.Location = new System.Drawing.Point(717, 411);
            this.lblRegClientes.Name = "lblRegClientes";
            this.lblRegClientes.Size = new System.Drawing.Size(54, 23);
            this.lblRegClientes.TabIndex = 17;
            // 
            // lblRegistros
            // 
            this.lblRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegistros.AutoSize = true;
            this.lblRegistros.Location = new System.Drawing.Point(636, 411);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(54, 13);
            this.lblRegistros.TabIndex = 18;
            this.lblRegistros.Text = "Registros:";
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(696, 452);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(615, 452);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 15;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Location = new System.Drawing.Point(534, 452);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cod_cli
            // 
            this.cod_cli.DataPropertyName = "cod_cli";
            this.cod_cli.HeaderText = "Codigo";
            this.cod_cli.Name = "cod_cli";
            this.cod_cli.ReadOnly = true;
            // 
            // apellidos_nombre
            // 
            this.apellidos_nombre.DataPropertyName = "apellidos_nombre";
            this.apellidos_nombre.HeaderText = "Nombres y Apellidos";
            this.apellidos_nombre.Name = "apellidos_nombre";
            this.apellidos_nombre.ReadOnly = true;
            // 
            // dni_cliente
            // 
            this.dni_cliente.DataPropertyName = "dni_cliente";
            this.dni_cliente.HeaderText = "DNI";
            this.dni_cliente.Name = "dni_cliente";
            this.dni_cliente.ReadOnly = true;
            // 
            // direccion_cliente
            // 
            this.direccion_cliente.DataPropertyName = "direccion_cliente";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.direccion_cliente.DefaultCellStyle = dataGridViewCellStyle1;
            this.direccion_cliente.HeaderText = "Direccion";
            this.direccion_cliente.Name = "direccion_cliente";
            this.direccion_cliente.ReadOnly = true;
            // 
            // cel_cliente
            // 
            this.cel_cliente.DataPropertyName = "cel_cliente";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.cel_cliente.DefaultCellStyle = dataGridViewCellStyle2;
            this.cel_cliente.HeaderText = "Tel. celular";
            this.cel_cliente.Name = "cel_cliente";
            this.cel_cliente.ReadOnly = true;
            // 
            // email_cliente
            // 
            this.email_cliente.DataPropertyName = "email_cliente";
            this.email_cliente.HeaderText = "Correo electronico";
            this.email_cliente.Name = "email_cliente";
            this.email_cliente.ReadOnly = true;
            // 
            // dueno
            // 
            this.dueno.DataPropertyName = "dueno";
            this.dueno.HeaderText = "¿Dueño o familiar?";
            this.dueno.Name = "dueno";
            this.dueno.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 487);
            this.Controls.Add(this.lblRegClientes);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dtgCliente);
            this.Name = "Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgCliente;
        private System.Windows.Forms.Label lblRegClientes;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_cli;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidos_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cel_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn email_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueno;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }
}