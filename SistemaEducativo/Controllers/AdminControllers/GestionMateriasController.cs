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
        public static Action cambioEnMaterias; // ACCION A EJECUTAR EN LOS CAMBIOS DE MATERIAS

        // STRINGS QUE ALMACENAN EL FILTRO
        private string nombreMateria = "";
        private string nombreCarrera = "";

        public GestionMateriasController(FrmGestionMaterias frmGestionMaterias)
        {
            _frmGestionMaterias = frmGestionMaterias;

            // AL INICIAR OBTIENE UN LISTADO DE LAS MATERIAS PARA CARGARLAS EN LA TABLA
            lstMaterias = MateriaDAO.ObtenerMaterias();

            // ACCION QUE SE EJECUTA CADA QUE SE REALIZA UN CAMBIO, OBTIENE LA LISTA DE MATERIAS Y RECARGA LA TABLA
            cambioEnMaterias = () => { lstMaterias = MateriaDAO.ObtenerMaterias(); CargarDatosEnTabla(null, null); };

            _frmGestionMaterias.comboBoxFiltroCarrera.Items.Add(""); // Para la opcion de nada
            _frmGestionMaterias.comboBoxFiltroCarrera.Items.Add("No Asignada"); // Para la opcion de mostrar materias sin carrera asignada

            // AGREGA LAS CARRERAS DE LAS MATERIAS DISPONIBLES AL COMBOBOX DE FILTRO POR CARRERA
            /*foreach (var materia in lstMaterias)
            {
                if(!_frmGestionMaterias.comboBoxFiltroCarrera.Items.Contains(materia.NombreCarrera) && materia.NombreCarrera != "No Asignada")
                {
                    _frmGestionMaterias.comboBoxFiltroCarrera.Items.Add(materia.NombreCarrera);
                }
            }*/

            // CONFIGURACION DE LA TABLA MOSTRADA
            _frmGestionMaterias.dataGridViewMaterias.Columns.Add("id", "ID");
            _frmGestionMaterias.dataGridViewMaterias.Columns.Add("nombreMateria", "Materia");
            _frmGestionMaterias.dataGridViewMaterias.Columns.Add("descripcion", "Descripcion");

            // CARGA LA TABLA Y SE ACTUALIZA CADA QUE CAMBIA EL TEXTO DE CUALQUIERA DE LOS FILTROS
            _frmGestionMaterias.Load += CargarDatosEnTabla;
            _frmGestionMaterias.textBoxFiltroMateria.TextChanged += textBoxFiltroMateria_TextChanged;
            _frmGestionMaterias.comboBoxFiltroCarrera.TextChanged += comboBoxFiltroCarrera_TextChanged;

            // EJECUTAN LAS FUNCIONES DE CREAR Y EDITAR MATERIA
            _frmGestionMaterias.btnCrearMateria.Click += btnCrearMateria_Click;
            _frmGestionMaterias.btnEditarMateria.Click += btnEditarMateria_Click;
            _frmGestionMaterias.btnEliminarMateria.Click += btnEliminarMateria_Click;
            _frmGestionMaterias.btnAsignarCarrera.Click += btnAsignarCarrera_Click;
        }

        private void CargarDatosEnTabla(object sender, EventArgs e)
        {
            // Limpia los datos de la tabla
            _frmGestionMaterias.dataGridViewMaterias.Rows.Clear();

            List<Materia> lstMateriasFiltro1 = lstMaterias.Where(materia => materia.NombreMateria.Contains(nombreMateria, StringComparison.OrdinalIgnoreCase)).ToList();
            //List<Materia> lstMateriasFiltro2 = lstMateriasFiltro1.Where(materia => materia.NombreCarrera.Contains(nombreCarrera, StringComparison.OrdinalIgnoreCase)).ToList();

            foreach(var materia in lstMateriasFiltro1)
            {
                _frmGestionMaterias.dataGridViewMaterias.Rows.Add(materia.MateriaId, materia.NombreMateria, materia.Descripcion);
            }
        }

        // Se ejecuta cuando detecta un cambio en el textbox que se usa para filtrar los nombres de los grupos y recarga la tabla
        private void textBoxFiltroMateria_TextChanged(object sender, EventArgs e)
        {
            nombreMateria = _frmGestionMaterias.textBoxFiltroMateria.Text;

            CargarDatosEnTabla(sender, e);
        }

        // Combo box con todas las carreras y cuando se selecciona alguna se aplica el filtro y recarga la tabla
        private void comboBoxFiltroCarrera_TextChanged(object sender, EventArgs e)
        {
            nombreCarrera = _frmGestionMaterias.comboBoxFiltroCarrera.Text;

            CargarDatosEnTabla(sender, e);
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
                Materia materia = lstMaterias.FirstOrDefault(materia => materia.MateriaId == Convert.ToInt32(_frmGestionMaterias.dataGridViewMaterias.SelectedRows[0].Cells[0].Value));

                FrmRegistroMateria frmGestionMaterias = new FrmRegistroMateria(materia);
                frmGestionMaterias.Show();
            }
        }

        // Funcion de eliminar materia
        private void btnEliminarMateria_Click(object sender, EventArgs e)
        {
            if (_frmGestionMaterias.dataGridViewMaterias.SelectedRows.Count > 0) // checa que tengas un registro seleccionado
            {
                int materiaID = Convert.ToInt32(_frmGestionMaterias.dataGridViewMaterias.SelectedRows[0].Cells[0].Value); // obtiene el id del registro

                if(MateriaDAO.EliminarMateria(materiaID)) // le dice a la base de datos que elimine el registro con el id que se le dio
                {
                    cambioEnMaterias?.Invoke(); // invoca la accion que recarga la tabla
                }
            }
        }

        // abre el formulario para asignar una materia a una carrera
        private void btnAsignarCarrera_Click(object sender, EventArgs e)
        {
            FrmAsignarMateria frmAsignarMateria = new FrmAsignarMateria();
            frmAsignarMateria.Show();
        }
    }
}
