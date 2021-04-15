using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimeraAplicacionDeConsola02
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void itemMarca_Click(object sender, EventArgs e)
        {
            frmMarca frmMarca = new frmMarca();
            frmMarca.ShowDialog();
        }

        private void itemEmpleado_Click(object sender, EventArgs e)
        {
            frmEmpleado frmEmpleado = new frmEmpleado();
            frmEmpleado.ShowDialog();
        }

        private void itemCliente_Click(object sender, EventArgs e)
        {
            frmCliente frmCliente = new frmCliente();
            frmCliente.ShowDialog();
        }

        private void tipoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipoUsuario frmTipoUsuario = new frmTipoUsuario();
            frmTipoUsuario.ShowDialog();
        }

        private void busToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBus frmBus = new frmBus();
            frmBus.ShowDialog();
        }

        private void viajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViaje frmViaje = new frmViaje();
            frmViaje.ShowDialog();
        }
    }
}
