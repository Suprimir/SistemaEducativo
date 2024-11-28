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
        public static Action cambioEnGrupos;

        private string filtroNombre = "";

        public GestionGruposController(FrmGestionGrupos frmGestionGrupos)
        {
            _frmGestionGrupos = frmGestionGrupos;

            lstGrupos = GrupoDAO.ObtenerGrupos(); // Obtiene la lista de grupos de la base de datos.

            // Accion que ejecuta la actualizacion de la tabla de grupos
            cambioEnGrupos = () => { lstGrupos = GrupoDAO.ObtenerGrupos(); CargarDatosEnTabla(null, null); };

            _frmGestionGrupos.Load += CargarDatosEnTabla; 

            _frmGestionGrupos.textBoxFiltroNombre.TextChanged += textBoxFiltroNombre_TextChanged;

            // Funciones para los botones del gestion de grupos
            _frmGestionGrupos.btnCrearGrupo.Click += btnCrearGrupo_Click;
            _frmGestionGrupos.btnEditarGrupo.Click += btnEditarGrupo_Click;
            _frmGestionGrupos.btnEliminarGrupo.Click += btnEliminarGrupo_Click;
            _frmGestionGrupos.btnAsignarAlumno.Click += btnAsignarAlumno_Click;
            _frmGestionGrupos.btnAsignarMaestro.Click += btnAsignarMaestro_Click;
        }

        private void CargarDatosEnTabla(object sender, EventArgs e)
        {
            List<Grupo> lstGruposFiltro = lstGrupos.Where(grupo => grupo.NombreGrupo.Contains(filtroNombre, StringComparison.OrdinalIgnoreCase)).ToList();

            _frmGestionGrupos.dataGridViewGrupos.DataSource = lstGruposFiltro;
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

        // Abre igualmente el formulario de registro de grupo pero esta vez le pasa el grupo que se selecciono para editarlo
        private void btnEditarGrupo_Click(object sender, EventArgs e)
        {
            Grupo grupoSeleccionado = lstGrupos.FirstOrDefault(grupo => grupo.GrupoID == Convert.ToInt32(_frmGestionGrupos.dataGridViewGrupos.SelectedRows[0].Cells[0].Value));

            FrmRegistroGrupo frmRegistroGrupo = new FrmRegistroGrupo(grupoSeleccionado);
            frmRegistroGrupo.Show();
        }

        // Pregunta si en verdad desea eliminar un grupo y si dice que si le pide a la base de datos eliminar ese registro.
        private void btnEliminarGrupo_Click(object sender, EventArgs e)
        {
            int generacionID = Convert.ToInt32(_frmGestionGrupos.dataGridViewGrupos.SelectedRows[0].Cells[0].Value);

            DialogResult dialogResult = MessageBox.Show("¿Estas seguro de realizar esta accion? Borrara todo lo relacionado con el grupo seleccionado.", "Eliminar Grupo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if(GrupoDAO.EliminarGrupo(generacionID))
                {
                    cambioEnGrupos?.Invoke();
                }
            }
        }

        // Abre el formulario para asignar alumnos a los grupos
        private void btnAsignarAlumno_Click(object sender, EventArgs e)
        {
            FrmAsignarAlumno frmAsignarAlumno = new FrmAsignarAlumno();
            frmAsignarAlumno.Show();
        }

        // Abre el formulario para asignar maestros a los grupos y que materia impartira
        private void btnAsignarMaestro_Click(object sender, EventArgs e)
        {
            FrmAsignarMaestro frmAsignarMaestro = new FrmAsignarMaestro();
            frmAsignarMaestro.Show();
        }
    }
}
