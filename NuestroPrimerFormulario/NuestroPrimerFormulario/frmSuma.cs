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
    public partial class frmSuma : Form
    {
        public frmSuma( )
        {
            InitializeComponent();
        }

        private void btnCalcular_Click( object sender, EventArgs e )
        {
            decimal numero1= txtNumero1.Value;
            decimal numero2= txtNumero2.Value;
            decimal numero3= txtNumero3.Value;
            decimal suma=0;

            if ( numero1 == 0 || numero2 == 0 || numero3 == 0 )
            {
                MessageBox.Show( "El número no puede ser cero", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
                return; //se sale del flujo
            }
            else
            {
                suma = numero1 + numero2 + numero3;
            }

            lblRespuesta.Text = "La suma es: " + suma;
        }

        private void btnLimpiar_Click( object sender, EventArgs e )
        {
            lblRespuesta.Text = "";
            txtNumero1.Value = 0;
            txtNumero2.Value = 0;
            txtNumero3.Value = 0;
        }
    }
}
