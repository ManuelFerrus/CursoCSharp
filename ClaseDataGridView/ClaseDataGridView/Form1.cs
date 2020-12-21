using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClaseDataGridView
{
    public partial class Form1 : Form
    {
        public Form1( )
        {
            InitializeComponent();
        }

        private void Form1_Load( object sender, EventArgs e )
        {
            dgvPersona.Rows.Add( "Jorge", "Padilla Gomez Sanchez", 40 );
            dgvPersona.Rows.Add( "Luis", "Sanchez Ruiz Montoro", 20 );
            dgvPersona.Rows.Add( "Ricardo", "Caballero Tello Carmona", 25 );
            
            dgvPersona.Columns[ 1 ].Width = 150;//Cambiamos el ancho de la columna
        }
    }
}
