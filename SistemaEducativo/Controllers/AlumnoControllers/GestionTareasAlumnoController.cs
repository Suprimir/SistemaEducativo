using SistemaEducativo.DAO;
using SistemaEducativo.Models;
using SistemaEducativo.Sesion;
using SistemaEducativo.Views.Alumno;
using SistemaEducativo.Views.Maestro;

namespace SistemaEducativo.Controllers.AlumnoControllers
{
    internal class GestionTareasAlumnoController
    {
        private FrmGestionTareasAlumno _frmGestionTareasAlumno;
        private List<Tarea> lstTareas;
        private Carrera carrera;
        private int semestre = 1;

        public GestionTareasAlumnoController(FrmGestionTareasAlumno frmGestionTareasAlumno)
        {
            _frmGestionTareasAlumno = frmGestionTareasAlumno;

            lstTareas = TareaDAO.ObtenerTareas(new GrupoProfesor());
            carrera = CarreraDAO.ObtenerCarreras().First(carrera => carrera.NombreCarrera == SesionUsuario.Instancia.Carrera);
            _frmGestionTareasAlumno.comboBoxSemestres.Items.Clear();

            for (int i = 1; i <= carrera.TotalSemestres; i++)
            {
                _frmGestionTareasAlumno.comboBoxSemestres.Items.Add(i);
            }

            _frmGestionTareasAlumno.Load += frmGestionTareasAlumno_Load;
            _frmGestionTareasAlumno.comboBoxSemestres.SelectedIndexChanged += comboBoxSemestres_SelectedIndexChanged; 
        }

        private void frmGestionTareasAlumno_Load(object sender, EventArgs e)
        {
            if (_frmGestionTareasAlumno.flowLayoutPanelTareas.Controls.Count > 0)
            {
                _frmGestionTareasAlumno.flowLayoutPanelTareas.Controls.Clear();
            }

            for (int j = 1; j <= 3; j++)
            {
                Label lblParcialSeparador = new Label();
                lblParcialSeparador.Text = $"Parcial {j}";
                lblParcialSeparador.ForeColor = Color.White;

                Panel panelParcialSeparador = new Panel();
                panelParcialSeparador.Width = _frmGestionTareasAlumno.flowLayoutPanelTareas.ClientSize.Width - 10;
                panelParcialSeparador.Height = lblParcialSeparador.ClientSize.Height;
                panelParcialSeparador.BackColor = ColorTranslator.FromHtml("#333fa7");
                lblParcialSeparador.Location = new Point((panelParcialSeparador.Width - lblParcialSeparador.Width) / 2, (panelParcialSeparador.Height - lblParcialSeparador.Height) / 2);

                panelParcialSeparador.Controls.Add(lblParcialSeparador);

                _frmGestionTareasAlumno.flowLayoutPanelTareas.Controls.Add(panelParcialSeparador);

                foreach (var tarea in lstTareas.Where(tarea => tarea.Parcial == j && tarea.Semestre == semestre))
                {
                    FrmTareaAlumno frmTareaAlumno = new FrmTareaAlumno(tarea);
                    frmTareaAlumno.TopLevel = false;
                    _frmGestionTareasAlumno.flowLayoutPanelTareas.Controls.Add(frmTareaAlumno);
                    frmTareaAlumno.Show();
                }
            }
        }

        private void comboBoxSemestres_SelectedIndexChanged(object sender, EventArgs e)
        {
            semestre = (int)_frmGestionTareasAlumno.comboBoxSemestres.SelectedItem;
            frmGestionTareasAlumno_Load(sender, e);
        }
    }
}
