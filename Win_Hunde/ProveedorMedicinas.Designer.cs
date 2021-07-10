
namespace Win_Hunde
{
    partial class ProveedorMedicinas
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
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblNomMed = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMedicina = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgProveedor = new System.Windows.Forms.DataGridView();
            this.cboProveedor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(161, 15);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(106, 20);
            this.txtTipo.TabIndex = 37;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(606, 15);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(145, 20);
            this.btnConsultar.TabIndex = 35;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblNomMed
            // 
            this.lblNomMed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNomMed.Location = new System.Drawing.Point(398, 18);
            this.lblNomMed.Name = "lblNomMed";
            this.lblNomMed.Size = new System.Drawing.Size(157, 20);
            this.lblNomMed.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(300, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Nombre Medicina";
            // 
            // lblMedicina
            // 
            this.lblMedicina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMedicina.Location = new System.Drawing.Point(161, 50);
            this.lblMedicina.Name = "lblMedicina";
            this.lblMedicina.Size = new System.Drawing.Size(106, 24);
            this.lblMedicina.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Codigo Medicina";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Ingrese tipo  Medicina";
            // 
            // dtgProveedor
            // 
            this.dtgProveedor.AllowUserToAddRows = false;
            this.dtgProveedor.AllowUserToDeleteRows = false;
            this.dtgProveedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProveedor.Location = new System.Drawing.Point(35, 82);
            this.dtgProveedor.Name = "dtgProveedor";
            this.dtgProveedor.ReadOnly = true;
            this.dtgProveedor.RowHeadersVisible = false;
            this.dtgProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProveedor.Size = new System.Drawing.Size(716, 150);
            this.dtgProveedor.TabIndex = 41;
            // 
            // cboProveedor
            // 
            this.cboProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProveedor.FormattingEnabled = true;
            this.cboProveedor.Location = new System.Drawing.Point(398, 55);
            this.cboProveedor.Name = "cboProveedor";
            this.cboProveedor.Size = new System.Drawing.Size(157, 21);
            this.cboProveedor.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Nombre del Proveedor";
            // 
            // ProveedorMedicinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 246);
            this.Controls.Add(this.dtgProveedor);
            this.Controls.Add(this.cboProveedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.lblNomMed);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblMedicina);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Name = "ProveedorMedicinas";
            this.Text = "ProveedorMedicinas";
            this.Load += new System.EventHandler(this.ProveedorMedicinas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProveedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblNomMed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblMedicina;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgProveedor;
        private System.Windows.Forms.ComboBox cboProveedor;
        private System.Windows.Forms.Label label2;
    }
}