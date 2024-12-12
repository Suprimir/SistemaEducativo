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
    internal class RegistroCarreraController
    {
        private FrmRegistroCarrera _frmRegistroCarrera;
        private Carrera carreraSeleccionada;

        public RegistroCarreraController(FrmRegistroCarrera frmRegistroCarrera, Carrera carrera)
        {
            _frmRegistroCarrera = frmRegistroCarrera;
            carreraSeleccionada = carrera;

            _frmRegistroCarrera.Load += frmRegistroCarrera_Load;
            _frmRegistroCarrera.btnRegistrar.Click += btnRegistrar_Click;
        }

        private void frmRegistroCarrera_Load(object sender, EventArgs e)
        {
            if (carreraSeleccionada != null)
            {
                _frmRegistroCarrera.textBoxNombreCarrera.Text = carreraSeleccionada.NombreCarrera;
                _frmRegistroCarrera.richTextBoxDescripcion.Text = carreraSeleccionada.Descripcion;
                _frmRegistroCarrera.numericUpDownTotalSemestres.Value = carreraSeleccionada.TotalSemestres;
                _frmRegistroCarrera.numericUpDownTotalSemestres.Enabled = false;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_frmRegistroCarrera.textBoxNombreCarrera.Text) && !string.IsNullOrEmpty(_frmRegistroCarrera.richTextBoxDescripcion.Text) && _frmRegistroCarrera.numericUpDownTotalSemestres.Value > 0)
            {
                if (carreraSeleccionada != null)
                {
                    carreraSeleccionada.NombreCarrera = _frmRegistroCarrera.textBoxNombreCarrera.Text;
                    carreraSeleccionada.Descripcion = _frmRegistroCarrera.richTextBoxDescripcion.Text;

                    if (CarreraDAO.CrearActualizarCarrera(carreraSeleccionada))
                    {
                        MessageBox.Show("Actualizacion exitosa.");
                        GestionCarrerasController.actualizarTabla?.Invoke();
                        _frmRegistroCarrera.Close();
                    }
                } else
                {
                    Carrera carrera = new Carrera();

                    carrera.Id = null;
                    carrera.NombreCarrera = _frmRegistroCarrera.textBoxNombreCarrera.Text;
                    carrera.Descripcion = _frmRegistroCarrera.richTextBoxDescripcion.Text;
                    carrera.TotalSemestres = Convert.ToInt32(_frmRegistroCarrera.numericUpDownTotalSemestres.Value);

                    if (CarreraDAO.CrearActualizarCarrera(carrera))
                    {
                        MessageBox.Show("Registro exitoso.");
                        GestionCarrerasController.actualizarTabla?.Invoke();
                        _frmRegistroCarrera.Close();
                    }
                }
            }
        }
    }
}
