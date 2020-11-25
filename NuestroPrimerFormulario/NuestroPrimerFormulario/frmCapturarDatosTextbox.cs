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
    public partial class frmCapturarDatosTextbox : Form
    {
        public frmCapturarDatosTextbox( )
        {
            InitializeComponent();
        }
        
        private void btnMostrar_Click( object sender, EventArgs e )
        {
            string valor = txtValor.Text;
            lblRespuesta.Text = "El valor ingresado es: " + valor;
        }
    }
}
