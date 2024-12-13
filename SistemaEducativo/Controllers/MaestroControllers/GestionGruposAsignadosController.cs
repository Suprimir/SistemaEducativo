using SistemaEducativo.DAO;
using SistemaEducativo.Models;
using SistemaEducativo.Sesion;
using SistemaEducativo.Views.Maestro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEducativo.Controllers.MaestroControllers
{
    internal class GestionGruposAsignadosController
    {
        private FrmGestionGruposAsignados _frmGestionGruposAsignados;
        private List<GrupoProfesor> lstGrupos;

        public GestionGruposAsignadosController(FrmGestionGruposAsignados frmGestionGruposAsignados)
        {
            _frmGestionGruposAsignados = frmGestionGruposAsignados;

            // CARGO TODO LO NECESARIO EN EL LOAD DEL FORMULARIO
            _frmGestionGruposAsignados.Load += frmGestionGruposAsignados_Load;

            _frmGestionGruposAsignados.verAlumnosToolStripMenuItem.Click += btnVerAlumnos_Click;
            _frmGestionGruposAsignados.verTareasToolStripMenuItem.Click += btnVerTareas_Click;
        }

        // EL LOAD OBTIENE LA LISTA DE LOS GRUPOS Y LOS MUESTRA EN LA TABLA CONFIGURADA ANTERIORMENTE
        private void frmGestionGruposAsignados_Load(object sender, EventArgs e)
        {
            lstGrupos = GrupoDAO.ObtenerGruposAsignados(Convert.ToInt32(SesionUsuario.Instancia.Id));

            foreach (var grupo in lstGrupos)
            {
                _frmGestionGruposAsignados.dataGridViewGrupos.Rows.Add(grupo.Id, grupo.NombreGrupo, grupo.Materia, grupo.SemestreActual);
            }
        }

        private void btnVerAlumnos_Click(object sender, EventArgs e)
        {
            GrupoProfesor grupoSeleccionado = new GrupoProfesor();

            if (_frmGestionGruposAsignados.dataGridViewGrupos.SelectedRows.Count > 0)
            {
                grupoSeleccionado = lstGrupos.FirstOrDefault(grupo => grupo.NombreGrupo.Contains(_frmGestionGruposAsignados.dataGridViewGrupos.SelectedRows[0].Cells[0].Value.ToString()));

                FrmVistaAlumnos frmVistaAlumnos = new FrmVistaAlumnos(_frmGestionGruposAsignados, grupoSeleccionado);
                MenuMaestroController.actualizarSubmenu?.Invoke(frmVistaAlumnos);
            }
        }

        // CUANDO SE DA CLICK EN EL BOTON DE VER TAREAS ACTUALIZA EL SUBMENU PARA MOSTRAR LAS TAREAS DEL GRUPO SELECCIONADO
        private void btnVerTareas_Click(object sender, EventArgs e)
        {
            GrupoProfesor grupoSeleccionado = new GrupoProfesor();

            if (_frmGestionGruposAsignados.dataGridViewGrupos.SelectedRows.Count > 0)
            {
                grupoSeleccionado = lstGrupos.FirstOrDefault(grupo => grupo.NombreGrupo.Contains(_frmGestionGruposAsignados.dataGridViewGrupos.SelectedRows[0].Cells[0].Value.ToString()));
                
                FrmGestionTareas frmGestionTareas = new FrmGestionTareas(_frmGestionGruposAsignados, grupoSeleccionado);
                MenuMaestroController.actualizarSubmenu?.Invoke(frmGestionTareas);
            }
        }
    }
}
