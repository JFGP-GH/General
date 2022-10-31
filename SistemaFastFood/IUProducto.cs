using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaFastFood
{
    public partial class IUProducto : SistemaFastFood.IUBase
    {
        public IUProducto()
        {
            InitializeComponent();
        }
    //
        #region "Variables Locales"
        private long Indice;
        private int IdProducto = 0;
        private NEGOCIO.Producto ObjClienteActual = new NEGOCIO.Producto();
        private DataTable dtLista;
        #endregion

        private void IUProducto_Load(object sender, EventArgs e)
        {


            MostrarPanelBotones(true);
            this.btnEliminar.Visible = false;
            this.btnImprimir.Visible = false;
            CargarCategoria();//Cargar La Lista de Desplazamiento
        }
        #region "Metodo Botones"
        public override void HabilitarEntradas(bool value)
        {
            base.HabilitarEntradas(value);
            //txtIdProveedor.Enabled = value
            //txt.Enabled = value;
        }
        public void limpiarEntradas()
        {

            base.LimpiarEntradas();
            txtIdProducto.Text = "";//IdCliente  
            txtNombreProducto.Text = ""; //NIT
            txtDescripcion.Text = "";//RAZON
            pbxFoto.ResetText(); //Foto
            txtPrecioCompra.Text = "";
            txtPrecioVenta.Text = "";
            txtCantidadStock.Text = "";


        }
        public override void ProcesoAceptar()
        {

            if (ValidarDatos() == false)
            {
                MessageBox.Show("FALTA Ingresar datos");
                return;
            }
            NEGOCIO.Producto oProducto = new NEGOCIO.Producto();
            LeerDatos(ref oProducto);
            try
            {

                if (IdProducto == 0)
                {
                    oProducto.Insertar(); //0, txtNombre.Text, txtApellidoPaterno.Text, txtApellidoMaterno.Text, txtNombre.Text & [ª0000ª] & txtApellidoPaterno.Text & [ª0001ª] & txtApellidoMaterno.Text, txtEmpresa.Text, sw, txtDireccion.Text, txtEmail.Text, txtNit.Text, dtpFechaNacimiento.Value, Now, True, cmbEstadoCivil.SelectedValue, cmbId_Tipo_Empresa.SelectedValue)
                    txtIdProducto.Text = Convert.ToString(oProducto.IdProducto);
                    MessageBox.Show("Guardado correctamente");
                    //MsgBox("Guardado correctamente", MsgBoxStyle.Information);
                }
                else
                {
                    oProducto.Modificar(); //txtIdProveedor.Text, txtNombre.Text, txtApellidoPaterno.Text, txtApellidoMaterno.Text, txtNombre.Text & [ª0000ª] & txtApellidoPaterno.Text & [ª0001ª] & txtApellidoMaterno.Text, txtEmpresa.Text, sw, txtDireccion.Text, txtEmail.Text, txtNit.Text, dtpFechaNacimiento.Value, Now, True, cmbEstadoCivil.SelectedValue, cmbId_Tipo_Empresa.SelectedValue)
                    //MsgBox("Modificado correctamente", MsgBoxStyle.Information);
                }

                LimpiarEntradas();
                base.HabilitarOperaciones(true);

            }
            catch (Exception ex)
            {
                //MsgBox("Error al guardar el Cliente: " + ex.ToString(), MsgBoxStyle.Critical);
            }
        }

        public override void ProcesoCancelar()
        {
            base.Cancelar();
            base.HabilitarOperaciones(true);
        }

        public override void Eliminar()
        {
            try
            {
                if (MessageBox.Show("Confirma la Eliminarcion", "ELIMINAR", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    NEGOCIO.Producto oProducto = new NEGOCIO.Producto();
                    LeerDatos(ref oProducto);

                    oProducto.Eliminar();
                    MessageBox.Show("Eliminado correctamente");
                    ProcesarConsulta();

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el Cliente");
            }
        }

        public void LeerDatos(ref NEGOCIO.Producto oProducto)
        {

            if (this.IdProducto > 0)
            {
                oProducto.IdProducto = Convert.ToInt32(txtIdProducto.Text);
            }

            oProducto.NombreProducto = txtNombreProducto.Text.Trim();
            oProducto.Descripcion = txtDescripcion.Text.Trim();
            oProducto.Foto = NEGOCIO.Imagen.ImagenUrlToBytes(pbxFoto.Image.Tag.ToString());
            oProducto.fkIdCategoria = Convert.ToInt32(cbxFkIdCategoria.SelectedValue);
            oProducto.PrecioCompra = decimal.Parse(txtPrecioCompra.Text);
            oProducto.PrecioVenta = decimal.Parse(txtPrecioVenta.Text);
            oProducto.CantidadStock = Convert.ToInt32(txtCantidadStock.Text);

        }

        public override void ProcesoModificar()
        {

            if ((txtIdProducto.Text != ""))
            {
                this.IdProducto = Convert.ToInt32(txtIdProducto.Text);
                base.ProcesoModificar();
                txtNombreProducto.Focus();


            }
            else
            {

                MessageBox.Show("Busque un registro para modificar");
            }
        }
        public override void ProcesoEliminar()
        {
            if ((txtIdProducto.Text != "" & this.IdProducto > 0))
            {
                this.Eliminar();
            }
            else
            {
                MessageBox.Show("Busque un registro para eliminar");
            }
        }
        public override void ProcesoNuevo()
        {

            base.ProcesoNuevo();
            this.IdProducto = 0;

            limpiarEntradas();
            txtNombreProducto.Focus();

        }
        #endregion

        private void btnVerListadoReporteProveedor_Click(System.Object sender, System.EventArgs e)
        {
            //Try
            //    IUVisor.NombreReporte = "rListadoProveedor"
            //    IUVisor.ShowDialog()
            //Catch ex As Exception

            //End Try
        }

        private bool ValidarDatos()
        {
            bool sw = true;
            //epError.Clear();


            //if (txtNombre.Text.Trim().Length == 0)
            //{
            //    epError.SetError(txtNombre, "Ingrese el nombre del proveedor");
            //    sw = false;
            //}

            //if (txtTelefono.Text.Trim().Length == 0)
            //{
            //    epError.SetError(txtTelefono, "Ingrese Telefono");
            //    sw = false;
            //}

            return sw;
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            IUProductoBuscar fB = new IUProductoBuscar();
            fB.ShowDialog();
            txtIdProducto.Text = Convert.ToString(fB.registro.IdProducto);
            IdProducto = fB.registro.IdProducto;
            txtNombreProducto.Text = fB.registro.NombreProducto;
            txtDescripcion.Text = fB.registro.Descripcion;


            pbxFoto.Image = NEGOCIO.Imagen.BytesToImagen(fB.registro.Foto);
            cbxFkIdCategoria.SelectedValue =  fB.registro.fkIdCategoria;

            txtPrecioCompra.Text = Convert.ToString(fB.registro.PrecioCompra) ;
            txtPrecioVenta.Text = Convert.ToString(fB.registro .PrecioVenta) ;
            txtCantidadStock.Text = Convert.ToString(fB.registro.CantidadStock); 

        }

        private void btnAbrirImagen_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    pbxFoto.Image = Image.FromFile(openFileDialog1.FileName);
                    pbxFoto.Image.Tag = openFileDialog1.FileName;
                }

            }
            catch (Exception ex)
            {
                
                //throw;
            }
        }
        private void CargarCategoria() {
            try
            {
                NEGOCIO.Categoria oCategoria = new NEGOCIO.Categoria();
                DataTable dt;
                dt = oCategoria.Traer("");
                cbxFkIdCategoria.DataSource = dt;
                cbxFkIdCategoria.ValueMember = "IdCategoria";
                cbxFkIdCategoria.DisplayMember = "NombreCategoria";
            }
            catch (Exception ex)
            {
                
                //throw;
            }
        }




        
  //
    }
}
