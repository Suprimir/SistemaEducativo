using SistemaEducativo.DAO;
using SistemaEducativo.Models;
using SistemaEducativo.Views.Maestro;
using System.Diagnostics;
using System.Reflection;

namespace SistemaEducativo.Controllers.MaestroControllers
{
    internal class RevisionTareasController
    {
        private FrmRevisionTareas _frmRevisionTareas;
        private List<TareaPorAlumno> lstTareas;
        public Action actualizarTabla;

        public RevisionTareasController(FrmRevisionTareas frmRevisionTareas, Tarea tarea)
        {
            _frmRevisionTareas = frmRevisionTareas;

            lstTareas = TareaDAO.ObtenerTareasAlumno(tarea);

            actualizarTabla = () => { lstTareas = TareaDAO.ObtenerTareasAlumno(tarea); frmRevisionTareas_Load(null, null); };

            // Configuracion datagridview
            _frmRevisionTareas.dataGridViewTareas.Columns.Add("id", "id");
            _frmRevisionTareas.dataGridViewTareas.Columns["id"].Visible = false;
            _frmRevisionTareas.dataGridViewTareas.Columns.Add("nombre", "Nombre");
            _frmRevisionTareas.dataGridViewTareas.Columns.Add("fechaEntregada", "Fecha Entregada");
            _frmRevisionTareas.dataGridViewTareas.Columns.Add("calificacion", "Calificacion");

            _frmRevisionTareas.Load += frmRevisionTareas_Load;
            _frmRevisionTareas.btnVisualizarTarea.Click += btnVisualizarTarea_Click;
            _frmRevisionTareas.btnCalificarTarea.Click += btnCalificarTarea_Click;
        }

        private void frmRevisionTareas_Load(object sender, EventArgs e)
        {
            _frmRevisionTareas.dataGridViewTareas.Rows.Clear();

            foreach (var tarea in lstTareas)
            {
                _frmRevisionTareas.dataGridViewTareas.Rows.Add(tarea.ID, tarea.NombreAlumno, tarea.FechaEntregada, tarea.Calificacion);
            }
        }

        private void btnVisualizarTarea_Click(object sender, EventArgs e)
        {
            TareaPorAlumno tarea = lstTareas.FirstOrDefault(tarea => tarea.ID == Convert.ToInt32(_frmRevisionTareas.dataGridViewTareas.SelectedRows[0].Cells[0].Value));

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = tarea.PathArchivoTarea,
                    UseShellExecute = true
                });
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCalificarTarea_Click(object sender, EventArgs e)
        {
            TareaPorAlumno tarea = new TareaPorAlumno();

            if (_frmRevisionTareas.dataGridViewTareas.SelectedRows.Count > 0)
            {
                tarea = lstTareas.FirstOrDefault(tarea => tarea.ID == Convert.ToInt32(_frmRevisionTareas.dataGridViewTareas.SelectedRows[0].Cells[0].Value));
            }

            tarea.Calificacion = Convert.ToInt32(_frmRevisionTareas.textBoxCalificacion.Text);
            
            if (TareaDAO.CalificarTarea(tarea))
            {
                MessageBox.Show("Registro exitoso.");
                actualizarTabla?.Invoke();
            }
        }
    }
}
