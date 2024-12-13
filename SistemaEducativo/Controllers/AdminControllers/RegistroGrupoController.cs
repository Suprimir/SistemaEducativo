using SistemaEducativo.DAO;
using SistemaEducativo.Models;
using SistemaEducativo.Views.Admin;
using SistemaEducativo.Views.Maestro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEducativo.Controllers.AdminControllers
{
    internal class RegistroGrupoController
    {
        private FrmRegistroGrupo _frmRegistroGrupo;

        // LISTA DE CARRERAS
        private List<Carrera> lstCarreras;
        private Grupo grupoSeleccionado;

        public RegistroGrupoController(FrmRegistroGrupo frmRegistroGrupo, Grupo grupo)
        {
            _frmRegistroGrupo = frmRegistroGrupo;
            grupoSeleccionado = grupo;

            lstCarreras = CarreraDAO.ObtenerCarreras(); // LLAMA A LA BASE DE DATOS PARA OBTENER LAS CARRERAS

            _frmRegistroGrupo.Load += frmRegistroGrupo_Load;
            _frmRegistroGrupo.btnRegistrarGrupo.Click += btnRegistrarGrupo_Click;
        }

        private void frmRegistroGrupo_Load(object sender, EventArgs e)
        {
            foreach (var carrera in lstCarreras)
            {
                _frmRegistroGrupo.comboBoxCarreras.Items.Add(carrera.NombreCarrera);
            }

            if (grupoSeleccionado != null)
            {
                _frmRegistroGrupo.comboBoxCarreras.SelectedItem = grupoSeleccionado.Carrera;
                _frmRegistroGrupo.comboBoxCarreras.Enabled = false;
                _frmRegistroGrupo.textBoxNombreG.Text = grupoSeleccionado.NombreGrupo;
                _frmRegistroGrupo.dateTimePickerFechaInicio.Value = grupoSeleccionado.FechaInicio;
                _frmRegistroGrupo.dateTimePickerFechaInicio.Enabled = false;
            }
        }

        private void btnRegistrarGrupo_Click(object sender, EventArgs e)
        {
            bool validarInputs = _frmRegistroGrupo.Controls.OfType<TextBox>().All(tb => !string.IsNullOrEmpty(tb.Text));

            if (validarInputs)
            {
                Carrera carrera = lstCarreras.FirstOrDefault(carrera => carrera.NombreCarrera == _frmRegistroGrupo.comboBoxCarreras.Text);

                if (grupoSeleccionado != null)
                {
                    grupoSeleccionado.NombreGrupo = _frmRegistroGrupo.textBoxNombreG.Text;

                    if (GrupoDAO.CrearActualizarGrupo(grupoSeleccionado, carrera))
                    {
                        GestionGruposController.actualizarTabla?.Invoke();
                        _frmRegistroGrupo.Dispose();
                    }
                }
                else
                {
                    Grupo grupo = new Grupo();
                    grupo.NombreGrupo = _frmRegistroGrupo.textBoxNombreG.Text;
                    grupo.FechaInicio = _frmRegistroGrupo.dateTimePickerFechaInicio.Value;
                    grupo.SemestreActual = 1;


                    if (GrupoDAO.CrearActualizarGrupo(grupo, carrera))
                    {
                        GestionGruposController.actualizarTabla?.Invoke();
                        _frmRegistroGrupo.Dispose();
                    }
                }
            } else
            {
                MessageBox.Show("Debes rellenar todos los campos.");
            }
        }
    }
}
