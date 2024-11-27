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
    internal class SubmenuAdminController
    {
        private FrmSubmenuAdmin _frmSubmenuAdmin;

        public SubmenuAdminController(FrmSubmenuAdmin frmSubmenuAdmin)
        {
            _frmSubmenuAdmin = frmSubmenuAdmin;

            TotalRegistros totalRegistros = TotalRegistrosDAO.ObtenerRegistros();

            _frmSubmenuAdmin.lblCantGrupos.Text = totalRegistros.TotalGrupos.ToString();
            _frmSubmenuAdmin.lblCantUsuarios.Text = totalRegistros.TotalUsuarios.ToString();
            _frmSubmenuAdmin.lblCantAlumnos.Text = totalRegistros.TotalAlumnos.ToString();
            _frmSubmenuAdmin.lblCantMaestros.Text = totalRegistros.TotalMaestros.ToString();
            _frmSubmenuAdmin.lblCantAdmins.Text = totalRegistros.TotalAdmins.ToString();
            _frmSubmenuAdmin.lblCantMaterias.Text = totalRegistros.TotalMaterias.ToString();
        }
    }
}
