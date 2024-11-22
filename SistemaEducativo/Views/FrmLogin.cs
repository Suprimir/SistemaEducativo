using SistemaEducativo.Controllers;

namespace SistemaEducativo
{
    public partial class FrmLogin : Form
    {
        private LoginController _loginController;
        public FrmLogin()
        {
            InitializeComponent();

            _loginController = new LoginController(this);
        }
    }
}
