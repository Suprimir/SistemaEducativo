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
    internal class TareaMaestroController
    {
        private FrmTareaMaestro _frmTareaMaestro;
        private FrmGestionTareas frmGestionTareas;
        private Tarea tareaSeleccionada;
        private GrupoProfesor grupoSeleccionado;

        public TareaMaestroController(FrmTareaMaestro frmTareaMaestro, FrmGestionTareas form, GrupoProfesor grupo, Tarea tarea)
        {
            _frmTareaMaestro = frmTareaMaestro;
            frmGestionTareas = form;
            grupoSeleccionado = grupo;
            tareaSeleccionada = tarea;

            _frmTareaMaestro.Load += frmTareaMaestro_Load;
            _frmTareaMaestro.btnRevisarTarea.Click += btnRevisarTarea_Click;
            _frmTareaMaestro.checkBoxSeleccionado.CheckedChanged += checkBoxSeleccionado_CheckedChanged;
        }

        private void frmTareaMaestro_Load(object sender, EventArgs e)
        {
            _frmTareaMaestro.lblTitulo.Text = tareaSeleccionada.Titulo;
            _frmTareaMaestro.lblParcial.Text = $"Parcial: {tareaSeleccionada.Parcial}";
        }

        private void btnRevisarTarea_Click(object sender, EventArgs e)
        {
            FrmRevisionTareas frmRevisionTareas = new FrmRevisionTareas(frmGestionTareas, grupoSeleccionado, tareaSeleccionada);
            MenuMaestroController.actualizarSubmenu(frmRevisionTareas);
        }

        private void checkBoxSeleccionado_CheckedChanged(object sender, EventArgs e)
        {
            if (_frmTareaMaestro.checkBoxSeleccionado.Checked)
            {
                GestionTareasController.lstTareasSeleccionadas.Add(tareaSeleccionada);
            } else
            {
                GestionTareasController.lstTareasSeleccionadas.Remove(tareaSeleccionada);
            }
        }
    }
}
