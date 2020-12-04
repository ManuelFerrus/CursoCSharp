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
    public partial class frmEdad:Form
    {
        public frmEdad ( )
        {
            InitializeComponent ( );
        }

        private void btnCalcular_Click ( object sender, EventArgs e )
        {
            decimal edad = txtEdad.Value;
            if ( edad<=0 ) {
                errorDato.SetError ( txtEdad, "La edad no puede ser menor o igual a 0" );//agregamos un error
                return;//no salimos del codigo
            }
            if ( edad>=18 ) {
                lblResultado.Text = "Es mayor de edad";
            }
            else {
                lblResultado.Text = "Es menor de edad";
            }
        }
    }
}
