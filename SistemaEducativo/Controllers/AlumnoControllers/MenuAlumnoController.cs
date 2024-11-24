using SistemaEducativo.Views.Alumno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEducativo.Controllers.AlumnoControllers
{
    internal class MenuAlumnoController
    {
        private FrmMenuAlumno _frmMenuAlumno;
        public MenuAlumnoController(FrmMenuAlumno frmMenuAlumno)
        {
            _frmMenuAlumno = frmMenuAlumno;

            _frmMenuAlumno._frmLogin.Hide();
        }
    }
}
