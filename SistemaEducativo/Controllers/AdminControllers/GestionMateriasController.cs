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
        private List<Carrera> lstCarreras;
        public static Action actualizarTabla; // ACCION A EJECUTAR EN LOS CAMBIOS DE MATERIAS

        // STRINGS QUE ALMACENAN EL FILTRO
        private string nombreMateria = "";
        private string nombreCarrera = null;

        public GestionMateriasController(FrmGestionMaterias frmGestionMaterias)
        {
            _frmGestionMaterias = frmGestionMaterias;

            // AL INICIAR OBTIENE UN LISTADO DE LAS MATERIAS PARA CARGARLAS EN LA TABLA
            lstMaterias = MateriaDAO.ObtenerMaterias(null);
            lstCarreras = CarreraDAO.ObtenerCarreras();

            // ACCION QUE SE EJECUTA CADA QUE SE REALIZA UN CAMBIO, OBTIENE LA LISTA DE MATERIAS Y RECARGA LA TABLA
            actualizarTabla = () => {
                lstMaterias = MateriaDAO.ObtenerMaterias(null); 
                frmGestionMaterias_Load(null, null); 
                _frmGestionMaterias.comboBoxFiltroCarrera.Text = ""; 
            };

            // AGREGA LAS CARRERAS AL FILTRO DE CARRERAS QUE TENGO CON UN COMBOBOX
            foreach (var carrera in lstCarreras)
            {
                _frmGestionMaterias.comboBoxFiltroCarrera.Items.Add(carrera.NombreCarrera);
            }

            // CONFIGURACION DE LA TABLA MOSTRADA
            _frmGestionMaterias.dataGridViewMaterias.Columns.Add("id", "ID");
            _frmGestionMaterias.dataGridViewMaterias.Columns.Add("nombreMateria", "Materia");
            _frmGestionMaterias.dataGridViewMaterias.Columns.Add("descripcion", "Descripcion");
            _frmGestionMaterias.dataGridViewMaterias.Columns.Add("semestre", "Semestre");

            // CARGA LA TABLA Y SE ACTUALIZA CADA QUE CAMBIA EL TEXTO DE CUALQUIERA DE LOS FILTROS
            _frmGestionMaterias.Load += frmGestionMaterias_Load;
            _frmGestionMaterias.textBoxFiltroMateria.TextChanged += textBoxFiltroMateria_TextChanged;
            _frmGestionMaterias.comboBoxFiltroCarrera.TextChanged += comboBoxFiltroCarrera_TextChanged;

            // EJECUTAN LAS FUNCIONES DE CREAR Y EDITAR MATERIA
            _frmGestionMaterias.btnCrearMateria.Click += btnCrearMateria_Click;
            _frmGestionMaterias.btnEditarMateria.Click += btnEditarMateria_Click;
            _frmGestionMaterias.btnEliminarMateria.Click += btnEliminarMateria_Click;
            _frmGestionMaterias.btnAsignarCarrera.Click += btnAsignarCarrera_Click;
            _frmGestionMaterias.btnDesasignarCarrera.Click += btnDesasignarCarrera_Click; 
        }

        private void frmGestionMaterias_Load(object sender, EventArgs e)
        {
            if (nombreCarrera == null)
            {
                _frmGestionMaterias.btnDesasignarCarrera.Enabled = false;
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
                _frmGestionMaterias.btnDesasignarCarrera.Enabled = true;
                _frmGestionMaterias.btnEliminarMateria.Enabled = false;
                _frmGestionMaterias.dataGridViewMaterias.Columns["semestre"].Visible = true;
            } else
            {
                _frmGestionMaterias.btnEliminarMateria.Enabled = true;
                _frmGestionMaterias.dataGridViewMaterias.Columns["semestre"].Visible = false;
            }

            lstMaterias = MateriaDAO.ObtenerMaterias(nombreCarrera);
            frmGestionMaterias_Load(sender, e);
        }

        // abre el formulario de registro de materia
        private void btnCrearMateria_Click(object sender, EventArgs e)
        {
            FrmRegistroMateria frmRegistroMateria = new FrmRegistroMateria(null);
            frmRegistroMateria.Show();
        }

        // abre el formulario de registro de materia con los datos de la materia a editar para actualizarla
        private void btnEditarMateria_Click(object sender, EventArgs e)
        {
            if (_frmGestionMaterias.dataGridViewMaterias.SelectedRows.Count > 0) // Esto checa que hayas seleccionado un registro
            {
                Materia materiaSeleccionada = lstMaterias.FirstOrDefault(materia => materia.Id == Convert.ToInt32(_frmGestionMaterias.dataGridViewMaterias.SelectedRows[0].Cells[0].Value));

                FrmRegistroMateria frmGestionMaterias = new FrmRegistroMateria(materiaSeleccionada);
                frmGestionMaterias.Show();
            }
        }

        // Funcion de eliminar materia
        private void btnEliminarMateria_Click(object sender, EventArgs e)
        {
            if (_frmGestionMaterias.dataGridViewMaterias.SelectedRows.Count > 0) // checa que tengas un registro seleccionado
            {
                int materiaID = Convert.ToInt32(_frmGestionMaterias.dataGridViewMaterias.SelectedRows[0].Cells[0].Value); // obtiene el id del registro

                if (MateriaDAO.EliminarMateria(materiaID)) // le dice a la base de datos que elimine el registro con el id que se le dio
                {
                    actualizarTabla?.Invoke(); // invoca la accion que recarga la tabla
                }
            }
        }

        // abre el formulario para asignar una materia a una carrera
        private void btnAsignarCarrera_Click(object sender, EventArgs e)
        {
            if (_frmGestionMaterias.dataGridViewMaterias.SelectedRows.Count > 0)
            {
                Materia materiaSeleccionada = lstMaterias.FirstOrDefault(materia => materia.Id == Convert.ToInt32(_frmGestionMaterias.dataGridViewMaterias.SelectedRows[0].Cells[0].Value));

                FrmAsignarMateria frmAsignarMateria = new FrmAsignarMateria(materiaSeleccionada);
                frmAsignarMateria.Show();
            }
        }

        private void btnDesasignarCarrera_Click(object sender, EventArgs e)
        {
            if (_frmGestionMaterias.dataGridViewMaterias.SelectedRows.Count > 0)
            {
                Materia materiaSeleccionada = lstMaterias.FirstOrDefault(materia => materia.Id == Convert.ToInt32(_frmGestionMaterias.dataGridViewMaterias.SelectedRows[0].Cells[0].Value));
                Carrera carreraSeleccionada = lstCarreras.FirstOrDefault(carrera => carrera.NombreCarrera == _frmGestionMaterias.comboBoxFiltroCarrera.Text);

                if (MateriaDAO.DesasignarMateriaCarrera(materiaSeleccionada, carreraSeleccionada))
                {
                    actualizarTabla?.Invoke(); // invoca la accion que recarga la tabla
                }
            }
        }
    }
}
