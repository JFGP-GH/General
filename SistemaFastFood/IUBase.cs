using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaFastFood
{
    public partial class IUBase : Form
    {

        protected Utilitario.Utilitarios._ABM Estado = Utilitario.Utilitarios._ABM.Consultar;
 

        public IUBase()
        {
            InitializeComponent();
        }

        #region "Metodos"
 
 
    public virtual void ProcesoNuevo() {
        LimpiarEntradas();
        HabilitarEntradas(true);
        HabilitarOperaciones(false);
        //habilitarAceptarCancelar(True)
        HabilitarBuscarImprimir(false);
        Estado = Utilitario.Utilitarios._ABM.Guardar;
        slblEstado.Text = "Nuevo registro";
        slblMensaje.Text = "Editando un nuevo registro";
 
    }  
    public virtual void ProcesoModificar() {
 
        HabilitarEntradas(true);
        HabilitarOperaciones(false);
        //habilitarAceptarCancelar(True)
        HabilitarBuscarImprimir(false);
        Estado = Utilitario.Utilitarios._ABM.Modificar;
        slblEstado.Text = "Modificar registro";
        slblMensaje.Text = "Modificando el registro";
 
    }  
    public virtual void ProcesoEliminar() {
 
        HabilitarEntradas(false);
        HabilitarOperaciones(false);
        //habilitarAceptarCancelar(True)
        HabilitarBuscarImprimir(false);
        //Estado = Utilitario.Utilitarios._ABM.Eliminar;
        slblEstado.Text = "Eliminar registro";
        slblMensaje.Text = "Eliminando el registro actual";
 
    }  
 
    //Public Overridable Sub Guardar()
 
 
    //End Sub
    public virtual void Cancelar() {
 
        HabilitarEntradas(false);
        HabilitarOperaciones(false);
        Estado = Utilitario.Utilitarios._ABM.Consultar;
        slblEstado.Text = "";
        slblMensaje.Text = "";
    }  
    public virtual void Eliminar() {
 
 
    }  
    //Public Overridable Sub Modificar()
 
 
    //End Sub
 
    /// <summary>
    /// Acepta el proceso en curso puede ser:
    /// Guardar;Modificar o Eliminar
    /// </summary>
    /// <remarks></remarks>
    public virtual void ProcesoAceptar() {
        try{
            switch(Estado){
                //Case Utilitario.Utilitarios._ABM.Guardar : Guardar()
                //Case Utilitario.Utilitarios._ABM.Modificar : Modificar()
                case Utilitario.Utilitarios._ABM.Eliminar:;Eliminar();
            break;
  
            }
 
        }catch(Exception ex){
 
        }
    }  
    public virtual void ProcesoCancelar() {
        try{
            this.HabilitarOperaciones(true);
            //Me.HabilitarAceptarCancelar(False)
 
        }catch(Exception ex){
 
        }
    }  
    public virtual void ProcesarConsulta() {
 
        HabilitarEntradas(false);
        HabilitarOperaciones(true);
        //habilitarAceptarCancelar(False)
        HabilitarBuscarImprimir(true);
        LimpiarEntradas();
        Estado = Utilitario.Utilitarios._ABM.Consultar;
        slblEstado.Text = "Consulta";
        slblMensaje.Text = "";
    }  
    public virtual void ProcesoListar() {
 
    }  
    public virtual void ProcesoBuscar() {
 
    }  
    public virtual void ProcesoImprimir() {
 
 
    }  
    public virtual void ProcesoCerrar() {
        Close();
    }  
 
    public virtual void HabilitarEntradas(bool value) {
 
 
    }  
    public virtual void LimpiarEntradas() {
 
    }  
    /// <summary>
    ///  btnNuevo.Enabled = value
    ///  btnModificar.Enabled = value
    ///  btnEliminar.Enabled = value
    ///  btnAceptar.Enabled = Not value
    ///  btnCancelar.Enabled = Not value
    /// </summary>
    /// <param name="value"></param>
    /// <remarks></remarks>
    public virtual void HabilitarOperaciones(bool value) {
        btnNuevo.Enabled = value;
        btnModificar.Enabled = value;
        btnEliminar.Enabled = value;
 
        btnAceptar.Enabled = ! value;
        btnCancelar.Enabled = ! value;
    }  
    //Public Overridable Sub HabilitarAceptarCancelar(ByVal value As Boolean)
    //    btnNuevo.Enabled = Not value
    //    btnModificar.Enabled = Not value
    //    btnEliminar.Enabled = Not value
 
    //    btnAceptar.Enabled = value
    //    btnCancelar.Enabled = value
    //End Sub
    public virtual void HabilitarBuscarImprimir(bool value) {
        btnBuscar.Enabled = value;
        btnImprimir.Enabled = value;
    }  
 
    public virtual void MostrarPanelBotones(bool sw) 
    {
        this.tsBotones.Visible = sw;
        this.ssEstado.Visible = sw;
    }  
 #endregion 

        #region "Seguridad sobre registros"
 
    /// <summary>
    /// Muestra los datos de un registro, quien lo creo y quien lo modifico con sus fecha y horas respectivas
    /// </summary>
    /// <param name="IdUsuarioCreador"></param>
    /// <param name="FechaCreado"></param>
    /// <param name="IdUsuarioModificador"></param>
    /// <param name="FechaModificado"></param>
    /// <remarks></remarks>
    public virtual void MostrarSeguridad(int IdUsuarioCreador, DateTime FechaCreado, int IdUsuarioModificador, DateTime FechaModificado) {
        //Try
        //    Me.slblUsuarioCreador.Visible = False
        //    Me.slblCreadoPor.Visible = False
        //    Me.slblFechaCreado.Visible = False
 
        //    Me.slblUsuarioModificador.Visible = False
        //    Me.slblModificadoPor.Visible = False
        //    Me.slblFechaModificado.Visible = False
 
        //    If IdUsuarioCreador > 0 Then
        //        Dim oUsuarioCreador As New NEGOCIO.guUsuario
        //        oUsuarioCreador.IdUsuario = IdUsuarioCreador
        //        oUsuarioCreador.ObtenerRegistro()
 
        //        Me.slblUsuarioCreador.Tag = oUsuarioCreador.IdUsuario
        //        Me.slblUsuarioCreador.Text = oUsuarioCreador.Usuario
        //        Me.slblFechaCreado.Text = FechaCreado.ToString
        //        Me.slblUsuarioCreador.Visible = True
        //        Me.slblCreadoPor.Visible = True
        //        Me.slblFechaCreado.Visible = True
 
        //        If IdUsuarioModificador > 0 Then
        //            Dim oUsuarioModificador As New NEGOCIO.guUsuario
        //            oUsuarioModificador.IdUsuario = IdUsuarioCreador
        //            oUsuarioModificador.ObtenerRegistro()
 
        //            Me.slblUsuarioModificador.Tag = oUsuarioModificador.IdUsuario
        //            Me.slblUsuarioModificador.Text = oUsuarioModificador.Usuario
        //            Me.slblFechaModificado.Text = FechaModificado.ToString
 
        //            Me.slblUsuarioModificador.Visible = True
        //            Me.slblModificadoPor.Visible = True
        //            Me.slblFechaModificado.Visible = True
 
        //        End If
 
        //    End If
 
        //Catch ex As Exception
 
        //End Try
    }  
 
 
    public virtual int DevolverIdCreador() {
        try{
            return Convert.ToInt32(this.slblUsuarioCreador.Tag);
        }catch(Exception ex){
            return 0;
        }
    }  
 
    public virtual DateTime DevolverFechaCreado() {
        try{
            return Convert.ToDateTime(this.slblFechaCreado.Text);
        }catch(Exception ex){
            return DateTime.Now ;
        }
    }  
 
    public virtual int DevolverIdModificador() {
        try{
            return Convert.ToInt32(this.slblUsuarioModificador.Tag);
        }catch(Exception ex){
            return 0;
        }
    }  
 
    public virtual DateTime DevolverFechaModificado() {
        try{
            return Convert.ToDateTime(this.slblFechaModificado.Text);
        }catch(Exception ex){
            return DateTime.Now;
        }
    }  
 
#endregion
        #region "Eventos"
            private void IUBase_Load(object sender, EventArgs e) {
                ProcesarConsulta();
            }  
 
            private void btnNuevo_Click(System.Object sender, System.EventArgs e) {
                ProcesoNuevo();
            }  
 
            private void btnModificar_Click(System.Object sender, System.EventArgs e) {
                ProcesoModificar();
            }  
 
            private void btnEliminar_Click(System.Object sender, System.EventArgs e) {
                ProcesoEliminar();
            }  
 
            private void btnAceptar_Click(System.Object sender, System.EventArgs e) {
                ProcesoAceptar();
            }  
 
            private void btnCancelar_Click(System.Object sender, System.EventArgs e) {
                ProcesoCancelar();
            }  
 
            private void btnBuscar_Click(System.Object sender, System.EventArgs e) {
                ProcesoBuscar();
            }  
 
            private void btnImprimir_Click(System.Object sender, System.EventArgs e) {
                ProcesoImprimir();
            }  
 
            private void btnSalir_Click(System.Object sender, System.EventArgs e) {
                ProcesoCerrar();
            }  
         #endregion

    }
}

