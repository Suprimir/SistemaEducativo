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
    internal class GestionUsuariosController
    {
        private FrmGestionUsuarios _frmGestionUsuarios;
        private List<UsuarioGeneral> lstUsuarios;
        private string nombreFiltro = "";

        public GestionUsuariosController(FrmGestionUsuarios frmGestionUsuarios)
        {
            _frmGestionUsuarios = frmGestionUsuarios;

            lstUsuarios = UsuarioDAO.ObtenerUsuarios();

            _frmGestionUsuarios.Load += frmGestionUsuarios_Load;
            _frmGestionUsuarios.textBoxFiltroUsuarios.TextChanged += textBoxFiltroUsuario_TextChanged;

            _frmGestionUsuarios.btnCrearUsuario.Click += btnCrearUsuario_Click;
        }

        private void frmGestionUsuarios_Load(object sender, EventArgs e)
        {
            List<UsuarioGeneral> lstUsuariosFiltro = lstUsuarios.Where(usuario => usuario.NombreCompleto.Contains(nombreFiltro, StringComparison.OrdinalIgnoreCase)).ToList();

            _frmGestionUsuarios.dataGridViewUsuarios.DataSource = lstUsuariosFiltro;
        }

        private void textBoxFiltroUsuario_TextChanged(object sender, EventArgs e)
        {
            nombreFiltro = _frmGestionUsuarios.textBoxFiltroUsuarios.Text;

            frmGestionUsuarios_Load(sender, e);
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            FrmRegistroUsuario frmRegistroUsuario = new FrmRegistroUsuario();
            frmRegistroUsuario.Show();
        }
    }
}
