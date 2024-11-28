using SistemaEducativo.DAO;
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

        public RegistroMateriaController(FrmRegistroMateria frmRegistroMateria)
        {
            _frmRegistroMateria = frmRegistroMateria;

            if (_frmRegistroMateria._materiaSeleccionada != null) // Si el formulario tiene una materia no nula
            {
                _frmRegistroMateria.textBoxNombreMateria.Text = _frmRegistroMateria._materiaSeleccionada.NombreMateria;
                _frmRegistroMateria.richTextBoxDescripcion.Text = _frmRegistroMateria._materiaSeleccionada.Descripcion;
            }

            _frmRegistroMateria.btnRegistrarMateria.Click += btnRegistrarMateria_Click;
        }

        private void btnRegistrarMateria_Click(object sender, EventArgs e)
        {
            if(_frmRegistroMateria._materiaSeleccionada != null)
            {
                _frmRegistroMateria._materiaSeleccionada.NombreMateria = _frmRegistroMateria.textBoxNombreMateria.Text;
                _frmRegistroMateria._materiaSeleccionada.Descripcion = _frmRegistroMateria.richTextBoxDescripcion.Text;

                if(MateriaDAO.ActualizarMateria(_frmRegistroMateria._materiaSeleccionada))
                {
                    MessageBox.Show("Registro Exitoso.");

                    GestionMateriasController.cambioEnMaterias?.Invoke();

                    _frmRegistroMateria.Dispose();
                }
                else
                {
                    MessageBox.Show("Hubo un error.");
                }
            } else
            {
                if (MateriaDAO.RegistrarMateria(_frmRegistroMateria.textBoxNombreMateria.Text, _frmRegistroMateria.richTextBoxDescripcion.Text))
                {
                    MessageBox.Show("Registro Exitoso.");

                    GestionMateriasController.cambioEnMaterias?.Invoke();

                    _frmRegistroMateria.Dispose();
                }
                else
                {
                    MessageBox.Show("Hubo un error.");
                }
            }
        }
    }
}
