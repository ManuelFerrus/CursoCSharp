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
    public partial class frmViaje : Form
    {
        public frmViaje()
        {
            InitializeComponent();
        }
        private void listar()
        {
            BDPasajeEntities db = new BDPasajeEntities();
            var consulta = (from viaje in db.Viaje
                            join lugarorigen in db.Lugar
                                on viaje.IIDLUGARORIGEN equals lugarorigen.IIDLUGAR
                            join lugardestino in db.Lugar
                                on viaje.IIDLUGARDESTINO equals lugardestino.IIDLUGAR
                            select new
                            {
                                viaje.IIDVIAJE,
                                NOMBREORIGEN =  lugarorigen.NOMBRE,
                                NOMBREDESTINO = lugardestino.NOMBRE,
                                viaje.PRECIO,
                                viaje.FECHAVIAJE
                            }
                            ).ToList();
            dgvViaje.DataSource = consulta;
        }
        private void frmViaje_Load(object sender, EventArgs e)
        {
            listar();
        }
    }
}
