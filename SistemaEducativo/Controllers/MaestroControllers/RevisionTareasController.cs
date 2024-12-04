using SistemaEducativo.DAO;
using SistemaEducativo.Models;
using SistemaEducativo.Views.Maestro;

namespace SistemaEducativo.Controllers.MaestroControllers
{
    internal class RevisionTareasController
    {
        private FrmRevisionTareas _frmRevisionTareas;
        private List<TareaPorAlumno> lstTareas;
        public Action actualizarView;

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
            _frmRevisionTareas.btnCalificarTarea.Click += btnCalificarTarea_Click;
        }

        private void frmRevisionTareas_Load(object sender, EventArgs e)
        {
            foreach (var tarea in lstTareas)
            {
                _frmRevisionTareas.dataGridViewTareas.Rows.Add(tarea.ID, tarea.NombreAlumno, tarea.FechaEntregada, tarea.Calificacion);
            }
        }

        private void btnCalificarTarea_Click(object sender, EventArgs e)
        {
            TareaPorAlumno tarea = new TareaPorAlumno();

            tarea.Calificacion = Convert.ToInt32(_frmRevisionTareas.textBoxCalificacion.Text);
            
            if (TareaDAO.CalificarTarea(tarea))
            {
                MessageBox.Show("Registro exitoso.");
            }
        }
    }
}
