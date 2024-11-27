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

        private List<Grupo> lstGrupos;
        public static Action cambioEnGrupos;

        private string filtroNombre = "";

        public GestionGruposController(FrmGestionGrupos frmGestionGrupos)
        {
            _frmGestionGrupos = frmGestionGrupos;

            lstGrupos = GrupoDAO.ObtenerGrupos();
            cambioEnGrupos = () => { lstGrupos = GrupoDAO.ObtenerGrupos(); frmGestionGrupos_Load(null, null); };

            _frmGestionGrupos.Load += frmGestionGrupos_Load;

            _frmGestionGrupos.textBoxFiltroNombre.TextChanged += textBoxFiltroNombre_TextChanged;

            _frmGestionGrupos.btnCrearGrupo.Click += btnCrearGrupo_Click;
            _frmGestionGrupos.btnEditarGrupo.Click += btnEditarGrupo_Click;
            _frmGestionGrupos.btnEliminarGrupo.Click += btnEliminarGrupo_Click;
        }

        private void frmGestionGrupos_Load(object sender, EventArgs e)
        {
            List<Grupo> lstGruposFiltro = lstGrupos.Where(grupo => grupo.NombreGrupo.Contains(filtroNombre, StringComparison.OrdinalIgnoreCase)).ToList();

            _frmGestionGrupos.dataGridViewGrupos.DataSource = lstGruposFiltro;
        }

        private void textBoxFiltroNombre_TextChanged(object sender, EventArgs e)
        {
            filtroNombre = _frmGestionGrupos.textBoxFiltroNombre.Text;

            frmGestionGrupos_Load(sender, e);
        }

        private void btnCrearGrupo_Click(object sender, EventArgs e)
        {
            FrmRegistroGrupo frmRegistroGrupo = new FrmRegistroGrupo(null);
            frmRegistroGrupo.Show();
        }

        private void btnEditarGrupo_Click(object sender, EventArgs e)
        {
            Grupo grupoSeleccionado = lstGrupos.FirstOrDefault(grupo => grupo.GrupoID == Convert.ToInt32(_frmGestionGrupos.dataGridViewGrupos.SelectedRows[0].Cells[0].Value));

            FrmRegistroGrupo frmRegistroGrupo = new FrmRegistroGrupo(grupoSeleccionado);
            frmRegistroGrupo.Show();
        }

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
    }
}
