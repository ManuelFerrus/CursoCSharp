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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            BDPasajeEntities db = new BDPasajeEntities();
            var consulta = (from cliente in db.Cliente
                            where cliente.BHABILITADO == 1
                            join sexo in db.Sexo //se hace un join a la tabla sexo
                            on cliente.IIDSEXO equals sexo.IIDSEXO //se matchean los campos para el join
                            select new
                            {
                                cliente.IIDCLIENTE,
                                NOMCOMPLETO = cliente.NOMBRE + " " + cliente.APPATERNO + " " + cliente.APMATERNO,
                                cliente.EMAIL,
                                sexo.NOMBRE
                            }).ToList();
            dgvClientes.DataSource = consulta;
        }

        private void filtrar(object sender, EventArgs e)
        {
            string nomCompleto = txtNomCompleto.Text;
            BDPasajeEntities db = new BDPasajeEntities();
            var consulta = (from cliente in db.Cliente
                            where cliente.BHABILITADO == 1
                            && (cliente.NOMBRE + " " + cliente.APPATERNO + " " + cliente.APMATERNO).Contains(nomCompleto)
                            join sexo in db.Sexo //se hace un join a la tabla sexo
                            on cliente.IIDSEXO equals sexo.IIDSEXO //se matchean los campos para el join
                            select new
                            {
                                cliente.IIDCLIENTE,
                                NOMCOMPLETO = cliente.NOMBRE + " " + cliente.APPATERNO + " " + cliente.APMATERNO,
                                cliente.EMAIL,
                                sexo.NOMBRE
                            }).ToList();
            dgvClientes.DataSource = consulta;
        }
    }
}
