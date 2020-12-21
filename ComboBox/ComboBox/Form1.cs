using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1( )
        {
            InitializeComponent();
        }

        private void Form1_Load( object sender, EventArgs e )
        {
            //Esto se puede hacer para el llenado del combo, por medio de un ciclo de lectura de la BD
            List<Persona> listaPersona = new List<Persona>();
            listaPersona.Add( new Persona { id = 1, nombre = "Luis" } );
            listaPersona.Add( new Persona { id = 2, nombre = "Pedro" } );
            listaPersona.Add( new Persona { id = 3, nombre = "Jorge" } );
            cboPersona.DataSource = listaPersona; //se enlaza con la lista
            cboPersona.DisplayMember = "nombre";//se le indica que valor verá el usuario en pantalla
            cboPersona.ValueMember = "id";//Se le indica al sistema que valor el que se tomara
        }

        private void btnMostrar_Click( object sender, EventArgs e )
        {
            string nombre = cboPersona.Text;
            MessageBox.Show( "El nombre seleccionado es: " + nombre );
        }

        private void btnValue_Click( object sender, EventArgs e )
        {
            string idPersona = cboPersona.SelectedValue.ToString();
            MessageBox.Show( "El ID seleccionado es: " + idPersona );
        }

        private void btnMostrarValores_Click( object sender, EventArgs e )
        {
            Persona oPersona = ( Persona )cboPersona.SelectedItem; // se tiene que crar un objeto de la clase persona, ya que el combo, se lleno por medio de un list
            MessageBox.Show( "id: " + oPersona.id );
            MessageBox.Show( "nombre: " + oPersona.nombre );
        }
    }
}
