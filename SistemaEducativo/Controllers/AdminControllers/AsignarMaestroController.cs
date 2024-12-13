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
    internal class AsignarMaestroController
    {
        private FrmAsignarMaestro _frmAsignarMaestro;
        private List<Usuario> lstMaestros;
        private List<Carrera> lstCarreras;
        private List<Materia> lstMateria;
        private Grupo grupoSeleccionado;
        private Carrera carrera;

        public AsignarMaestroController(FrmAsignarMaestro frmAsignarMaestro, Grupo grupo)
        {
            _frmAsignarMaestro = frmAsignarMaestro;
            grupoSeleccionado = grupo;

            lstMaestros = UsuarioDAO.ObtenerUsuarios("maestro");
            lstCarreras = CarreraDAO.ObtenerCarreras();

            _frmAsignarMaestro.Load += frmAsignarMaestro_Load;
            _frmAsignarMaestro.comboBoxSemestres.TextChanged += comboBoxSemestres_TextChanged;
            _frmAsignarMaestro.btnAsignarMaestro.Click += btnAsignarMaestro_Click;
        }

        private void frmAsignarMaestro_Load(object sender, EventArgs e)
        {
            _frmAsignarMaestro.lblGrupo.Text = grupoSeleccionado.NombreGrupo;
            _frmAsignarMaestro.lblCarrera.Text = grupoSeleccionado.Carrera;

            _frmAsignarMaestro.comboBoxMaterias.Enabled = false;

            carrera = lstCarreras.FirstOrDefault(carrera => carrera.NombreCarrera == grupoSeleccionado.Carrera);

            for (int i = 1; i <= carrera.TotalSemestres; i++)
            {
                _frmAsignarMaestro.comboBoxSemestres.Items.Add(i);
            }

            foreach (var maestro in lstMaestros)
            {
                _frmAsignarMaestro.comboBoxMaestros.Items.Add(maestro);
            }
        }

        private void comboBoxSemestres_TextChanged(object sender, EventArgs e)
        {
            _frmAsignarMaestro.comboBoxMaterias.Items.Clear();
            _frmAsignarMaestro.comboBoxMaterias.Enabled = true;

            lstMateria = MateriaDAO.ObtenerMaterias(carrera.NombreCarrera, Convert.ToInt32(_frmAsignarMaestro.comboBoxSemestres.Text));

            foreach (var materia in lstMateria)
            {
                _frmAsignarMaestro.comboBoxMaterias.Items.Add(materia);
            }
        }

        private void btnAsignarMaestro_Click(object sender, EventArgs e)
        {
            bool validarInputs = _frmAsignarMaestro.Controls.OfType<ComboBox>().All(cb => !string.IsNullOrEmpty(cb.Text));

            if (validarInputs)
            {
                if (GrupoDAO.AsignarMaestroGrupo(_frmAsignarMaestro.comboBoxMaestros.SelectedItem as Usuario, grupoSeleccionado, _frmAsignarMaestro.comboBoxMaterias.SelectedItem as Materia))
                {
                    MessageBox.Show("Registro exitoso.");

                    _frmAsignarMaestro.Close();
                }
            } else
            {
                MessageBox.Show("Debes rellenar todos los campos.");
            }
        }
    }
}
