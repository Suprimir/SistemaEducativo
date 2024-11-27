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
        public Materia? _materiaSeleccionada;

        public FrmRegistroMateria(Materia? materiaSeleccionada)
        {
            InitializeComponent();

            _materiaSeleccionada = materiaSeleccionada;
            
            controller = new RegistroMateriaController(this);
        }
    }
}
