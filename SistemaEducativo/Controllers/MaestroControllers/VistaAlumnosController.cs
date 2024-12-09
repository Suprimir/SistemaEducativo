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
    internal class VistaAlumnosController
    {
        private FrmVistaAlumnos _frmVistaAlumnos;
        private List<Usuario> lstAlumnos;
        private GrupoProfesor grupoSeleccionado;
        private Usuario usuarioSeleccionado;

        public VistaAlumnosController(FrmVistaAlumnos frmVistaAlumnos, GrupoProfesor grupo)
        {
            _frmVistaAlumnos = frmVistaAlumnos;

            grupoSeleccionado = grupo;

            lstAlumnos = UsuarioDAO.ObtenerAlumnos(grupoSeleccionado);

            _frmVistaAlumnos.Load += frmVistaAlumnos_Load;
            _frmVistaAlumnos.verCalificacionesToolStripMenuItem.Click += btnVerCalificaciones_Click;
        }

        private void frmVistaAlumnos_Load(object sender, EventArgs e)
        {
            foreach (var alumno in lstAlumnos)
            {
                _frmVistaAlumnos.dataGridViewAlumnos.Rows.Add(alumno.Id, alumno.Matricula, alumno.NombreCompleto);
            }
        }

        private void btnVerCalificaciones_Click(object sender, EventArgs e)
        {
            if (_frmVistaAlumnos.dataGridViewAlumnos.SelectedRows.Count > 0)
            {
                usuarioSeleccionado = lstAlumnos.FirstOrDefault(alumno => alumno.Id == Convert.ToInt32(_frmVistaAlumnos.dataGridViewAlumnos.SelectedRows[0].Cells[0].Value));

                FrmVistaCalificaciones frmVistaCalificaciones = new FrmVistaCalificaciones(usuarioSeleccionado, grupoSeleccionado.Materia);
                MenuMaestroController.actualizarSubmenu?.Invoke(frmVistaCalificaciones);
            }
        }
    }
}
