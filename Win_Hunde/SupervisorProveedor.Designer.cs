
namespace Win_Hunde
{
    partial class SupervisorProveedor
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
            this.dtgSupervisor = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.cboSupervisor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSupervisor)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgSupervisor
            // 
            this.dtgSupervisor.AllowUserToAddRows = false;
            this.dtgSupervisor.AllowUserToDeleteRows = false;
            this.dtgSupervisor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgSupervisor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSupervisor.Location = new System.Drawing.Point(23, 53);
            this.dtgSupervisor.Name = "dtgSupervisor";
            this.dtgSupervisor.ReadOnly = true;
            this.dtgSupervisor.RowHeadersVisible = false;
            this.dtgSupervisor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgSupervisor.Size = new System.Drawing.Size(532, 150);
            this.dtgSupervisor.TabIndex = 15;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(322, 8);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(233, 23);
            this.btnConsultar.TabIndex = 14;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // cboSupervisor
            // 
            this.cboSupervisor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSupervisor.FormattingEnabled = true;
            this.cboSupervisor.Location = new System.Drawing.Point(135, 10);
            this.cboSupervisor.Name = "cboSupervisor";
            this.cboSupervisor.Size = new System.Drawing.Size(179, 21);
            this.cboSupervisor.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre del supervisor";
            // 
            // SupervisorProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 212);
            this.Controls.Add(this.dtgSupervisor);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.cboSupervisor);
            this.Controls.Add(this.label1);
            this.Name = "SupervisorProveedor";
            this.Text = "SupervisorProveedor";
            this.Load += new System.EventHandler(this.SupervisorProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSupervisor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgSupervisor;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ComboBox cboSupervisor;
        private System.Windows.Forms.Label label1;
    }
}