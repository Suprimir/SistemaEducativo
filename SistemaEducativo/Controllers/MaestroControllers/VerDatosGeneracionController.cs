using SistemaEducativo.DAO;
using SistemaEducativo.Models;
using SistemaEducativo.Views.Maestro;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEducativo.Controllers.MaestroControllers
{
    internal class VerDatosGeneracionController
    {
        private FrmVerDatosGeneracion _frmVerDatosGeneracion;

        int semestreSeleccionado;
        int parcialSeleccionado;
        int materiaSeleccionada;

        private List<Usuario> lstUsuarios;

        private List<Semestre> lstSemestre;
        private List<Parcial> lstParciales;
        private List<Materia> lstMaterias;

        public VerDatosGeneracionController(FrmVerDatosGeneracion frmVerDatosGeneracion)
        {
            _frmVerDatosGeneracion = frmVerDatosGeneracion;

            _frmVerDatosGeneracion.Load += frmVerDatosGeneracion_Load;

            _frmVerDatosGeneracion.comboBoxSemestres.TextChanged += comboBoxSemestres_TextChanged;
            _frmVerDatosGeneracion.comboBoxParciales.TextChanged += comboBoxParciales_TextChanged;
            _frmVerDatosGeneracion.comboBoxMaterias.TextChanged += comboBoxMaterias_TextChanged;

            _frmVerDatosGeneracion.btnVerCalificaciones.Click += btnVerCalificaciones_Click;
        }

        private void frmVerDatosGeneracion_Load(object sender, EventArgs e)
        {
            lstSemestre = SemestreDAO.ObtenerSemestres(_frmVerDatosGeneracion.generacion.GeneracionID);

            lstUsuarios = UsuarioDAO.ObtenerAlumnosPorGeneracion(_frmVerDatosGeneracion.generacion.GeneracionID);
            
            _frmVerDatosGeneracion.dataGridViewAlumnos.DataSource = lstUsuarios;

            foreach(Semestre semestre in lstSemestre)
            {
                _frmVerDatosGeneracion.comboBoxSemestres.Items.Add(semestre.NivelSemestral);
            }
        }

        private void comboBoxSemestres_TextChanged(object sender, EventArgs e)
        {
            semestreSeleccionado = int.Parse(_frmVerDatosGeneracion.comboBoxSemestres.Text);

            // Parciales

            _frmVerDatosGeneracion.comboBoxParciales.Items.Clear();
            Semestre semestre = lstSemestre.FirstOrDefault(s => s.NivelSemestral == semestreSeleccionado);

            lstParciales = ParcialDAO.ObtenerParcialesPorSemestre(semestre.SemestreId);

            foreach(Parcial parcial in lstParciales)
            {
                _frmVerDatosGeneracion.comboBoxParciales.Items.Add(parcial.NivelParcial);
            }

            // Materias

            _frmVerDatosGeneracion.comboBoxMaterias.Items.Clear();

            lstMaterias = MateriaDAO.ObtenerMateriasPorSemestre(_frmVerDatosGeneracion.generacion.CarreraID, semestreSeleccionado);

            foreach (Materia materia in lstMaterias)
            {
                _frmVerDatosGeneracion.comboBoxMaterias.Items.Add(materia.NombreMateria);
            }
        }

        private void comboBoxParciales_TextChanged(object sender, EventArgs e)
        {
            parcialSeleccionado = int.Parse(_frmVerDatosGeneracion.comboBoxParciales.Text);
        }

        private void comboBoxMaterias_TextChanged(object sender, EventArgs e)
        {
            materiaSeleccionada = lstMaterias.FirstOrDefault(m => m.NombreMateria.Contains(_frmVerDatosGeneracion.comboBoxMaterias.Text)).MateriaId;
        }

        private void btnVerCalificaciones_Click(object sender, EventArgs e)
        {
            List<CalificacionAlumno> lstCalificaciones = CalificacionDAO.ObtenerCalificacionesPorParcial(materiaSeleccionada, parcialSeleccionado);
            
            _frmVerDatosGeneracion.dataGridViewAlumnos.DataSource = null;
            _frmVerDatosGeneracion.dataGridViewAlumnos.Columns.Clear();
            _frmVerDatosGeneracion.dataGridViewAlumnos.Rows.Clear();

            _frmVerDatosGeneracion.dataGridViewAlumnos.Columns.Add("Matricula", "Matricula");
            _frmVerDatosGeneracion.dataGridViewAlumnos.Columns.Add("NombreCompleto", "Nombre Completo");
            _frmVerDatosGeneracion.dataGridViewAlumnos.Columns.Add("Calificacion", "Calificacion");

            foreach (var calificacion in lstCalificaciones)
            {
                _frmVerDatosGeneracion.dataGridViewAlumnos.Rows.Add(calificacion.Matricula, calificacion.NombreCompleto, calificacion.CalificacionValor);
            }
        }
    }
}
