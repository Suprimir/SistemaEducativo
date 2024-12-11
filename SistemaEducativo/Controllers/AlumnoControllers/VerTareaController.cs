using SistemaEducativo.DAO;
using SistemaEducativo.Models;
using SistemaEducativo.Sesion;
using SistemaEducativo.Views.Alumno;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEducativo.Controllers.AlumnoControllers
{
    internal class VerTareaController
    {
        private FrmVerTarea _frmVerTarea;
        private Tarea tareaSeleccionada;
        public Action actualizarEstado;
        TareaPorAlumno tareaEntregada; // Por si ya esta entregada la tarea realizar ciertas validaciones

        public VerTareaController(FrmVerTarea frmVerTarea, Tarea tarea)
        {
            _frmVerTarea = frmVerTarea;
            tareaSeleccionada = tarea;

            tareaEntregada = TareaDAO.ValidarTareaAlumno(tarea);

            actualizarEstado = () => { tareaEntregada = TareaDAO.ValidarTareaAlumno(tarea); frmVerTarea_Load(null, null); };

            _frmVerTarea.Load += frmVerTarea_Load;
            _frmVerTarea.btnAdjuntarArchivo.Click += btnAdjuntarArchivo_Click;
            _frmVerTarea.btnSubirTarea.Click += btnSubirTarea_Click;
            _frmVerTarea.btnCancelarEntrega.Click += btnCancelarEntrega_Click;
            _frmVerTarea.btnVerArchivo.Click += btnVerArchivo_Click;
            _frmVerTarea.openFileDialogTarea.FileOk += openFileDialogTarea_FileOk;
        }

        private void frmVerTarea_Load(object sender, EventArgs e)
        {
            _frmVerTarea.lblTitulo.Text = tareaSeleccionada.Titulo;
            _frmVerTarea.richTextBoxDescripcion.Text = tareaSeleccionada.Descripcion;

            if (tareaEntregada != null)
            {
                _frmVerTarea.lblNombreArchivo.Visible = false;
                _frmVerTarea.btnVerArchivo.Visible = true;
                _frmVerTarea.btnAdjuntarArchivo.Enabled = false;
                _frmVerTarea.btnSubirTarea.Enabled = false;
                _frmVerTarea.btnCancelarEntrega.Enabled = true;

                _frmVerTarea.lblCalificacionStatic.Visible = true;
                _frmVerTarea.lblCalificacion.Text = tareaEntregada.Calificacion.ToString();
                _frmVerTarea.lblEstado.Text = tareaEntregada.Estado;
            }
            else
            {
                _frmVerTarea.lblNombreArchivo.Visible = true;
                _frmVerTarea.btnVerArchivo.Visible = false;
                _frmVerTarea.btnCancelarEntrega.Enabled = false;
                _frmVerTarea.btnSubirTarea.Enabled = false;
                _frmVerTarea.btnAdjuntarArchivo.Enabled = true;

                _frmVerTarea.lblCalificacionStatic.Visible = false;
                _frmVerTarea.lblCalificacion.Text = "";
                _frmVerTarea.lblEstado.Text = "Pendiente";
            }
        }

        private void btnAdjuntarArchivo_Click(object sender, EventArgs e)
        {
            _frmVerTarea.openFileDialogTarea.ShowDialog();
        }

        private void btnSubirTarea_Click(object sender, EventArgs e)
        {
            try
            {
                TareaPorAlumno tarea = new TareaPorAlumno();

                string pathTarea = Path.Combine(Application.StartupPath, "archivosTareas");
                string pathTareaID = Path.Combine(pathTarea, tareaSeleccionada.ID.ToString());

                if (!Directory.Exists(pathTarea))
                {
                    Directory.CreateDirectory(pathTarea);
                } 

                if (!Directory.Exists(pathTareaID))
                {
                    Directory.CreateDirectory(pathTareaID);
                }

                string pathArchivoInicial = _frmVerTarea.openFileDialogTarea.FileName;
                string pathArchivoFinal = Path.Combine(pathTareaID, SesionUsuario.Instancia.Matricula + Path.GetExtension(pathArchivoInicial));

                File.Copy(pathArchivoInicial, pathArchivoFinal, true);

                tarea.ID = tareaSeleccionada.ID;
                tarea.PathArchivoTarea = pathArchivoInicial;
                tarea.FechaEntregada = DateTime.Now;

                if (TareaDAO.EntregarTarea(tarea))
                {
                    MessageBox.Show("El archivo fue subido correctamente.");
                    actualizarEstado?.Invoke();
                }

            } catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un problema | ERROR {ex}");
            }
        }

        private void btnCancelarEntrega_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseas cancelar la entrega?", "Cancelar Entrega", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                if (TareaDAO.CancelarEntregaTarea(tareaEntregada))
                {
                    MessageBox.Show("Tarea Cancelada.");
                    actualizarEstado?.Invoke();
                }
            }
        }

        private void btnVerArchivo_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                UseShellExecute = true,
                FileName = tareaEntregada.PathArchivoTarea
            });
        }

        private void openFileDialogTarea_FileOk(object sender, EventArgs e)
        {
            _frmVerTarea.btnSubirTarea.Enabled = true;

            _frmVerTarea.lblNombreArchivo.Text = _frmVerTarea.openFileDialogTarea.SafeFileName;
        }
    }
}
