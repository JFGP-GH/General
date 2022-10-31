using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaFastFood
{
    public partial class IUProveedorBuscar : SistemaFastFood.IUBaseBuscar
    {
        public IUProveedorBuscar()
        {
            InitializeComponent();
        }

        public NEGOCIO.Cliente registro = new NEGOCIO.Cliente();


        public override void procesarBuscar(string criterio)
        {

            //MyBase.procesarBuscar(criterio)
            DataTable dt = new DataTable();
            dt = registro.Traer("razonSocial like " + criterio);
            dgvResultado.DataSource = dt;
            //dgvResultado.Columns("fkIdAlmacen").Visible = False
        }

        public override void procesarAceptar()
        {

            base.procesarAceptar();
            if ((dgvResultado.Rows.Count > 0))
            {

                int F = dgvResultado.CurrentRow.Index;
                registro.IdCliente = Convert.ToInt32(dgvResultado["IdCliente", F].Value.ToString());
                registro.ObtenerRegistro();

                Close();

            }

        }
    }
}
