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
    public partial class FrmAsignarMateria : Form
    {
        private AsignarMateriaController controller;

        public FrmAsignarMateria(List<Materia> lstMaterias)
        {
            InitializeComponent();

            controller = new AsignarMateriaController(this, lstMaterias);
        }
    }
}
