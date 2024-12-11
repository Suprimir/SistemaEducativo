using SistemaEducativo.DAO;
using SistemaEducativo.Models;
using SistemaEducativo.Views.Alumno;
using SistemaEducativo.Views.Maestro;

namespace SistemaEducativo.Controllers.AlumnoControllers
{
    internal class GestionTareasAlumnoController
    {
        private FrmGestionTareasAlumno _frmGestionTareasAlumno;
        private List<Tarea> lstTareas;

        public GestionTareasAlumnoController(FrmGestionTareasAlumno frmGestionTareasAlumno)
        {
            _frmGestionTareasAlumno = frmGestionTareasAlumno;

            lstTareas = TareaDAO.ObtenerTareas(new GrupoProfesor());

            _frmGestionTareasAlumno.Load += frmGestionTareasAlumno_Load;
        }

        private void frmGestionTareasAlumno_Load(object sender, EventArgs e)
        {
            if (_frmGestionTareasAlumno.flowLayoutPanelTareas.Controls.Count > 0)
            {
                _frmGestionTareasAlumno.flowLayoutPanelTareas.Controls.Clear();
            }

            for (int i = 1; i <= 3; i++)
            {
                Label lblParcialSeparador = new Label();
                lblParcialSeparador.Text = $"Parcial {i}";
                lblParcialSeparador.ForeColor = Color.White;

                Panel panelParcialSeparador = new Panel();
                panelParcialSeparador.Width = _frmGestionTareasAlumno.flowLayoutPanelTareas.ClientSize.Width - 10;
                panelParcialSeparador.Height = lblParcialSeparador.ClientSize.Height;
                panelParcialSeparador.BackColor = ColorTranslator.FromHtml("#333fa7");
                lblParcialSeparador.Location = new Point((panelParcialSeparador.Width - lblParcialSeparador.Width) / 2, (panelParcialSeparador.Height - lblParcialSeparador.Height) / 2);

                panelParcialSeparador.Controls.Add(lblParcialSeparador);

                _frmGestionTareasAlumno.flowLayoutPanelTareas.Controls.Add(panelParcialSeparador);

                foreach (var tarea in lstTareas.Where(tarea => tarea.Parcial == i))
                {
                    FrmTareaAlumno frmTareaAlumno = new FrmTareaAlumno(tarea);
                    frmTareaAlumno.TopLevel = false;
                    _frmGestionTareasAlumno.flowLayoutPanelTareas.Controls.Add(frmTareaAlumno);
                    frmTareaAlumno.Show();
                }
            }
        }

        private void btnVerTarea_Click(object sender, EventArgs e)
        {

        }
    }
}
