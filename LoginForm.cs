using SCD_LAB_W14.Admin;
using SCD_LAB_W14.Classes;

namespace SCD_LAB_W14
{
    public partial class LoginForm : Form
    {
        LoginDTO[] logincreds;
        
        public LoginForm()
        {
            InitializeComponent();
            logincreds = new LoginDTO[5];

            for (int i = 0; i < logincreds.Length; i++)
            {
                logincreds[i] = new LoginDTO();
            }
            //Users
            logincreds[0].Username = "U1";
            logincreds[0].Password = "U1P";
            logincreds[1].Username = "U2";
            logincreds[1].Password = "U2P";
            logincreds[2].Username = "U3";
            logincreds[2].Password = "U3P";
            logincreds[3].Username = "U4";
            logincreds[3].Password = "U4P";
            //Admin
            logincreds[4].Username = "A1";
            logincreds[4].Password = "A1P";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            bool loginFlag = false;
            if (txt_username.Text.ToString().Equals("") || txt_password.Text.ToString().Equals(""))
            {
                MessageBox.Show("Invalid Login Credientials", "Error");
            }
            else
            {
                for(int i = 0; i < (logincreds.Length - 1); i++) //for possible users
                {
                    if(txt_username.Text.ToString().Equals(logincreds[i].Username) && txt_password.Text.ToString().Equals(logincreds[i].Password))
                    {
                        MessageBox.Show("Welcome User " + logincreds[i].Username);
                        UserMainForm UMF = new UserMainForm(logincreds[i]);
                        this.Hide();
                        UMF.Show();
                        loginFlag = true;
                    }
                }

                if(loginFlag == false) //for admin
                {
                    if (txt_username.Text.ToString().Equals(logincreds[4].Username) && txt_password.Text.ToString().Equals(logincreds[4].Password))
                    {
                        MessageBox.Show("Welcome Admin " + logincreds[4].Username);
                        AdminMainForm AMF = new AdminMainForm();
                        this.Hide();
                        AMF.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Login Credientials", "Error");
                    }
                }
            }
        }
    }
}