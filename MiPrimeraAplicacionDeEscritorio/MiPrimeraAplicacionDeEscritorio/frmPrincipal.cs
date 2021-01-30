using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimeraAplicacionDeEscritorio
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpleado ofrmEmpleado = new frmEmpleado();
            ofrmEmpleado.ShowDialog();
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMarca ofrmMarca = new frmMarca();
            ofrmMarca.ShowDialog();
        }

        private void itemClientes_Click(object sender, EventArgs e)
        {
            frmCliente ofrmCliente = new frmCliente();
            ofrmCliente.ShowDialog();
        }
    }
}
