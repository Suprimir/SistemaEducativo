using SistemaEducativo.DAO;
using SistemaEducativo.Models;
using SistemaEducativo.Views.Alumno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEducativo.Controllers.AlumnoControllers
{
    internal class GestionTareasAlumnoController
    {
        private FrmGestionTareasAlumno _frmGestionTareasAlumno;
        private List<Tarea> lstTareas;

        public GestionTareasAlumnoController(FrmGestionTareasAlumno frmGestionTareasAlumno)
        {
            _frmGestionTareasAlumno = frmGestionTareasAlumno;

            lstTareas = TareaDAO.ObtenerTareas(new GrupoProfesor());

            // CONFIGURACION DATA GRID VIEW
            _frmGestionTareasAlumno.dataGridViewTareas.Columns.Add("id", "id");
            _frmGestionTareasAlumno.dataGridViewTareas.Columns["id"].Visible = false;
            _frmGestionTareasAlumno.dataGridViewTareas.Columns.Add("parcial", "Parcial");
            _frmGestionTareasAlumno.dataGridViewTareas.Columns.Add("titulo", "Titulo");
            _frmGestionTareasAlumno.dataGridViewTareas.Columns.Add("descripcion", "Descripcion");
            _frmGestionTareasAlumno.dataGridViewTareas.Columns.Add("fechaLimite", "Fecha Limite");

            _frmGestionTareasAlumno.Load += frmGestionTareasAlumno_Load;
            _frmGestionTareasAlumno.btnVerTarea.Click += btnVerTarea_Click;
        }

        private void frmGestionTareasAlumno_Load(object sender, EventArgs e)
        {
            foreach (var tarea in lstTareas)
            {
                _frmGestionTareasAlumno.dataGridViewTareas.Rows.Add(tarea.ID, tarea.Parcial, tarea.Titulo, tarea.Descripcion, tarea.Fecha_Limite);
            }
        }

        private void btnVerTarea_Click(object sender, EventArgs e)
        {
            Tarea tarea = new Tarea();

            if (_frmGestionTareasAlumno.dataGridViewTareas.SelectedRows.Count > 0)
            {
                tarea = lstTareas.FirstOrDefault(tarea => tarea.ID == Convert.ToInt32(_frmGestionTareasAlumno.dataGridViewTareas.SelectedRows[0].Cells[0].Value));
            }

            FrmVerTarea frmVerTarea = new FrmVerTarea(tarea);
            MenuAlumnoController.actualizarSubmenu(frmVerTarea);
        }
    }
}
