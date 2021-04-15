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
    public partial class frmBus : Form
    {
        public frmBus()
        {
            InitializeComponent();
        }
        private void listar()
        {
            BDPasajeEntities db = new BDPasajeEntities();
            var consulta = (from bus in db.Bus
                            join sucursal in db.Sucursal
                                on bus.IIDSUCURSAL equals sucursal.IIDSUCURSAL
                            join tipobus in db.TipoBus
                                on bus.IIDTIPOBUS equals tipobus.IIDTIPOBUS
                            where bus.BHABILITADO == 1
                            select new
                            {
                                bus.IIDBUS,
                                NOMBRESUCURSAL = sucursal.NOMBRE,
                                tipobus.NOMBRE,
                                bus.PLACA
                            }).ToList();
            dgvBus.DataSource = consulta;
        }
        private void llenarComboTipoBus()
        {
            BDPasajeEntities db = new BDPasajeEntities();
            var consulta = (from tipobus in db.TipoBus
                            where tipobus.BHABILITADO == 1
                            select new
                            { 
                                tipobus.IIDTIPOBUS,
                                tipobus.NOMBRE
                            }).ToList();
            cboTipoBus.DataSource = consulta;
            cboTipoBus.DisplayMember = "NOMBRE";
            cboTipoBus.ValueMember = "IIDTIPOBUS";
        }
        private void frmBus_Load(object sender, EventArgs e)
        {
            listar();
            llenarComboTipoBus();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int valor = (int)cboTipoBus.SelectedValue;
            
            BDPasajeEntities db = new BDPasajeEntities();
            
            var consulta = (from bus in db.Bus
                            join sucursal in db.Sucursal
                                on bus.IIDSUCURSAL equals sucursal.IIDSUCURSAL
                            join tipobus in db.TipoBus
                                on bus.IIDTIPOBUS equals tipobus.IIDTIPOBUS
                            where bus.BHABILITADO == 1
                            && tipobus.IIDTIPOBUS == valor
                            select new
                            {
                                bus.IIDBUS,
                                NOMBRESUCURSAL = sucursal.NOMBRE,
                                tipobus.NOMBRE,
                                bus.PLACA
                            }).ToList();
            dgvBus.DataSource = consulta;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            listar();
        }
    }
}