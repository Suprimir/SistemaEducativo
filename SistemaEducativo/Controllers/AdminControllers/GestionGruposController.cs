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
        private string filtroCarrera = "";

        public GestionGruposController(FrmGestionGrupos frmGestionGrupos)
        {
            _frmGestionGrupos = frmGestionGrupos;

            lstGrupos = GrupoDAO.ObtenerGrupos(); // Obtiene la lista de grupos de la base de datos.

            // Accion que ejecuta la actualizacion de la tabla de grupos
            actualizarTabla = () => ActualizarTablaAction();

            foreach (var grupo in lstGrupos)
            {
                if (!_frmGestionGrupos.comboBoxFiltroCarrera.Items.Contains(grupo.Carrera))
                {
                    _frmGestionGrupos.comboBoxFiltroCarrera.Items.Add(grupo.Carrera);
                }
            }

            _frmGestionGrupos.Load += frmGestionGrupos_Load;

            _frmGestionGrupos.textBoxFiltroNombre.TextChanged += textBoxFiltroNombre_TextChanged;
            _frmGestionGrupos.comboBoxFiltroCarrera.SelectedIndexChanged += comboBoxFiltroCarrera_SelectedIndexChanged;

            // Funciones para los botones del gestion de grupos
            _frmGestionGrupos.crearGrupoToolStripMenuItem.Click += btnCrearGrupo_Click;
            _frmGestionGrupos.eliminarGrupoToolStripMenuItem.Click += btnEliminarGrupo_Click;
            _frmGestionGrupos.asignarMaestrosToolStripMenuItem.Click += btnAsignarMaestro_Click;
            _frmGestionGrupos.dataGridViewGrupos.CellClick += dataGridViewGrupos_CellClick;
            _frmGestionGrupos.dataGridViewGrupos.CellContentClick += dataGridViewGrupos_CellContentClick;
        }

        private void ActualizarTablaAction()
        {
            lstGrupos = GrupoDAO.ObtenerGrupos();

            frmGestionGrupos_Load(null, null);

            _frmGestionGrupos.comboBoxFiltroCarrera.Items.Clear();
            _frmGestionGrupos.comboBoxFiltroCarrera.Items.Add("");

            foreach (var grupo in lstGrupos)
            {
                if (!_frmGestionGrupos.comboBoxFiltroCarrera.Items.Contains(grupo.Carrera))
                {
                    _frmGestionGrupos.comboBoxFiltroCarrera.Items.Add(grupo.Carrera);
                }
            }
        }

        private void frmGestionGrupos_Load(object sender, EventArgs e)
        {
            _frmGestionGrupos.dataGridViewGrupos.Rows.Clear();

            List<Grupo> lstGruposFiltro = lstGrupos.Where(g => g.NombreGrupo.Contains(filtroNombre, StringComparison.OrdinalIgnoreCase) && g.Carrera.Contains(filtroCarrera, StringComparison.OrdinalIgnoreCase)).ToList();

            foreach (var grupo in lstGruposFiltro)
            {
                _frmGestionGrupos.dataGridViewGrupos.Rows.Add(grupo.Id, grupo.Carrera, grupo.NombreGrupo, grupo.SemestreActual, grupo.FechaInicio);
            }
        }

        // Se ejecuta cuando detecta un cambio en el textbox que se usa para filtrar los nombres de los grupos y recarga la tabla
        private void textBoxFiltroNombre_TextChanged(object sender, EventArgs e)
        {
            filtroNombre = _frmGestionGrupos.textBoxFiltroNombre.Text;

            frmGestionGrupos_Load(sender, e);
        }

        private void comboBoxFiltroCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtroCarrera = _frmGestionGrupos.comboBoxFiltroCarrera.Text;

            frmGestionGrupos_Load(sender, e);
        }

        // Abre formulario de registro de grupo 
        private void btnCrearGrupo_Click(object sender, EventArgs e)
        {
            FrmRegistroGrupo frmRegistroGrupo = new FrmRegistroGrupo(null);
            frmRegistroGrupo.ShowDialog();
        }

        // Pregunta si en verdad desea eliminar un grupo y si dice que si le pide a la base de datos eliminar ese registro.
        private void btnEliminarGrupo_Click(object sender, EventArgs e)
        {
            if (lstGruposSeleccionados.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("¿Estas seguro de realizar esta accion? Borrara todo lo relacionado con el grupo seleccionado.", "Eliminar Grupo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    foreach (var grupo in lstGruposSeleccionados)
                    {
                        GrupoDAO.EliminarGrupo(grupo);
                    }

                    actualizarTabla?.Invoke();
                }
            } else
            {
                MessageBox.Show("Seleccione 1 o más grupos para esta accion.");
            }
        }

        // Abre el formulario para asignar maestros a los grupos y que materia impartira
        private void btnAsignarMaestro_Click(object sender, EventArgs e)
        {
            if (lstGruposSeleccionados.Count == 1)
            {
                FrmAsignarMaestro frmAsignarMaestro = new FrmAsignarMaestro(lstGruposSeleccionados[0]);
                frmAsignarMaestro.ShowDialog();
            } else
            {
                MessageBox.Show("Seleccione 1 solo grupo para esta accion.");
            }
        }

        private void dataGridViewGrupos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && _frmGestionGrupos.dataGridViewGrupos.Columns[e.ColumnIndex].Name == "editar")
            {
                Grupo grupoSeleccionado = lstGrupos.First(g => g.Id == Convert.ToInt32(_frmGestionGrupos.dataGridViewGrupos.Rows[e.RowIndex].Cells[0].Value));

                FrmRegistroGrupo frmRegistroGrupo = new FrmRegistroGrupo(grupoSeleccionado);
                frmRegistroGrupo.ShowDialog();
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
