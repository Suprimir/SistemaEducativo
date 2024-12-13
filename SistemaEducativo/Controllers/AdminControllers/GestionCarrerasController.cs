using SistemaEducativo.DAO;
using SistemaEducativo.Models;
using SistemaEducativo.Views.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEducativo.Controllers.AdminControllers
{
    internal class GestionCarrerasController
    {
        private FrmGestionCarreras _frmGestionCarreras;
        private List<Carrera> lstCarreras;
        private List<Carrera> lstCarrerasSeleccionadas = new List<Carrera>();
        public static Action actualizarTabla;
        private string filtroNombre = "";

        public GestionCarrerasController(FrmGestionCarreras frmGestionCarreras)
        {
            _frmGestionCarreras = frmGestionCarreras;

            lstCarreras = CarreraDAO.ObtenerCarreras();

            actualizarTabla = () => { lstCarreras = CarreraDAO.ObtenerCarreras(); frmGestionCarreras_Load(null, null); };

            _frmGestionCarreras.Load += frmGestionCarreras_Load;
            _frmGestionCarreras.textBoxFiltroNombre.TextChanged += textBoxFiltroNombre_TextChanged;

            _frmGestionCarreras.crearCarreraToolStripMenuItem.Click += btnCrearCarrera_Click;
            _frmGestionCarreras.eliminarCarreraToolStripMenuItem.Click += btnEliminarCarrera_Click;

            _frmGestionCarreras.dataGridViewGrupos.CellClick += dataGridViewGrupos_CellClick;
            _frmGestionCarreras.dataGridViewGrupos.CellContentClick += dataGridViewGrupos_CellContentClick;
        }

        private void frmGestionCarreras_Load(object sender, EventArgs e)
        {
            _frmGestionCarreras.dataGridViewGrupos.Rows.Clear();

            List<Carrera> lstCarrerasFiltro = lstCarreras.Where(c => c.NombreCarrera.Contains(filtroNombre, StringComparison.OrdinalIgnoreCase)).ToList();

            foreach(var carrera in lstCarrerasFiltro)
            {
                _frmGestionCarreras.dataGridViewGrupos.Rows.Add(carrera.Id, carrera.NombreCarrera, carrera.Descripcion, carrera.TotalSemestres);
            }
        }

        private void textBoxFiltroNombre_TextChanged(object sender, EventArgs e)
        {
            filtroNombre = _frmGestionCarreras.textBoxFiltroNombre.Text;

            frmGestionCarreras_Load(sender, e);
        }

        private void btnCrearCarrera_Click(object sender, EventArgs e)
        {
            FrmRegistroCarrera frmRegistroCarrera = new FrmRegistroCarrera(null);
            frmRegistroCarrera.ShowDialog();
        }

        private void btnEliminarCarrera_Click(object sender, EventArgs e)
        {
            if (lstCarrerasSeleccionadas.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Estas seguro que deseas eliminar una carrera? (Si elimnas una carrera eliminaras todo lo relacionado a esta)", "Eliminar Carrera", MessageBoxButtons.YesNo);
            
                if (dialogResult == DialogResult.Yes)
                {
                    foreach (var carrera in lstCarrerasSeleccionadas)
                    {
                        CarreraDAO.EliminarCarrera(carrera);
                    }

                    actualizarTabla?.Invoke();
                    MessageBox.Show("Eliminacion exitosa.");
                }
            } else
            {
                MessageBox.Show("Selecciona 1 o más carreras para realizar esta accion.");
            }
        }

        private void dataGridViewGrupos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && _frmGestionCarreras.dataGridViewGrupos.Columns[e.ColumnIndex].Name == "editar")
            {
                Carrera carreraSeleccionada = lstCarreras.First(g => g.Id == Convert.ToInt32(_frmGestionCarreras.dataGridViewGrupos.Rows[e.RowIndex].Cells[0].Value));

                FrmRegistroCarrera frmRegistroCarrera = new FrmRegistroCarrera(carreraSeleccionada);
                frmRegistroCarrera.ShowDialog();
            }
        }

        private void dataGridViewGrupos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && _frmGestionCarreras.dataGridViewGrupos.Columns[e.ColumnIndex].Name == "eliminar")
            {
                _frmGestionCarreras.dataGridViewGrupos.CommitEdit(DataGridViewDataErrorContexts.Commit);

                bool seleccion = Convert.ToBoolean(_frmGestionCarreras.dataGridViewGrupos.Rows[e.RowIndex].Cells["eliminar"].Value);

                Carrera carreraSeleccionada = lstCarreras.First(g => g.Id == Convert.ToInt32(_frmGestionCarreras.dataGridViewGrupos.Rows[e.RowIndex].Cells[0].Value));

                if (carreraSeleccionada != null)
                {
                    if (seleccion == true)
                    {
                        lstCarrerasSeleccionadas.Add(carreraSeleccionada);
                    }
                    else
                    {
                        lstCarrerasSeleccionadas.Remove(carreraSeleccionada);
                    }
                }
            }
        }
    }
}
