using SistemaEducativo.DAO;
using SistemaEducativo.Models;
using SistemaEducativo.Views.Admin;
using SistemaEducativo.Views.Alumno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEducativo.Controllers.AdminControllers
{
    internal class SubmenuAdminController
    {
        private FrmSubmenuAdmin _frmSubmenuAdmin;
        private TotalRegistros totalRegistros;

        public SubmenuAdminController(FrmSubmenuAdmin frmSubmenuAdmin)
        {
            _frmSubmenuAdmin = frmSubmenuAdmin;

            totalRegistros = TotalRegistrosDAO.ObtenerRegistros();

            _frmSubmenuAdmin.Load += frmSubmenuAdmin_Load;
            _frmSubmenuAdmin.timerMenu.Tick += timerMenu_Tick;
            _frmSubmenuAdmin.timerMenu.Start();
        }

        private void frmSubmenuAdmin_Load(object sender, EventArgs e)
        {
            _frmSubmenuAdmin.lblCantGrupos.Text = totalRegistros.TotalGrupos.ToString();
            _frmSubmenuAdmin.lblCantUsuarios.Text = totalRegistros.TotalUsuarios.ToString();
            _frmSubmenuAdmin.lblCantAlumnos.Text = totalRegistros.TotalAlumnos.ToString();
            _frmSubmenuAdmin.lblCantMaestros.Text = totalRegistros.TotalMaestros.ToString();
            _frmSubmenuAdmin.lblCantAdmins.Text = totalRegistros.TotalAdmins.ToString();
            _frmSubmenuAdmin.lblCantMaterias.Text = totalRegistros.TotalMaterias.ToString();
            _frmSubmenuAdmin.lblHora.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void timerMenu_Tick(object sender, EventArgs e)
        {
            _frmSubmenuAdmin.lblHora.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
    }
}
