using SistemaEducativo.Controllers.AdminControllers;
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

namespace SistemaEducativo.Views.Admin
{
    public partial class FrmMenuAdmin : Form
    {
        public FrmLogin _frmLogin;
        public Usuario _usuarioLogueado;
        private MenuAdminController controller;

        public FrmMenuAdmin(FrmLogin frmLogin, Usuario usuario)
        {
            _frmLogin = frmLogin;
            _usuarioLogueado = usuario;

            InitializeComponent();

            controller = new MenuAdminController(this);
        }
    }
}
