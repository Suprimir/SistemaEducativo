using SistemaEducativo.Controllers;
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

namespace SistemaEducativo.Views
{
    public partial class FrmTareaPreview : Form
    {
        private TareaPreviewController controller;

        public FrmTareaPreview(TareaPorAlumno tarea)
        {
            InitializeComponent();

            controller = new TareaPreviewController(this, tarea);
        }
    }
}
