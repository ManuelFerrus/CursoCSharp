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
using System.Diagnostics;

namespace Ejercicio01Directorio
{
    public partial class Form1 : Form
    {
        public Form1( )
        {
            InitializeComponent();
        }

        private void Form1_Load( object sender, EventArgs e )
        {
            //Agregamos los elemento a la lista
            List<TiposArchivos> listaArchivos = new List<TiposArchivos>
            {
                new TiposArchivos{extension=".txt", nombreArchivo="Archivos Planos"},
                new TiposArchivos{extension=".odt", nombreArchivo="Archivos Word"},
                new TiposArchivos{extension=".ods", nombreArchivo="Archivos Excel"}
            };
            //para casos practicos se pueden agregar elements con la propiedad .Add();
            //https://www.udemy.com/course/c-la-guia-definitiva-aprende-a-programar-de-cero/learn/lecture/15303448#overview
            cboArchivos.DataSource = listaArchivos;
            cboArchivos.DisplayMember = "nombreArchivo";//Valo a mostrar
            cboArchivos.ValueMember = "extension";//valor a tomar como ID
        }

        private void btnBuscar_Click( object sender, EventArgs e )
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();//para que el ususario pueda seleccionar una carpeta
            if ( fbd.ShowDialog().Equals(DialogResult.OK) ) //Si se mostro y se cerro con OK
            {
                //MessageBox.Show( fbd.SelectedPath ); //mostramos la ruta
                txtRuta.Text = fbd.SelectedPath;
            }
        }

        private void btnFiltrar_Click( object sender, EventArgs e )
        {
            if ( txtRuta.Text.Equals("") )
            {
                errorDatos.SetError( txtRuta, "Tiene que ingresar una ruta" );
                return; //terminamos la ejecusion
            }
            else
            {
                errorDatos.SetError( txtRuta, "" );//limpiamos el error
            }
            string rutaDirectorio = txtRuta.Text;
            string extension = cboArchivos.SelectedValue.ToString(); //obtenemos el valor del combobox
            lbDatos.DataSource = Directory.GetFiles( rutaDirectorio, "*" + extension ); //clase de directorios
        }

        private void btnLimpiar_Click( object sender, EventArgs e )
        {
            lbDatos.DataSource = null;//limpiamos el listbox
        }

        private void mostrarArchivo( object sender, EventArgs e )
        {
            if ( lbDatos.Items.Count > 0 ) //vlidamos que haya datos en el listbox
            {
                string itemSeleccionado = lbDatos.SelectedItem.ToString();//obtenemos el item seleccionado
                //MessageBox.Show( itemSeleccionado );
                Process.Start( itemSeleccionado );//abrimos el archivo
            }
        }
    }
}
