using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using System;
// Creado por Ing. David Ribera Blanco
// Celular:   70902782  72130344
// E-Mail:    davidriberablanco@hotmail.com
// Fecha y Hora 13/12/2018 20:18:32
// Negocio para la tabla VentaDetalle
namespace NEGOCIO
{
public class VentaDetalle:CONEXION.DAC {

#region "Atributos" 
       private int m_IdVentadetalle;
       private int m_Cantidad;
       private Double m_Precio;
       private int m_fkIdVenta;
       private int m_fkIdProducto;
#endregion

   #region "Propiedades" 
       public Int32 IdVentadetalle{ 
           get {
               return m_IdVentadetalle;
           }

           set {
               m_IdVentadetalle = value;
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

       public Int32 fkIdVenta{ 
           get {
               return m_fkIdVenta;
           }

           set {
               m_fkIdVenta = value;
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

   #endregion

   #region "Metodos" 
   public  Insertar(){ 
       String sInsert;
       List<SqlParameter> ListPrm = new List<SqlParameter>();
       SqlTransaction trn = this.IniciarTransaccion();
       try {
           sInsert = "pVentaDetalleAdd";
           ListPrm=CONEXION.DAC.CargarListaParametros("@IdVentadetalle", IdVentadetalle, "@Cantidad", Cantidad, "@Precio", Precio, "@fkIdVenta", fkIdVenta, "@fkIdProducto", fkIdProducto);
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
           sUpdate = "pVentaDetalleUpd";
           ListPrm=CONEXION.DAC.CargarListaParametros("@IdVentadetalle", IdVentadetalle, "@Cantidad", Cantidad, "@Precio", Precio, "@fkIdVenta", fkIdVenta, "@fkIdProducto", fkIdProducto);
           EjecutarProc(sUpdate,ListPrm);
       } catch (Exception ex){
           throw;
       }
   }

   public void Eliminar() {
       String sDelete;
       List<SqlParameter> ListPrm = new List<SqlParameter>();
       try{
           sDelete = "pVentaDetalleDel";
           ListPrm=CONEXION.DAC.CargarListaParametros("@" ,m_);
           EjecutarProc(sDelete,ListPrm);
       } catch (Exception ex){
           throw;
       }
   } 

   public DataTable Traer(string filtro) {
       if (filtro == string.Empty) {
           return Consultar("SELECT * FROM VentaDetalle").Tables[0];
       } else {
           return Consultar("SELECT * FROM VentaDetalle WHERE  " + filtro).Tables[0];
       }
   }

   public DataTable Traer(string Columnas, string Filtro) { 
       if (Filtro.Trim() == string.Empty) {
           if (Columnas.Trim() == string.Empty) {
               return Consultar("SELECT * FROM VentaDetalle").Tables[0];
           } else {
               return Consultar("SELECT " + Columnas  + " FROM VentaDetalle").Tables[0];
           }
       } else {
           if (Columnas.Trim() == string.Empty ) {
               return Consultar("SELECT * FROM VentaDetalle WHERE " + Filtro + " ").Tables[0];
           } else {
               return Consultar("SELECT " + Columnas  +  "  FROM VentaDetalle WHERE " +  Filtro + " ").Tables[0];
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
            m_IdVentadetalle=int.Parse(dr["IdVentadetalle"].ToString());
            m_Cantidad=int.Parse(dr["Cantidad"].ToString());
            m_fkIdVenta=int.Parse(dr["fkIdVenta"].ToString());
            m_fkIdProducto=int.Parse(dr["fkIdProducto"].ToString());

       }
       else{
           m_ = 0;
       }
   }
   #endregion
   }
}
