using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaFastFood
{
    public partial class IUVenta : SistemaFastFood.IUBase
    {
        public IUVenta()
        {
            InitializeComponent();
        }
//--------------------------------------------

        #region "Variables Locales"
        private long Indice;
        private int IdVenta = 0;
        //private int IdCliente = 0;
        private NEGOCIO.Venta ObjVentaActual = new NEGOCIO.Venta(); ////----------
        //private NEGOCIO.Cliente ObjClienteActual = new NEGOCIO.Cliente();
        private DataTable dtLista;
        #endregion

        private void IUProveedor_Load(object sender, EventArgs e)
        {
            MostrarPanelBotones(false);
            this.btnEliminar.Visible = false;
            this.btnImprimir.Visible = false;
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
            txtIdVenta.Text = "";
            //txtFecha.Text = "";
            txtIdCliente.Text = "";
            txtNIT.Text = "";
            txtRazonSocial.Text = "";
            txtNombreCliente.Text = "";

        }
        public override void ProcesoAceptar()
        {

            if (ValidarDatos() == false)
            {
                MessageBox.Show("FALTA Ingresar datos");
                return;
            }
            NEGOCIO.Venta oVenta = new NEGOCIO.Venta();
            LeerDatos(ref oVenta);
            try
            {

                if (IdVenta == 0)
                {
                    oVenta.Insertar(); //0, txtNombre.Text, txtApellidoPaterno.Text, txtApellidoMaterno.Text, txtNombre.Text & [ª0000ª] & txtApellidoPaterno.Text & [ª0001ª] & txtApellidoMaterno.Text, txtEmpresa.Text, sw, txtDireccion.Text, txtEmail.Text, txtNit.Text, dtpFechaNacimiento.Value, Now, True, cmbEstadoCivil.SelectedValue, cmbId_Tipo_Empresa.SelectedValue)
                    txtIdVenta.Text = Convert.ToString(oVenta.IdVenta);
                    //MsgBox("Guardado correctamente", MsgBoxStyle.Information);
                    MessageBox.Show("Guardado correctamente");
                }
                else
                {
                    oVenta.Modificar(); //txtIdProveedor.Text, txtNombre.Text, txtApellidoPaterno.Text, txtApellidoMaterno.Text, txtNombre.Text & [ª0000ª] & txtApellidoPaterno.Text & [ª0001ª] & txtApellidoMaterno.Text, txtEmpresa.Text, sw, txtDireccion.Text, txtEmail.Text, txtNit.Text, dtpFechaNacimiento.Value, Now, True, cmbEstadoCivil.SelectedValue, cmbId_Tipo_Empresa.SelectedValue)
                    //MsgBox("Modificado correctamente", MsgBoxStyle.Information);
                }


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
                    NEGOCIO.Venta oVenta = new NEGOCIO.Venta();
                    LeerDatos(ref oVenta);

                    oVenta.Eliminar();
                    MessageBox.Show("Eliminado correctamente");
                    ProcesarConsulta();

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el Cliente");
            }
        }

        public void LeerDatos(ref NEGOCIO.Venta oVenta)
        {

            if (this.IdVenta > 0)
            {
                oVenta.IdVenta = Convert.ToInt32(txtIdVenta.Text);  //---------------
            }

            //oVenta.fecha = txtFecha.Text;
            oVenta.fecha = dTPFechaVenta.Text;
            oVenta.fkIdCliente = Convert.ToInt32(txtIdCliente.Text);
            oVenta.NIT= txtNIT.Text;//NIT
            oVenta.razonSocial = txtRazonSocial.Text;
            oVenta.nombreCliente = txtNombreCliente.Text;

        }

        public override void ProcesoModificar()
        {

            if ((txtIdVenta.Text != ""))
            {
                this.IdVenta = Convert.ToInt32(txtIdVenta.Text);
                base.ProcesoModificar();
                dTPFechaVenta.Focus();


            }
            else
            {

                MessageBox.Show("Busque un registro para modificar");
            }
        }
        public override void ProcesoEliminar()
        {
            if ((txtIdVenta.Text != "" & this.IdVenta > 0))
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
            this.IdVenta = 0;

            limpiarEntradas();
            dTPFechaVenta.Focus();

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

        private void btnBuscarVenta_Click(object sender, EventArgs e)
        {
            IUVentaBuscar fB = new IUVentaBuscar();
            fB.ShowDialog();
            txtIdVenta.Text = Convert.ToString(fB.registro.IdVenta);
            IdVenta = fB.registro.IdVenta;
            //txtFecha.Text = Convert.ToString(fB.registro.fecha);
            dTPFechaVenta.Text = fB.registro.fecha;
            txtIdCliente.Text = Convert.ToString(fB.registro.fkIdCliente);
            txtNIT.Text = fB.registro.NIT;
            txtRazonSocial.Text = fB.registro.razonSocial;
            txtNombreCliente.Text = fB.registro.razonSocial;
        }


        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            IUClienteBuscar fB = new IUClienteBuscar();
            fB.ShowDialog();
            txtIdCliente.Text = Convert.ToString(fB.registro.IdCliente);
            //IdCliente = fB.registro.IdCliente;
            txtNIT.Text = fB.registro.NIT;
            txtRazonSocial.Text = fB.registro.RazonSocial;
            txtNombreCliente.Text = fB.registro.NombreCliente;

        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            IUProductoBuscar fB = new IUProductoBuscar();
            fB.ShowDialog();
            txtIdProducto.Text = Convert.ToString(fB.registro.IdProducto);
            txtNombreProducto.Text = fB.registro.NombreProducto;
            txtCantidad.Text = Convert.ToString(fB.registro.CantidadStock);
            txtPrecio.Text = Convert.ToString(fB.registro.PrecioVenta);

        }









//---------------------------------------------
    }
}
