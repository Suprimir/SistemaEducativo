using SistemaEducativo.Views.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEducativo.Controllers.AdminControllers
{
    internal class AsignarMateriaController
    {
        private FrmAsignarMateria _frmAsignarMateria;

        public AsignarMateriaController(FrmAsignarMateria frmAsignarMateria)
        {
            _frmAsignarMateria = frmAsignarMateria;

            _frmAsignarMateria.Load += frmAsignarMateria_Load;
        }

        private void frmAsignarMateria_Load(object sender, EventArgs e)
        {

        }
    }
}
