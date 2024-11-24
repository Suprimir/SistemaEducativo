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
    internal class RegistroGeneracionController
    {
        private FrmRegistroGeneracion _frmRegistroGeneracion;
        private List<Carrera> lstCarreras = CarreraDAO.ObtenerTodas();

        public RegistroGeneracionController(FrmRegistroGeneracion frmRegistroGeneracion)
        {
            _frmRegistroGeneracion = frmRegistroGeneracion;

            _frmRegistroGeneracion.Load += frmRegistroGeneracion_Load;
            _frmRegistroGeneracion.btnRegistrar.Click += btnRegistrar_Click;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Carrera carrera = lstCarreras.FirstOrDefault(c => c.NombreCarrera.Contains(_frmRegistroGeneracion.comboBoxCarreras.Text));

            int generacionID = GeneracionDAO.CrearGeneracion(carrera.CarreraID, _frmRegistroGeneracion.textBoxNombreGeneracion.Text);

            if (generacionID != 0)
            {
                List<int> lstSemestreID = SemestreDAO.CrearSemestresGeneracion(generacionID, carrera.CarreraID);

                if(lstSemestreID.Count > 0)
                {
                    foreach(int semestreID in lstSemestreID)
                    {
                        if(!ParcialDAO.CrearParcialesGeneracion(semestreID))
                        {
                            MessageBox.Show("Error al crear parciales");
                        }
                    }
                }
            }
        }

        private void frmRegistroGeneracion_Load(object sender, EventArgs e)
        {
            foreach(var carrera in lstCarreras)
            {
                _frmRegistroGeneracion.comboBoxCarreras.Items.Add(carrera.NombreCarrera);
            }
        }
    }
}
