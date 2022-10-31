using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using System;
// Creado por Ing. David Ribera Blanco
// Celular:   70902782  72130344
// E-Mail:    davidriberablanco@hotmail.com
// Fecha y Hora 13/12/2018 20:18:32
// Negocio para la tabla Producto
namespace NEGOCIO
{
public class Producto:CONEXION.DAC {

#region "Atributos" 
       private int m_IdProducto;
       private string m_NombreProducto;
       private string m_Descripcion;
       private Byte[] m_Foto;
       private decimal m_PrecioCompra;
       private decimal m_PrecioVenta;
       private int m_CantidadStock;
       private int m_fkIdCategoria;
#endregion

   #region "Propiedades" 
       public Int32 IdProducto{ 
           get {
               return m_IdProducto;
           }

           set {
               m_IdProducto = value;
           }
       }

       public string NombreProducto{ 
           get {
               return m_NombreProducto;
           }

           set {
               m_NombreProducto = value;
           }
       }

       public string Descripcion{ 
           get {
               return m_Descripcion;
           }

           set {
               m_Descripcion = value;
           }
       }

       public Byte[] Foto{ 
           get {
               return m_Foto;
           }

           set {
               m_Foto = value;
           }
       }

       public Int32 fkIdCategoria{ 
           get {
               return m_fkIdCategoria;
           }

           set {
               m_fkIdCategoria = value;
           }
       }
       public decimal PrecioCompra
       {
           get { return m_PrecioCompra; }
           set { m_PrecioCompra = value; }
       }
       public decimal PrecioVenta
       {
           get { return m_PrecioVenta; }
           set { m_PrecioVenta = value; }
       }
       public Int32 CantidadStock
       {
           get { return m_CantidadStock; }
           set { m_CantidadStock = value; }
       }

   #endregion

   #region "Metodos" 
   public  int Insertar(){ 
       String sInsert;
       List<SqlParameter> ListPrm = new List<SqlParameter>();
       SqlTransaction trn = this.IniciarTransaccion();
       try {
           sInsert = "pProductoAdd";
           ListPrm=CONEXION.DAC.CargarListaParametros("@IdProducto", IdProducto, "@NombreProducto", NombreProducto, "@Descripcion", Descripcion, "@Foto", Foto, "@fkIdCategoria", fkIdCategoria, "@PrecioCompra",PrecioCompra,"@PrecioVenta",PrecioVenta,"@CantidadStock",CantidadStock);
           m_IdProducto  = EjecutarInsertProc(sInsert,ListPrm,trn);
       this.TerminarTransaccion(ref trn);
       return m_IdProducto;
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
           sUpdate = "pProductoUpd";
           ListPrm = CONEXION.DAC.CargarListaParametros("@IdProducto", IdProducto, "@NombreProducto", NombreProducto, "@Descripcion", Descripcion, "@Foto", Foto, "@fkIdCategoria", fkIdCategoria, "@PrecioCompra", PrecioCompra, "@PrecioVenta", PrecioVenta, "@CantidadStock", CantidadStock);
           EjecutarProc(sUpdate,ListPrm);
       } catch (Exception ex){
           throw;
       }
   }

   public void Eliminar() {
       String sDelete;
       List<SqlParameter> ListPrm = new List<SqlParameter>();
       try{
           sDelete = "pProductoDel";
           ListPrm = CONEXION.DAC.CargarListaParametros("@IdProducto", m_IdProducto);
           EjecutarProc(sDelete,ListPrm);
       } catch (Exception ex){
           throw;
       }
   } 

   public DataTable Traer(string filtro) {
       if (filtro == string.Empty) {
           return Consultar("SELECT * FROM Producto").Tables[0];
       } else {
           return Consultar("SELECT * FROM Producto WHERE  " + filtro).Tables[0];
       }
   }

   public DataTable Traer(string Columnas, string Filtro) { 
       if (Filtro.Trim() == string.Empty) {
           if (Columnas.Trim() == string.Empty) {
               return Consultar("SELECT * FROM Producto").Tables[0];
           } else {
               return Consultar("SELECT " + Columnas  + " FROM Producto").Tables[0];
           }
       } else {
           if (Columnas.Trim() == string.Empty ) {
               return Consultar("SELECT * FROM Producto WHERE " + Filtro + " ").Tables[0];
           } else {
               return Consultar("SELECT " + Columnas  +  "  FROM Producto WHERE " +  Filtro + " ").Tables[0];
           }
       }
   }

   // <summary>
   // DR: Busca y Carga la clase a partir de la llave primaria de la tabla
   // Cargar llave primaria '' para traer los datos del registro
   // </summary>
   // <remarks></remarks>
   public void ObtenerRegistro(){
       DataTable dt = Traer("IdProducto=" + m_IdProducto);
       if (dt.Rows.Count > 0 ) {
           DataRow dr = dt.Rows[0];
            m_IdProducto= int.Parse(dr["IdProducto"].ToString());
            m_NombreProducto = dr["NombreProducto"].ToString();
            m_Descripcion= dr["Descripcion"].ToString();
            m_Foto = (byte[])dr["Foto"];
            m_fkIdCategoria= int.Parse(dr["fkIdCategoria"].ToString());
            m_PrecioCompra = decimal.Parse(dr["PrecioCompra"].ToString());
            m_PrecioVenta = decimal.Parse(dr["PrecioVenta"].ToString());
            m_CantidadStock = int.Parse(dr["CantidadStock"].ToString());

       }
       else{
           m_IdProducto = 0;
       }
   }
   #endregion
   }
}
