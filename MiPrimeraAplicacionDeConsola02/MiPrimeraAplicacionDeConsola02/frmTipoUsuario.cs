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
    public partial class frmTipoUsuario : Form
    {
        public frmTipoUsuario()
        {
            InitializeComponent();
        }

        private void frmTipoUsuario_Load(object sender, EventArgs e)
        {
            listar();
        }

        private void listar() {
            BDPasajeEntities db = new BDPasajeEntities();
            var consulta = (from tipousu in db.TipoUsuario
                            where tipousu.BHABILITADO == 1
                            select new
                            {
                                tipousu.IIDTIPOUSUARIO,
                                tipousu.NOMBRE,
                                tipousu.DESCRIPCION
                            }).ToList();

            dgvTipoUsuario.DataSource = consulta;
        }

        private void filtrarTipoUsuario(object sender, EventArgs e)
        {
            string nombre = txtNombreTipoUsuario.Text;
            BDPasajeEntities db = new BDPasajeEntities();
            var consulta = (from tipousu in db.TipoUsuario
                            where tipousu.BHABILITADO == 1
                            && tipousu.NOMBRE.Contains(nombre)
                            select new
                            {
                                tipousu.IIDTIPOUSUARIO,
                                tipousu.NOMBRE,
                                tipousu.DESCRIPCION
                            }).ToList();

            dgvTipoUsuario.DataSource = consulta;
        }
    }
}
