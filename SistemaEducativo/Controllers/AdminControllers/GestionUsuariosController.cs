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
        private List<Usuario> lstUsuariosSeleccionados = new List<Usuario>();
        public static Action actualizarTabla;
        private string nombreFiltro = "";
        private string rolFiltro = "";

        public GestionUsuariosController(FrmGestionUsuarios frmGestionUsuarios)
        {
            _frmGestionUsuarios = frmGestionUsuarios;

            lstUsuarios = UsuarioDAO.ObtenerUsuarios(null); // Llama a la base de datos para obtener la lista de usuarios
            actualizarTabla = () => { lstUsuarios = UsuarioDAO.ObtenerUsuarios(null); frmGestionUsuarios_Load(null, null); };

            _frmGestionUsuarios.Load += frmGestionUsuarios_Load; // Cuando inicia el formulario carga una funcion la cual es cargar datos en tabla
            _frmGestionUsuarios.textBoxFiltroUsuarios.TextChanged += textBoxFiltroUsuario_TextChanged;
            _frmGestionUsuarios.comboBoxFiltroRol.TextChanged += comboBoxFiltroRol_TextChanged;

            _frmGestionUsuarios.crearUsuarioToolStripMenuItem.Click += btnCrearUsuario_Click;
            _frmGestionUsuarios.eliminarUsuarioToolStripMenuItem.Click += btnEliminarUsuario_Click;
            _frmGestionUsuarios.verCalificacionesToolStripMenuItem.Click += btnVerCalificaciones_Click;
        
            _frmGestionUsuarios.dataGridViewUsuarios.CellClick += dataGridViewUsuarios_CellClick;
            _frmGestionUsuarios.dataGridViewUsuarios.CellContentClick += dataGridViewUsuarios_CellContentClick;
        }

        // funcion que carga los datos en la tabla de gestion de usuarios
        private void frmGestionUsuarios_Load(object sender, EventArgs e)
        {
            lstUsuariosSeleccionados.Clear();

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

        // elimina el usuario obteniendo el id de la fila seleccionada
        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (lstUsuariosSeleccionados.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("¿Estas seguro de realizar esta accion? Borrara todo lo relacionado con el usuario seleccionado.", "Eliminar Usuario", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    foreach (var usuario in lstUsuariosSeleccionados)
                    {
                        UsuarioDAO.EliminarUsuario(usuario);
                    }

                    actualizarTabla?.Invoke();
                }
            } else
            {
                MessageBox.Show("Selecciona 1 o más usuarios.");
            }
        }

        private void btnVerCalificaciones_Click(object sender, EventArgs e)
        {
            if (lstUsuariosSeleccionados.Count == 1)
            {
                if (lstUsuariosSeleccionados[0].Rol == "alumno")
                {
                    FrmVistaCalificaciones frmVistaCalificaciones = new FrmVistaCalificaciones(lstUsuariosSeleccionados[0], null);
                    MenuAdminController.actualizarSubmenu(frmVistaCalificaciones);
                } else
                {
                    MessageBox.Show("El usuario seleccionado no es un alumno.");
                }
            } else
            {
                MessageBox.Show("Selecciona 1 solo alumno para ver sus calificaciones.");
            }
        }

        private void dataGridViewUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && _frmGestionUsuarios.dataGridViewUsuarios.Columns[e.ColumnIndex].Name == "editar")
            {
                Usuario usuarioSeleccionado = lstUsuarios.First(g => g.Id == Convert.ToInt32(_frmGestionUsuarios.dataGridViewUsuarios.Rows[e.RowIndex].Cells[0].Value));
                
                FrmRegistroUsuario frmRegistroUsuario = new FrmRegistroUsuario(usuarioSeleccionado);
                frmRegistroUsuario.Show();
            }
        }

        private void dataGridViewUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && _frmGestionUsuarios.dataGridViewUsuarios.Columns[e.ColumnIndex].Name == "eliminar")
            {
                _frmGestionUsuarios.dataGridViewUsuarios.CommitEdit(DataGridViewDataErrorContexts.Commit);

                bool seleccion = Convert.ToBoolean(_frmGestionUsuarios.dataGridViewUsuarios.Rows[e.RowIndex].Cells["eliminar"].Value);

                Usuario usuarioSeleccionado = lstUsuarios.First(g => g.Id == Convert.ToInt32(_frmGestionUsuarios.dataGridViewUsuarios.Rows[e.RowIndex].Cells[0].Value));

                if (usuarioSeleccionado != null)
                {
                    if (seleccion == true)
                    {
                        lstUsuariosSeleccionados.Add(usuarioSeleccionado);
                    }
                    else
                    {
                        lstUsuariosSeleccionados.Remove(usuarioSeleccionado);
                    }
                }
            }
        }
    }
}
