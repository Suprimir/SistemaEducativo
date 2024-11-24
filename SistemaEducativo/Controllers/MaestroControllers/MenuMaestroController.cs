using SistemaEducativo.Views.Maestro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEducativo.Controllers.MaestroControllers
{
    internal class MenuMaestroController
    {
        private FrmMenuMaestro _frmMenuMaestro;
        public MenuMaestroController(FrmMenuMaestro frmMenuMaestro)
        {
            _frmMenuMaestro = frmMenuMaestro;

            _frmMenuMaestro._frmLogin.Hide();

            _frmMenuMaestro.btnRegistrarGeneracion.Click += btnRegistrarGeneracion_Click;
            _frmMenuMaestro.btnVerGeneraciones.Click += btnVerGeneraciones_Click;
            _frmMenuMaestro.btnCerrarVentana.Click += btnCerrarVentana_Click;
        }

        private void btnRegistrarGeneracion_Click(object sender, EventArgs e)
        {
            FrmRegistroGeneracion frmRegistroGeneracion = new FrmRegistroGeneracion();
            frmRegistroGeneracion.ShowDialog();
        }

        private void btnVerGeneraciones_Click(object sender, EventArgs e)
        {
            FrmVerGeneraciones frmVerGSP = new FrmVerGeneraciones();
            frmVerGSP.ShowDialog();
        }

        private void btnCerrarVentana_Click(object sender, EventArgs e)
        {
            _frmMenuMaestro._frmLogin.Dispose();
        }
    }
}
