using SistemaEducativo.Views.Admin;
using SistemaEducativo.Views.Alumno;

namespace SistemaEducativo.Controllers.AlumnoControllers
{
    internal class MenuAlumnoController
    {
        private FrmMenuAlumno _frmMenuAlumno;

        public MenuAlumnoController(FrmMenuAlumno frmMenuAlumno)
        {
            _frmMenuAlumno = frmMenuAlumno;

            _frmMenuAlumno._frmLogin.Hide();

            _frmMenuAlumno.btnCerrarSesion.Click += (sender, e) => { _frmMenuAlumno._frmLogin.Show(); _frmMenuAlumno.Dispose(); };

            _frmMenuAlumno.btnCerrarVentana.Click += (sender, e) => _frmMenuAlumno._frmLogin.Dispose();
            _frmMenuAlumno.btnMinimizarVentana.Click += (sender, e) => _frmMenuAlumno.WindowState = FormWindowState.Minimized;

            _frmMenuAlumno.FormClosing += (sender, e) => _frmMenuAlumno._frmLogin.Dispose();
        }
    }
}
