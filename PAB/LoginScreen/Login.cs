using ReaLTaiizor.Forms;
using PAB.LoginScreen;
using PAB.MainWindow;

namespace PAB
{
    public partial class Login : MetroForm
    {
        private ILoginDAO LoginDAO { get; set; }
        private GeneralMenu GeneralMenu { get; set; }

        public Login(ILoginDAO loginDAO,GeneralMenu generalMenu)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.LoginDAO = loginDAO;
            this.GeneralMenu = generalMenu;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }


        private void bntLogin_Click(object sender, EventArgs e)
        {
            string alias = txtId.Text;
            string password = txtPassword.Text;
            bool isLoginValid = LoginDAO.CheckLoginData(alias, password);
            if (isLoginValid)
            {
                this.Hide();
                GeneralMenu.Closed += (s, args) => this.Close();
                GeneralMenu.Show();
            }
            else
            {
                MessageBox.Show("Inccorect username or password");
            }



        }

 
    }
}