using SistemaEducativo.DAO;
using SistemaEducativo.Models;
using SistemaEducativo.Views.Alumno;
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

            _frmGestionTareas.Load += frmGestionTareas_Load;
            _frmGestionTareas.crearTareaToolStripMenuItem.Click += btnCrearTarea_Click; // Crear Tarea Asignado a Boton
            _frmGestionTareas.editarTareaToolStripMenuItem.Click += btnEditarTarea_Clck; // Crear Tarea Asignado a Boton
            _frmGestionTareas.eliminarTareaToolStripMenuItem.Click += btnEliminarTarea_Click;
        }

        private void frmGestionTareas_Load(object sender, EventArgs e)
        {

            foreach (var tarea in lstTareas)
            {
                FrmTareaAlumno frmTareaAlumno = new FrmTareaAlumno(tarea);
                frmTareaAlumno.TopLevel = false;
                _frmGestionTareas.flowLayoutPanelTareas.Controls.Add(frmTareaAlumno);
                frmTareaAlumno.Show();
            }

            MessageBox.Show(_frmGestionTareas.flowLayoutPanelTareas.Controls.Count.ToString());
        }

        private void btnCrearTarea_Click(object sender, EventArgs e) // Funcion Crear Tarea
        {
            FrmRegistroTarea frmRegistroTarea = new FrmRegistroTarea(grupoSeleccionado, null);
            frmRegistroTarea.Show();
        }

        private void btnEditarTarea_Clck(object sender, EventArgs e)
        {
        }

        private void btnEliminarTarea_Click(object sender, EventArgs e)
        {
            if (TareaDAO.EliminarTarea(null))
            {
                MessageBox.Show("Registro exitoso.");
                actualizarTabla?.Invoke();
            }
        }

        private void btnRevisarTareas_Click(object sender, EventArgs e)
        {

        }
    }
}
