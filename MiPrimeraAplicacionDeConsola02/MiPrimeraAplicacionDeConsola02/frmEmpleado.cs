using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiPrimeraAplicacionDeConsola02.Models;

namespace MiPrimeraAplicacionDeConsola02
{
    public partial class frmEmpleado : Form
    {
        public frmEmpleado()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listar();
        }

        private void listar() {
            BDPasajeEntities db = new BDPasajeEntities();
            var consulta = (from empleado in db.Empleado
                            where empleado.BHABILITADO == 1
                            select new
                            {
                                empleado.IIDEMPLEADO,
                                NOMBRECOMPLETO = empleado.NOMBRE + " " + empleado.APPATERNO + " " + empleado.APMATERNO, //Se tiene que generar la columna para poder concatenar
                                empleado.FECHACONTRATO,
                                empleado.SUELDO
                            }).ToList();
            dgvEmpleados.DataSource = consulta;
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNomCompleto.Text = "";
            listar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nomCompleto = txtNomCompleto.Text;

            BDPasajeEntities db = new BDPasajeEntities();
            var consulta = (from empleado in db.Empleado
                            where empleado.BHABILITADO == 1
                            && (empleado.NOMBRE + " " + empleado.APPATERNO + " " + empleado.APMATERNO).Contains(nomCompleto)
                            select new
                            {
                                empleado.IIDEMPLEADO,
                                NOMBRECOMPLETO = empleado.NOMBRE + " " + empleado.APPATERNO + " " + empleado.APMATERNO, //Se tiene que generar la columna para poder concatenar
                                empleado.FECHACONTRATO,
                                empleado.SUELDO
                            }).ToList();
            dgvEmpleados.DataSource = consulta;
        }
    }
}
