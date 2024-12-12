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
        private string filtroNombre = "";

        public RevisionTareasController(FrmRevisionTareas frmRevisionTareas, GrupoProfesor grupo, Tarea tarea)
        {
            _frmRevisionTareas = frmRevisionTareas;

            lstTareas = TareaDAO.ObtenerTareasAlumno(grupo, tarea);

            actualizarTabla = () => { lstTareas = TareaDAO.ObtenerTareasAlumno(grupo, tarea); frmRevisionTareas_Load(null, null); };

            _frmRevisionTareas.Load += frmRevisionTareas_Load;
            _frmRevisionTareas.dataGridViewTareas.SelectionChanged += dataGridViewTareas_SelectionChanged;
            _frmRevisionTareas.textBoxFiltroNombre.TextChanged += textBoxFiltroNombre_TextChanged;
            _frmRevisionTareas.btnVisualizarTarea.Click += btnVisualizarTarea_Click;
            _frmRevisionTareas.btnCalificarTarea.Click += btnCalificarTarea_Click;
        }

        private void frmRevisionTareas_Load(object sender, EventArgs e)
        {
            _frmRevisionTareas.dataGridViewTareas.Rows.Clear();

            List<TareaPorAlumno> lstTareasFiltro = lstTareas.Where(t => t.NombreAlumno.Contains(filtroNombre, StringComparison.OrdinalIgnoreCase)).ToList();

            foreach (var tarea in lstTareasFiltro)
            {
                _frmRevisionTareas.dataGridViewTareas.Rows.Add(tarea.ID, tarea.NombreAlumno, tarea.Estado, tarea.FechaEntregada, tarea.Calificacion);
            }
        }

        private void dataGridViewTareas_SelectionChanged(object sender, EventArgs e)
        {
            if (_frmRevisionTareas.dataGridViewTareas.SelectedRows.Count > 0)
            {
                if (_frmRevisionTareas.dataGridViewTareas.SelectedRows[0].Cells[0].Value == null)
                {
                    _frmRevisionTareas.textBoxCalificacion.Enabled = false;
                    _frmRevisionTareas.btnVisualizarTarea.Enabled = false;
                    _frmRevisionTareas.btnCalificarTarea.Enabled = false;
                } else
                {
                    _frmRevisionTareas.textBoxCalificacion.Enabled = true;
                    _frmRevisionTareas.btnVisualizarTarea.Enabled = true;
                    _frmRevisionTareas.btnCalificarTarea.Enabled = true;
                }
            }
        }

        private void textBoxFiltroNombre_TextChanged(object sender, EventArgs e)
        {
            filtroNombre = _frmRevisionTareas.textBoxFiltroNombre.Text;
            frmRevisionTareas_Load(sender, e);
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
