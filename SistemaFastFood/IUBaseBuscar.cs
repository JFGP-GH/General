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
    public partial class IUBaseBuscar : Form
    {
        public IUBaseBuscar()
        {
            InitializeComponent();
        }

        private void txtCriterio_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtCriterio.Text.Length == 0) {
                procesarBuscar("'%'");
            }
            else{
                procesarBuscar("'%" + txtCriterio.Text + "%'");
            }
        }

        public virtual void procesarBuscar(string criterio)
        {

        }
        public void aceptar()
        {
            if ((dgvResultado.RowCount > 0))
            {
                procesarAceptar();
            }
            else
            {
                Close();
            }
        }
        public virtual void procesarAceptar()
        {
        }

        private void dgvResultado_KeyDown(object sender, KeyEventArgs e)
        {
            aceptar();
        }

        private void dgvResultado_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            aceptar();
        }

        private void IUBaseBuscar_Load(object sender, EventArgs e)
        {
            procesarBuscar("'%'");
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            aceptar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
 
    }
}


        