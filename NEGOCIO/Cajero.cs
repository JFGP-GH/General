using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using System;
// Creado por Ing. David Ribera Blanco
// Celular:   70902782  72130344
// E-Mail:    davidriberablanco@hotmail.com
// Fecha y Hora 13/12/2018 20:18:32
// Negocio para la tabla Cajero
namespace NEGOCIO
{
public class Cajero:CONEXION.DAC {

#region "Atributos" 
       private int m_IdCajero;
       private string m_Nombres;
       private string m_ApellidoPaterno;
       private string m_ApellidoMaterno;
       private string m_Direccion;
       private string m_Telefono;
#endregion

   #region "Propiedades" 
       public Int32 IdCajero{ 
           get {
               return m_IdCajero;
           }

           set {
               m_IdCajero = value;
           }
       }

       public string Nombres{ 
           get {
               return m_Nombres;
           }

           set {
               m_Nombres = value;
           }
       }

       public string ApellidoPaterno{ 
           get {
               return m_ApellidoPaterno;
           }

           set {
               m_ApellidoPaterno = value;
           }
       }

       public string ApellidoMaterno{ 
           get {
               return m_ApellidoMaterno;
           }

           set {
               m_ApellidoMaterno = value;
           }
       }

       public string Direccion{ 
           get {
               return m_Direccion;
           }

           set {
               m_Direccion = value;
           }
       }

       public string Telefono{ 
           get {
               return m_Telefono;
           }

           set {
               m_Telefono = value;
           }
       }

   #endregion

   #region "Metodos" 
   public  Insertar(){ 
       String sInsert;
       List<SqlParameter> ListPrm = new List<SqlParameter>();
       SqlTransaction trn = this.IniciarTransaccion();
       try {
           sInsert = "pCajeroAdd";
           ListPrm=CONEXION.DAC.CargarListaParametros("@IdCajero", IdCajero, "@Nombres", Nombres, "@ApellidoPaterno", ApellidoPaterno, "@ApellidoMaterno", ApellidoMaterno, "@Direccion", Direccion, "@Telefono", Telefono);
           m_ = EjecutarInsertProc(sInsert,ListPrm,trn);
       this.TerminarTransaccion(ref trn);
       return m_;
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
           sUpdate = "pCajeroUpd";
           ListPrm=CONEXION.DAC.CargarListaParametros("@IdCajero", IdCajero, "@Nombres", Nombres, "@ApellidoPaterno", ApellidoPaterno, "@ApellidoMaterno", ApellidoMaterno, "@Direccion", Direccion, "@Telefono", Telefono);
           EjecutarProc(sUpdate,ListPrm);
       } catch (Exception ex){
           throw;
       }
   }

   public void Eliminar() {
       String sDelete;
       List<SqlParameter> ListPrm = new List<SqlParameter>();
       try{
           sDelete = "pCajeroDel";
           ListPrm=CONEXION.DAC.CargarListaParametros("@" ,m_);
           EjecutarProc(sDelete,ListPrm);
       } catch (Exception ex){
           throw;
       }
   } 

   public DataTable Traer(string filtro) {
       if (filtro == string.Empty) {
           return Consultar("SELECT * FROM Cajero").Tables[0];
       } else {
           return Consultar("SELECT * FROM Cajero WHERE  " + filtro).Tables[0];
       }
   }

   public DataTable Traer(string Columnas, string Filtro) { 
       if (Filtro.Trim() == string.Empty) {
           if (Columnas.Trim() == string.Empty) {
               return Consultar("SELECT * FROM Cajero").Tables[0];
           } else {
               return Consultar("SELECT " + Columnas  + " FROM Cajero").Tables[0];
           }
       } else {
           if (Columnas.Trim() == string.Empty ) {
               return Consultar("SELECT * FROM Cajero WHERE " + Filtro + " ").Tables[0];
           } else {
               return Consultar("SELECT " + Columnas  +  "  FROM Cajero WHERE " +  Filtro + " ").Tables[0];
           }
       }
   }

   // <summary>
   // DR: Busca y Carga la clase a partir de la llave primaria de la tabla
   // Cargar llave primaria '' para traer los datos del registro
   // </summary>
   // <remarks></remarks>
   public void ObtenerRegistro(){
       DataTable dt = Traer("=" + m_);
       if (dt.Rows.Count > 0 ) {
           DataRow dr = dt.Rows[0];
            m_IdCajero=int.Parse(dr["IdCajero"].ToString());
            m_Nombres=dr["Nombres"].ToString();
            m_ApellidoPaterno=dr["ApellidoPaterno"].ToString();
            m_ApellidoMaterno=dr["ApellidoMaterno"].ToString();
            m_Direccion=dr["Direccion"].ToString();
            m_Telefono=dr["Telefono"].ToString();

       }
       else{
           m_ = 0;
       }
   }
   #endregion
   }
}
