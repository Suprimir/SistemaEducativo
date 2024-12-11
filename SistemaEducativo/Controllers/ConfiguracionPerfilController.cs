using SistemaEducativo.DAO;
using SistemaEducativo.Sesion;
using SistemaEducativo.Views;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEducativo.Controllers
{
    internal class ConfiguracionPerfilController
    {
        private FrmConfiguracionPerfil _frmConfiguracionPerfil;
        private bool cambioContraseña = false;
        private bool cambioFoto = false;

        public ConfiguracionPerfilController(FrmConfiguracionPerfil frmConfiguracionPerfil)
        {
            _frmConfiguracionPerfil = frmConfiguracionPerfil;

            _frmConfiguracionPerfil.textBoxContraseñaActual.Enabled = false;
            _frmConfiguracionPerfil.textBoxContraseñaNueva.Enabled = false;

            _frmConfiguracionPerfil.checkBoxContraseña.CheckedChanged += checkBoxContraseña_CheckedChanged;

            _frmConfiguracionPerfil.btnSubirFoto.Click += btnSubirFoto_Click;
            _frmConfiguracionPerfil.btnActualizarPerfil.Click += btnActualizarPerfil_Click;

            _frmConfiguracionPerfil.openFileDialogPfp.FileOk += openFileDialogPfp_FileOk;
        }

        private void checkBoxContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (_frmConfiguracionPerfil.checkBoxContraseña.Checked == true)
            {
                _frmConfiguracionPerfil.textBoxContraseñaActual.Enabled = true;
                _frmConfiguracionPerfil.textBoxContraseñaNueva.Enabled = true;

                cambioContraseña = true;
            } else
            {
                _frmConfiguracionPerfil.textBoxContraseñaActual.Enabled = false;
                _frmConfiguracionPerfil.textBoxContraseñaNueva.Enabled = false;
                cambioContraseña = false;
            }
        }

        private void btnSubirFoto_Click(object sender, EventArgs e)
        {
            _frmConfiguracionPerfil.openFileDialogPfp.ShowDialog();
        }

        private void btnActualizarPerfil_Click(object sender, EventArgs e)
        {
            string contraseñaActual = _frmConfiguracionPerfil.textBoxContraseñaActual.Text;
            string contraseñaNueva = _frmConfiguracionPerfil.textBoxContraseñaNueva.Text;

            string path = Path.Combine(Application.StartupPath, "fotosPerfil");

            if (!string.IsNullOrEmpty(contraseñaActual) && !string.IsNullOrEmpty(contraseñaNueva))
            {
                if (cambioFoto == true)
                {
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }

                    string pathArchivoInicial = _frmConfiguracionPerfil.openFileDialogPfp.FileName;
                    string pathFinal = Path.Combine(path, SesionUsuario.Instancia.Matricula + Path.GetExtension(pathArchivoInicial));

                    File.Copy(pathArchivoInicial, pathFinal, true);

                    if (UsuarioDAO.ActualizarPerfil(contraseñaActual, contraseñaNueva, pathFinal))
                    {
                        MessageBox.Show("Foto y contraseña actualizada.");
                    }
                } else
                {
                    if (UsuarioDAO.ActualizarPerfil(contraseñaActual, contraseñaNueva, null))
                    {
                        MessageBox.Show("Contraseña actualizada.");
                    }
                }
            } else
            {
                if (cambioFoto == true)
                {
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }

                    string pathArchivoInicial = _frmConfiguracionPerfil.openFileDialogPfp.FileName;
                    string pathFinal = Path.Combine(path, SesionUsuario.Instancia.Matricula + Path.GetExtension(pathArchivoInicial));

                    File.Copy(pathArchivoInicial, pathFinal, true);

                    if (UsuarioDAO.ActualizarPerfil(null, null, _frmConfiguracionPerfil.openFileDialogPfp.FileName))
                    {
                        MessageBox.Show("Foto actualizada.");
                    }
                }
                else
                {
                    MessageBox.Show("No hay nada que actualizar.");
                }
            }
        }

        private void openFileDialogPfp_FileOk(object sender, EventArgs e)
        {
            if (File.Exists(_frmConfiguracionPerfil.openFileDialogPfp.FileName))
            {
                _frmConfiguracionPerfil.pictureBoxPfp.ImageLocation = _frmConfiguracionPerfil.openFileDialogPfp.FileName;

                cambioFoto = true;
            } else
            {
                cambioFoto = false;
            }
        }
    }
}
