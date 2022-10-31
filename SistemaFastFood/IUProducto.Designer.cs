namespace SistemaFastFood
{
    partial class IUProducto
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRegistrarProducto = new System.Windows.Forms.Label();
            this.lblCantidadStock = new System.Windows.Forms.Label();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.lblPrecioCompra = new System.Windows.Forms.Label();
            this.txtCantidadStock = new System.Windows.Forms.TextBox();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.btnAbrirImagen = new System.Windows.Forms.Button();
            this.cbxFkIdCategoria = new System.Windows.Forms.ComboBox();
            this.pbxFoto = new System.Windows.Forms.PictureBox();
            this.lblfkIdCategoria = new System.Windows.Forms.Label();
            this.lblFoto = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.lblIdProducto = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRegistrarProducto);
            this.groupBox1.Controls.Add(this.lblCantidadStock);
            this.groupBox1.Controls.Add(this.lblPrecioVenta);
            this.groupBox1.Controls.Add(this.lblPrecioCompra);
            this.groupBox1.Controls.Add(this.txtCantidadStock);
            this.groupBox1.Controls.Add(this.txtPrecioCompra);
            this.groupBox1.Controls.Add(this.txtPrecioVenta);
            this.groupBox1.Controls.Add(this.btnBuscarProducto);
            this.groupBox1.Controls.Add(this.btnAbrirImagen);
            this.groupBox1.Controls.Add(this.cbxFkIdCategoria);
            this.groupBox1.Controls.Add(this.pbxFoto);
            this.groupBox1.Controls.Add(this.lblfkIdCategoria);
            this.groupBox1.Controls.Add(this.lblFoto);
            this.groupBox1.Controls.Add(this.lblDescripcion);
            this.groupBox1.Controls.Add(this.lblNombreProducto);
            this.groupBox1.Controls.Add(this.lblIdProducto);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.txtNombreProducto);
            this.groupBox1.Controls.Add(this.txtIdProducto);
            this.groupBox1.Location = new System.Drawing.Point(13, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(827, 526);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS";
            // 
            // lblRegistrarProducto
            // 
            this.lblRegistrarProducto.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblRegistrarProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRegistrarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrarProducto.ForeColor = System.Drawing.SystemColors.Info;
            this.lblRegistrarProducto.Location = new System.Drawing.Point(4, 19);
            this.lblRegistrarProducto.Name = "lblRegistrarProducto";
            this.lblRegistrarProducto.Size = new System.Drawing.Size(819, 20);
            this.lblRegistrarProducto.TabIndex = 21;
            this.lblRegistrarProducto.Text = "REGISTRAR PRODUCTO";
            this.lblRegistrarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCantidadStock
            // 
            this.lblCantidadStock.AutoSize = true;
            this.lblCantidadStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadStock.Location = new System.Drawing.Point(35, 239);
            this.lblCantidadStock.Name = "lblCantidadStock";
            this.lblCantidadStock.Size = new System.Drawing.Size(123, 18);
            this.lblCantidadStock.TabIndex = 20;
            this.lblCantidadStock.Text = "CantidadStock:";
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioVenta.Location = new System.Drawing.Point(54, 198);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(104, 18);
            this.lblPrecioVenta.TabIndex = 19;
            this.lblPrecioVenta.Text = "PrecioVenta:";
            // 
            // lblPrecioCompra
            // 
            this.lblPrecioCompra.AutoSize = true;
            this.lblPrecioCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioCompra.Location = new System.Drawing.Point(36, 160);
            this.lblPrecioCompra.Name = "lblPrecioCompra";
            this.lblPrecioCompra.Size = new System.Drawing.Size(122, 18);
            this.lblPrecioCompra.TabIndex = 18;
            this.lblPrecioCompra.Text = "PrecioCompra:";
            // 
            // txtCantidadStock
            // 
            this.txtCantidadStock.Location = new System.Drawing.Point(184, 238);
            this.txtCantidadStock.Name = "txtCantidadStock";
            this.txtCantidadStock.Size = new System.Drawing.Size(140, 22);
            this.txtCantidadStock.TabIndex = 17;
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Location = new System.Drawing.Point(184, 160);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(140, 22);
            this.txtPrecioCompra.TabIndex = 16;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(184, 198);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(140, 22);
            this.txtPrecioVenta.TabIndex = 15;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarProducto.AutoSize = true;
            this.btnBuscarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBuscarProducto.BackgroundImage = global::SistemaFastFood.Properties.Resources.Actions_edit_find_icon;
            this.btnBuscarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProducto.ForeColor = System.Drawing.Color.Navy;
            this.btnBuscarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarProducto.Location = new System.Drawing.Point(370, 62);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(190, 34);
            this.btnBuscarProducto.TabIndex = 14;
            this.btnBuscarProducto.Text = "Buscar:       ";
            this.btnBuscarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            this.btnBuscarProducto.UseWaitCursor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // btnAbrirImagen
            // 
            this.btnAbrirImagen.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAbrirImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirImagen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAbrirImagen.Location = new System.Drawing.Point(184, 291);
            this.btnAbrirImagen.Name = "btnAbrirImagen";
            this.btnAbrirImagen.Size = new System.Drawing.Size(106, 33);
            this.btnAbrirImagen.TabIndex = 13;
            this.btnAbrirImagen.Text = "Abrir Imagen";
            this.btnAbrirImagen.UseVisualStyleBackColor = false;
            this.btnAbrirImagen.Click += new System.EventHandler(this.btnAbrirImagen_Click);
            // 
            // cbxFkIdCategoria
            // 
            this.cbxFkIdCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFkIdCategoria.FormattingEnabled = true;
            this.cbxFkIdCategoria.Location = new System.Drawing.Point(346, 442);
            this.cbxFkIdCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.cbxFkIdCategoria.Name = "cbxFkIdCategoria";
            this.cbxFkIdCategoria.Size = new System.Drawing.Size(328, 24);
            this.cbxFkIdCategoria.TabIndex = 12;
            // 
            // pbxFoto
            // 
            this.pbxFoto.Location = new System.Drawing.Point(346, 178);
            this.pbxFoto.Margin = new System.Windows.Forms.Padding(4);
            this.pbxFoto.Name = "pbxFoto";
            this.pbxFoto.Size = new System.Drawing.Size(329, 239);
            this.pbxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxFoto.TabIndex = 11;
            this.pbxFoto.TabStop = false;
            // 
            // lblfkIdCategoria
            // 
            this.lblfkIdCategoria.AutoSize = true;
            this.lblfkIdCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfkIdCategoria.Location = new System.Drawing.Point(181, 445);
            this.lblfkIdCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfkIdCategoria.Name = "lblfkIdCategoria";
            this.lblfkIdCategoria.Size = new System.Drawing.Size(95, 18);
            this.lblfkIdCategoria.TabIndex = 10;
            this.lblfkIdCategoria.Text = "fkIdCategoria";
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Location = new System.Drawing.Point(367, 157);
            this.lblFoto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(36, 17);
            this.lblFoto.TabIndex = 9;
            this.lblFoto.Text = "Foto";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(55, 125);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(103, 18);
            this.lblDescripcion.TabIndex = 8;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.Location = new System.Drawing.Point(17, 93);
            this.lblNombreProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(142, 18);
            this.lblNombreProducto.TabIndex = 7;
            this.lblNombreProducto.Text = "NombreProducto:";
            // 
            // lblIdProducto
            // 
            this.lblIdProducto.AutoSize = true;
            this.lblIdProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdProducto.Location = new System.Drawing.Point(63, 62);
            this.lblIdProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdProducto.Name = "lblIdProducto";
            this.lblIdProducto.Size = new System.Drawing.Size(95, 18);
            this.lblIdProducto.TabIndex = 6;
            this.lblIdProducto.Text = "IdProducto:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(184, 125);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(496, 22);
            this.txtDescripcion.TabIndex = 2;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(184, 93);
            this.txtNombreProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(132, 22);
            this.txtNombreProducto.TabIndex = 1;
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Location = new System.Drawing.Point(184, 61);
            this.txtIdProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.ReadOnly = true;
            this.txtIdProducto.Size = new System.Drawing.Size(132, 22);
            this.txtIdProducto.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Archivo JPG|*.JPG";
            // 
            // IUProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(876, 607);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "IUProducto";
            this.Text = "PRODUCTO";
            this.Load += new System.EventHandler(this.IUProducto_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxFkIdCategoria;
        private System.Windows.Forms.PictureBox pbxFoto;
        private System.Windows.Forms.Label lblfkIdCategoria;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Label lblIdProducto;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.Button btnAbrirImagen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Label lblCantidadStock;
        private System.Windows.Forms.Label lblPrecioVenta;
        private System.Windows.Forms.Label lblPrecioCompra;
        private System.Windows.Forms.TextBox txtCantidadStock;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label lblRegistrarProducto;

    }
}
