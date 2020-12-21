using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PicturBoxClase
{
    public partial class Form2 : Form
    {
        public Form2( )
        {
            InitializeComponent();
        }

        private void Form2_Load( object sender, EventArgs e )
        {
            string ruta = @"C:\Users\mferrusquia\Pictures\fondo.jfif"; //ruta de la imgen
            byte[]buffer= File.ReadAllBytes( ruta ); //leemos los byte de la imagen

            using ( MemoryStream ms = new MemoryStream( buffer ) )//pasamos a memorystream el buffer, para poderlo pintar
            {
                pbImagen.Image = Image.FromStream( ms );
            }
        }
    }
}
