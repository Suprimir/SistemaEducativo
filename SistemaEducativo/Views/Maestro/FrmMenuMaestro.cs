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
    public partial class FrmMenuMaestro : Form
    {
        public FrmLogin _frmLogin;
        private MenuMaestroController controller;

        public FrmMenuMaestro(FrmLogin frmLogin)
        {
            _frmLogin = frmLogin;

            InitializeComponent();

            controller = new MenuMaestroController(this);
        }
    }
}
