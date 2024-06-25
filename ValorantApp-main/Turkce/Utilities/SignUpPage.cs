using Newtonsoft.Json;
using PlayValorant.Interfaces;
using PlayValorant.Turkce.Classes;
using System.Text;
using System.Security.Cryptography;

namespace DataBaseReaderProgram
{
    public partial class SignUpPage : Form
    {
        int myCounter;
        Implementation implementation = new Implementation();
        public SignUpPage(int myCounter)
        {
            InitializeComponent();
            this.myCounter=myCounter;

            if (!(myCounter % 2 == 0))
            {
                implementation.sifreToPassword(password);
                implementation.postaToMail(email);
                implementation.sifreToPassword(passwordCheck);
                implementation.gosterToShow(passwordCheckbox);
                implementation.gosterToShow(passwordAgainCheckox);
                implementation.kaydolToSignUp(continueButton);
                implementation.geriToBack(backButton);
            }
        }


        private void continueButton_Click(object sender, EventArgs e)
        {
            if (myCounter % 2 == 0)
            {
                continueTurkish();
            }
            else
            {
                continueEnglish();
            }
        }

        private async void continueTurkish()
        {
            string phpAddress = "http://localhost:80/SignUp.php";

            if (!passwordCheckTextbox.Text.Equals(passwordTextbox.Text))
            {
                MessageBox.Show("Şifreler Aynı Değil!", "PlayValorant");
            }
            else
            {
                using (HttpClient client = new HttpClient())
                {
                    try
                    {
                        StringContent content = new StringContent(sendCreditentials(), Encoding.UTF8, "application/json");
                        HttpResponseMessage response = await client.PostAsync(phpAddress, content);

                        if (mailTextbox.Text.Equals("") || passwordTextbox.Text.Equals(""))
                        {
                            MessageBox.Show("Lütfen Tüm Boşlukları Doldurun!", "PlayValorant");
                        }
                        if (passwordCheckTextbox.Text.Equals(passwordTextbox.Text))
                        {
                            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                            {
                                MessageBox.Show("Başarıyla Kayıt Oldunuz!", "PlayValorant");
                            }
                            else if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                            {
                                MessageBox.Show("E Posta Zaten Kayıtlı!");
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Bir Hata Oluştu, Lütfen Daha Sonra Tekrar Deneyin", "PlayValorant");
                    }
                }
            }
        }
        private async void continueEnglish()
        {
            if (!passwordTextbox.Text.Equals(passwordCheckTextbox.Text))
            {
                Console.WriteLine("Passwords Are Not Equal", "PlayValorant");
            }
            else
            {
                string phpAddress = "http://localhost:80/SignUp.php";

                using (HttpClient client = new HttpClient())
                {
                    try
                    {
                        StringContent content = new StringContent(sendCreditentials(), Encoding.UTF8, "application/json");
                        HttpResponseMessage response = await client.PostAsync(phpAddress, content);
                        if (mailTextbox.Text.Equals("") || passwordTextbox.Text.Equals(""))
                        {

                            MessageBox.Show("Please Fill All Of The Blanks!", "PlayValorant");

                        }
                        else if (response.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            MessageBox.Show("You Have Signed Up Successfully", "PlayValorant");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("There Was An Error, Please Try Again Later", "PlayValorant");
                    }
                }
            }
        }

        private string getUserMail()
        {
            string getMail = "";

            if (emailCombobox.SelectedIndex > -1)
            {
                getMail += mailTextbox.Text + emailCombobox.SelectedItem.ToString();
            }
            else
            {
                getMail += mailTextbox.Text + "@hotmail.com";
            }
            return getMail;
        }

        private string sendCreditentials()
        {
            string getMail = getUserMail();
            SignUpInfo signUpdata = new SignUpInfo()
            {
                mail = getMail,
                password = hashing(passwordTextbox.Text)
            };
            string jsonData = JsonConvert.SerializeObject(signUpdata);
            return jsonData;
        }

        private static string hashing(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha256.ComputeHash(bytes);
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            LogInPage logInPage = new LogInPage(myCounter);
            logInPage.Show();
        }

        private void passwordCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (passwordCheckbox.Checked)
            {
                passwordTextbox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordTextbox.UseSystemPasswordChar= true;
            }
        }

        private void passwordAgainCheckox_CheckedChanged(object sender, EventArgs e)
        {
            if (passwordAgainCheckox.Checked)
            {
                passwordCheckTextbox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordCheckTextbox.UseSystemPasswordChar= true;
            }
        }

        private const int CP_NOCLOSE_BUTTON = 0x200;


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
