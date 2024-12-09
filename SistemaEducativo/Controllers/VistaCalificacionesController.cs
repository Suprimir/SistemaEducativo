using SistemaEducativo.DAO;
using SistemaEducativo.Models;
using SistemaEducativo.Sesion;
using SistemaEducativo.Views.Alumno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEducativo.Controllers
{
    internal class VistaCalificacionesController
    {
        private FrmVistaCalificaciones _frmVistaCalificacionesAlumno;
        private List<Calificacion> lstCalificaciones;
        private Grupo grupo;
        private Carrera carrera;
        private Usuario usuarioSeleccionado;
        private int semestreFiltro = 1;

        public VistaCalificacionesController(FrmVistaCalificaciones frmVistaCalificacionesAlumno, Usuario usuario, string? nombreMateria)
        {
            _frmVistaCalificacionesAlumno = frmVistaCalificacionesAlumno;

             usuarioSeleccionado = usuario;

            if (nombreMateria != null)
            {
                _frmVistaCalificacionesAlumno.lblSemestreStatic.Visible = false;
                _frmVistaCalificacionesAlumno.comboBoxSemestres.Visible = false;    
            }

            lstCalificaciones = CalificacionDAO.ObtenerCalificacionesParciales(null, usuarioSeleccionado.Matricula, nombreMateria);

            grupo = GrupoDAO.ObtenerGrupos().First(g => g.Id == usuario.GrupoId);
            carrera = CarreraDAO.ObtenerCarreras().First(carrera => carrera.NombreCarrera == grupo.Carrera);

            for (int i = 1; i <= carrera.TotalSemestres; i++)
            {
                _frmVistaCalificacionesAlumno.comboBoxSemestres.Items.Add(i);
            }

            _frmVistaCalificacionesAlumno.comboBoxSemestres.SelectedItem = 1;

            _frmVistaCalificacionesAlumno.Load += frmVistaCalificacionesAlumno_Load;
            _frmVistaCalificacionesAlumno.comboBoxSemestres.SelectedIndexChanged += comboBoxSemestres_SelectedIndexChanged;
        }

        private void frmVistaCalificacionesAlumno_Load(object sender, EventArgs e)
        {
            _frmVistaCalificacionesAlumno.dataGridViewCalificaciones.Rows.Clear();

            List<Calificacion> lstCalificacionesFiltro = lstCalificaciones.Where(cal => cal.Semestre == semestreFiltro).ToList();

            foreach (var calificacion in lstCalificacionesFiltro)
            {
                _frmVistaCalificacionesAlumno.dataGridViewCalificaciones.Rows.Add(calificacion.Materia, calificacion.Parcial, calificacion.CalificacionNumero);
            }
        }

        private void comboBoxSemestres_SelectedIndexChanged(object sender, EventArgs e)
        { 
            semestreFiltro = Convert.ToInt32(_frmVistaCalificacionesAlumno.comboBoxSemestres.SelectedItem);

            frmVistaCalificacionesAlumno_Load(sender, e);
        }
    }
}
