using DataBaseReaderProgram.UserControls;
using DataBaseReaderProgram.Utilities;
using PlayValorant.Turkce.Classes;
using PlayValorant.Interfaces;
using System.Globalization;
using Newtonsoft.Json;
using System.Text;
using System.Security.Cryptography;

namespace DataBaseReaderProgram
{
    public partial class LogInPage : Form
    {

        int counter;
        public LogInPage(int counter)
        {
            InitializeComponent();
            this.counter = counter;
            getLocation();
            if (!(counter % 2 == 0))
            {
                implementation.arayuzToInterface(arayuzLabel);
                implementation.kullanıcıAdıToUsername(kullanıcıAdıLabel);
                implementation.cikisToExit(exitButton);
                implementation.girisToLogIn(logInButton);
                implementation.gosterToShow(showHide);
                implementation.sifreToPassword(sifreLabel);
                implementation.unuttunToForgot(forgotPasswordLink);
                implementation.uyeOlToSignUp(signUpButton);
                languageButtonEnglishFlag.Hide();
            }
        }

        int getLocation()
        {
            CultureInfo ci = CultureInfo.InstalledUICulture;

            if ((ci.Name).Equals("tr-TR"))
            {
                return counter = 0;
            }
            else
            {
                return counter = 1;
            }
        }

        Implementation implementation = new Implementation();


        private async void logInButton_Click(object sender, EventArgs e)
        {

            string phpAddress = "http://localhost:80/LogIn.php";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    StringContent content = new StringContent(sendCreditentials(), Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync(phpAddress, content);
                    if (mailTextbox.Text.Equals("") || passwordTextbox.Text.Equals(""))
                    {
                        mailTextbox.Clear();
                        passwordTextbox.Clear();
                        if (counter % 2 == 0)
                        {
                            MessageBox.Show("Lütfen Tüm Boşlukları Doldur!", "PlayValorant");
                        }
                        else
                        {
                            MessageBox.Show("Please Fill All Of The Blanks!", "PlayValorant");
                        }
                    }
                    else if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {

                         UserMainPage userMainPage = new UserMainPage(getMail(), getCounter());
                         userMainPage.Show();
                         this.Close();
                    }
                    else if(response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                    {
                        passwordTextbox.Clear();
                        if (counter % 2 == 0)
                        {
                            MessageBox.Show("E Posta Veya Şifren Hatalı!", "PlayValorant");
                        }
                        else
                        {
                            MessageBox.Show("Your E Mail Or Your Password Is Not Correct!", "PlayValorant");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hata Oluştu: " + ex.Message);
                }
            }


        }

        private string sendCreditentials()
        {
            LogInInfo logInData = new LogInInfo()
            {
                mail = mailTextbox.Text,
                password = hashing(passwordTextbox.Text)
            };
            string jsonData = JsonConvert.SerializeObject(logInData);
            return jsonData;
        }

        private string hashing(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha256.ComputeHash(bytes);
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            this.Close();
            SignUpPage signUpPage = new SignUpPage(counter);
            signUpPage.Show();
        }

        private void showHide_CheckedChanged(object sender, EventArgs e)
        {
            if (showHide.Checked)
            {
                passwordTextbox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordTextbox.UseSystemPasswordChar= true;
            }
        }

        private void forgotPasswordLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            ForgotPasswordPage forgotPasswordPage = new ForgotPasswordPage(counter);
            forgotPasswordPage.Show();
        }

        public string getMail()
        {
            return mailTextbox.Text;
        }

        public int getCounter()
        {
            return counter;
        }

        private const int CP_NOCLOSE_BUTTON = 0x200;

        private void languageButtonTurkishFlag_Click(object sender, EventArgs e)
        {
            counter++;
            this.Close();
            counter = 0;
            LogInPage logInPage = new LogInPage(counter);
            logInPage.Show();
        }

        private void languageButtonEnglishFlag_Click(object sender, EventArgs e)
        {
            counter++;
            implementation.arayuzToInterface(arayuzLabel);
            implementation.kullanıcıAdıToUsername(kullanıcıAdıLabel);
            implementation.cikisToExit(exitButton);
            implementation.girisToLogIn(logInButton);
            implementation.gosterToShow(showHide);
            implementation.sifreToPassword(sifreLabel);
            implementation.unuttunToForgot(forgotPasswordLink);
            implementation.uyeOlToSignUp(signUpButton);
            languageButtonEnglishFlag.Hide();
            languageButtonTurkishFlag.Show();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
    }
}
