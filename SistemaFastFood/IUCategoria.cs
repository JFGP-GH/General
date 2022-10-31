using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaFastFood
{
    public partial class IUCategoria : Form
    {
        public IUCategoria()
        {
            InitializeComponent();
        }

        private void IUCategoria_Load(object sender, EventArgs e)
        {
            NEGOCIO.Categoria oCategoria = new NEGOCIO.Categoria();
            DataTable dtCategoria = new DataTable();
            dtCategoria = oCategoria.Traer("");
            dgvListaCategoria.DataSource = dtCategoria;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            // crear metoto Limpiar y llamar.

        }
    }
}
