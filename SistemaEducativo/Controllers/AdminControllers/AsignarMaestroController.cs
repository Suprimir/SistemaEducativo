using SistemaEducativo.Views.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEducativo.Controllers.AdminControllers
{
    internal class AsignarMaestroController
    {
        private FrmAsignarMaestro _frmAsignarMaestro;

        public AsignarMaestroController(FrmAsignarMaestro frmAsignarMaestro)
        {
            _frmAsignarMaestro = frmAsignarMaestro;

            _frmAsignarMaestro.Load += frmAsignarMaestro_Load;
        }

        private void frmAsignarMaestro_Load(object sender, EventArgs e)
        {

        }
    }
}
