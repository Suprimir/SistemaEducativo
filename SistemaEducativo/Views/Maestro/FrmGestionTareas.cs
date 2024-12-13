using SistemaEducativo.Controllers.MaestroControllers;
using SistemaEducativo.Models;
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
    public partial class FrmGestionTareas : Form
    {
        private GestionTareasController controller;

        public FrmGestionTareas(Form form, GrupoProfesor grupo)
        {
            InitializeComponent();

            controller = new GestionTareasController(this, form, grupo);
        }
    }
}
