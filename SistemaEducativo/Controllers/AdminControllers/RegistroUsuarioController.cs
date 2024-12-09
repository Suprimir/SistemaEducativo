using SistemaEducativo.DAO;
using SistemaEducativo.Models;
using SistemaEducativo.Views.Admin;
using SistemaEducativo.Views.Alumno;
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
            _frmRegistroUsuario.btnSubirFoto.Click += btnSubirFoto_Click;
            _frmRegistroUsuario.openFileDialogPfp.FileOk += openFileDialogPfp_FileOk;
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
            string path = Path.Combine(Application.StartupPath, "fotosPerfil");

            if(!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            string pathArchivoInicial = _frmRegistroUsuario.openFileDialogPfp.FileName;
            string pathFinal = Path.Combine(path, usuarioSeleccionado.Matricula.ToString() + Path.GetExtension(pathArchivoInicial));

            File.Copy(pathArchivoInicial, pathFinal, true);

            if (usuarioSeleccionado != null)
            {
                usuarioSeleccionado.Nombre = _frmRegistroUsuario.textBoxNombre.Text;
                usuarioSeleccionado.ApellidoP = _frmRegistroUsuario.textBoxApellidoP.Text;
                usuarioSeleccionado.ApellidoM = _frmRegistroUsuario.textBoxApellidoM.Text;
                usuarioSeleccionado.Pass = _frmRegistroUsuario.textBoxContraseña.Text;
                usuarioSeleccionado.Correo = _frmRegistroUsuario.textBoxCorreo.Text;
                usuarioSeleccionado.PathFotoPerfil = pathFinal;

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
                usuario.PathFotoPerfil = pathFinal;

                if (UsuarioDAO.CrearActualizarUsuario(usuario))
                {
                    MessageBox.Show("Registro exitoso.");
                    GestionUsuariosController.actualizarTabla?.Invoke();
                    _frmRegistroUsuario.Close();
                }
            }
        }

        private void btnSubirFoto_Click(object sender, EventArgs e)
        {
            _frmRegistroUsuario.openFileDialogPfp.ShowDialog();
        }

        private void openFileDialogPfp_FileOk(object sender, EventArgs e)
        {
            _frmRegistroUsuario.pictureBoxPfp.ImageLocation = _frmRegistroUsuario.openFileDialogPfp.FileName;
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
