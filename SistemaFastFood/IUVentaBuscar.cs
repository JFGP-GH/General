using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaFastFood
{
    public partial class IUVentaBuscar : SistemaFastFood.IUBaseBuscar
    {
        public IUVentaBuscar()
        {
            InitializeComponent();
        }
        //----------------------
        public NEGOCIO.Venta registro = new NEGOCIO.Venta();


        public override void procesarBuscar(string criterio)
        {

            //MyBase.procesarBuscar(criterio)
            DataTable dt = new DataTable();
            dt = registro.Traer("fecha like " + criterio);
            dgvResultado.DataSource = dt;
            //dgvResultado.Columns("fkIdAlmacen").Visible = False
        }

        public override void procesarAceptar()
        {

            base.procesarAceptar();
            if ((dgvResultado.Rows.Count > 0))
            {

                int F = dgvResultado.CurrentRow.Index;
                registro.IdVenta = Convert.ToInt32(dgvResultado["IdVenta", F].Value.ToString());
                registro.ObtenerRegistro();

                Close();

            }

        }


        //----------------------
    }
}
