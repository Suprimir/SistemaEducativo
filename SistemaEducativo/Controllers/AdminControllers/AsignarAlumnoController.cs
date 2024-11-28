using SistemaEducativo.Views.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEducativo.Controllers.AdminControllers
{
    internal class AsignarAlumnoController
    {
        private FrmAsignarAlumno _frmAsignarAlumno;

        public AsignarAlumnoController(FrmAsignarAlumno frmAsignarAlumno)
        {
            _frmAsignarAlumno = frmAsignarAlumno;

            _frmAsignarAlumno.Load += frmAsignarAlumno_Load;
        }

        private void frmAsignarAlumno_Load(object sender, EventArgs e)
        {

        }
    }
}
