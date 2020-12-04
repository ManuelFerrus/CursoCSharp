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
    public partial class frmDescuento:Form
    {
        public frmDescuento ( )
        {
            InitializeComponent ( );
        }

        private void btnCalcular_Click ( object sender, EventArgs e )
        {
            string precio = txtPrecio.Text;
            double precioReal = double.Parse ( precio );
            double descuento = precioReal * 0.20;
            double totalapagar = precioReal - descuento;

            txtPrecioReal.Text = precioReal.ToString ( );
            txtDescuento.Text = descuento.ToString ( );
            txtTotalPagar.Text = totalapagar.ToString ( );
        }
    }
}
