namespace SistemaFastFood
{
    partial class IUCliente
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
            this.lblRegistrarCliente = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
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
            this.gbDatos.Controls.Add(this.lblRegistrarCliente);
            this.gbDatos.Controls.Add(this.txtNombreCliente);
            this.gbDatos.Controls.Add(this.lblNombreCliente);
            this.gbDatos.Controls.Add(this.btnBuscarCliente);
            this.gbDatos.Controls.Add(this.lblRazonSocial);
            this.gbDatos.Controls.Add(this.lblNIT);
            this.gbDatos.Controls.Add(this.lblIdCliente);
            this.gbDatos.Controls.Add(this.txtRazonSocial);
            this.gbDatos.Controls.Add(this.txtNIT);
            this.gbDatos.Controls.Add(this.txtIdCliente);
            this.gbDatos.Location = new System.Drawing.Point(16, 1);
            this.gbDatos.Margin = new System.Windows.Forms.Padding(4);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Padding = new System.Windows.Forms.Padding(4);
            this.gbDatos.Size = new System.Drawing.Size(666, 234);
            this.gbDatos.TabIndex = 14;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos del Cliente";
            // 
            // lblRegistrarCliente
            // 
            this.lblRegistrarCliente.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblRegistrarCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRegistrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrarCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRegistrarCliente.Location = new System.Drawing.Point(4, 19);
            this.lblRegistrarCliente.Name = "lblRegistrarCliente";
            this.lblRegistrarCliente.Size = new System.Drawing.Size(658, 22);
            this.lblRegistrarCliente.TabIndex = 9;
            this.lblRegistrarCliente.Text = "REGISTRAR CLIENTE";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(160, 163);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(389, 22);
            this.txtNombreCliente.TabIndex = 8;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.Location = new System.Drawing.Point(8, 164);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(125, 18);
            this.lblNombreCliente.TabIndex = 7;
            this.lblNombreCliente.Text = "Nombre Cliente";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.Location = new System.Drawing.Point(332, 57);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(99, 28);
            this.btnBuscarCliente.TabIndex = 6;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazonSocial.Location = new System.Drawing.Point(23, 130);
            this.lblRazonSocial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(109, 18);
            this.lblRazonSocial.TabIndex = 5;
            this.lblRazonSocial.Text = "Razon Social";
            // 
            // lblNIT
            // 
            this.lblNIT.AutoSize = true;
            this.lblNIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNIT.Location = new System.Drawing.Point(95, 100);
            this.lblNIT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNIT.Name = "lblNIT";
            this.lblNIT.Size = new System.Drawing.Size(34, 18);
            this.lblNIT.TabIndex = 4;
            this.lblNIT.Text = "NIT";
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCliente.Location = new System.Drawing.Point(54, 63);
            this.lblIdCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(73, 18);
            this.lblIdCliente.TabIndex = 3;
            this.lblIdCliente.Text = "IdCliente";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(160, 126);
            this.txtRazonSocial.Margin = new System.Windows.Forms.Padding(4);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(389, 22);
            this.txtRazonSocial.TabIndex = 2;
            // 
            // txtNIT
            // 
            this.txtNIT.Location = new System.Drawing.Point(160, 94);
            this.txtNIT.Margin = new System.Windows.Forms.Padding(4);
            this.txtNIT.Name = "txtNIT";
            this.txtNIT.Size = new System.Drawing.Size(175, 22);
            this.txtNIT.TabIndex = 1;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(160, 57);
            this.txtIdCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.ReadOnly = true;
            this.txtIdCliente.Size = new System.Drawing.Size(132, 22);
            this.txtIdCliente.TabIndex = 0;
            // 
            // IUCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(917, 311);
            this.Controls.Add(this.gbDatos);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "IUCliente";
            this.Text = "IUCliente";
            this.Controls.SetChildIndex(this.gbDatos, 0);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Label lblNIT;
        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.TextBox txtNIT;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblRegistrarCliente;
    }
}
