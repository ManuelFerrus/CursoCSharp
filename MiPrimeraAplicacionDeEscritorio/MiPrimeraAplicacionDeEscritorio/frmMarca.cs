﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiPrimeraAplicacionDeEscritorio.Models; //Instanciamos la carpeta

namespace MiPrimeraAplicacionDeEscritorio
{
    public partial class frmMarca : Form
    {
        public frmMarca()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            BDPasajeEntities oBDPasajesEntities = new BDPasajeEntities();
            var consulta = (from marca in oBDPasajesEntities.Marca
                            where marca.BHABILITADO==1
                            select new
                            {
                                marca.IIDMARCA,
                                marca.NOMBRE,
                                marca.DESCRIPCION
                            }).ToList();
            dgvMarca.DataSource = consulta;
        }
    }
}
