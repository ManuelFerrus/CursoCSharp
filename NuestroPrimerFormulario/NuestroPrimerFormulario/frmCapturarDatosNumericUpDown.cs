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
    public partial class frmCapturarDatosNumericUpDown : Form
    {
        public frmCapturarDatosNumericUpDown( )
        {
            InitializeComponent();
        }

        private void btnMostrar_Click( object sender, EventArgs e )
        {
            decimal valor = txtNumeros.Value;//siempre devuelve un decimal
            lblRespuesta.Text = "El varlor a mostrar es: " + valor;//ya que va concatenado, no es necesario castear a string
        }

        private void btnLimpiar_Click( object sender, EventArgs e )
        {
            lblRespuesta.Text = "";
            txtNumeros.Value = 0; //Resetemos los valores
        }
    }
}
