using Org.BouncyCastle.Tls;
using SistemaEducativo.DAO;
using SistemaEducativo.Models;
using SistemaEducativo.Sesion;
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

            _frmMenuMaestro.lblMenuTitulo.Click += lblTitulo_Click;

            // ASIGNAMOS FUNCION QUE CARGA TODO LO NECESARIO AL INICIO DEL MENU
            _frmMenuMaestro.Load += frmMenuMaestro_Load;

            // ASIGNAMOS FUNCIONES A LOS BOTONES DEL MENU
            _frmMenuMaestro.btnGrupos.Click += btnGrupos_Click;
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

        private void btnGrupos_Click(object sender, EventArgs e)
        {
            FrmGestionGruposAsignados frmGestionGruposAsignados = new FrmGestionGruposAsignados(_frmMenuMaestro._usuarioLogueado);
            AbrirFormEnPanelSubmenu(frmGestionGruposAsignados);
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanelSubmenu(frmSubmenuMaestro);
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
