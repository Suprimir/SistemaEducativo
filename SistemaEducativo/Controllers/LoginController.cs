using SistemaEducativo.DAO;
using SistemaEducativo.Models;
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

        public LoginController(FrmLogin frmLogin)
        {
            _frmLogin = frmLogin;

            _frmLogin.btnCerrarVentana.Click += frmLogin_Dispose;
            _frmLogin.btnMinimizarVentana.Click += frmLogin_Minimize;
            _frmLogin.btnIniciarSesion.Click += btnIniciarSesion_Click;
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string matricula = _frmLogin.textBoxUsuario.Text;
            string contraseña = _frmLogin.textBoxPass.Text;

            Usuario usuario = UsuarioDAO.ValidarUsuario(matricula, contraseña);

            if(usuario != null)
            {
                switch(usuario.Rol)
                {
                    case "alumno":
                        frmMenuAlumno = new FrmMenuAlumno(_frmLogin);
                        frmMenuAlumno.ShowDialog();
                        break;
                    case "maestro":
                        frmMenuMaestro = new FrmMenuMaestro(_frmLogin);
                        frmMenuMaestro.ShowDialog();
                        break;
                    case "admin":
                        frmMenuMaestro = new FrmMenuMaestro(_frmLogin);
                        frmMenuMaestro.ShowDialog();
                        break;
                    case "default":
                        MessageBox.Show("El usuario existe pero tiene un rol no identificado.");
                        break;
                }
            }
        }

        private void frmLogin_Dispose(object sender, EventArgs e)
        {
            _frmLogin.Dispose();
        }

        private void frmLogin_Minimize(object sender, EventArgs e)
        {
            _frmLogin.WindowState = FormWindowState.Minimized;
        }
    }
}
