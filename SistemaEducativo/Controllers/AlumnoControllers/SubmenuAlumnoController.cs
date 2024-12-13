using K4os.Compression.LZ4.Encoders;
using SistemaEducativo.DAO;
using SistemaEducativo.Models;
using SistemaEducativo.Views.Alumno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEducativo.Controllers.AlumnoControllers
{
    internal class SubmenuAlumnoController
    {
        private FrmSubmenuAlumno _frmSubmenuAlumno;
        private TotalRegistros totalRegistros;

        public SubmenuAlumnoController(FrmSubmenuAlumno frmSubmenuAlumno)
        {
            _frmSubmenuAlumno = frmSubmenuAlumno;

            totalRegistros = TotalRegistrosDAO.DatosMenuAlumno();

            _frmSubmenuAlumno.Load += frmSubmenuAlumno_Load;
            _frmSubmenuAlumno.timerMenu.Tick += timerMenu_Tick;
            _frmSubmenuAlumno.timerMenu.Start();
        }

        private void frmSubmenuAlumno_Load(object sender, EventArgs e)
        {
            _frmSubmenuAlumno.lblTareasPendientes.Text = totalRegistros.TotalTareas.ToString();
            _frmSubmenuAlumno.lblHora.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void timerMenu_Tick(object sender, EventArgs e)
        {
            _frmSubmenuAlumno.lblHora.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
    }
}
