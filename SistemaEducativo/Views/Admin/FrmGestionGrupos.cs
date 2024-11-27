using SistemaEducativo.Controllers.AdminControllers;

namespace SistemaEducativo.Views.Maestro
{
    public partial class FrmGestionGrupos : Form
    {
        private GestionGruposController controller;
        public FrmGestionGrupos()
        {
            InitializeComponent();

            controller = new GestionGruposController(this);
        }
    }
}
