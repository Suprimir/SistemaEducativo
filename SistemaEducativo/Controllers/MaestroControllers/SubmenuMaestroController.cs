using SistemaEducativo.DAO;
using SistemaEducativo.Models;
using SistemaEducativo.Views.Alumno;
using SistemaEducativo.Views.Maestro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEducativo.Controllers.MaestroControllers
{
    internal class SubmenuMaestroController
    {
        private FrmSubmenuMaestro _frmSubmenuMaestro;
        private TotalRegistros totalRegistros;

        public SubmenuMaestroController(FrmSubmenuMaestro frmSubmenuMaestro)
        {
            _frmSubmenuMaestro = frmSubmenuMaestro;
            totalRegistros = TotalRegistrosDAO.DatosMenuMaestro();

            _frmSubmenuMaestro.Load += frmSubmenuMaestro_Load;
            _frmSubmenuMaestro.timerMenu.Tick += timerMenu_Tick;
            _frmSubmenuMaestro.timerMenu.Start();
        }

        private void frmSubmenuMaestro_Load(object sender, EventArgs e)
        {
            _frmSubmenuMaestro.lblGruposAsignados.Text = totalRegistros.TotalGrupos.ToString();
            _frmSubmenuMaestro.lblTareasPendientes.Text = totalRegistros.TotalTareas.ToString();
            _frmSubmenuMaestro.lblHora.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void timerMenu_Tick(object sender, EventArgs e)
        {
            _frmSubmenuMaestro.lblHora.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
    }
}
