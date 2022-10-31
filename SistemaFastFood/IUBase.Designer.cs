namespace SistemaFastFood
{
    partial class IUBase
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IUBase));
            this.slblEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.slblCreadoPor = new System.Windows.Forms.ToolStripStatusLabel();
            this.slblUsuarioCreador = new System.Windows.Forms.ToolStripStatusLabel();
            this.slblFechaModificado = new System.Windows.Forms.ToolStripStatusLabel();
            this.slblMensaje = new System.Windows.Forms.ToolStripStatusLabel();
            this.slblModificadoPor = new System.Windows.Forms.ToolStripStatusLabel();
            this.slblFechaCreado = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssEstado = new System.Windows.Forms.StatusStrip();
            this.slblUsuarioModificador = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsBotones = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAceptar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.btnImprimir = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ssEstado.SuspendLayout();
            this.tsBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // slblEstado
            // 
            this.slblEstado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.slblEstado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.slblEstado.ForeColor = System.Drawing.Color.DarkRed;
            this.slblEstado.Name = "slblEstado";
            this.slblEstado.Size = new System.Drawing.Size(54, 17);
            this.slblEstado.Text = "Consulta";
            // 
            // slblCreadoPor
            // 
            this.slblCreadoPor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.slblCreadoPor.Name = "slblCreadoPor";
            this.slblCreadoPor.Size = new System.Drawing.Size(66, 17);
            this.slblCreadoPor.Text = "Creado por";
            // 
            // slblUsuarioCreador
            // 
            this.slblUsuarioCreador.ForeColor = System.Drawing.SystemColors.Desktop;
            this.slblUsuarioCreador.Name = "slblUsuarioCreador";
            this.slblUsuarioCreador.Size = new System.Drawing.Size(62, 17);
            this.slblUsuarioCreador.Text = "Supervisor";
            // 
            // slblFechaModificado
            // 
            this.slblFechaModificado.ForeColor = System.Drawing.Color.Red;
            this.slblFechaModificado.Name = "slblFechaModificado";
            this.slblFechaModificado.Size = new System.Drawing.Size(95, 17);
            this.slblFechaModificado.Text = "25/04/2010 12:10";
            // 
            // slblMensaje
            // 
            this.slblMensaje.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slblMensaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.slblMensaje.Name = "slblMensaje";
            this.slblMensaje.Size = new System.Drawing.Size(131, 17);
            this.slblMensaje.Text = "Mensaje de la accion";
            // 
            // slblModificadoPor
            // 
            this.slblModificadoPor.Name = "slblModificadoPor";
            this.slblModificadoPor.Size = new System.Drawing.Size(89, 17);
            this.slblModificadoPor.Text = "Modificado por";
            // 
            // slblFechaCreado
            // 
            this.slblFechaCreado.ForeColor = System.Drawing.Color.Red;
            this.slblFechaCreado.Name = "slblFechaCreado";
            this.slblFechaCreado.Size = new System.Drawing.Size(95, 17);
            this.slblFechaCreado.Text = "25/04/2010 10:20";
            // 
            // ssEstado
            // 
            this.ssEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slblEstado,
            this.slblMensaje,
            this.slblCreadoPor,
            this.slblUsuarioCreador,
            this.slblFechaCreado,
            this.slblModificadoPor,
            this.slblUsuarioModificador,
            this.slblFechaModificado});
            this.ssEstado.Location = new System.Drawing.Point(0, 270);
            this.ssEstado.Name = "ssEstado";
            this.ssEstado.Size = new System.Drawing.Size(718, 22);
            this.ssEstado.TabIndex = 12;
            this.ssEstado.Text = "statusStrip1";
            // 
            // slblUsuarioModificador
            // 
            this.slblUsuarioModificador.ForeColor = System.Drawing.SystemColors.Desktop;
            this.slblUsuarioModificador.Name = "slblUsuarioModificador";
            this.slblUsuarioModificador.Size = new System.Drawing.Size(37, 17);
            this.slblUsuarioModificador.Text = "David";
            // 
            // tsBotones
            // 
            this.tsBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsBotones.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tsBotones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnModificar,
            this.btnEliminar,
            this.toolStripSeparator1,
            this.btnAceptar,
            this.btnCancelar,
            this.toolStripSeparator2,
            this.btnBuscar,
            this.btnImprimir,
            this.btnSalir});
            this.tsBotones.Location = new System.Drawing.Point(0, 292);
            this.tsBotones.Name = "tsBotones";
            this.tsBotones.Size = new System.Drawing.Size(718, 39);
            this.tsBotones.TabIndex = 13;
            this.tsBotones.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::SistemaFastFood.Properties.Resources.new_icon;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(78, 36);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Image = global::SistemaFastFood.Properties.Resources.Text_Edit_icon;
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(94, 36);
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::SistemaFastFood.Properties.Resources.Actions_edit_delete_icon;
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(86, 36);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = global::SistemaFastFood.Properties.Resources.Devices_media_floppy_icon;
            this.btnAceptar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(84, 36);
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::SistemaFastFood.Properties.Resources.arrow_back_icon;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 36);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::SistemaFastFood.Properties.Resources.Actions_edit_find_icon;
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(78, 36);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = global::SistemaFastFood.Properties.Resources.Devices_printer_icon;
            this.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(89, 36);
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::SistemaFastFood.Properties.Resources.Button_exit_icon;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 36);
            this.btnSalir.Text = "Cerrar";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "16 (Grid split cells).ico");
            this.ImageList1.Images.SetKeyName(1, "16 (Options-2).ico");
            this.ImageList1.Images.SetKeyName(2, "16 (Find).ico");
            this.ImageList1.Images.SetKeyName(3, "16 (Filter-2).ico");
            this.ImageList1.Images.SetKeyName(4, "desktop_32x32-32.gif");
            this.ImageList1.Images.SetKeyName(5, "file_broken_32x32-32.gif");
            this.ImageList1.Images.SetKeyName(6, "trashcan_full_32x32-32.gif");
            this.ImageList1.Images.SetKeyName(7, "16 (Save).ico");
            this.ImageList1.Images.SetKeyName(8, "Delete_32x32-32.gif");
            this.ImageList1.Images.SetKeyName(9, "k-hex-edit_32x32-32.gif");
            this.ImageList1.Images.SetKeyName(10, "16 (Card edit).ico");
            this.ImageList1.Images.SetKeyName(11, "16 (Edit-2).ico");
            // 
            // IUBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 331);
            this.Controls.Add(this.ssEstado);
            this.Controls.Add(this.tsBotones);
            this.Name = "IUBase";
            this.Text = "IUBase";
            this.Load += new System.EventHandler(this.IUBase_Load);
            this.ssEstado.ResumeLayout(false);
            this.ssEstado.PerformLayout();
            this.tsBotones.ResumeLayout(false);
            this.tsBotones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.ToolStripStatusLabel slblEstado;
        internal System.Windows.Forms.ToolStripStatusLabel slblCreadoPor;
        internal System.Windows.Forms.ToolStripStatusLabel slblUsuarioCreador;
        internal System.Windows.Forms.ToolStripStatusLabel slblFechaModificado;
        protected System.Windows.Forms.ToolStripStatusLabel slblMensaje;
        internal System.Windows.Forms.ToolStripStatusLabel slblModificadoPor;
        internal System.Windows.Forms.ToolStripStatusLabel slblFechaCreado;
        protected System.Windows.Forms.StatusStrip ssEstado;
        internal System.Windows.Forms.ToolStripStatusLabel slblUsuarioModificador;
        private System.Windows.Forms.ToolStripButton btnSalir;
        protected System.Windows.Forms.ToolStripButton btnImprimir;
        protected System.Windows.Forms.ToolStripButton btnModificar;
        protected System.Windows.Forms.ToolStripButton btnBuscar;
        protected System.Windows.Forms.ToolStripButton btnNuevo;
        protected System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStrip tsBotones;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        protected System.Windows.Forms.ToolStripButton btnAceptar;
        protected System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        internal System.Windows.Forms.ImageList ImageList1;
    }
}