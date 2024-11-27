using SistemaEducativo.Controllers.AdminControllers;

namespace SistemaEducativo.Views.Admin
{
    public partial class FrmGestionMaterias : Form
    {
        private GestionMateriasController controller;

        public FrmGestionMaterias()
        {
            InitializeComponent();

            controller = new GestionMateriasController(this);
        }
    }
}
