using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClaseListBox
{
    public partial class Form2 : Form
    {
        public Form2( )
        {
            InitializeComponent();
        }

        private void Form2_Load( object sender, EventArgs e )
        {
            //como arreglo 
            //string[]curso =
            //{
            //    "Matematicas",
            //    "Religion",
            //    "Comuniacion",
            //    "Educacion Fisica"
            //};
            //lbCursos.DataSource = curso;

            //como lista
            List<string>curso = new List<string>
            {
                "Matematicas",
                "Religion",
                "Comuniacion",
                "Educacion Fisica"
            };
            lbCursos.DataSource = curso;
        }
    }
}
