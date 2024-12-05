using SistemaEducativo.DAO;
using SistemaEducativo.Models;
using SistemaEducativo.Views.Alumno;
using SistemaEducativo.Views.Maestro;
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

            _frmGestionTareasAlumno.Load += frmGestionTareasAlumno_Load;
        }

        private void frmGestionTareasAlumno_Load(object sender, EventArgs e)
        {
            if (_frmGestionTareasAlumno.flowLayoutPanelTareas.Controls.Count > 0)
            {
                _frmGestionTareasAlumno.flowLayoutPanelTareas.Controls.RemoveAt(0);
            }

            foreach (var tarea in lstTareas)
            {
                FrmTareaAlumno frmTareaAlumno = new FrmTareaAlumno(tarea);
                frmTareaAlumno.TopLevel = false;
                _frmGestionTareasAlumno.flowLayoutPanelTareas.Controls.Add(frmTareaAlumno);
                frmTareaAlumno.Show();
            }
        }

        private void btnVerTarea_Click(object sender, EventArgs e)
        {

        }
    }
}
