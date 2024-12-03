using SistemaEducativo.DAO;
using SistemaEducativo.Models;
using SistemaEducativo.Views.Maestro;

namespace SistemaEducativo.Controllers.MaestroControllers
{
    internal class RevisionTareasController
    {
        private FrmRevisionTareas _frmRevisionTareas;
        private List<TareaPorAlumno> lstTareas;

        public RevisionTareasController(FrmRevisionTareas frmRevisionTareas, Tarea tarea)
        {
            _frmRevisionTareas = frmRevisionTareas;

            lstTareas = TareaDAO.ObtenerTareasAlumnos(tarea);
        }
    }
}
