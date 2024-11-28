using SistemaEducativo.Views.Admin;
using SistemaEducativo.Views.Maestro;

namespace SistemaEducativo.Controllers.AdminControllers
{
    internal class MenuAdminController
    {
        private FrmMenuAdmin _frmMenuAdmin;

        public MenuAdminController(FrmMenuAdmin frmMenuAdmin)
        {
            _frmMenuAdmin = frmMenuAdmin;

            _frmMenuAdmin._frmLogin.Hide();

            _frmMenuAdmin.btnCerrarSesion.Click += (sender, e) => { _frmMenuAdmin._frmLogin.Show(); _frmMenuAdmin.Dispose(); } ;

            _frmMenuAdmin.btnCerrarVentana.Click += (sender, e) => _frmMenuAdmin._frmLogin.Dispose();
            _frmMenuAdmin.btnMinimizarVentana.Click += (sender, e) => _frmMenuAdmin.WindowState = FormWindowState.Minimized;

            _frmMenuAdmin.FormClosing += (sender, e) => _frmMenuAdmin._frmLogin.Dispose();

            _frmMenuAdmin.Load += frmMenuAdmin_Load;
            _frmMenuAdmin.lblMenuTitulo.Click += lblMenuTitulo_Click;

            // Configuracion Botones Menu
            _frmMenuAdmin.panelPerfil.Click += btnPerfil_Click;
            _frmMenuAdmin.btnPerfil.Click += btnPerfil_Click;

            _frmMenuAdmin.btnGrupos.Click += btnGrupos_Click;
            _frmMenuAdmin.btnUsuarios.Click += btnUsuarios_Click;
            _frmMenuAdmin.btnMaterias.Click += btnMaterias_Click;
        }

        // FUNCION QUE SE EJECUTA AL INICIA EL FORMULARIO DE MENU ADMIN

        private void frmMenuAdmin_Load(object sender, EventArgs e)
        {
            _frmMenuAdmin.lblBienvenida.Text = $"~ Bienvenido {_frmMenuAdmin._usuarioLogueado.Nombre}!";
            _frmMenuAdmin.lblUsuario.Text = _frmMenuAdmin._usuarioLogueado.Matricula;
            _frmMenuAdmin.lblRol.Text = _frmMenuAdmin._usuarioLogueado.Rol;

            lblMenuTitulo_Click(sender, e);
        }

        // Funcion para "reiniciar el menu" basicamente pone el submenu default

        private void lblMenuTitulo_Click(object sender, EventArgs e)
        {
            FrmSubmenuAdmin frmSubmenuAdmin = new FrmSubmenuAdmin();
            AbrirFormEnPanelSubmenu(frmSubmenuAdmin);
        }

        // Funcion boton perfil

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            _frmMenuAdmin.contextMenuStripPerfil.Show(_frmMenuAdmin.panelPerfil, new Point(0, _frmMenuAdmin.panelPerfil.Height));
        }

        // Funciones para boton Gestion

        private void btnGrupos_Click(object sender, EventArgs e)
        {
            FrmGestionGrupos frmGestionGrupos = new FrmGestionGrupos();
            AbrirFormEnPanelSubmenu(frmGestionGrupos);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FrmGestionUsuarios frmGestionUsuarios = new FrmGestionUsuarios();
            AbrirFormEnPanelSubmenu(frmGestionUsuarios);
        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {
            FrmGestionMaterias frmGestionMaterias = new FrmGestionMaterias();
            AbrirFormEnPanelSubmenu(frmGestionMaterias);
        }

        private void AbrirFormEnPanelSubmenu(Form subMenu)
        {
            if(_frmMenuAdmin.panelSubMenu.Controls.Count > 0)
            {
                _frmMenuAdmin.panelSubMenu.Controls.RemoveAt(0);
            }

            subMenu.TopLevel = false;
            subMenu.Dock =  DockStyle.Fill;
            _frmMenuAdmin.panelSubMenu.Controls.Add(subMenu);
            _frmMenuAdmin.panelSubMenu.Tag = subMenu;
            subMenu.Show();
        }
    }
}
