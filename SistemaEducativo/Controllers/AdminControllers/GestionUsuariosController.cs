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
        private List<UsuarioGeneral> lstUsuarios; // Lista de usuarios
        private string nombreFiltro = "";

        public GestionUsuariosController(FrmGestionUsuarios frmGestionUsuarios)
        {
            _frmGestionUsuarios = frmGestionUsuarios;

            lstUsuarios = UsuarioDAO.ObtenerUsuarios(); // Llama a la base de datos para obtener la lista de usuarios

            _frmGestionUsuarios.Load += CargarDatosEnTabla; // Cuando inicia el formulario carga una funcion la cual es cargar datos en tabla
            _frmGestionUsuarios.textBoxFiltroUsuarios.TextChanged += textBoxFiltroUsuario_TextChanged; 

            _frmGestionUsuarios.btnCrearUsuario.Click += btnCrearUsuario_Click;
        }

        // funcion que carga los datos en la tabla de gestion de usuarios
        private void CargarDatosEnTabla(object sender, EventArgs e)
        {
            List<UsuarioGeneral> lstUsuariosFiltro = lstUsuarios.Where(usuario => usuario.NombreCompleto.Contains(nombreFiltro, StringComparison.OrdinalIgnoreCase)).ToList();

            _frmGestionUsuarios.dataGridViewUsuarios.DataSource = lstUsuariosFiltro;
        }

        // Funcion que cuando detecta cambios en el textbox para filtrar por nombre de materia recarga la tabla con el filtro
        private void textBoxFiltroUsuario_TextChanged(object sender, EventArgs e)
        {
            nombreFiltro = _frmGestionUsuarios.textBoxFiltroUsuarios.Text;

            CargarDatosEnTabla(sender, e);
        }

        // funcion que abre el formulario de registro de usuarios
        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            FrmRegistroUsuario frmRegistroUsuario = new FrmRegistroUsuario();
            frmRegistroUsuario.Show();
        }
    }
}
