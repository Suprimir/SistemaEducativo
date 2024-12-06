using Microsoft.VisualBasic.Devices;
using SistemaEducativo.Sesion;
using SistemaEducativo.Views.Admin;
using SistemaEducativo.Views.Maestro;

namespace SistemaEducativo.Controllers.AdminControllers
{
    internal class MenuAdminController
    {
        private FrmMenuAdmin _frmMenuAdmin;

        public MenuAdminController(FrmMenuAdmin frmMenuAdmin)
        {
            // ASIGNA FORMULARIO AL CONTROLADOR Y ESCONDE EL LOGIN
            _frmMenuAdmin = frmMenuAdmin;
            _frmMenuAdmin._frmLogin.Hide();

            // ASIGNA FUNCIONES DE CERRAR VENTANA, MINIMIZAR VENTANA Y CERRAR PROGRAMA
            _frmMenuAdmin.btnCerrarSesion.Click += (sender, e) => { _frmMenuAdmin._frmLogin.Show(); _frmMenuAdmin.Dispose(); } ;
            _frmMenuAdmin.btnCerrarVentana.Click += (sender, e) => _frmMenuAdmin._frmLogin.Dispose();
            _frmMenuAdmin.btnMinimizarVentana.Click += (sender, e) => _frmMenuAdmin.WindowState = FormWindowState.Minimized;
            _frmMenuAdmin.FormClosing += (sender, e) => _frmMenuAdmin._frmLogin.Dispose();

            // FUNCION A EJECUTAR AL ABRIR EL FORMULARIO
            _frmMenuAdmin.Load += frmMenuAdmin_Load;

            // SI DA CLICK AL TEXTO MENU DE ARRIBA A LA IZQUIERDA COLOCA EL SUBMENU DEFAULT
            _frmMenuAdmin.lblMenuTitulo.Click += CargarSubMenuDefault;

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
            _frmMenuAdmin.lblBienvenida.Text = $"~ Hola {SesionUsuario.Instancia.NombreUsuario} como va tu dia?";
            _frmMenuAdmin.lblBienvenidaSub.Text = "  Espero que muy bien!";
            _frmMenuAdmin.lblUsuario.Text = _frmMenuAdmin._usuarioLogueado.Matricula;
            _frmMenuAdmin.lblRol.Text = _frmMenuAdmin._usuarioLogueado.Rol;

            CargarSubMenuDefault(sender, e);
        }

        // Funcion para "reiniciar el menu" basicamente pone el submenu default

        private void CargarSubMenuDefault(object sender, EventArgs e)
        {
            FrmSubmenuAdmin frmSubmenuAdmin = new FrmSubmenuAdmin();
            AbrirFormEnPanelSubmenu(frmSubmenuAdmin);
        }

        // Funcion boton perfil

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            // ABRE EL CONTEXTMENUSTRIP (BASICAMENTE UN DROPDOWN LIST CON BOTONES EN ESTE CASO EL DE CONFIGURAR PERFIL)
            _frmMenuAdmin.contextMenuStripPerfil.Show(_frmMenuAdmin.panelPerfil, new Point(0, _frmMenuAdmin.panelPerfil.Height));
        }

        // Funciones para boton Gestion abre los formularios correspondientes

        private void btnGrupos_Click(object sender, EventArgs e)
        {
            FrmGestionGrupos frmGestionGrupos = new FrmGestionGrupos(); // ABRE FORMULARIO GESTION GRUPOS
            AbrirFormEnPanelSubmenu(frmGestionGrupos);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FrmGestionUsuarios frmGestionUsuarios = new FrmGestionUsuarios(); // ABRE FORMULARIO GESTION USUARIOS
            AbrirFormEnPanelSubmenu(frmGestionUsuarios);
        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {
            FrmGestionMaterias frmGestionMaterias = new FrmGestionMaterias(); // ABRE FORMULARIO GESTION MATERIAS
            AbrirFormEnPanelSubmenu(frmGestionMaterias);
        }

        // FUNCION PARA ABRIR FORMULARIOS EN EL PANEL SUBMENU
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
