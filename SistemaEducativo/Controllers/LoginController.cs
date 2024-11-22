using SistemaEducativo.DAO;
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

        public LoginController(FrmLogin frmLogin)
        {
            _frmLogin = frmLogin;

            _frmLogin.btnCerrarVentana.Click += frmLogin_Dispose;
            _frmLogin.btnMinimizarVentana.Click += frmLogin_Minimize;
            _frmLogin.btnIniciarSesion.Click += btnIniciarSesion_Click;
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            int matricula = Convert.ToInt32(_frmLogin.textBoxUsuario.Text);
            string pass = _frmLogin.textBoxPass.Text;

            if(UsuarioDAO.ValidarUsuario(matricula, pass))
            {
                MessageBox.Show("EL USUARIO EXISTE");
            } else
            {
                MessageBox.Show("EL USUARIO NO EXISTE");
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
