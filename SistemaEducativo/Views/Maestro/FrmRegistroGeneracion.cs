﻿using SistemaEducativo.Controllers.MaestroControllers;
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
    public partial class FrmRegistroGeneracion : Form
    {
        private RegistroGeneracionController registroGeneracionController;
        public FrmRegistroGeneracion()
        {
            InitializeComponent();

            registroGeneracionController = new RegistroGeneracionController(this);
        }
    }
}