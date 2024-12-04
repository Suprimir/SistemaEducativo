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

            lstTareas = TareaDAO.ObtenerTareasAlumno(tarea);

            // Configuracion datagridview
            _frmRevisionTareas.dataGridViewTareas.Columns.Add("id", "id");
            _frmRevisionTareas.dataGridViewTareas.Columns["id"].Visible = false;
            _frmRevisionTareas.dataGridViewTareas.Columns.Add("nombre", "Nombre");
            _frmRevisionTareas.dataGridViewTareas.Columns.Add("fechaEntregada", "Fecha Entregada");
            _frmRevisionTareas.dataGridViewTareas.Columns.Add("calificacion", "Calificacion");

            _frmRevisionTareas.Load += frmRevisionTareas_Load;
        }

        private void frmRevisionTareas_Load(object sender, EventArgs e)
        {
            foreach (var tarea in lstTareas)
            {
                _frmRevisionTareas.dataGridViewTareas.Rows.Add(tarea.ID, tarea.NombreAlumno, tarea.FechaEntregada, tarea.Calificacion);
            }
        }
    }
}
