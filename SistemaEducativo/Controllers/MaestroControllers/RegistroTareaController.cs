using Org.BouncyCastle.Asn1.Crmf;
using SistemaEducativo.DAO;
using SistemaEducativo.Models;
using SistemaEducativo.Views.Admin;
using SistemaEducativo.Views.Maestro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEducativo.Controllers.MaestroControllers
{
    public class RegistroTareaController
    {
        private FrmRegistroTarea _frmRegistroTarea;
        private GrupoProfesor grupoSeleccionado;
        private Tarea tareaSeleccionada;

        public RegistroTareaController(FrmRegistroTarea frmRegistroTarea, GrupoProfesor grupo, Tarea tarea)
        {
            _frmRegistroTarea = frmRegistroTarea;

            grupoSeleccionado = grupo;
            tareaSeleccionada = tarea;

            if (tareaSeleccionada != null)
            {
                _frmRegistroTarea.Load += frmRegistroTarea_Load;
            }

            _frmRegistroTarea.btnRegistrarTarea.Click += btnRegistrarTarea_Click;
        }

        private void frmRegistroTarea_Load(object sender, EventArgs e)
        {
            _frmRegistroTarea.comboBoxParciales.Text = tareaSeleccionada.Parcial.ToString();
            _frmRegistroTarea.textBoxTitulo.Text = tareaSeleccionada.Titulo;
            _frmRegistroTarea.richTextBoxDescripcion.Text = tareaSeleccionada.Descripcion;
            _frmRegistroTarea.dateTimePickerFechaLimite.Value = tareaSeleccionada.Fecha_Limite;
        }

        private void btnRegistrarTarea_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_frmRegistroTarea.comboBoxParciales.Text) && !string.IsNullOrEmpty(_frmRegistroTarea.textBoxTitulo.Text) && !string.IsNullOrEmpty(_frmRegistroTarea.richTextBoxDescripcion.Text))
            {
                if (tareaSeleccionada != null)
                {
                    tareaSeleccionada.Titulo = _frmRegistroTarea.textBoxTitulo.Text;
                    tareaSeleccionada.Descripcion = _frmRegistroTarea.richTextBoxDescripcion.Text;
                    tareaSeleccionada.Fecha_Limite = _frmRegistroTarea.dateTimePickerFechaLimite.Value;

                    if (TareaDAO.CrearActualizarTarea(grupoSeleccionado, tareaSeleccionada))
                    {
                        MessageBox.Show("Registro exitoso");
                        GestionTareasController.actualizarTabla?.Invoke();
                        _frmRegistroTarea.Close();
                    }
                }
                else
                {
                    Tarea tarea = new Tarea();

                    tarea.Parcial = Convert.ToInt32(_frmRegistroTarea.comboBoxParciales.Text);
                    tarea.Titulo = _frmRegistroTarea.textBoxTitulo.Text;
                    tarea.Descripcion = _frmRegistroTarea.richTextBoxDescripcion.Text;
                    tarea.Fecha_Limite = _frmRegistroTarea.dateTimePickerFechaLimite.Value;

                    if (TareaDAO.CrearActualizarTarea(grupoSeleccionado, tarea))
                    {
                        MessageBox.Show("Registro exitoso");
                        GestionTareasController.actualizarTabla?.Invoke();
                        _frmRegistroTarea.Close();
                    }
                }
            } else
            {
                MessageBox.Show("Debes rellenar todos los campos.");
            }
        }
    }
}
