using SistemaEducativo.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEducativo.Views
{
    public partial class FrmConfiguracionPerfil : Form
    {
        private ConfiguracionPerfilController controller;

        public FrmConfiguracionPerfil()
        {
            InitializeComponent();

            controller = new ConfiguracionPerfilController(this);
        }
    }
}
