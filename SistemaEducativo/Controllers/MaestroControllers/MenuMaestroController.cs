using Org.BouncyCastle.Tls;
using SistemaEducativo.DAO;
using SistemaEducativo.Models;
using SistemaEducativo.Views.Maestro;

namespace SistemaEducativo.Controllers.MaestroControllers
{
    internal class MenuMaestroController
    {
        private FrmMenuMaestro _frmMenuMaestro;
        public MenuMaestroController(FrmMenuMaestro frmMenuMaestro)
        {
            _frmMenuMaestro = frmMenuMaestro;
            _frmMenuMaestro._frmLogin.Hide();

            _frmMenuMaestro.btnCerrarSesion.Click += (sender, e) => { _frmMenuMaestro._frmLogin.Show(); _frmMenuMaestro.Dispose(); };

            _frmMenuMaestro.btnCerrarVentana.Click += (sender, e) => _frmMenuMaestro._frmLogin.Dispose();
            _frmMenuMaestro.btnMinimizarVentana.Click += (sender, e) => _frmMenuMaestro.WindowState = FormWindowState.Minimized;

            _frmMenuMaestro.FormClosing += (sender, e) => _frmMenuMaestro._frmLogin.Dispose();
        }
    }
}
