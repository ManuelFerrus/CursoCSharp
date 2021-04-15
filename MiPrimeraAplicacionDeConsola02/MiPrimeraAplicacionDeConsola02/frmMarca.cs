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
    public partial class frmMarca : Form
    {
        public frmMarca()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //leemos el valor del textbox
            string nombreMarca = txtNombre.Text;
            //abrimos conexion
            BDPasajeEntities oBDPasajeEntities = new BDPasajeEntities();

            //hacemos la consulta y agregamos el filtro por nombre
            var consulta = (from marca in oBDPasajeEntities.Marca
                            where marca.BHABILITADO == 1
                            && marca.NOMBRE.Contains(nombreMarca)
                            select new
                            {
                                marca.IIDMARCA,
                                marca.NOMBRE,
                                marca.DESCRIPCION
                            }).ToList();
            dgvMarca.DataSource = consulta;
        }

        private void listar()
        {
            BDPasajeEntities oBDPasajeEntities = new BDPasajeEntities();

            var consulta = (from marca in oBDPasajeEntities.Marca
                            where marca.BHABILITADO == 1
                            select new
                            {
                                marca.IIDMARCA,
                                marca.NOMBRE,
                                marca.DESCRIPCION
                            }).ToList();

            dgvMarca.DataSource = consulta;
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";

            listar();
        }
    }
}
