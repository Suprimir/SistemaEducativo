﻿using SistemaEducativo.Controllers.AdminControllers;
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
    public partial class FrmRegistroUsuario : Form
    {
        private RegistroUsuarioController controller;

        public FrmRegistroUsuario(Usuario usuario)
        {
            InitializeComponent();

            controller = new RegistroUsuarioController(this, usuario);
        }
    }
}
