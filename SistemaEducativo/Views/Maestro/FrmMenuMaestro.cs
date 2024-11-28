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
    public partial class FrmMenuMaestro : Form
    {
        public FrmLogin _frmLogin;
        public Usuario _usuarioLogueado;
        private MenuMaestroController controller;

        public FrmMenuMaestro(FrmLogin frmLogin, Usuario usuario)
        {
            _frmLogin = frmLogin;
            _usuarioLogueado = usuario;

            InitializeComponent();

            controller = new MenuMaestroController(this);
        }
    }
}
