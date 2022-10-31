using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using System;
// Creado por Ing. David Ribera Blanco
// Celular:   70902782  72130344
// E-Mail:    davidriberablanco@hotmail.com
// Fecha y Hora 13/12/2018 20:18:32
// Negocio para la tabla Categoria
namespace NEGOCIO
{
public class Categoria:CONEXION.DAC {

#region "Atributos" 
       private int m_IdCategoria;
       private string m_NombreCategoria;
#endregion

   #region "Propiedades" 
       public Int32 IdCategoria{ 
           get {
               return m_IdCategoria;
           }

           set {
               m_IdCategoria = value;
           }
       }

       public string NombreCategoria{ 
           get {
               return m_NombreCategoria;
           }

           set {
               m_NombreCategoria = value;
           }
       }

   #endregion

   #region "Metodos" 
   public int  Insertar(){ 
       String sInsert;
       List<SqlParameter> ListPrm = new List<SqlParameter>();
       SqlTransaction trn = this.IniciarTransaccion();
       try {
           sInsert = "pCategoriaAdd";
           ListPrm=CONEXION.DAC.CargarListaParametros("@IdCategoria", IdCategoria, "@NombreCategoria", NombreCategoria);
           m_IdCategoria = EjecutarInsertProc(sInsert,ListPrm,trn);
       this.TerminarTransaccion(ref trn);
       return m_IdCategoria;
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
           sUpdate = "pCategoriaUpd";
           ListPrm=CONEXION.DAC.CargarListaParametros("@IdCategoria", IdCategoria, "@NombreCategoria", NombreCategoria);
           EjecutarProc(sUpdate,ListPrm);
       } catch (Exception ex){
           throw;
       }
   }

   public void Eliminar() {
       String sDelete;
       List<SqlParameter> ListPrm = new List<SqlParameter>();
       try{
           sDelete = "pCategoriaDel";
           ListPrm = CONEXION.DAC.CargarListaParametros("@IdCategoria", m_IdCategoria);
           EjecutarProc(sDelete,ListPrm);
       } catch (Exception ex){
           throw;
       }
   } 

   public DataTable Traer(string filtro) {
       if (filtro == string.Empty) {
           return Consultar("SELECT * FROM Categoria").Tables[0];
       } else {
           return Consultar("SELECT * FROM Categoria WHERE  " + filtro).Tables[0];
       }
   }

   public DataTable Traer(string Columnas, string Filtro) { 
       if (Filtro.Trim() == string.Empty) {
           if (Columnas.Trim() == string.Empty) {
               return Consultar("SELECT * FROM Categoria").Tables[0];
           } else {
               return Consultar("SELECT " + Columnas  + " FROM Categoria").Tables[0];
           }
       } else {
           if (Columnas.Trim() == string.Empty ) {
               return Consultar("SELECT * FROM Categoria WHERE " + Filtro + " ").Tables[0];
           } else {
               return Consultar("SELECT " + Columnas  +  "  FROM Categoria WHERE " +  Filtro + " ").Tables[0];
           }
       }
   }

   // <summary>
   // DR: Busca y Carga la clase a partir de la llave primaria de la tabla
   // Cargar llave primaria '' para traer los datos del registro
   // </summary>
   // <remarks></remarks>
   public void ObtenerRegistro(){
       DataTable dt = Traer("IdCategoria=" + m_IdCategoria);
       if (dt.Rows.Count > 0 ) {
           DataRow dr = dt.Rows[0];
            m_IdCategoria=int.Parse(dr["IdCategoria"].ToString());
            m_NombreCategoria=dr["NombreCategoria"].ToString();

       }
       else{
           m_IdCategoria = 0;
       }
   }
   #endregion
   }
}
