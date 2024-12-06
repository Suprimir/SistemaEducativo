using SistemaEducativo.Sesion;
using SistemaEducativo.Views.Admin;
using SistemaEducativo.Views.Alumno;
using SistemaEducativo.Views.Maestro;

namespace SistemaEducativo.Controllers.AlumnoControllers
{
    internal class MenuAlumnoController
    {
        private FrmMenuAlumno _frmMenuAlumno;
        public static Action<Form> actualizarSubmenu;

        public MenuAlumnoController(FrmMenuAlumno frmMenuAlumno)
        {
            _frmMenuAlumno = frmMenuAlumno;
            _frmMenuAlumno._frmLogin.Hide();

            actualizarSubmenu = AbrirFormEnPanelSubmenu;

            _frmMenuAlumno.btnCerrarSesion.Click += (sender, e) => { _frmMenuAlumno._frmLogin.Show(); _frmMenuAlumno.Dispose(); };

            _frmMenuAlumno.btnCerrarVentana.Click += (sender, e) => _frmMenuAlumno._frmLogin.Dispose();
            _frmMenuAlumno.btnMinimizarVentana.Click += (sender, e) => _frmMenuAlumno.WindowState = FormWindowState.Minimized;

            _frmMenuAlumno.FormClosing += (sender, e) => _frmMenuAlumno._frmLogin.Dispose();

            _frmMenuAlumno.Load += frmMenuAlumno_Load;
            _frmMenuAlumno.btnTareas.Click += btnTareas_Click;
        }

        private void frmMenuAlumno_Load(object sender, EventArgs e)
        {
            _frmMenuAlumno.lblBienvenida.Text = $"~ Hola {SesionUsuario.Instancia.NombreUsuario} como va tu dia?";
            _frmMenuAlumno.lblBienvenidaSub.Text = "  Espero que muy bien!";
        }

        private void btnTareas_Click(object sender, EventArgs e)
        {
            FrmGestionTareasAlumno frmGestionTareasAlumno = new FrmGestionTareasAlumno();
            AbrirFormEnPanelSubmenu(frmGestionTareasAlumno);
        }

        private void AbrirFormEnPanelSubmenu(Form subMenu)
        {
            if (_frmMenuAlumno.panelSubMenu.Controls.Count > 0)
            {
                _frmMenuAlumno.panelSubMenu.Controls.RemoveAt(0);
            }

            subMenu.TopLevel = false;
            subMenu.Dock = DockStyle.Fill;
            _frmMenuAlumno.panelSubMenu.Controls.Add(subMenu);
            _frmMenuAlumno.panelSubMenu.Tag = subMenu;
            subMenu.Show();
        }
    }
}
