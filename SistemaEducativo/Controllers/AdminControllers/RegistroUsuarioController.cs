using SistemaEducativo.DAO;
using SistemaEducativo.Models;
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
        private Usuario usuarioSeleccionado; // En caso de que se quiera editar un usuario

        public RegistroUsuarioController(FrmRegistroUsuario frmRegistroUsuario, Usuario usuario)
        {
            _frmRegistroUsuario = frmRegistroUsuario;
            usuarioSeleccionado = usuario;

            _frmRegistroUsuario.lblAsignarGStatic.Enabled = false;
            _frmRegistroUsuario.comboBoxGrupo.Enabled = false;

            if (usuarioSeleccionado != null)
            {
                _frmRegistroUsuario.Load += frmRegistroUsuario_Load;
            }


            _frmRegistroUsuario.btnRegistrarUsuario.Click += btnRegistrarUsuario_Click;
            _frmRegistroUsuario.comboBoxRol.TextChanged += comboBoxRol_TextChanged;
        }

        private void frmRegistroUsuario_Load(object sender, EventArgs e)
        {
            _frmRegistroUsuario.textBoxNombre.Text = usuarioSeleccionado.Nombre;
            _frmRegistroUsuario.textBoxApellidoP.Text = usuarioSeleccionado.ApellidoP;
            _frmRegistroUsuario.textBoxApellidoM.Text = usuarioSeleccionado.ApellidoM;
            _frmRegistroUsuario.textBoxMatricula.Text = usuarioSeleccionado.Matricula;
            _frmRegistroUsuario.textBoxMatricula.Enabled = false;
            _frmRegistroUsuario.textBoxContraseña.Text = usuarioSeleccionado.Pass;
            _frmRegistroUsuario.textBoxCorreo.Text = usuarioSeleccionado.Correo;
            _frmRegistroUsuario.comboBoxRol.Text = usuarioSeleccionado.Rol;
            _frmRegistroUsuario.comboBoxRol.Enabled = false;
            _frmRegistroUsuario.comboBoxGrupo.Text = usuarioSeleccionado.GrupoId.ToString();
            _frmRegistroUsuario.comboBoxGrupo.Enabled = false;
        }

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            if (usuarioSeleccionado != null)
            {
                usuarioSeleccionado.Nombre = _frmRegistroUsuario.textBoxNombre.Text;
                usuarioSeleccionado.ApellidoP = _frmRegistroUsuario.textBoxApellidoP.Text;
                usuarioSeleccionado.ApellidoM = _frmRegistroUsuario.textBoxApellidoM.Text;
                usuarioSeleccionado.Pass = _frmRegistroUsuario.textBoxContraseña.Text;
                usuarioSeleccionado.Correo = _frmRegistroUsuario.textBoxCorreo.Text;

                if (UsuarioDAO.CrearActualizarUsuario(usuarioSeleccionado))
                {
                    MessageBox.Show("Registro exitoso.");
                    GestionUsuariosController.actualizarTabla?.Invoke();
                    _frmRegistroUsuario.Close();
                }
            } else
            {
                // OBTENER TODOS LOS VALORES
                Usuario usuario = new Usuario();

                usuario.Nombre = _frmRegistroUsuario.textBoxNombre.Text;
                usuario.ApellidoP = _frmRegistroUsuario.textBoxApellidoP.Text;
                usuario.ApellidoM = _frmRegistroUsuario.textBoxApellidoM.Text;
                usuario.Matricula = _frmRegistroUsuario.textBoxMatricula.Text;
                usuario.Pass = _frmRegistroUsuario.textBoxContraseña.Text;
                usuario.Correo = _frmRegistroUsuario.textBoxCorreo.Text;
                usuario.Rol = _frmRegistroUsuario.comboBoxRol.Text;

                if (UsuarioDAO.CrearActualizarUsuario(usuario))
                {
                    MessageBox.Show("Registro exitoso.");
                    GestionUsuariosController.actualizarTabla?.Invoke();
                    _frmRegistroUsuario.Close();
                }
            }
        }

        private void comboBoxRol_TextChanged(object sender, EventArgs e)
        {
            if (_frmRegistroUsuario.comboBoxRol.Text == "alumno")
            {
                _frmRegistroUsuario.lblAsignarGStatic.Enabled = true;
                _frmRegistroUsuario.comboBoxGrupo.Enabled = true;
            }
        }
    }
}
