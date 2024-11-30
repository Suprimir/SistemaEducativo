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
    public partial class FrmRegistroMateria : Form
    {
        private RegistroMateriaController controller;

        public FrmRegistroMateria(Materia materia)
        {
            InitializeComponent();
            
            controller = new RegistroMateriaController(this, materia);
        }
    }
}
