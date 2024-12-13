using SistemaEducativo.Models;
using SistemaEducativo.Sesion;
using SistemaEducativo.Views;
using SistemaEducativo.Views.Admin;
using SistemaEducativo.Views.Alumno;
using SistemaEducativo.Views.Maestro;

namespace SistemaEducativo.Controllers.AlumnoControllers
{
    internal class MenuAlumnoController
    {
        private FrmMenuAlumno _frmMenuAlumno;
        private FrmSubmenuAlumno frmSubmenuAlumno = new FrmSubmenuAlumno();
        public static Action<Form> actualizarSubmenu;

        private bool dragging = false;
        private Point offset;

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
            _frmMenuAlumno.tableLayoutPanelCustom.MouseDown += tableLayoutPanelCustom_MouseDown;
            _frmMenuAlumno.tableLayoutPanelCustom.MouseMove += tableLayoutPanelCustom_MouseMove;
            _frmMenuAlumno.tableLayoutPanelCustom.MouseUp += tableLayoutPanelCustom_MouseUp;

            _frmMenuAlumno.lblMenuTitulo.Click += lblTitulo_Click;
            _frmMenuAlumno.btnPerfil.Click += btnPerfil_Click;
            _frmMenuAlumno.btnTareas.Click += btnTareas_Click;
            _frmMenuAlumno.btnCalificaciones.Click += btnCalificaciones_Click;

            _frmMenuAlumno.configurarPerfilToolStripMenuItem.Click += btnConfigurarPerfil_Click;
        }

        private void frmMenuAlumno_Load(object sender, EventArgs e)
        {
            _frmMenuAlumno.lblBienvenida.Text = $"~ Hola {SesionUsuario.Instancia.NombreUsuario} como va tu dia?";
            _frmMenuAlumno.lblBienvenidaSub.Text = "  Espero que muy bien!";

            _frmMenuAlumno.lblUsuario.Text = SesionUsuario.Instancia.Matricula;
            _frmMenuAlumno.lblCarrera.Text = SesionUsuario.Instancia.Carrera;

            _frmMenuAlumno.pictureBoxMPfp.ImageLocation = SesionUsuario.Instancia.PathImagen;

            AbrirFormEnPanelSubmenu(frmSubmenuAlumno);
        }

        private void tableLayoutPanelCustom_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                offset = new Point(e.X, e.Y);  // Captura la posición relativa del mouse
            }
        }

        private void tableLayoutPanelCustom_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void tableLayoutPanelCustom_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (dragging)
                {
                    _frmMenuAlumno.Location = new Point(_frmMenuAlumno.Left + e.X - offset.X, _frmMenuAlumno.Top + e.Y - offset.Y);
                }
            }
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {
            SubmenuAlumnoController.actualizarSubMenu?.Invoke();
            AbrirFormEnPanelSubmenu(frmSubmenuAlumno);
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            // ABRE EL CONTEXTMENUSTRIP (BASICAMENTE UN DROPDOWN LIST CON BOTONES EN ESTE CASO EL DE CONFIGURAR PERFIL)
            _frmMenuAlumno.contextMenuStripPerfil.Show(_frmMenuAlumno.panelPerfil, new Point(0, _frmMenuAlumno.panelPerfil.Height));
        }

        private void btnTareas_Click(object sender, EventArgs e)
        {
            FrmGestionTareasAlumno frmGestionTareasAlumno = new FrmGestionTareasAlumno();
            AbrirFormEnPanelSubmenu(frmGestionTareasAlumno);
        }

        private void btnCalificaciones_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            usuario.Matricula = SesionUsuario.Instancia.Matricula;
            usuario.Carrera = SesionUsuario.Instancia.Carrera;
            usuario.GrupoId = SesionUsuario.Instancia.GrupoID;

            FrmVistaCalificaciones frmVistaCalificacionesAlumno = new FrmVistaCalificaciones(null, usuario, null);
            AbrirFormEnPanelSubmenu(frmVistaCalificacionesAlumno);
        }

        private void btnConfigurarPerfil_Click(object sender, EventArgs e)
        {
            FrmConfiguracionPerfil frmConfiguracionPerfil = new FrmConfiguracionPerfil();
            frmConfiguracionPerfil.Show();
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
