using SistemaEducativo.Controllers.AlumnoControllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEducativo.Views.Alumno
{
    public partial class FrmGestionTareasAlumno : Form
    {
        private GestionTareasAlumnoController controller;

        public FrmGestionTareasAlumno()
        {
            InitializeComponent();

            controller = new GestionTareasAlumnoController(this);
        }
    }
}
