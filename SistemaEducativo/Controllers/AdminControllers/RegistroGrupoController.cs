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

            if(grupoSeleccionado != null)
            {
                _frmRegistroGrupo.comboBoxCarreras.Text = grupoSeleccionado.Carrera;
                _frmRegistroGrupo.comboBoxCarreras.Enabled = false;
                _frmRegistroGrupo.textBoxNombreG.Text = grupoSeleccionado.NombreGrupo;
                _frmRegistroGrupo.dateTimePickerFechaInicio.Value = grupoSeleccionado.FechaInicio;
                _frmRegistroGrupo.dateTimePickerFechaInicio.Enabled = false;
                _frmRegistroGrupo.comboBoxSemestres.Text = grupoSeleccionado.SemestreActual.ToString();
                _frmRegistroGrupo.comboBoxSemestres.Enabled = false;
            }

            _frmRegistroGrupo.Load += frmRegistroGrupo_Load;
            _frmRegistroGrupo.comboBoxCarreras.TextChanged += comboBoxCarreras_TextChanged;
            _frmRegistroGrupo.btnRegistrarGrupo.Click += btnRegistrarGrupo_Click;
        }

        private void frmRegistroGrupo_Load(object sender, EventArgs e)
        {
            foreach (var carrera in lstCarreras)
            {
                _frmRegistroGrupo.comboBoxCarreras.Items.Add(carrera.NombreCarrera);
            }
        }

        private void comboBoxCarreras_TextChanged(object sender, EventArgs e)
        {
            _frmRegistroGrupo.comboBoxSemestres.Items.Clear();

            Carrera carrera = lstCarreras.FirstOrDefault(carrera => carrera.NombreCarrera == _frmRegistroGrupo.comboBoxCarreras.Text);

            for (int i = 1; i <= carrera.TotalSemestres; i++)
            {
                _frmRegistroGrupo.comboBoxSemestres.Items.Add(i);
            }
        }

        private void btnRegistrarGrupo_Click(object sender, EventArgs e)
        {
            Carrera carrera = lstCarreras.FirstOrDefault(carrera => carrera.NombreCarrera == _frmRegistroGrupo.comboBoxCarreras.Text);

            if (grupoSeleccionado != null)
            {
                if (!string.IsNullOrEmpty(_frmRegistroGrupo.textBoxNombreG.Text))
                {
                    grupoSeleccionado.NombreGrupo = _frmRegistroGrupo.textBoxNombreG.Text;

                    if (GrupoDAO.CrearActualizarGrupo(grupoSeleccionado, carrera))
                    {
                        GestionGruposController.actualizarTabla?.Invoke();
                        _frmRegistroGrupo.Dispose();
                    }
                }
            }
            else
            {
                Grupo grupo = new Grupo();
                grupo.NombreGrupo = _frmRegistroGrupo.textBoxNombreG.Text;
                grupo.FechaInicio = _frmRegistroGrupo.dateTimePickerFechaInicio.Value;
                grupo.SemestreActual = Convert.ToInt32(_frmRegistroGrupo.comboBoxSemestres.Text);

                if (!string.IsNullOrEmpty(_frmRegistroGrupo.comboBoxCarreras.Text) || !string.IsNullOrEmpty(_frmRegistroGrupo.comboBoxSemestres.Text))
                {
                    if (GrupoDAO.CrearActualizarGrupo(grupo, carrera))
                    {
                        GestionGruposController.actualizarTabla?.Invoke();
                        _frmRegistroGrupo.Dispose();
                    }
                }
            }
        }
    }
}
