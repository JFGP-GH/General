using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using System;
// Creado por Ing. David Ribera Blanco
// Celular:   70902782  72130344
// E-Mail:    davidriberablanco@hotmail.com
// Fecha y Hora 13/12/2018 20:18:32
// Negocio para la tabla Venta
namespace NEGOCIO
{
public class Venta:CONEXION.DAC {

#region "Atributos" 
       private int m_IdVenta;
       private string m_fecha;
       private int m_fkIdCliente;
       private string m_NIT;//m_fkIdCajero
       private string m_razonSocial;//Txt Razon social Cliente
       private string m_nombreCliente;//txtNombreUsuario

#endregion

   #region "Propiedades" 
       public Int32 IdVenta{ 
           get {
               return m_IdVenta;
           }

           set {
               m_IdVenta = value;
           }
       }

       public string fecha{ 
           get {
               return m_fecha;
           }

           set {
               m_fecha = value;
           }
       }

       public Int32 fkIdCliente{ 
           get {
               return m_fkIdCliente;
           }

           set {
               m_fkIdCliente = value;
           }
       }

       public string NIT{ 
           get {
               return m_NIT;
           }

           set {
               m_NIT = value;
           }
       }

       public string razonSocial
       {
           get { return m_razonSocial; }
           set { m_razonSocial = value; }
       }

       public string nombreCliente
       {
           get { return m_nombreCliente; }
           set { m_nombreCliente = value; }
       }


   #endregion

   #region "Metodos" 
   public  int Insertar(){ 
       String sInsert;
       List<SqlParameter> ListPrm = new List<SqlParameter>();
       SqlTransaction trn = this.IniciarTransaccion();
       try {
           sInsert = "pVentaAdd";                                                                                           //fkIdUsuario",
           ListPrm = CONEXION.DAC.CargarListaParametros("@IdVenta", IdVenta, "@fecha", fecha, "@fkIdCliente", fkIdCliente, "@NIT", NIT, "@razonSocial", razonSocial,"@nombreCliente",nombreCliente); //@fkIdCajero
           m_IdVenta = EjecutarInsertProc(sInsert,ListPrm,trn);
       this.TerminarTransaccion(ref trn);
       return m_IdVenta;
       } catch (Exception ex){
           if (trn == null) {
       this.AbortarTransaccion(trn);
           }
           throw;
       }
   } 

   public void Modificar() {
       String sUpdate;
       List<SqlParameter> ListPrm = new List<SqlParameter>();
       try{
           sUpdate = "pVentaUpd";
           ListPrm = CONEXION.DAC.CargarListaParametros("@IdVenta", IdVenta, "@fecha", fecha, "@fkIdCliente", fkIdCliente, "@NIT", NIT, "@razonSocial", razonSocial,"@nombreCliente",nombreCliente); //---@fkIdCajero
           EjecutarProc(sUpdate,ListPrm);
       } catch (Exception ex){
           throw;
       }
   }

   public void Eliminar() {
       String sDelete;
       List<SqlParameter> ListPrm = new List<SqlParameter>();
       try{
           sDelete = "pVentaDel";
           ListPrm = CONEXION.DAC.CargarListaParametros("@IdVenta", IdVenta, "@fecha", fecha, "@fkIdCliente", fkIdCliente, "@NIT", NIT, "@razonSocial", razonSocial, "@nombreCliente", nombreCliente); //
           EjecutarProc(sDelete,ListPrm);
       } catch (Exception ex){
           throw;
       }
   } 

   public DataTable Traer(string filtro) {
       if (filtro == string.Empty) {
           return Consultar("SELECT * FROM Venta").Tables[0];
       } else {
           return Consultar("SELECT * FROM Venta WHERE  " + filtro).Tables[0];
       }
   }

   public DataTable Traer(string Columnas, string Filtro) { 
       if (Filtro.Trim() == string.Empty) {
           if (Columnas.Trim() == string.Empty) {
               return Consultar("SELECT * FROM Venta").Tables[0];
           } else {
               return Consultar("SELECT " + Columnas  + " FROM Venta").Tables[0];
           }
       } else {
           if (Columnas.Trim() == string.Empty ) {
               return Consultar("SELECT * FROM Venta WHERE " + Filtro + " ").Tables[0];
           } else {
               return Consultar("SELECT " + Columnas  +  "  FROM Venta WHERE " +  Filtro + " ").Tables[0];
           }
       }
   }

   // <summary>
   // DR: Busca y Carga la clase a partir de la llave primaria de la tabla
   // Cargar llave primaria '' para traer los datos del registro
   // </summary>
   // <remarks></remarks>
   public void ObtenerRegistro(){
       DataTable dt = Traer("IdVenta=" + m_IdVenta);
       if (dt.Rows.Count > 0 ) {
           DataRow dr = dt.Rows[0];
            m_IdVenta= int.Parse(dr["IdVenta"].ToString());
            m_fecha= dr["fecha"].ToString();
            m_fkIdCliente = int.Parse(dr["fkIdCliente"].ToString());
            m_NIT= dr["NIT"].ToString();
            m_razonSocial = dr["razonSocial"].ToString();
            m_nombreCliente = dr["nombreCliente"].ToString();
       }
       else{
           m_IdVenta = 0;
       }
   }
   #endregion
   }
}
