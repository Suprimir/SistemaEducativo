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
    internal class AsignarMateriaController
    {
        private FrmAsignarMateria _frmAsignarMateria;
        private List<Materia> lstMateriasSeleccionadas;
        private List<Carrera> lstCarreras;
        private int semestres;

        public AsignarMateriaController(FrmAsignarMateria frmAsignarMateria, List<Materia> lstMaterias)
        {
            _frmAsignarMateria = frmAsignarMateria;
            lstMateriasSeleccionadas = lstMaterias;

            lstCarreras = CarreraDAO.ObtenerCarreras();
            
            _frmAsignarMateria.Load += frmAsignarMateria_Load;
            _frmAsignarMateria.comboBoxCarreras.TextChanged += comboBoxCarreras_TextChanged;
            _frmAsignarMateria.btnAsignarMateria.Click += btnAsignarMateria_Click;
        }

        private void frmAsignarMateria_Load(object sender, EventArgs e)
        {
            _frmAsignarMateria.lblNombreMateria.Text = lstMateriasSeleccionadas.Count.ToString();

            foreach (var carrera in lstCarreras)
            {
                _frmAsignarMateria.comboBoxCarreras.Items.Add(carrera.NombreCarrera);
            }
        }

        private void comboBoxCarreras_TextChanged(object sender, EventArgs e)
        {
            _frmAsignarMateria.comboBoxSemestres.Items.Clear();

            Carrera carrera = lstCarreras.FirstOrDefault(carrera => carrera.NombreCarrera == _frmAsignarMateria.comboBoxCarreras.Text);

            for (int i = 1; i <= carrera.TotalSemestres; i++)
            {
                _frmAsignarMateria.comboBoxSemestres.Items.Add(i);
            }
        }
        
        private void btnAsignarMateria_Click(object sender, EventArgs e)
        {
            foreach (var materia in lstMateriasSeleccionadas)
            {
                materia.NombreCarrera = _frmAsignarMateria.comboBoxCarreras.Text;
                materia.Semestre = Convert.ToInt32(_frmAsignarMateria.comboBoxSemestres.Text);

                MateriaDAO.AsignarMateriaCarrera(materia);
            }
            MessageBox.Show("Registro exitoso.");

            _frmAsignarMateria.Close();
        }
    }
}
