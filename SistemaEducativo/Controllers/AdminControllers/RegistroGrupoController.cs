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

        public RegistroGrupoController(FrmRegistroGrupo frmRegistroGrupo)
        {
            _frmRegistroGrupo = frmRegistroGrupo;

            lstCarreras = CarreraDAO.ObtenerCarreras(); // LLAMA A LA BASE DE DATOS PARA OBTENER LAS CARRERAS

            if(_frmRegistroGrupo._grupoSeleccionado != null)
            {
                _frmRegistroGrupo.comboBoxCarreras.Text = _frmRegistroGrupo._grupoSeleccionado.Carrera;
                _frmRegistroGrupo.comboBoxCarreras.Enabled = false;
                _frmRegistroGrupo.textBoxNombreG.Text = _frmRegistroGrupo._grupoSeleccionado.NombreGrupo;
                _frmRegistroGrupo.dateTimePickerFechaInicio.Value = _frmRegistroGrupo._grupoSeleccionado.FechaInicio;
                _frmRegistroGrupo.dateTimePickerFechaInicio.Enabled = false;
            }

            _frmRegistroGrupo.Load += frmRegistroGrupo_Load;
            _frmRegistroGrupo.btnRegistrarGrupo.Click += btnRegistrarGrupo_Click;
        }

        private void frmRegistroGrupo_Load(object sender, EventArgs e)
        {
            foreach (var carrera in lstCarreras)
            {
                _frmRegistroGrupo.comboBoxCarreras.Items.Add(carrera.NombreCarrera);
            }
        }

        private void btnRegistrarGrupo_Click(object sender, EventArgs e)
        {
            if (_frmRegistroGrupo._grupoSeleccionado != null)
            {
                string nombreGeneracion = _frmRegistroGrupo.textBoxNombreG.Text;

                if (!string.IsNullOrEmpty(nombreGeneracion))
                {
                    if(GrupoDAO.EditarGrupo(nombreGeneracion, _frmRegistroGrupo._grupoSeleccionado.GrupoID))
                    {
                        GestionGruposController.cambioEnGrupos?.Invoke();
                        _frmRegistroGrupo.Dispose();
                    }
                }
            }
            else
            {
                int carreraID = lstCarreras.FirstOrDefault(carrera => carrera.NombreCarrera.Contains(_frmRegistroGrupo.comboBoxCarreras.Text)).CarreraID;
                string nombreGeneracion = _frmRegistroGrupo.textBoxNombreG.Text;
                DateTime fechaInicio = _frmRegistroGrupo.dateTimePickerFechaInicio.Value;

                if (!string.IsNullOrEmpty(_frmRegistroGrupo.comboBoxCarreras.Text) || !string.IsNullOrEmpty(nombreGeneracion))
                {
                    if (GrupoDAO.CrearGeneracion(carreraID, nombreGeneracion, fechaInicio))
                    {
                        GestionGruposController.cambioEnGrupos?.Invoke();
                        _frmRegistroGrupo.Dispose();
                    }
                }
            }
        }
    }
}
