using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace NEGOCIO
{
    public class Imagen
    {
        /// <summary>
        ///     ''' Retorna una imagen a partir de datos Bytes()
        ///     ''' </summary>
        ///     ''' <param name="buffer"></param>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public static System.Drawing.Bitmap BytesToImagen(byte[] buffer)
        {
            System.Drawing.Bitmap imagen;
            try
            {
                System.IO.MemoryStream stream = new System.IO.MemoryStream(buffer, true);
                stream.Write(buffer, 0, buffer.Length);
                imagen = new System.Drawing.Bitmap(stream);
                stream.Close();
                return imagen;
            }
            catch (Exception ex)
            {
                return null/* TODO Change to default(_) if this is not a reference type */;
            }
        }

        /// <summary>
        ///     ''' Retorna Bytes desde una URL de una imagen existente
        ///     ''' </summary>
        ///     ''' <param name="path"></param>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public static byte[] ImagenUrlToBytes(string path)
        {
            if ( System.IO.File.Exists(path))
            {
                System.IO.FileStream st = new System.IO.FileStream(path, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                System.IO.BinaryReader mbr = new System.IO.BinaryReader(st);
                byte[] buffer = new byte[st.Length - 1 + 1];
                mbr.Read(buffer, 0, System.Convert.ToInt32(st.Length));
                st.Close();
                return buffer;
            }
            else
                return null;
        }
    }

}
