using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaFastFood
{
    public partial class IUProveedor : SistemaFastFood.IUBase
    {
        public IUProveedor()
        {
            InitializeComponent();
        }

        #region "Variables Locales"
        private long Indice;
        private int IdCliente = 0;
        private NEGOCIO.Cliente ObjClienteActual = new NEGOCIO.Cliente();
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
            txtIdCliente.Text = "";
            txtNIT.Text = "";
            txtRazonSocial.Text = "";

        }
        public override void ProcesoAceptar()
        {

            if (ValidarDatos() == false)
            {
                MessageBox.Show("FALTA Ingresar datos");
                return;
            }
            NEGOCIO.Cliente oCliente = new NEGOCIO.Cliente();
            LeerDatos(ref  oCliente);
            try
            {

                if (IdCliente == 0)
                {
                    oCliente.Insertar(); //0, txtNombre.Text, txtApellidoPaterno.Text, txtApellidoMaterno.Text, txtNombre.Text & [ª0000ª] & txtApellidoPaterno.Text & [ª0001ª] & txtApellidoMaterno.Text, txtEmpresa.Text, sw, txtDireccion.Text, txtEmail.Text, txtNit.Text, dtpFechaNacimiento.Value, Now, True, cmbEstadoCivil.SelectedValue, cmbId_Tipo_Empresa.SelectedValue)
                    txtIdCliente.Text = Convert.ToString(oCliente.IdCliente);
                    //MsgBox("Guardado correctamente", MsgBoxStyle.Information);
                }
                else
                {
                    oCliente.Modificar(); //txtIdProveedor.Text, txtNombre.Text, txtApellidoPaterno.Text, txtApellidoMaterno.Text, txtNombre.Text & [ª0000ª] & txtApellidoPaterno.Text & [ª0001ª] & txtApellidoMaterno.Text, txtEmpresa.Text, sw, txtDireccion.Text, txtEmail.Text, txtNit.Text, dtpFechaNacimiento.Value, Now, True, cmbEstadoCivil.SelectedValue, cmbId_Tipo_Empresa.SelectedValue)
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
                    NEGOCIO.Cliente oCliente = new NEGOCIO.Cliente();
                    LeerDatos(ref oCliente);

                    oCliente.Eliminar();
                    MessageBox.Show("Eliminado correctamente");
                    ProcesarConsulta();

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el Cliente");
            }
        }

        public void LeerDatos(ref NEGOCIO.Cliente oCliente)
        {

            if (this.IdCliente > 0)
            {
                oCliente.IdCliente = Convert.ToInt32(txtIdCliente.Text);
            }

            oCliente.NIT = txtNIT.Text;

            oCliente.RazonSocial = txtRazonSocial.Text;

        }

        public override void ProcesoModificar()
        {

            if ((txtIdCliente.Text != ""))
            {
                this.IdCliente = Convert.ToInt32(txtIdCliente.Text);
                base.ProcesoModificar();
                txtNIT.Focus();


            }
            else
            {

                MessageBox.Show("Busque un registro para modificar");
            }
        }
        public override void ProcesoEliminar()
        {
            if ((txtIdCliente.Text != "" & this.IdCliente > 0))
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
            this.IdCliente = 0;

            limpiarEntradas();
            txtNIT.Focus();

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
            IUClienteBuscar fB = new IUClienteBuscar();
            fB.ShowDialog();
            txtIdCliente.Text = Convert.ToString(fB.registro.IdCliente);
            IdCliente = fB.registro.IdCliente;
            txtNIT.Text = Convert.ToString(fB.registro.NIT);
            txtRazonSocial.Text = fB.registro.RazonSocial;

        }
    }
}
