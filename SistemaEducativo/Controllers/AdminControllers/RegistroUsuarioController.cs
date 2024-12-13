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
        private List<Grupo> lstGrupos;
        private Usuario usuarioSeleccionado; // En caso de que se quiera editar un usuario

        public RegistroUsuarioController(FrmRegistroUsuario frmRegistroUsuario, Usuario usuario)
        {
            _frmRegistroUsuario = frmRegistroUsuario;
            usuarioSeleccionado = usuario;

            lstGrupos = GrupoDAO.ObtenerGrupos();

            foreach (var grupo in lstGrupos)
            {
                _frmRegistroUsuario.comboBoxGrupo.Items.Add(grupo.NombreGrupo);
            }

            _frmRegistroUsuario.lblAsignarGStatic.Enabled = false;
            _frmRegistroUsuario.comboBoxGrupo.Enabled = false;
            _frmRegistroUsuario.textBoxCorreo.Enabled = false;

            if (usuarioSeleccionado != null)
            {
                _frmRegistroUsuario.Load += frmRegistroUsuario_Load;
            }

            _frmRegistroUsuario.textBoxMatricula.TextChanged += textBoxMatricula_TextChanged;
            _frmRegistroUsuario.checkBoxCorreo.CheckedChanged += checkBoxCorreo_CheckedChanged;
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

        private void textBoxMatricula_TextChanged(object sender, EventArgs e)
        {
            if (_frmRegistroUsuario.checkBoxCorreo.Checked)
            {
                _frmRegistroUsuario.textBoxCorreo.Text = $"{_frmRegistroUsuario.textBoxMatricula.Text}@escuela.com";
            }
        }

        private void checkBoxCorreo_CheckedChanged(object sender, EventArgs e)
        {
            if (!_frmRegistroUsuario.checkBoxCorreo.Checked)
            {
                _frmRegistroUsuario.textBoxCorreo.Enabled = true;
            } else
            {
                _frmRegistroUsuario.textBoxCorreo.Enabled = false;
                textBoxMatricula_TextChanged(sender, e);
            }
        }

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            bool validarInputs = _frmRegistroUsuario.Controls.OfType<TextBox>().All(tb => !string.IsNullOrEmpty(tb.Text));

            if (validarInputs && !string.IsNullOrEmpty(_frmRegistroUsuario.comboBoxRol.Text))
            {
                if (usuarioSeleccionado != null)
                {
                    usuarioSeleccionado.Nombre = _frmRegistroUsuario.textBoxNombre.Text;
                    usuarioSeleccionado.ApellidoP = _frmRegistroUsuario.textBoxApellidoP.Text;
                    usuarioSeleccionado.ApellidoM = _frmRegistroUsuario.textBoxApellidoM.Text;
                    usuarioSeleccionado.Pass = _frmRegistroUsuario.textBoxContraseña.Text;
                    usuarioSeleccionado.Correo = _frmRegistroUsuario.textBoxCorreo.Text;

                    string path = Path.Combine(Application.StartupPath, "fotosPerfil");

                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }

                    if (_frmRegistroUsuario.openFileDialogPfp.FileName != "")
                    {
                        string pathArchivoInicial = _frmRegistroUsuario.openFileDialogPfp.FileName;
                        string pathFinal = Path.Combine(path, usuarioSeleccionado.Matricula.ToString() + Path.GetExtension(pathArchivoInicial));

                        File.Copy(pathArchivoInicial, pathFinal, true);

                        usuarioSeleccionado.PathFotoPerfil = pathFinal;
                    }

                    if (UsuarioDAO.CrearActualizarUsuario(usuarioSeleccionado))
                    {
                        MessageBox.Show("Registro exitoso.");
                        GestionUsuariosController.actualizarTabla?.Invoke();
                        _frmRegistroUsuario.Close();
                    }
                }
                else
                {
                    Grupo grupo = lstGrupos.First(g => g.NombreGrupo == _frmRegistroUsuario.comboBoxGrupo.Text);

                    // OBTENER TODOS LOS VALORES
                    Usuario usuario = new Usuario();

                    usuario.Nombre = _frmRegistroUsuario.textBoxNombre.Text;
                    usuario.ApellidoP = _frmRegistroUsuario.textBoxApellidoP.Text;
                    usuario.ApellidoM = _frmRegistroUsuario.textBoxApellidoM.Text;
                    usuario.Matricula = _frmRegistroUsuario.textBoxMatricula.Text;
                    usuario.Pass = _frmRegistroUsuario.textBoxContraseña.Text;
                    usuario.Correo = _frmRegistroUsuario.textBoxCorreo.Text;
                    usuario.Rol = _frmRegistroUsuario.comboBoxRol.Text;
                    usuario.GrupoId = grupo.Id;

                    string path = Path.Combine(Application.StartupPath, "fotosPerfil");

                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }

                    if (_frmRegistroUsuario.openFileDialogPfp.FileName != "")
                    {
                        string pathArchivoInicial = _frmRegistroUsuario.openFileDialogPfp.FileName;
                        string pathFinal = Path.Combine(path, usuario.Matricula.ToString() + Path.GetExtension(pathArchivoInicial));

                        File.Copy(pathArchivoInicial, pathFinal, true);

                        usuario.PathFotoPerfil = pathFinal;
                    }

                    if (UsuarioDAO.CrearActualizarUsuario(usuario))
                    {
                        MessageBox.Show("Registro exitoso.");
                        GestionUsuariosController.actualizarTabla?.Invoke();
                        _frmRegistroUsuario.Close();
                    }
                }
            } else
            {
                MessageBox.Show("Debes rellenar todos los campos.");
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
            if (_frmRegistroUsuario.comboBoxRol.Text == "Alumno")
            {
                _frmRegistroUsuario.lblAsignarGStatic.Enabled = true;
                _frmRegistroUsuario.comboBoxGrupo.Enabled = true;
            }
        }
    }
}
