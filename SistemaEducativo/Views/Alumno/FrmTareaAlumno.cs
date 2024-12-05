using SistemaEducativo.Controllers.AlumnoControllers;
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

namespace SistemaEducativo.Views.Alumno
{
    public partial class FrmTareaAlumno : Form
    {
        private TareaAlumnoController controller;
        public FrmTareaAlumno(Tarea tarea)
        {
            InitializeComponent();

            controller = new TareaAlumnoController(this, tarea);
        }
    }
}
