using SistemaEducativo.Controllers.AdminControllers;
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
    public partial class FrmGestionUsuarios : Form
    {
        private GestionUsuariosController controller;
        public FrmGestionUsuarios()
        {
            InitializeComponent();

            controller = new GestionUsuariosController(this);
        }
    }
}
