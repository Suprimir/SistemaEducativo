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
            cambioEnMaterias = () => { lstMaterias = MateriaDAO.ObtenerMaterias(); frmGestionMaterias_Load(null, null); };

            _frmGestionMaterias.comboBoxFiltroCarrera.Items.Add(""); // Para la opcion de nada
            _frmGestionMaterias.comboBoxFiltroCarrera.Items.Add("No Asignada"); // Para la opcion de mostrar materias sin carrera asignada

            // AGREGA LAS CARRERAS DE LAS MATERIAS DISPONIBLES AL COMBOBOX DE FILTRO POR CARRERA
            foreach (var materia in lstMaterias)
            {
                if(!_frmGestionMaterias.comboBoxFiltroCarrera.Items.Contains(materia.NombreCarrera) && materia.NombreCarrera != "No Asignada")
                {
                    _frmGestionMaterias.comboBoxFiltroCarrera.Items.Add(materia.NombreCarrera);
                }
            }

            // CARGA LA TABLA Y SE ACTUALIZA CADA QUE CAMBIA EL TEXTO DE CUALQUIERA DE LOS FILTROS
            _frmGestionMaterias.Load += frmGestionMaterias_Load;
            _frmGestionMaterias.textBoxFiltroMateria.TextChanged += textBoxFiltroMateria_TextChanged;
            _frmGestionMaterias.comboBoxFiltroCarrera.TextChanged += comboBoxFiltroCarrera_TextChanged;

            // EJECUTAN LAS FUNCIONES DE CREAR Y EDITAR MATERIA
            _frmGestionMaterias.btnCrearMateria.Click += btnCrearMateria_Click;
            _frmGestionMaterias.btnEditarMateria.Click += btnEditarMateria_Click;
        }

        private void frmGestionMaterias_Load(object sender, EventArgs e)
        {
            List<Materia> lstMateriasFiltro1 = lstMaterias.Where(materia => materia.NombreMateria.Contains(nombreMateria, StringComparison.OrdinalIgnoreCase)).ToList();
            List<Materia> lstMateriasFiltro2 = lstMateriasFiltro1.Where(materia => materia.NombreCarrera.Contains(nombreCarrera, StringComparison.OrdinalIgnoreCase)).ToList();

            _frmGestionMaterias.dataGridViewMaterias.DataSource = lstMateriasFiltro2;
        }

        private void textBoxFiltroMateria_TextChanged(object sender, EventArgs e)
        {
            nombreMateria = _frmGestionMaterias.textBoxFiltroMateria.Text;

            frmGestionMaterias_Load(sender, e);
        }

        private void comboBoxFiltroCarrera_TextChanged(object sender, EventArgs e)
        {
            nombreCarrera = _frmGestionMaterias.comboBoxFiltroCarrera.Text;

            frmGestionMaterias_Load(sender, e);
        }

        private void btnCrearMateria_Click(object sender, EventArgs e)
        {
            FrmRegistroMateria frmRegistroMateria = new FrmRegistroMateria(null);
            frmRegistroMateria.Show();
        }

        private void btnEditarMateria_Click(object sender, EventArgs e)
        {
            if (_frmGestionMaterias.dataGridViewMaterias.SelectedRows.Count > 0 )
            {
                Materia materia = lstMaterias.FirstOrDefault(materia => materia.MateriaId == Convert.ToInt32(_frmGestionMaterias.dataGridViewMaterias.SelectedRows[0].Cells[0].Value));

                FrmRegistroMateria frmGestionMaterias = new FrmRegistroMateria(materia);
                frmGestionMaterias.Show();
            }
        }
    }
}
