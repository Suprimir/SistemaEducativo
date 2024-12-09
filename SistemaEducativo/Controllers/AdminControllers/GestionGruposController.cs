using SistemaEducativo.DAO;
using SistemaEducativo.Models;
using SistemaEducativo.Views.Admin;
using SistemaEducativo.Views.Maestro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEducativo.Controllers.AdminControllers
{
    internal class GestionGruposController
    {
        private FrmGestionGrupos _frmGestionGrupos;

        // LISTA DE LOS GRUPOS
        private List<Grupo> lstGrupos;
        private List<Grupo> lstGruposSeleccionados = new List<Grupo>();
        public static Action actualizarTabla;

        private string filtroNombre = "";

        public GestionGruposController(FrmGestionGrupos frmGestionGrupos)
        {
            _frmGestionGrupos = frmGestionGrupos;

            lstGrupos = GrupoDAO.ObtenerGrupos(); // Obtiene la lista de grupos de la base de datos.

            // Accion que ejecuta la actualizacion de la tabla de grupos
            actualizarTabla = () => { lstGrupos = GrupoDAO.ObtenerGrupos(); CargarDatosEnTabla(null, null); };

            _frmGestionGrupos.Load += CargarDatosEnTabla; 

            _frmGestionGrupos.textBoxFiltroNombre.TextChanged += textBoxFiltroNombre_TextChanged;

            // Funciones para los botones del gestion de grupos
            _frmGestionGrupos.crearGrupoToolStripMenuItem.Click += btnCrearGrupo_Click;
            _frmGestionGrupos.eliminarGrupoToolStripMenuItem.Click += btnEliminarGrupo_Click;
            _frmGestionGrupos.asignarMaestrosToolStripMenuItem.Click += btnAsignarMaestro_Click;
            _frmGestionGrupos.dataGridViewGrupos.CellClick += dataGridViewGrupos_CellClick;
            _frmGestionGrupos.dataGridViewGrupos.CellContentClick += dataGridViewGrupos_CellContentClick;
        }

        private void CargarDatosEnTabla(object sender, EventArgs e)
        {
            List<Grupo> lstGruposFiltro = lstGrupos.Where(grupo => grupo.NombreGrupo.Contains(filtroNombre, StringComparison.OrdinalIgnoreCase)).ToList();

            foreach (var grupo in lstGruposFiltro)
            {
                _frmGestionGrupos.dataGridViewGrupos.Rows.Add(grupo.Id, grupo.Carrera, grupo.NombreGrupo, grupo.SemestreActual, grupo.FechaInicio);
            }
        }

        // Se ejecuta cuando detecta un cambio en el textbox que se usa para filtrar los nombres de los grupos y recarga la tabla
        private void textBoxFiltroNombre_TextChanged(object sender, EventArgs e)
        {
            filtroNombre = _frmGestionGrupos.textBoxFiltroNombre.Text;

            CargarDatosEnTabla(sender, e);
        }

        // Abre formulario de registro de grupo 
        private void btnCrearGrupo_Click(object sender, EventArgs e)
        {
            FrmRegistroGrupo frmRegistroGrupo = new FrmRegistroGrupo(null);
            frmRegistroGrupo.Show();
        }

        // Pregunta si en verdad desea eliminar un grupo y si dice que si le pide a la base de datos eliminar ese registro.
        private void btnEliminarGrupo_Click(object sender, EventArgs e)
        {
            Grupo grupoSeleccionado = lstGrupos.FirstOrDefault(grupo => grupo.Id == Convert.ToInt32(_frmGestionGrupos.dataGridViewGrupos.SelectedRows[0].Cells[0].Value));

            DialogResult dialogResult = MessageBox.Show("¿Estas seguro de realizar esta accion? Borrara todo lo relacionado con el grupo seleccionado.", "Eliminar Grupo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                foreach (var grupo in lstGruposSeleccionados)
                {
                    GrupoDAO.EliminarGrupo(grupo);
                }

                actualizarTabla?.Invoke();
            }
        }

        // Abre el formulario para asignar maestros a los grupos y que materia impartira
        private void btnAsignarMaestro_Click(object sender, EventArgs e)
        {
            Grupo grupoSeleccionado = lstGrupos.FirstOrDefault(grupo => grupo.Id == Convert.ToInt32(_frmGestionGrupos.dataGridViewGrupos.SelectedRows[0].Cells[0].Value));

            FrmAsignarMaestro frmAsignarMaestro = new FrmAsignarMaestro(grupoSeleccionado);
            frmAsignarMaestro.Show();
        }

        private void dataGridViewGrupos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && _frmGestionGrupos.dataGridViewGrupos.Columns[e.ColumnIndex].Name == "editar")
            {
                Grupo grupoSeleccionado = lstGrupos.FirstOrDefault(g => g.Id == Convert.ToInt32(_frmGestionGrupos.dataGridViewGrupos.Rows[e.RowIndex].Cells[0].Value));

                FrmRegistroGrupo frmRegistroGrupo = new FrmRegistroGrupo(grupoSeleccionado);
                frmRegistroGrupo.Show();
            }
        }

        private void dataGridViewGrupos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && _frmGestionGrupos.dataGridViewGrupos.Columns[e.ColumnIndex].Name == "eliminar")
            {
                _frmGestionGrupos.dataGridViewGrupos.CommitEdit(DataGridViewDataErrorContexts.Commit);

                bool seleccion = Convert.ToBoolean(_frmGestionGrupos.dataGridViewGrupos.Rows[e.RowIndex].Cells["eliminar"].Value);

                Grupo grupoSeleccionado = lstGrupos.FirstOrDefault(g => g.Id == Convert.ToInt32(_frmGestionGrupos.dataGridViewGrupos.Rows[e.RowIndex].Cells[0].Value));

                if (grupoSeleccionado != null)
                {
                    if (seleccion == true)
                    {
                        lstGruposSeleccionados.Add(grupoSeleccionado);
                    }
                    else
                    {
                        lstGruposSeleccionados.Remove(grupoSeleccionado);
                    }
                }
            }
        }
    }
}
