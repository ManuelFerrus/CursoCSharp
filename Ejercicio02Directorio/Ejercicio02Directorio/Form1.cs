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

namespace Ejercicio02Directorio
{
    public partial class Form1 : Form
    {
        public Form1( )
        {
            InitializeComponent();
        }

        private void btnBuscar_Click( object sender, EventArgs e )
        {
            OpenFileDialog ofd = new OpenFileDialog();//buscamos un archivo
            ofd.Filter = "Archivos de imagenes |*.jpg;*.jpeg;*.gif;*.png;*.jfif";//Filtramos las imagenes
            if ( ofd.ShowDialog().Equals(DialogResult.OK) )//abrimmos y verificamos que se cierr con aceptar
            {
                string rutaArchivo = ofd.FileName;
                byte[]buffer = File.ReadAllBytes( rutaArchivo );//combertimos la imagen en bytes
                using ( MemoryStream ms = new MemoryStream( buffer ) )
                {
                    pbFoto.Image = Image.FromStream( ms );//pasamos la imagen del memory stream
                }
                txtRuta.Text = rutaArchivo;
            }
        }

        private void btnMover_Click( object sender, EventArgs e )
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Archivos de imagenes |*.jpg;*.jpeg;*.gif;*.png;*.jfif";//Filtramos las imagenes
            if ( sfd.ShowDialog().Equals( DialogResult.OK ) )
            {
                string rutaDestino = sfd.FileName;
                //MessageBox.Show( rutaArchivo );
                string rutaOrigen = txtRuta.Text;
                File.Move( rutaOrigen, rutaDestino );
                MessageBox.Show( "Se movio el archivo" );
            }
        }

        private void btnCopiar_Click( object sender, EventArgs e )
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Archivos de imagenes |*.jpg;*.jpeg;*.gif;*.png;*.jfif";//Filtramos las imagenes
            if ( sfd.ShowDialog().Equals( DialogResult.OK ) )
            {
                string rutaDestino = sfd.FileName;
                string rutaOrigen = txtRuta.Text;
                File.Copy( rutaOrigen, rutaDestino );
                MessageBox.Show( "Se copio el archivo" );
            }
        }
    }
}
