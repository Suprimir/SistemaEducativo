using SistemaEducativo.Controllers.AdminControllers;
using SistemaEducativo.Controllers.AlumnoControllers;
using SistemaEducativo.Controllers.MaestroControllers;
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
        private Form? frmAnterior;
        private List<Calificacion> lstCalificaciones;
        private List<Calificacion> lstCalificacionesFiltro = new List<Calificacion>();
        private Grupo grupo;
        private Carrera carrera;
        private Usuario usuarioSeleccionado;
        private string? nombreMateriaSeleccionada;
        private int semestreFiltro = 1;

        public VistaCalificacionesController(FrmVistaCalificaciones frmVistaCalificacionesAlumno, Form? form, Usuario usuario, string? nombreMateria)
        {
            _frmVistaCalificacionesAlumno = frmVistaCalificacionesAlumno;
            frmAnterior = form;

            usuarioSeleccionado = usuario;
            nombreMateriaSeleccionada = nombreMateria;

            if (nombreMateriaSeleccionada != null)
            {
                _frmVistaCalificacionesAlumno.lblSemestreStatic.Visible = false;
                _frmVistaCalificacionesAlumno.comboBoxSemestres.Visible = false;

                _frmVistaCalificacionesAlumno.checkBoxSemestral.Visible = false;
                _frmVistaCalificacionesAlumno.checkBoxFinales.Visible = false;
            }

            if (frmAnterior == null)
            {
                _frmVistaCalificacionesAlumno.btnRegresarForm.Visible = false;
            }

            lstCalificaciones = CalificacionDAO.ObtenerCalificacionesParciales(null, usuarioSeleccionado.Matricula, nombreMateriaSeleccionada);

            grupo = GrupoDAO.ObtenerGrupos().First(g => g.Id == usuario.GrupoId);
            carrera = CarreraDAO.ObtenerCarreras().First(carrera => carrera.NombreCarrera == grupo.Carrera);

            for (int i = 1; i <= carrera.TotalSemestres; i++)
            {
                _frmVistaCalificacionesAlumno.comboBoxSemestres.Items.Add(i);
            }

            _frmVistaCalificacionesAlumno.comboBoxSemestres.SelectedItem = 1;

            _frmVistaCalificacionesAlumno.btnRegresarForm.Click += btnRegresarForm_Click;

            _frmVistaCalificacionesAlumno.Load += frmVistaCalificacionesAlumno_Load;
            _frmVistaCalificacionesAlumno.checkBoxSemestral.CheckedChanged += checkBoxSemestral_CheckedChanged;
            _frmVistaCalificacionesAlumno.checkBoxFinales.CheckedChanged += checkBoxFinales_CheckedChanged;
            _frmVistaCalificacionesAlumno.comboBoxSemestres.SelectedIndexChanged += comboBoxSemestres_SelectedIndexChanged;
        }

        private void frmVistaCalificacionesAlumno_Load(object sender, EventArgs e)
        {
            _frmVistaCalificacionesAlumno.dataGridViewCalificaciones.Rows.Clear();

            if (_frmVistaCalificacionesAlumno.checkBoxFinales.Checked)
            {
                lstCalificacionesFiltro = lstCalificaciones;
            }
            else
            {
                lstCalificacionesFiltro = lstCalificaciones.Where(cal => cal.Semestre == semestreFiltro).ToList();
            }

            foreach (var calificacion in lstCalificacionesFiltro)
            {
                _frmVistaCalificacionesAlumno.dataGridViewCalificaciones.Rows.Add(calificacion.Semestre, calificacion.Materia, calificacion.Parcial, calificacion.CalificacionNumero);
            }
        }

        private void btnRegresarForm_Click(object sender, EventArgs e)
        {
            if (frmAnterior != null)
            {
                switch (SesionUsuario.Instancia.Rol)
                {
                    case "Alumno":
                        MenuAlumnoController.actualizarSubmenu(frmAnterior);
                        break;
                    case "Maestro":
                        MenuMaestroController.actualizarSubmenu(frmAnterior);
                        break;
                    case "Admin":
                        MenuAdminController.actualizarSubmenu(frmAnterior);
                        break;
                }
            } 
        }

        private void checkBoxSemestral_CheckedChanged(object sender, EventArgs e)
        {
            if(_frmVistaCalificacionesAlumno.checkBoxSemestral.Checked == true)
            {
                _frmVistaCalificacionesAlumno.checkBoxFinales.Enabled = false;

                lstCalificaciones = CalificacionDAO.ObtenerCalificacionesSemestral(semestreFiltro, usuarioSeleccionado.Matricula);
            
                _frmVistaCalificacionesAlumno.dataGridViewCalificaciones.Columns["parcial"].Visible = false;
            } else
            {
                _frmVistaCalificacionesAlumno.checkBoxFinales.Enabled = true;

                lstCalificaciones = CalificacionDAO.ObtenerCalificacionesParciales(null, usuarioSeleccionado.Matricula, nombreMateriaSeleccionada);

                _frmVistaCalificacionesAlumno.dataGridViewCalificaciones.Columns["parcial"].Visible = true;
            }

            frmVistaCalificacionesAlumno_Load(sender, e);
        }

        private void checkBoxFinales_CheckedChanged(object sender, EventArgs e)
        {
            if (_frmVistaCalificacionesAlumno.checkBoxFinales.Checked == true)
            {
                _frmVistaCalificacionesAlumno.checkBoxSemestral.Enabled = false;

                lstCalificaciones = CalificacionDAO.ObtenerCalificacionesFinales(usuarioSeleccionado.Matricula);

                _frmVistaCalificacionesAlumno.dataGridViewCalificaciones.Columns["parcial"].Visible = false;
                _frmVistaCalificacionesAlumno.dataGridViewCalificaciones.Columns["nombreMateria"].Visible = false;

                _frmVistaCalificacionesAlumno.comboBoxSemestres.Enabled = false;
            }
            else
            {
                _frmVistaCalificacionesAlumno.checkBoxSemestral.Enabled = true;

                lstCalificaciones = CalificacionDAO.ObtenerCalificacionesParciales(null, usuarioSeleccionado.Matricula, nombreMateriaSeleccionada);

                _frmVistaCalificacionesAlumno.dataGridViewCalificaciones.Columns["parcial"].Visible = true;
                _frmVistaCalificacionesAlumno.dataGridViewCalificaciones.Columns["nombreMateria"].Visible = true;

                _frmVistaCalificacionesAlumno.comboBoxSemestres.Enabled = true;
            }

            frmVistaCalificacionesAlumno_Load(sender, e);
        }

        private void comboBoxSemestres_SelectedIndexChanged(object sender, EventArgs e)
        { 
            semestreFiltro = Convert.ToInt32(_frmVistaCalificacionesAlumno.comboBoxSemestres.SelectedItem);

            frmVistaCalificacionesAlumno_Load(sender, e);
        }
    }
}
