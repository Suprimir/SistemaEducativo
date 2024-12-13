using Org.BouncyCastle.Tls;
using SistemaEducativo.DAO;
using SistemaEducativo.Models;
using SistemaEducativo.Sesion;
using SistemaEducativo.Views;
using SistemaEducativo.Views.Admin;
using SistemaEducativo.Views.Alumno;
using SistemaEducativo.Views.Maestro;

namespace SistemaEducativo.Controllers.MaestroControllers
{
    internal class MenuMaestroController
    {
        private FrmMenuMaestro _frmMenuMaestro;
        FrmSubmenuMaestro frmSubmenuMaestro = new FrmSubmenuMaestro();
        public static Action<Form> actualizarSubmenu;

        private bool dragging = false;
        private Point offset;

        public MenuMaestroController(FrmMenuMaestro frmMenuMaestro)
        {
            // ASIGNAMOS EL EL FORMULARIO AL CONTROLLER Y ESCONDEMOS EL LOGIN
            _frmMenuMaestro = frmMenuMaestro;
            _frmMenuMaestro._frmLogin.Hide();

            // AGREGO LA FUNCION DE ACTUALIZAR EL SUBMENU A UN ACTION PARA EJECUTARLO DONDE SEA
            actualizarSubmenu = AbrirFormEnPanelSubmenu;

            // ASIGNO FUNCIONES DE CERRAR SESION, (CERRAR VENTANA Y MINIMIZAR VENTANA A BOTONES CUSTOM)
            _frmMenuMaestro.btnCerrarSesion.Click += (sender, e) => { _frmMenuMaestro._frmLogin.Show(); _frmMenuMaestro.Dispose(); };
            _frmMenuMaestro.btnCerrarVentana.Click += (sender, e) => _frmMenuMaestro._frmLogin.Dispose();
            _frmMenuMaestro.btnMinimizarVentana.Click += (sender, e) => _frmMenuMaestro.WindowState = FormWindowState.Minimized;
            _frmMenuMaestro.FormClosing += (sender, e) => _frmMenuMaestro._frmLogin.Dispose();

            // ASIGNAMOS FUNCION QUE CARGA TODO LO NECESARIO AL INICIO DEL MENU
            _frmMenuMaestro.Load += frmMenuMaestro_Load;
            _frmMenuMaestro.tableLayoutPanelCustom.MouseDown += tableLayoutPanelCustom_MouseDown;
            _frmMenuMaestro.tableLayoutPanelCustom.MouseMove += tableLayoutPanelCustom_MouseMove;
            _frmMenuMaestro.tableLayoutPanelCustom.MouseUp += tableLayoutPanelCustom_MouseUp;

            // ASIGNAMOS FUNCIONES A LOS BOTONES DEL MENU
            _frmMenuMaestro.lblMenuTitulo.Click += lblTitulo_Click;
            _frmMenuMaestro.btnPerfil.Click += btnPerfil_Click;
            _frmMenuMaestro.btnGrupos.Click += btnGrupos_Click;
            _frmMenuMaestro.configurarPerfilToolStripMenuItem.Click += btnConfigurarPerfil_Click;
        }

        private void frmMenuMaestro_Load(object sender, EventArgs e)
        {
            _frmMenuMaestro.lblBienvenida.Text = $"~ Hola {SesionUsuario.Instancia.NombreUsuario} como va tu dia?";
            _frmMenuMaestro.lblBienvenidaSub.Text = "  Espero que muy bien!";
            _frmMenuMaestro.lblMatricula.Text = SesionUsuario.Instancia.Matricula;
            _frmMenuMaestro.lblRol.Text = SesionUsuario.Instancia.Rol;

            _frmMenuMaestro.pictureBoxMPfp.ImageLocation = SesionUsuario.Instancia.PathImagen;

            AbrirFormEnPanelSubmenu(frmSubmenuMaestro);
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
                    _frmMenuMaestro.Location = new Point(_frmMenuMaestro.Left + e.X - offset.X, _frmMenuMaestro.Top + e.Y - offset.Y);
                }
            }
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            // ABRE EL CONTEXTMENUSTRIP (BASICAMENTE UN DROPDOWN LIST CON BOTONES EN ESTE CASO EL DE CONFIGURAR PERFIL)
            _frmMenuMaestro.contextMenuStripPerfil.Show(_frmMenuMaestro.panelPerfil, new Point(0, _frmMenuMaestro.panelPerfil.Height));
        }

        private void btnGrupos_Click(object sender, EventArgs e)
        {
            FrmGestionGruposAsignados frmGestionGruposAsignados = new FrmGestionGruposAsignados(_frmMenuMaestro._usuarioLogueado);
            AbrirFormEnPanelSubmenu(frmGestionGruposAsignados);
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {
            SubmenuMaestroController.actualizarSubMenu?.Invoke();
            AbrirFormEnPanelSubmenu(frmSubmenuMaestro);
        }

        private void btnConfigurarPerfil_Click(object sender, EventArgs e)
        {
            FrmConfiguracionPerfil frmConfiguracionPerfil = new FrmConfiguracionPerfil();
            frmConfiguracionPerfil.Show();
        }

        private void AbrirFormEnPanelSubmenu(Form subMenu)
        {
            if (_frmMenuMaestro.panelSubMenu.Controls.Count > 0)
            {
                _frmMenuMaestro.panelSubMenu.Controls.RemoveAt(0);
            }

            subMenu.TopLevel = false;
            subMenu.Dock = DockStyle.Fill;
            _frmMenuMaestro.panelSubMenu.Controls.Add(subMenu);
            _frmMenuMaestro.panelSubMenu.Tag = subMenu;
            subMenu.Show();
        }
    }
}
