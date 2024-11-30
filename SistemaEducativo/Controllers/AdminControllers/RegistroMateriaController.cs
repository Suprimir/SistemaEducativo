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
    internal class RegistroMateriaController
    {
        private FrmRegistroMateria _frmRegistroMateria;
        private Materia materiaSeleccionado;

        public RegistroMateriaController(FrmRegistroMateria frmRegistroMateria, Materia materia)
        {
            _frmRegistroMateria = frmRegistroMateria;
            materiaSeleccionado = materia;

            _frmRegistroMateria.Load += frmRegistroMateria_Load;
            _frmRegistroMateria.btnRegistrarMateria.Click += btnRegistrarMateria_Click;
        }

        private void frmRegistroMateria_Load(object sender, EventArgs e)
        {
            if (materiaSeleccionado != null) // Si el formulario tiene una materia a editar
            {
                _frmRegistroMateria.textBoxNombreMateria.Text = materiaSeleccionado.NombreMateria;
                _frmRegistroMateria.richTextBoxDescripcion.Text = materiaSeleccionado.Descripcion;
            }
        }

        private void btnRegistrarMateria_Click(object sender, EventArgs e)
        {
            if(materiaSeleccionado != null)
            {
                materiaSeleccionado.NombreMateria = _frmRegistroMateria.textBoxNombreMateria.Text;
                materiaSeleccionado.Descripcion = _frmRegistroMateria.richTextBoxDescripcion.Text;

                if (MateriaDAO.CrearActualizarMateria(materiaSeleccionado)) 
                {
                    MessageBox.Show("Registro exitoso.");
                    GestionMateriasController.actualizarTabla?.Invoke();
                    _frmRegistroMateria.Close();
                }
            } else
            {
                Materia materia = new Materia();

                materia.NombreMateria = _frmRegistroMateria.textBoxNombreMateria.Text;
                materia.Descripcion = _frmRegistroMateria.richTextBoxDescripcion.Text;

                if (MateriaDAO.CrearActualizarMateria(materia))
                {
                    MessageBox.Show("Registro exitoso.");
                    GestionMateriasController.actualizarTabla?.Invoke();
                    _frmRegistroMateria.Close();
                }
            }
        }
    }
}
