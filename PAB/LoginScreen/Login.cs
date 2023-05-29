using ReaLTaiizor.Forms;
using PAB.LoginScreen;

namespace PAB
{
    public partial class Login : MetroForm
    {
        private string _connectionString = "Server=DESKTOP-C9F8288;Database=Docu;Integrated Security=True;Encrypt=False;";

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void CenterControlHorizontally(Control control)
        {
            control.Anchor = AnchorStyles.None;

            int formCenterX = this.Width / 2;
            int controlCenterX = control.Width / 2;

            int left = formCenterX - controlCenterX;

            control.Left = left;
        }

        private void bntLogin_Click(object sender, EventArgs e)
        {
            string alias = txtId.Text;
            string password = txtPassword.Text;

            LoginDAO loginDAO = new LoginDAO(_connectionString);
            bool isLoginValid = loginDAO.CheckLoginData(alias, password);
            MessageBox.Show(isLoginValid == true ? "ok" : "nok");



        }

        
    }
}