using SistemaEducativo.Models;
using SistemaEducativo.Views.Alumno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEducativo.Controllers.AlumnoControllers
{
    internal class TareaAlumnoController
    {
        private FrmTareaAlumno _frmTareaAlumno;
        private FrmGestionTareasAlumno frmGestionTareasAlumno;
        private Tarea tareaSeleccionada;

        public TareaAlumnoController(FrmTareaAlumno frmTareaAlumno, FrmGestionTareasAlumno form, Tarea tarea)
        {
            _frmTareaAlumno = frmTareaAlumno;
            frmGestionTareasAlumno = form;
            tareaSeleccionada = tarea;

            _frmTareaAlumno.Load += frmTareaAlumno_Load;
            _frmTareaAlumno.btnVerTarea.Click += btnVerTarea_Click;
        }

        private void frmTareaAlumno_Load(object sender, EventArgs e)
        {
            _frmTareaAlumno.lblTitulo.Text = tareaSeleccionada.Titulo;
            _frmTareaAlumno.lblMateria.Text = tareaSeleccionada.MateriaNombre;
            _frmTareaAlumno.lblParcial.Text = $"Parcial: {tareaSeleccionada.Parcial}";
        }

        private void btnVerTarea_Click(object sender, EventArgs e)
        {
            FrmVerTarea frmVerTarea = new FrmVerTarea(frmGestionTareasAlumno, tareaSeleccionada);
            MenuAlumnoController.actualizarSubmenu(frmVerTarea);
        }
    }
}
