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
    internal class GestionGruposAsignadosController
    {
        private FrmGestionGruposAsignados _frmGestionGruposAsignados;
        private List<GrupoProfesor> lstGrupos;

        public GestionGruposAsignadosController(FrmGestionGruposAsignados frmGestionGruposAsignados)
        {
            _frmGestionGruposAsignados = frmGestionGruposAsignados;

            // CONFIURO LA TABLA DE GRUPOS ASIGNADOS AL MAESTRO
            _frmGestionGruposAsignados.dataGridViewTareas.Columns.Add("grupo", "Grupo");
            _frmGestionGruposAsignados.dataGridViewTareas.Columns.Add("materia", "Materia");
            _frmGestionGruposAsignados.dataGridViewTareas.Columns.Add("semestre", "Semestre");
            
            // CARGO TODO LO NECESARIO EN EL LOAD DEL FORMULARIO
            _frmGestionGruposAsignados.Load += frmGestionGruposAsignados_Load;

            _frmGestionGruposAsignados.btnVerTareas.Click += btnVerTareas_Click;
        }

        // EL LOAD OBTIENE LA LISTA DE LOS GRUPOS Y LOS MUESTRA EN LA TABLA CONFIGURADA ANTERIORMENTE
        private void frmGestionGruposAsignados_Load(object sender, EventArgs e)
        {
            lstGrupos = GrupoDAO.ObtenerGruposAsignados(Convert.ToInt32(_frmGestionGruposAsignados.maestro.Id));

            foreach (var grupo in lstGrupos)
            {
                _frmGestionGruposAsignados.dataGridViewTareas.Rows.Add(grupo.NombreGrupo, grupo.Materia, grupo.SemestreActual);
            }
        }

        // CUANDO SE DA CLICK EN EL BOTON DE VER TAREAS ACTUALIZA EL SUBMENU PARA MOSTRAR LAS TAREAS DEL GRUPO SELECCIONADO
        private void btnVerTareas_Click(object sender, EventArgs e)
        {
            GrupoProfesor grupoSeleccionado = lstGrupos.FirstOrDefault(grupo => grupo.NombreGrupo.Contains(_frmGestionGruposAsignados.dataGridViewTareas.SelectedRows[0].Cells[0].Value.ToString())); ;

            if (_frmGestionGruposAsignados.dataGridViewTareas.SelectedRows.Count > 0)
            {
                
            }

            FrmGestionTareas frmGestionTareas = new FrmGestionTareas(grupoSeleccionado);
            MenuMaestroController.actualizarSubmenu?.Invoke(frmGestionTareas);
        }
    }
}
