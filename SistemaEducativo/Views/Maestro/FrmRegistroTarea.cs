﻿using SistemaEducativo.Controllers.MaestroControllers;
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
    public partial class FrmRegistroTarea : Form
    {
        public RegistroTareaController controller;

        public FrmRegistroTarea(GrupoProfesor grupo, Tarea tarea)
        {
            InitializeComponent();

            controller = new RegistroTareaController(this, grupo, tarea);
        }
    }
}
