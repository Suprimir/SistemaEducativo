using SistemaEducativo.Views.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEducativo.Controllers.AdminControllers
{
    internal class RegistroUsuarioController
    {
        private FrmRegistroUsuario _frmRegistroUsuario;

        public RegistroUsuarioController(FrmRegistroUsuario frmRegistroUsuario)
        {
            _frmRegistroUsuario = frmRegistroUsuario;

            _frmRegistroUsuario.btnRegistrarUsuario.Click += btnRegistrarUsuario_Click;
        }

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            // OBTENER TODOS LOS VALORES

            string nombre = _frmRegistroUsuario.textBoxNombre.Text;
            string apellidoP = _frmRegistroUsuario.textBoxApellidoP.Text;
            string apellidoM = _frmRegistroUsuario.textBoxApellidoM.Text;
            string matricula = _frmRegistroUsuario.textBoxMatricula.Text;
            string contraseña = _frmRegistroUsuario.textBoxContraseña.Text;
            string correo = _frmRegistroUsuario.textBoxCorreo.Text;
            string rol = _frmRegistroUsuario.comboBoxRol.Text;
            string grupo = _frmRegistroUsuario.comboBoxGrupo.Text;
        }
    }
}
