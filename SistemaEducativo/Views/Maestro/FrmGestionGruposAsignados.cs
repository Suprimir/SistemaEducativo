using SistemaEducativo.Controllers.MaestroControllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEducativo.Views.Maestro
{
    public partial class FrmGestionGruposAsignados : Form
    {
        private GestionGruposAsignadosController controller;
        public int maestroID;

        public FrmGestionGruposAsignados(int maestroID)
        {
            this.maestroID = maestroID;

            InitializeComponent();

            controller = new GestionGruposAsignadosController(this);
        }
    }
}
