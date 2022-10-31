using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using System;
// Creado por Ing. David Ribera Blanco
// Celular:   70902782  72130344
// E-Mail:    davidriberablanco@hotmail.com
// Fecha y Hora 13/12/2018 20:18:32
// Negocio para la tabla CompraDetalle
namespace NEGOCIO
{
public class CompraDetalle:CONEXION.DAC {

#region "Atributos" 
       private int m_IdCompraDetalle;
       private int m_Cantidad;
       private Double m_Precio;
       private int m_fkIdProducto;
       private int m_fkIdCompra;
#endregion

   #region "Propiedades" 
       public Int32 IdCompraDetalle{ 
           get {
               return m_IdCompraDetalle;
           }

           set {
               m_IdCompraDetalle = value;
           }
       }

       public Int32 Cantidad{ 
           get {
               return m_Cantidad;
           }

           set {
               m_Cantidad = value;
           }
       }

       public Double Precio{ 
           get {
               return m_Precio;
           }

           set {
               m_Precio = value;
           }
       }

       public Int32 fkIdProducto{ 
           get {
               return m_fkIdProducto;
           }

           set {
               m_fkIdProducto = value;
           }
       }

       public Int32 fkIdCompra{ 
           get {
               return m_fkIdCompra;
           }

           set {
               m_fkIdCompra = value;
           }
       }

   #endregion

   #region "Metodos" 
   public int Insertar(){ 
       String sInsert;
       List<SqlParameter> ListPrm = new List<SqlParameter>();
       SqlTransaction trn = this.IniciarTransaccion();
       try {
           sInsert = "pCompraDetalleAdd";
           ListPrm=CONEXION.DAC.CargarListaParametros("@IdCompraDetalle", IdCompraDetalle, "@Cantidad", Cantidad, "@Precio", Precio, "@fkIdProducto", fkIdProducto, "@fkIdCompra", fkIdCompra);
           m_IdCompraDetalle = EjecutarInsertProc(sInsert,ListPrm,trn);
       this.TerminarTransaccion(ref trn);
       return m_IdCompraDetalle;
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
           sUpdate = "pCompraDetalleUpd";
           ListPrm=CONEXION.DAC.CargarListaParametros("@IdCompraDetalle", IdCompraDetalle, "@Cantidad", Cantidad, "@Precio", Precio, "@fkIdProducto", fkIdProducto, "@fkIdCompra", fkIdCompra);
           EjecutarProc(sUpdate,ListPrm);
       } catch (Exception ex){
           throw;
       }
   }

   public void Eliminar() {
       String sDelete;
       List<SqlParameter> ListPrm = new List<SqlParameter>();
       try{
           sDelete = "pCompraDetalleDel";
           ListPrm = CONEXION.DAC.CargarListaParametros("@IdCompraDetalle", m_IdCompraDetalle);
           EjecutarProc(sDelete,ListPrm);
       } catch (Exception ex){
           throw;
       }
   } 

   public DataTable Traer(string filtro) {
       if (filtro == string.Empty) {
           return Consultar("SELECT * FROM CompraDetalle").Tables[0];
       } else {
           return Consultar("SELECT * FROM CompraDetalle WHERE  " + filtro).Tables[0];
       }
   }

   public DataTable Traer(string Columnas, string Filtro) { 
       if (Filtro.Trim() == string.Empty) {
           if (Columnas.Trim() == string.Empty) {
               return Consultar("SELECT * FROM CompraDetalle").Tables[0];
           } else {
               return Consultar("SELECT " + Columnas  + " FROM CompraDetalle").Tables[0];
           }
       } else {
           if (Columnas.Trim() == string.Empty ) {
               return Consultar("SELECT * FROM CompraDetalle WHERE " + Filtro + " ").Tables[0];
           } else {
               return Consultar("SELECT " + Columnas  +  "  FROM CompraDetalle WHERE " +  Filtro + " ").Tables[0];
           }
       }
   }

   // <summary>
   // DR: Busca y Carga la clase a partir de la llave primaria de la tabla
   // Cargar llave primaria '' para traer los datos del registro
   // </summary>
   // <remarks></remarks>
   public void ObtenerRegistro(){
       DataTable dt = Traer("=" + m_IdCompraDetalle);
       if (dt.Rows.Count > 0 ) {
           DataRow dr = dt.Rows[0];
            m_IdCompraDetalle=int.Parse(dr["IdCompraDetalle"].ToString());
            m_Cantidad=int.Parse(dr["Cantidad"].ToString());
            m_fkIdProducto=int.Parse(dr["fkIdProducto"].ToString());
            m_fkIdCompra=int.Parse(dr["fkIdCompra"].ToString());

       }
       else{
           m_IdCompraDetalle = 0;
       }
   }
   #endregion
   }
}
