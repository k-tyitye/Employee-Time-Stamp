using Microsoft.Office.Interop.Access.Dao;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GuiEmployeeDatabase
{
    public partial class MainMenu : Form
    {

        protected string? currentUserID;

        public MainMenu()
        {
            currentUserID = null;
            InitializeComponent();
        }
        
        private void SignInButton(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Users\\ggxdi\\Desktop\\Senior Project\\GuiEmployeeDatabase\\Resources\\EmployeeDatabase.accdb");
            OleDbDataAdapter sda = new OleDbDataAdapter("select count(*) from tblEmployees where Emp_Username='" + textBox1.Text + "' and Emp_Password='" + textBox2.Text + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();

                bool foundID = getUserID(textBox1.Text, textBox2.Text);

                if (!foundID)
                {
                    MessageBox.Show("User Not Found", "alert", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    System.Environment.Exit(0);
                }

                if (currentUserID != null)
                {
                    TimeStampChoices timeStampChoices = new TimeStampChoices(currentUserID);
                    timeStampChoices.Show();
                }
            }
            else
            {
                MessageBox.Show("Please enter correct username and password", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool getUserID(string user, string pass)
        {
            bool foundRecordSuccessfully = false;

            OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\ggxdi\\Desktop\\Senior Project\\GuiEmployeeDatabase\\Resources\\EmployeeDatabase.accdb");

            OleDbCommand cmd = new OleDbCommand("SELECT * FROM tblEmployees WHERE Emp_Username = @name AND Emp_Password = @pass", connection);
            cmd.Parameters.AddWithValue("@name", user);
            cmd.Parameters.AddWithValue("@pass", pass);
            connection.Open();

            DataTable dt = new DataTable();
            OleDbDataAdapter ad = new OleDbDataAdapter(cmd);
            ad.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                currentUserID = dt.Rows[0]["Emp_ID"].ToString();
                textBox1.Text = currentUserID; //Flag
                foundRecordSuccessfully = true;
            }
            else
            {
                MessageBox.Show("NO RECORD WAS FOUND!", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            connection.Close();
            
            return foundRecordSuccessfully;
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