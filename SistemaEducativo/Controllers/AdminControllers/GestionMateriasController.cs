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
    internal class GestionMateriasController
    {
        private FrmGestionMaterias _frmGestionMaterias;

        private List<Materia> lstMaterias;
        private List<Materia> lstMateriasSeleccionadas = new List<Materia>();
        private List<Carrera> lstCarreras;
        public static Action actualizarTabla; // ACCION A EJECUTAR EN LOS CAMBIOS DE MATERIAS

        // STRINGS QUE ALMACENAN EL FILTRO
        private string nombreMateria = "";
        private string nombreCarrera = null;

        public GestionMateriasController(FrmGestionMaterias frmGestionMaterias)
        {
            _frmGestionMaterias = frmGestionMaterias;

            // AL INICIAR OBTIENE UN LISTADO DE LAS MATERIAS PARA CARGARLAS EN LA TABLA
            lstMaterias = MateriaDAO.ObtenerMaterias(null, null);
            lstCarreras = CarreraDAO.ObtenerCarreras();

            // ACCION QUE SE EJECUTA CADA QUE SE REALIZA UN CAMBIO, OBTIENE LA LISTA DE MATERIAS Y RECARGA LA TABLA
            actualizarTabla = () => {
                lstMaterias = MateriaDAO.ObtenerMaterias(null, null); 
                frmGestionMaterias_Load(null, null); 
                _frmGestionMaterias.comboBoxFiltroCarrera.Text = ""; 
            };

            // AGREGA LAS CARRERAS AL FILTRO DE CARRERAS QUE TENGO CON UN COMBOBOX
            foreach (var carrera in lstCarreras)
            {
                _frmGestionMaterias.comboBoxFiltroCarrera.Items.Add(carrera.NombreCarrera);
            }

            // CARGA LA TABLA Y SE ACTUALIZA CADA QUE CAMBIA EL TEXTO DE CUALQUIERA DE LOS FILTROS
            _frmGestionMaterias.Load += frmGestionMaterias_Load;
            _frmGestionMaterias.textBoxFiltroMateria.TextChanged += textBoxFiltroMateria_TextChanged;
            _frmGestionMaterias.comboBoxFiltroCarrera.TextChanged += comboBoxFiltroCarrera_TextChanged;

            // EJECUTAN LAS FUNCIONES DE CREAR Y EDITAR MATERIA
            _frmGestionMaterias.crearMateriaToolStripMenuItem.Click += btnCrearMateria_Click;
            _frmGestionMaterias.eliminarMateriaToolStripMenuItem.Click += btnEliminarMateria_Click;
            _frmGestionMaterias.asignarMateriaToolStripMenuItem.Click += btnAsignarCarrera_Click;
            _frmGestionMaterias.desasignarMateriaToolStripMenuItem.Click += btnDesasignarCarrera_Click;

            _frmGestionMaterias.dataGridViewMaterias.CellClick += dataGridViewMaterias_CellClick;
            _frmGestionMaterias.dataGridViewMaterias.CellContentClick += dataGridViewMaterias_CellContentClick;
        }

        private void frmGestionMaterias_Load(object sender, EventArgs e)
        {
            lstMateriasSeleccionadas.Clear();

            if (nombreCarrera == null)
            {
                _frmGestionMaterias.dataGridViewMaterias.Columns["editar"].Visible = true;
                _frmGestionMaterias.asignarMateriaToolStripMenuItem.Enabled = true;
                _frmGestionMaterias.desasignarMateriaToolStripMenuItem.Enabled = false;
                _frmGestionMaterias.dataGridViewMaterias.Columns["semestre"].Visible = false;
            }
            // Limpia los datos de la tabla
            _frmGestionMaterias.dataGridViewMaterias.Rows.Clear();

            List<Materia> lstMateriasFiltro1 = lstMaterias.Where(materia => materia.NombreMateria.Contains(nombreMateria, StringComparison.OrdinalIgnoreCase)).ToList();

            foreach(var materia in lstMateriasFiltro1)
            {
                _frmGestionMaterias.dataGridViewMaterias.Rows.Add(materia.Id, materia.NombreMateria, materia.Descripcion, materia.Semestre);
            }
        }

        // Se ejecuta cuando detecta un cambio en el textbox que se usa para filtrar los nombres de las materias y recarga la tabla
        private void textBoxFiltroMateria_TextChanged(object sender, EventArgs e)
        {
            nombreMateria = _frmGestionMaterias.textBoxFiltroMateria.Text;

            frmGestionMaterias_Load(sender, e);
        }

        // Combo box con todas las carreras y cuando se selecciona alguna se aplica el filtro y recarga la tabla
        private void comboBoxFiltroCarrera_TextChanged(object sender, EventArgs e)
        {
            nombreCarrera = _frmGestionMaterias.comboBoxFiltroCarrera.Text;
            if (nombreCarrera == "") { nombreCarrera = null; }

            if (nombreCarrera != null)
            {
                _frmGestionMaterias.asignarMateriaToolStripMenuItem.Enabled = false;
                _frmGestionMaterias.desasignarMateriaToolStripMenuItem.Enabled = true;
                _frmGestionMaterias.eliminarMateriaToolStripMenuItem.Enabled = false;
                _frmGestionMaterias.dataGridViewMaterias.Columns["editar"].Visible = false;
                _frmGestionMaterias.dataGridViewMaterias.Columns["semestre"].Visible = true;
            } else
            {
                _frmGestionMaterias.eliminarMateriaToolStripMenuItem.Enabled = true;
                _frmGestionMaterias.dataGridViewMaterias.Columns["semestre"].Visible = false;
            }

            lstMaterias = MateriaDAO.ObtenerMaterias(nombreCarrera, null);
            frmGestionMaterias_Load(sender, e);
        }

        // abre el formulario de registro de materia
        private void btnCrearMateria_Click(object sender, EventArgs e)
        {
            FrmRegistroMateria frmRegistroMateria = new FrmRegistroMateria(null);
            frmRegistroMateria.Show();
        }

        // Funcion de eliminar materia
        private void btnEliminarMateria_Click(object sender, EventArgs e)
        {
            if (lstMateriasSeleccionadas.Count > 0) // checa que tengas un registro seleccionado
            {
                DialogResult dialogResult = MessageBox.Show("Estas seguro de eliminar esta materia?", "Eliminar Materia", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    foreach (var materia in lstMateriasSeleccionadas)
                    {
                        MateriaDAO.EliminarMateria(Convert.ToInt32(materia.Id));
                    }
                }

                actualizarTabla?.Invoke(); // invoca la accion que recarga la tabla
            }
            else
            {
                MessageBox.Show("Selecciona 1 o más materias.");
            }
        }

        // abre el formulario para asignar una materia a una carrera
        private void btnAsignarCarrera_Click(object sender, EventArgs e)
        {
            if (lstMateriasSeleccionadas.Count > 0)
            {
                FrmAsignarMateria frmAsignarMateria = new FrmAsignarMateria(lstMateriasSeleccionadas);
                frmAsignarMateria.Show();
            } else
            {
                MessageBox.Show("Selecciona 1 o más materias.");
            }
        }

        private void btnDesasignarCarrera_Click(object sender, EventArgs e)
        {
            if (lstMateriasSeleccionadas.Count > 0)
            {
                MessageBox.Show($"{lstMateriasSeleccionadas.Count}");
                Carrera carreraSeleccionada = lstCarreras.First(carrera => carrera.NombreCarrera == _frmGestionMaterias.comboBoxFiltroCarrera.Text);

                foreach (var materia in lstMateriasSeleccionadas)
                {
                    MateriaDAO.DesasignarMateriaCarrera(materia, carreraSeleccionada);
                }

                actualizarTabla?.Invoke(); // invoca la accion que recarga la tabla
            }
        }

        private void dataGridViewMaterias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && _frmGestionMaterias.dataGridViewMaterias.Columns[e.ColumnIndex].Name == "editar")
            {
                Materia materiaSeleccionada = lstMaterias.FirstOrDefault(g => g.Id == Convert.ToInt32(_frmGestionMaterias.dataGridViewMaterias.Rows[e.RowIndex].Cells[0].Value));

                FrmRegistroMateria frmRegistroMateria = new FrmRegistroMateria(materiaSeleccionada);
                frmRegistroMateria.Show();
            }
        }

        private void dataGridViewMaterias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && _frmGestionMaterias.dataGridViewMaterias.Columns[e.ColumnIndex].Name == "eliminar")
            {
                _frmGestionMaterias.dataGridViewMaterias.CommitEdit(DataGridViewDataErrorContexts.Commit);

                bool seleccion = Convert.ToBoolean(_frmGestionMaterias.dataGridViewMaterias.Rows[e.RowIndex].Cells["eliminar"].Value);

                Materia materiaSeleccionada = lstMaterias.FirstOrDefault(g => g.Id == Convert.ToInt32(_frmGestionMaterias.dataGridViewMaterias.Rows[e.RowIndex].Cells[0].Value));

                if (materiaSeleccionada != null)
                {
                    if (seleccion == true)
                    {
                        lstMateriasSeleccionadas.Add(materiaSeleccionada);
                    }
                    else
                    {
                        lstMateriasSeleccionadas.Remove(materiaSeleccionada);
                    }
                }
            }
        }
    }
}
