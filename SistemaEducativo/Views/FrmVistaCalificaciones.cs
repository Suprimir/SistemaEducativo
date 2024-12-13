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

namespace SistemaEducativo.Views.Alumno
{
    public partial class FrmVistaCalificaciones : Form
    {
        private VistaCalificacionesController controller;
        public FrmVistaCalificaciones(Form? form, Usuario usuario, string? materiaNombre)
        {
            InitializeComponent();

            controller = new VistaCalificacionesController(this, form, usuario, materiaNombre);
        }
    }
}
