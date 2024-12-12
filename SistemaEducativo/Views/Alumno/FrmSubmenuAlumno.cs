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
    public partial class FrmSubmenuAlumno : Form
    {
        private SubmenuAlumnoController controller;

        public FrmSubmenuAlumno()
        {
            InitializeComponent();

            controller = new SubmenuAlumnoController(this);
        }
    }
}
