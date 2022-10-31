using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaFastFood
{
    public partial class IUProductoBuscar : SistemaFastFood.IUBaseBuscar
    {
        public IUProductoBuscar()
        {
            InitializeComponent();
        }

        public NEGOCIO.Producto registro = new NEGOCIO.Producto();


        public override void procesarBuscar(string criterio)
        {

            //MyBase.procesarBuscar(criterio)
            DataTable dt = new DataTable();
            dt = registro.Traer("NombreProducto like " + criterio);
            dgvResultado.DataSource = dt;
            //dgvResultado.Columns("fkIdAlmacen").Visible = False
        }

        public override void procesarAceptar()
        {

            base.procesarAceptar();
            if ((dgvResultado.Rows.Count > 0))
            {

                int F = dgvResultado.CurrentRow.Index;
                registro.IdProducto = Convert.ToInt32(dgvResultado["IdProducto", F].Value.ToString());
                registro.ObtenerRegistro();

                Close();

            }

        }



    }
}
