using SistemaEducativo.DAO;
using SistemaEducativo.Models;
using SistemaEducativo.Views.Admin;
using SistemaEducativo.Views.Alumno;
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
        private List<Usuario> lstUsuarios; // Lista de usuarios
        public static Action actualizarTabla;
        private string nombreFiltro = "";
        private string rolFiltro = "";

        public GestionUsuariosController(FrmGestionUsuarios frmGestionUsuarios)
        {
            _frmGestionUsuarios = frmGestionUsuarios;

            // Configuracion tabla
            _frmGestionUsuarios.dataGridViewUsuarios.Columns.Add("id", "ID");
            _frmGestionUsuarios.dataGridViewUsuarios.Columns.Add("matricula", "Matricula");
            _frmGestionUsuarios.dataGridViewUsuarios.Columns.Add("nombre", "Nombre");
            _frmGestionUsuarios.dataGridViewUsuarios.Columns.Add("apellidoP", "Ap. Paterno");
            _frmGestionUsuarios.dataGridViewUsuarios.Columns.Add("apellidoM", "Ap. Materno");
            _frmGestionUsuarios.dataGridViewUsuarios.Columns.Add("correo", "Correo");
            _frmGestionUsuarios.dataGridViewUsuarios.Columns.Add("rol", "Rol");
            _frmGestionUsuarios.dataGridViewUsuarios.Columns.Add("grupoID", "Grupo ID");

            lstUsuarios = UsuarioDAO.ObtenerUsuarios(null); // Llama a la base de datos para obtener la lista de usuarios
            actualizarTabla = () => { lstUsuarios = UsuarioDAO.ObtenerUsuarios(null); frmGestionUsuarios_Load(null, null); };

            _frmGestionUsuarios.Load += frmGestionUsuarios_Load; // Cuando inicia el formulario carga una funcion la cual es cargar datos en tabla
            _frmGestionUsuarios.textBoxFiltroUsuarios.TextChanged += textBoxFiltroUsuario_TextChanged;
            _frmGestionUsuarios.comboBoxFiltroRol.TextChanged += comboBoxFiltroRol_TextChanged;

            _frmGestionUsuarios.crearUsuarioToolStripMenuItem.Click += btnCrearUsuario_Click;
            _frmGestionUsuarios.editarUsuarioToolStripMenuItem.Click += btnEditarUsuario_Click;
            _frmGestionUsuarios.eliminarUsuarioToolStripMenuItem.Click += btnEliminarUsuario_Click;
            _frmGestionUsuarios.verCalificacionesToolStripMenuItem.Click += btnVerCalificaciones_Click;
        }

        // funcion que carga los datos en la tabla de gestion de usuarios
        private void frmGestionUsuarios_Load(object sender, EventArgs e)
        {
            _frmGestionUsuarios.dataGridViewUsuarios.Rows.Clear();

            List<Usuario> lstUsuariosFiltroNombre = lstUsuarios.Where(usuario => usuario.Nombre.Contains(nombreFiltro, StringComparison.OrdinalIgnoreCase)).ToList();
            List<Usuario> lstUsuariosFiltroRol = lstUsuariosFiltroNombre.Where(usuario => usuario.Rol.Contains(_frmGestionUsuarios.comboBoxFiltroRol.Text)).ToList();

            foreach (var usuario in lstUsuariosFiltroRol)
            {
                _frmGestionUsuarios.dataGridViewUsuarios.Rows.Add(usuario.Id, usuario.Matricula, usuario.Nombre, usuario.ApellidoP, usuario.ApellidoM, usuario.Correo, usuario.Rol, usuario.GrupoId);
            }
        }

        // Funcion que cuando detecta cambios en el textbox para filtrar por nombre de usuario y recarga la tabla con el filtro
        private void textBoxFiltroUsuario_TextChanged(object sender, EventArgs e)
        {
            nombreFiltro = _frmGestionUsuarios.textBoxFiltroUsuarios.Text;
            frmGestionUsuarios_Load(sender, e);
        }

        // Funcion que detecta cambios en el combobox para filtrar por rol y recargar la tabla con el filtro
        private void comboBoxFiltroRol_TextChanged(object sender, EventArgs e)
        {
            rolFiltro = _frmGestionUsuarios.comboBoxFiltroRol.Text;
            frmGestionUsuarios_Load(sender, e);
        }

        // funcion que abre el formulario de registro de usuarios
        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            FrmRegistroUsuario frmRegistroUsuario = new FrmRegistroUsuario(null);
            frmRegistroUsuario.Show();
        }

        // abre formulario registro de usuarios pero con la informacion a editar
        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            if (_frmGestionUsuarios.dataGridViewUsuarios.SelectedRows.Count > 0)
            {
                Usuario usuarioSeleccionado = lstUsuarios.FirstOrDefault(usuario => usuario.Id == Convert.ToInt32(_frmGestionUsuarios.dataGridViewUsuarios.SelectedRows[0].Cells[0].Value));

                FrmRegistroUsuario frmRegistroUsuario = new FrmRegistroUsuario(usuarioSeleccionado);
                frmRegistroUsuario.Show();
            }
        }

        // elimina el usuario obteniendo el id de la fila seleccionada
        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            Usuario usuarioSeleccionado = lstUsuarios.FirstOrDefault(usuario => usuario.Id == Convert.ToInt32(_frmGestionUsuarios.dataGridViewUsuarios.SelectedRows[0].Cells[0].Value));
            DialogResult dialogResult = MessageBox.Show("¿Estas seguro de realizar esta accion? Borrara todo lo relacionado con el usuario seleccionado.", "Eliminar Usuario", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                if (UsuarioDAO.EliminarUsuario(usuarioSeleccionado))
                {
                    actualizarTabla?.Invoke();
                }
            }
        }

        private void btnVerCalificaciones_Click(object sender, EventArgs e)
        {
            if (_frmGestionUsuarios.dataGridViewUsuarios.SelectedRows.Count > 0)
            {
                Usuario usuario = lstUsuarios.FirstOrDefault(u => u.Id == Convert.ToInt32(_frmGestionUsuarios.dataGridViewUsuarios.SelectedRows[0].Cells[0].Value));

                if (usuario.Rol == "alumno")
                {
                    FrmVistaCalificaciones frmVistaCalificaciones = new FrmVistaCalificaciones(usuario, null);
                    MenuAdminController.actualizarSubmenu(frmVistaCalificaciones);
                } else
                {
                    MessageBox.Show("El usuario seleccionado no es un alumno.");
                }
            }
        }
    }
}
