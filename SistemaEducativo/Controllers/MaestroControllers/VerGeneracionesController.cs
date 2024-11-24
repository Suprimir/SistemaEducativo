using SistemaEducativo.DAO;
using SistemaEducativo.Models;
using SistemaEducativo.Views.Maestro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEducativo.Controllers.MaestroControllers
{
    internal class VerGeneracionesController
    {
        private FrmVerGeneraciones frmVerGeneraciones;

        public VerGeneracionesController(FrmVerGeneraciones frmVerGeneraciones)
        {
            this.frmVerGeneraciones = frmVerGeneraciones;

            this.frmVerGeneraciones.dataGridViewGSP.DataSource = GeneracionDAO.ObtenerTabla();

            this.frmVerGeneraciones.dataGridViewGSP.CellDoubleClick += dataGridViewGSP_RowHeaderMouseDoubleClick;
        }

        private void dataGridViewGSP_RowHeaderMouseDoubleClick(object sender, EventArgs e)
        {
            int generacionID = Convert.ToInt32(frmVerGeneraciones.dataGridViewGSP.SelectedRows[0].Cells[0].Value);

            Generacion generacion = GeneracionDAO.ObtenerPorID(generacionID);

            FrmVerDatosGeneracion frmVerDatosGeneracion = new FrmVerDatosGeneracion(generacion);
            frmVerDatosGeneracion.ShowDialog();
        }
    }
}
