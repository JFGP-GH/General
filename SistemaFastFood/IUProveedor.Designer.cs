namespace SistemaFastFood
{
    partial class IUProveedor
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.btnBuscarProveedor = new System.Windows.Forms.Button();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.lblNIT = new System.Windows.Forms.Label();
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.txtNIT = new System.Windows.Forms.TextBox();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.btnBuscarProveedor);
            this.gbDatos.Controls.Add(this.lblRazonSocial);
            this.gbDatos.Controls.Add(this.lblNIT);
            this.gbDatos.Controls.Add(this.lblIdCliente);
            this.gbDatos.Controls.Add(this.txtRazonSocial);
            this.gbDatos.Controls.Add(this.txtNIT);
            this.gbDatos.Controls.Add(this.txtIdCliente);
            this.gbDatos.Location = new System.Drawing.Point(12, 12);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(431, 233);
            this.gbDatos.TabIndex = 15;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos del Proveedor";
            // 
            // btnBuscarProveedor
            // 
            this.btnBuscarProveedor.Location = new System.Drawing.Point(225, 48);
            this.btnBuscarProveedor.Name = "btnBuscarProveedor";
            this.btnBuscarProveedor.Size = new System.Drawing.Size(74, 23);
            this.btnBuscarProveedor.TabIndex = 6;
            this.btnBuscarProveedor.Text = "Buscar";
            this.btnBuscarProveedor.UseVisualStyleBackColor = true;
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(20, 107);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(70, 13);
            this.lblRazonSocial.TabIndex = 5;
            this.lblRazonSocial.Text = "Razon Social";
            // 
            // lblNIT
            // 
            this.lblNIT.AutoSize = true;
            this.lblNIT.Location = new System.Drawing.Point(65, 81);
            this.lblNIT.Name = "lblNIT";
            this.lblNIT.Size = new System.Drawing.Size(25, 13);
            this.lblNIT.TabIndex = 4;
            this.lblNIT.Text = "NIT";
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.Location = new System.Drawing.Point(20, 51);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(65, 13);
            this.lblIdCliente.TabIndex = 3;
            this.lblIdCliente.Text = "IdProveedor";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(96, 104);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(293, 20);
            this.txtRazonSocial.TabIndex = 2;
            // 
            // txtNIT
            // 
            this.txtNIT.Location = new System.Drawing.Point(96, 78);
            this.txtNIT.Name = "txtNIT";
            this.txtNIT.Size = new System.Drawing.Size(132, 20);
            this.txtNIT.TabIndex = 1;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(96, 48);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.ReadOnly = true;
            this.txtIdCliente.Size = new System.Drawing.Size(100, 20);
            this.txtIdCliente.TabIndex = 0;
            // 
            // IUProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(492, 331);
            this.Controls.Add(this.gbDatos);
            this.Name = "IUProveedor";
            this.Text = "Proveedor";
            this.Controls.SetChildIndex(this.gbDatos, 0);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Button btnBuscarProveedor;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Label lblNIT;
        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.TextBox txtNIT;
        private System.Windows.Forms.TextBox txtIdCliente;
    }
}
