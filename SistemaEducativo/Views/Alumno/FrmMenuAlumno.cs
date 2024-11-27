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
    public partial class FrmMenuAlumno : Form
    {
        public FrmLogin _frmLogin;
        private MenuAlumnoController controller;

        public FrmMenuAlumno(FrmLogin frmLogin)
        {
            _frmLogin = frmLogin;

            InitializeComponent();

            controller = new MenuAlumnoController(this);
        }
    }
}
