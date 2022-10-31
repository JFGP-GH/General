using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using System;
// Creado por Ing. David Ribera Blanco
// Celular:   70902782  72130344
// E-Mail:    davidriberablanco@hotmail.com
// Fecha y Hora 13/12/2018 20:18:32
// Negocio para la tabla Compra
namespace NEGOCIO
{
public class Compra:CONEXION.DAC {

#region "Atributos" 
       private int m_IdCompra;
       private string m_Fecha;
       private int m_fkIdProveedor;
#endregion

   #region "Propiedades" 
       public Int32 IdCompra{ 
           get {
               return m_IdCompra;
           }

           set {
               m_IdCompra = value;
           }
       }

       public string Fecha{ 
           get {
               return m_Fecha;
           }

           set {
               m_Fecha = value;
           }
       }

       public Int32 fkIdProveedor{ 
           get {
               return m_fkIdProveedor;
           }

           set {
               m_fkIdProveedor = value;
           }
       }

   #endregion

   #region "Metodos" 
   public int  Insertar(){ 
       String sInsert;
       List<SqlParameter> ListPrm = new List<SqlParameter>();
       SqlTransaction trn = this.IniciarTransaccion();
       try {
           sInsert = "pCompraAdd";
           ListPrm=CONEXION.DAC.CargarListaParametros("@IdCompra", IdCompra, "@Fecha", Fecha, "@fkIdProveedor", fkIdProveedor);
           m_IdCompra = EjecutarInsertProc(sInsert,ListPrm,trn);
       this.TerminarTransaccion(ref trn);
       return m_IdCompra;
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
           sUpdate = "pCompraUpd";
           ListPrm=CONEXION.DAC.CargarListaParametros("@IdCompra", IdCompra, "@Fecha", Fecha, "@fkIdProveedor", fkIdProveedor);
           EjecutarProc(sUpdate,ListPrm);
       } catch (Exception ex){
           throw;
       }
   }

   public void Eliminar() {
       String sDelete;
       List<SqlParameter> ListPrm = new List<SqlParameter>();
       try{
           sDelete = "pCompraDel";
           ListPrm=CONEXION.DAC.CargarListaParametros("@IdCompra" ,m_IdCompra);
           EjecutarProc(sDelete,ListPrm);
       } catch (Exception ex){
           throw;
       }
   } 

   public DataTable Traer(string filtro) {
       if (filtro == string.Empty) {
           return Consultar("SELECT * FROM Compra").Tables[0];
       } else {
           return Consultar("SELECT * FROM Compra WHERE  " + filtro).Tables[0];
       }
   }

   public DataTable Traer(string Columnas, string Filtro) { 
       if (Filtro.Trim() == string.Empty) {
           if (Columnas.Trim() == string.Empty) {
               return Consultar("SELECT * FROM Compra").Tables[0];
           } else {
               return Consultar("SELECT " + Columnas  + " FROM Compra").Tables[0];
           }
       } else {
           if (Columnas.Trim() == string.Empty ) {
               return Consultar("SELECT * FROM Compra WHERE " + Filtro + " ").Tables[0];
           } else {
               return Consultar("SELECT " + Columnas  +  "  FROM Compra WHERE " +  Filtro + " ").Tables[0];
           }
       }
   }

   // <summary>
   // DR: Busca y Carga la clase a partir de la llave primaria de la tabla
   // Cargar llave primaria '' para traer los datos del registro
   // </summary>
   // <remarks></remarks>
   public void ObtenerRegistro(){
       DataTable dt = Traer("=" + m_IdCompra);
       if (dt.Rows.Count > 0 ) {
           DataRow dr = dt.Rows[0];
            m_IdCompra=int.Parse(dr["IdCompra"].ToString());
            m_Fecha=dr["Fecha"].ToString();
            m_fkIdProveedor=int.Parse(dr["fkIdProveedor"].ToString());

       }
       else{
           m_IdCompra = 0;
       }
   }
   #endregion
   }
}
