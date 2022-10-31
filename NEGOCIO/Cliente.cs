using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using System;
// Creado por Ing. David Ribera Blanco
// Celular:   70902782  72130344
// E-Mail:    davidriberablanco@hotmail.com
// Fecha y Hora 13/12/2018 20:18:32
// Negocio para la tabla Cliente
namespace NEGOCIO
{
public class Cliente:CONEXION.DAC {

#region "Atributos" 
       private int m_IdCliente;
       private string m_NIT;
       private string m_RazonSocial;
       private string m_NombreCliente;


#endregion

   #region "Propiedades" 
       public Int32 IdCliente{ 
           get {
               return m_IdCliente;
           }

           set {
               m_IdCliente = value;
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

       public string RazonSocial{ 
           get {
               return m_RazonSocial;
           }

           set {
               m_RazonSocial = value;
           }
       }

       public string NombreCliente
       {
           get { return m_NombreCliente; }
           set { m_NombreCliente = value; }
       }

   #endregion

   #region "Metodos" 
   public int  Insertar(){ 
       String sInsert;
       List<SqlParameter> ListPrm = new List<SqlParameter>();
       SqlTransaction trn = this.IniciarTransaccion();
       try {
           sInsert = "pClienteAdd";
           ListPrm=CONEXION.DAC.CargarListaParametros("@IdCliente", IdCliente, "@NIT", NIT, "@RazonSocial", RazonSocial,"@NombreCliente", NombreCliente );
           m_IdCliente = EjecutarInsertProc(sInsert,ListPrm,trn);
       this.TerminarTransaccion(ref trn);
       return m_IdCliente;
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
           sUpdate = "pClienteUpd";
           ListPrm = CONEXION.DAC.CargarListaParametros("@IdCliente", IdCliente, "@NIT", NIT, "@RazonSocial", RazonSocial, "@NombreCliente", NombreCliente);
           EjecutarProc(sUpdate,ListPrm);
       } catch (Exception ex){
           throw;
       }
   }

   public void Eliminar() {
       String sDelete;
       List<SqlParameter> ListPrm = new List<SqlParameter>();
       try{
           sDelete = "pClienteDel";
           ListPrm=CONEXION.DAC.CargarListaParametros("@IdCliente" ,m_IdCliente);
           EjecutarProc(sDelete,ListPrm);
       } catch (Exception ex){
           throw;
       }
   } 

   public DataTable Traer(string filtro) {
       if (filtro == string.Empty) {
           return Consultar("SELECT * FROM Cliente").Tables[0];
       } else {
           return Consultar("SELECT * FROM Cliente WHERE  " + filtro).Tables[0];
       }
   }

   public DataTable Traer(string Columnas, string Filtro) { 
       if (Filtro.Trim() == string.Empty) {
           if (Columnas.Trim() == string.Empty) {
               return Consultar("SELECT * FROM Cliente").Tables[0];
           } else {
               return Consultar("SELECT " + Columnas  + " FROM Cliente").Tables[0];
           }
       } else {
           if (Columnas.Trim() == string.Empty ) {
               return Consultar("SELECT * FROM Cliente WHERE " + Filtro + " ").Tables[0];
           } else {
               return Consultar("SELECT " + Columnas  +  "  FROM Cliente WHERE " +  Filtro + " ").Tables[0];
           }
       }
   }

   // <summary>
   // DR: Busca y Carga la clase a partir de la llave primaria de la tabla
   // Cargar llave primaria '' para traer los datos del registro
   // </summary>
   // <remarks></remarks>
   public void ObtenerRegistro(){
       DataTable dt = Traer("IdCliente=" + m_IdCliente);
       if (dt.Rows.Count > 0 ) {
           DataRow dr = dt.Rows[0];
            m_IdCliente=int.Parse(dr["IdCliente"].ToString());
            m_NIT= dr["NIT"].ToString();
            m_RazonSocial=  dr["RazonSocial"].ToString();
            m_NombreCliente = dr["NombreCliente"].ToString();

       }
       else{
           m_IdCliente = 0;
       }
   }
   #endregion
   }
}
