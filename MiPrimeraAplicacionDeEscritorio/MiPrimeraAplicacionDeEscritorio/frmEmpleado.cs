using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MiPrimeraAplicacionDeEscritorio.Models;

namespace MiPrimeraAplicacionDeEscritorio
{
    public partial class frmEmpleado : Form
    {
        public frmEmpleado()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            BDPasajeEntities db = new BDPasajeEntities();
            var consulta = (from empleado in db.Empleado
                            where empleado.BHABILITADO == 1
                            select new
                            {
                                empleado.IIDEMPLEADO,
                                NOMBREOMPLETO = empleado.NOMBRE + " " + empleado.APPATERNO + " " + empleado.APMATERNO,
                                empleado.FECHACONTRATO,
                                empleado.SUELDO
                            }).ToList();
            dgvEmpleados.DataSource = consulta;
        }
    }
}
