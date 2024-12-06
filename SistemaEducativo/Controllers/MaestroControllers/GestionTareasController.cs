using Org.BouncyCastle.Utilities.Encoders;
using SistemaEducativo.DAO;
using SistemaEducativo.Models;
using SistemaEducativo.Views.Alumno;
using SistemaEducativo.Views.Maestro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEducativo.Controllers.MaestroControllers
{
    public class GestionTareasController
    {
        private FrmGestionTareas _frmGestionTareas;
        public GrupoProfesor grupoSeleccionado;
        public static List<Tarea> lstTareasSeleccionadas = new List<Tarea>();
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
            _frmGestionTareas.editarTareaToolStripMenuItem.Click += btnEditarTarea_Click; // Crear Tarea Asignado a Boton
            _frmGestionTareas.eliminarTareaToolStripMenuItem.Click += btnEliminarTarea_Click;
        }

        private void frmGestionTareas_Load(object sender, EventArgs e)
        {
            if (_frmGestionTareas.flowLayoutPanelTareas.Controls.Count > 0)
            {
                _frmGestionTareas.flowLayoutPanelTareas.Controls.Clear();
            }

            for (int i = 1; i <= 3; i++)
            {
                Label lblParcialSeparador = new Label();
                lblParcialSeparador.Text = $"Parcial {i}";

                Panel panelParcialSeparador = new Panel();
                panelParcialSeparador.Width = _frmGestionTareas.flowLayoutPanelTareas.ClientSize.Width - 25;
                panelParcialSeparador.Height = lblParcialSeparador.ClientSize.Height;
                panelParcialSeparador.BackColor = ColorTranslator.FromHtml("#e4dcc9");
                lblParcialSeparador.Location = new Point((panelParcialSeparador.Width - lblParcialSeparador.Width) / 2, (panelParcialSeparador.Height - lblParcialSeparador.Height) / 2);

                panelParcialSeparador.Controls.Add(lblParcialSeparador);

                _frmGestionTareas.flowLayoutPanelTareas.Controls.Add(panelParcialSeparador);

                foreach (var tarea in lstTareas.Where(tarea => tarea.Parcial == i))
                {
                    FrmTareaMaestro frmTareaAlumno = new FrmTareaMaestro(tarea);
                    frmTareaAlumno.TopLevel = false;
                    _frmGestionTareas.flowLayoutPanelTareas.Controls.Add(frmTareaAlumno);
                    frmTareaAlumno.Show();
                }
            }
        }

        private void btnCrearTarea_Click(object sender, EventArgs e) // Funcion Crear Tarea
        {
            FrmRegistroTarea frmRegistroTarea = new FrmRegistroTarea(grupoSeleccionado, null);
            frmRegistroTarea.Show();
        }

        private void btnEditarTarea_Click(object sender, EventArgs e)
        {
            if (lstTareasSeleccionadas.Count == 1)
            {
                FrmRegistroTarea frmRegistroTarea = new FrmRegistroTarea(grupoSeleccionado, lstTareasSeleccionadas[0]);
                frmRegistroTarea.Show();
            } else
            {
                MessageBox.Show("Selecciona una sola tarea para editar.");
            }
        }

        private void btnEliminarTarea_Click(object sender, EventArgs e)
        {
            foreach (var tarea in lstTareasSeleccionadas)
            {
                TareaDAO.EliminarTarea(tarea);
            }

            MessageBox.Show("Registro exitoso.");
            actualizarTabla?.Invoke();

            lstTareasSeleccionadas.Clear();
        }
    }
}
