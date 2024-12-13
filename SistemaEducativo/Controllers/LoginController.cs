using SistemaEducativo.DAO;
using SistemaEducativo.Models;
using SistemaEducativo.Sesion;
using SistemaEducativo.Views.Admin;
using SistemaEducativo.Views.Alumno;
using SistemaEducativo.Views.Maestro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEducativo.Controllers
{
    internal class LoginController
    {
        private FrmLogin _frmLogin;
        private FrmMenuAlumno frmMenuAlumno;
        private FrmMenuMaestro frmMenuMaestro;
        private FrmMenuAdmin frmMenuAdmin;

        private bool dragging = false;
        private Point offset;

        public LoginController(FrmLogin frmLogin)
        {
            _frmLogin = frmLogin;

            // CIERRA Y MINIMIZA EL PROGRAMA CON EL BOTON CUSTOM
            _frmLogin.btnCerrarVentana.Click += (sender, e) => _frmLogin.Dispose();
            _frmLogin.btnMinimizarVentana.Click += (sender, e) => _frmLogin.WindowState = FormWindowState.Minimized;

            // BOTON FUNCION INICIAR SESION
            _frmLogin.btnIniciarSesion.Click += btnIniciarSesion_Click;
            _frmLogin.tableLayoutPanelCustom.MouseDown += tableLayoutPanelCustom_MouseDown;
            _frmLogin.tableLayoutPanelCustom.MouseMove += tableLayoutPanelCustom_MouseMove;
            _frmLogin.tableLayoutPanelCustom.MouseUp += tableLayoutPanelCustom_MouseUp;
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
                    _frmLogin.Location = new Point(_frmLogin.Left + e.X - offset.X, _frmLogin.Top + e.Y - offset.Y);
                }
            }
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string matricula = _frmLogin.textBoxUsuario.Text;
            string contraseña = _frmLogin.textBoxPass.Text;

            if (!string.IsNullOrEmpty(matricula) || !string.IsNullOrEmpty(contraseña))
            {
                Usuario usuario = UsuarioDAO.IniciarSesion(matricula, contraseña);

                if (usuario != null)
                {
                    SesionUsuario.Instancia.IniciarSesion(usuario);

                    switch (usuario.Rol)
                    {
                        case "Alumno":
                            frmMenuAlumno = new FrmMenuAlumno(_frmLogin);
                            frmMenuAlumno.Show();
                            break;
                        case "Maestro":
                            frmMenuMaestro = new FrmMenuMaestro(_frmLogin, usuario);
                            frmMenuMaestro.Show();
                            break;
                        case "Admin":
                            frmMenuAdmin = new FrmMenuAdmin(_frmLogin, usuario);
                            frmMenuAdmin.Show();
                            break;
                        case "default":
                            MessageBox.Show("El usuario existe pero tiene un rol no identificado.");
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas");
                }
            }
        }
    }
}
