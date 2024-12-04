using SistemaEducativo.DAO;
using SistemaEducativo.Models;
using SistemaEducativo.Views.Maestro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEducativo.Controllers.MaestroControllers
{
    public class GestionTareasController
    {
        private FrmGestionTareas _frmGestionTareas;
        public GrupoProfesor grupoSeleccionado;
        private List<Tarea> lstTareas;
        public static Action actualizarTabla;

        public GestionTareasController(FrmGestionTareas frmGestionTareas, GrupoProfesor grupo)
        {
            _frmGestionTareas = frmGestionTareas;
            grupoSeleccionado = grupo;

            lstTareas = TareaDAO.ObtenerTareas(grupoSeleccionado);
            actualizarTabla = () => { lstTareas = TareaDAO.ObtenerTareas(grupoSeleccionado); frmGestionTareas_Load(null, null); };

            // CONFIGURACION TABLA
            _frmGestionTareas.dataGridViewTareas.Columns.Add("id", "ID");
            _frmGestionTareas.dataGridViewTareas.Columns[0].Visible = false; // Ocultamos la tabla id al usuarios normal
            _frmGestionTareas.dataGridViewTareas.Columns.Add("nivelParcial", "Parcial");
            _frmGestionTareas.dataGridViewTareas.Columns.Add("titulo", "Titulo");
            _frmGestionTareas.dataGridViewTareas.Columns.Add("descripcion", "Descripcion");
            _frmGestionTareas.dataGridViewTareas.Columns.Add("fechaLimite", "Fecha Limite");

            _frmGestionTareas.Load += frmGestionTareas_Load;
            _frmGestionTareas.btnCrearTarea.Click += btnCrearTarea_Click; // Crear Tarea Asignado a Boton
            _frmGestionTareas.btnEditarTarea.Click += btnEditarTarea_Clck; // Crear Tarea Asignado a Boton
            _frmGestionTareas.btnEliminarTarea.Click += btnEliminarTarea_Click;
            _frmGestionTareas.btnRevisarTareas.Click += btnRevisarTareas_Click;  
        }

        private void frmGestionTareas_Load(object sender, EventArgs e)
        {
            _frmGestionTareas.dataGridViewTareas.Rows.Clear();

            foreach (var tarea in lstTareas)
            {
                _frmGestionTareas.dataGridViewTareas.Rows.Add(tarea.ID, tarea.Parcial, tarea.Titulo, tarea.Descripcion, tarea.Fecha_Limite);
            }
        }

        private void btnCrearTarea_Click(object sender, EventArgs e) // Funcion Crear Tarea
        {
            FrmRegistroTarea frmRegistroTarea = new FrmRegistroTarea(grupoSeleccionado, null);
            frmRegistroTarea.Show();
        }

        private void btnEditarTarea_Clck(object sender, EventArgs e)
        {
            Tarea tareaSeleccionada = new Tarea();

            if (_frmGestionTareas.dataGridViewTareas.SelectedRows.Count > 0)
            {
                tareaSeleccionada = lstTareas.FirstOrDefault(tarea => tarea.ID == Convert.ToInt32(_frmGestionTareas.dataGridViewTareas.SelectedRows[0].Cells[0].Value));
            }

            FrmRegistroTarea frmRegistroTarea = new FrmRegistroTarea(grupoSeleccionado, tareaSeleccionada);
            frmRegistroTarea.Show();
        }

        private void btnEliminarTarea_Click(object sender, EventArgs e)
        {
            Tarea tareaSeleccionada = new Tarea();

            if (_frmGestionTareas.dataGridViewTareas.SelectedRows.Count > 0)
            {
                tareaSeleccionada = lstTareas.FirstOrDefault(tarea => tarea.ID == Convert.ToInt32(_frmGestionTareas.dataGridViewTareas.SelectedRows[0].Cells[0].Value));
                
                if (TareaDAO.EliminarTarea(tareaSeleccionada))
                {
                    MessageBox.Show("Registro exitoso.");
                    actualizarTabla?.Invoke();
                }
            }
        }

        private void btnRevisarTareas_Click(object sender, EventArgs e)
        {
            Tarea tareaSeleccionada = new Tarea();

            if (_frmGestionTareas.dataGridViewTareas.SelectedRows.Count > 0)
            {
                tareaSeleccionada = lstTareas.FirstOrDefault(tarea => tarea.ID == Convert.ToInt32(_frmGestionTareas.dataGridViewTareas.SelectedRows[0].Cells[0].Value));

                FrmRevisionTareas frmRevisionTareas = new FrmRevisionTareas(tareaSeleccionada);
                MenuMaestroController.actualizarSubmenu(frmRevisionTareas);
            }
        }
    }
}
