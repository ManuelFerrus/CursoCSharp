using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NuestroPrimerFormulario
{
    public partial class frmCapturarDatosCombobox : Form
    {
        public frmCapturarDatosCombobox( )
        {
            InitializeComponent();
        }

        private void btnMostrar_Click( object sender, EventArgs e )
        {
            string dia = cboDia.Text;
            lblRespuesta.Text = "El dia es: " + dia;
        }

        private void btnLimpiar_Click( object sender, EventArgs e )
        {
            cboDia.Text = "";
            lblRespuesta.Text = "";
        }
    }
}
