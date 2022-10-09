namespace GuiEmployeeDatabase
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        /*POSSIBLY CHANGE JUST FOR TEST*/
        private void SignInButton(object sender, EventArgs e)
        {
            this.Hide();
            TimeStampChoices timeStampChoices = new TimeStampChoices();
            timeStampChoices.Show();
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HelpPage helpPage = new HelpPage();
            helpPage.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ForgotUsername forgotUsername = new ForgotUsername();
            forgotUsername.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.Show();
        }
    }
}