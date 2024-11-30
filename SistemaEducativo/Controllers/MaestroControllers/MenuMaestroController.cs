using Org.BouncyCastle.Tls;
using SistemaEducativo.DAO;
using SistemaEducativo.Models;
using SistemaEducativo.Views.Admin;
using SistemaEducativo.Views.Alumno;
using SistemaEducativo.Views.Maestro;

namespace SistemaEducativo.Controllers.MaestroControllers
{
    internal class MenuMaestroController
    {
        private FrmMenuMaestro _frmMenuMaestro;
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

            // ASIGNAMOS FUNCION QUE CARGA TODO LO NECESARIO AL INICIO DEL MENU
            _frmMenuMaestro.Load += frmMenuMaestro_Load;

            // ASIGNAMOS FUNCIONES A LOS BOTONES DEL MENU
            _frmMenuMaestro.btnGrupos.Click += btnGrupos_Click;
            _frmMenuMaestro.btnTareas.Click += btnTareas_Click;
        }

        private void frmMenuMaestro_Load(object sender, EventArgs e)
        {

            _frmMenuMaestro.lblBienvenida.Text = $"~ Bienvenido {_frmMenuMaestro._usuarioLogueado.Nombre}!";
            _frmMenuMaestro.lblUsuario.Text = _frmMenuMaestro._usuarioLogueado.Matricula;
            _frmMenuMaestro.lblRol.Text = _frmMenuMaestro._usuarioLogueado.Rol;
        }

        private void btnGrupos_Click(object sender, EventArgs e)
        {
            FrmGestionGruposAsignados frmGestionGruposAsignados = new FrmGestionGruposAsignados(_frmMenuMaestro._usuarioLogueado);
            AbrirFormEnPanelSubmenu(frmGestionGruposAsignados);
        }

        private void btnTareas_Click(object sender, EventArgs e)
        {
            FrmGestionTareas frmGestionTareas = new FrmGestionTareas(null);
            AbrirFormEnPanelSubmenu(frmGestionTareas);
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
