using SistemaEducativo.DAO;
using SistemaEducativo.Models;
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

        public LoginController(FrmLogin frmLogin)
        {
            _frmLogin = frmLogin;

            _frmLogin.btnCerrarVentana.Click += (sender, e) => _frmLogin.Dispose();
            _frmLogin.btnMinimizarVentana.Click += (sender, e) => _frmLogin.WindowState = FormWindowState.Minimized;

            _frmLogin.btnIniciarSesion.Click += btnIniciarSesion_Click;
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string matricula = _frmLogin.textBoxUsuario.Text;
            string contraseña = _frmLogin.textBoxPass.Text;

            if (!string.IsNullOrEmpty(matricula) || !string.IsNullOrEmpty(contraseña))
            {
                Usuario usuario = UsuarioDAO.ValidarUsuario(matricula, contraseña);

                if (usuario != null)
                {
                    switch (usuario.Rol)
                    {
                        case "alumno":
                            frmMenuAlumno = new FrmMenuAlumno(_frmLogin);
                            frmMenuAlumno.Show();
                            break;
                        case "maestro":
                            frmMenuMaestro = new FrmMenuMaestro(_frmLogin);
                            frmMenuMaestro.Show();
                            break;
                        case "admin":
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
