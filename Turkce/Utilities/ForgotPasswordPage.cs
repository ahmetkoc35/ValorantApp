using System.Net.Mail;
using System.Net;
using PlayValorant.Interfaces;
using Newtonsoft.Json;
using PlayValorant.Turkce.Classes;
using System.Text;
using Newtonsoft.Json.Linq;

namespace DataBaseReaderProgram.Utilities
{
    public partial class ForgotPasswordPage : Form
    {
        int myCounter;
        Implementation implementation = new Implementation();
        public ForgotPasswordPage(int myCounter)
        {
            InitializeComponent();
            this.myCounter=myCounter;
            if (!(myCounter % 2 == 0))
            {
                implementation.postanToMail(email);
                implementation.gonderToSend(sendButton);
                implementation.geriToBack(backButton);
            }
        }


        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            LogInPage logInPage = new LogInPage(myCounter);
            logInPage.Show();
        }


        private async void sendButton_Click(object sender, EventArgs e)
        {
            string phpAddress = "http://localhost:80/ForgotPassword.php";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    StringContent content = new StringContent(sendCreditentials(), Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync(phpAddress, content);

                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        sendAnEmail();
                        emailTextbox.Clear();
                    }
                    else if (response.StatusCode == HttpStatusCode.Unauthorized)
                    {
                        if (myCounter % 2 == 0)
                        {
                            MessageBox.Show("E-Postanı Kontrol Et");
                        }
                        else
                        {
                            MessageBox.Show("Please Check Your E-Mail");
                        }
                    }
                    else
                    {
                        MessageBox.Show("aa");
                    }
                }
                catch
                {
                    MessageBox.Show("Bir Hata Oluştu, Lütfen Daha Sonra Tekrar Deneyin", "PlayValorant");
                }
            }
        }

        private string returnPassword()
        {
            string apiUrl = "http://localhost:80/ForgotPassword.php?mail=" + emailTextbox.Text;
            string apiResponse = SendGetRequest(apiUrl);

            JObject jsonResponse = JObject.Parse(apiResponse);
            string UsersPassword = jsonResponse["Passwords"].ToString();

            return UsersPassword;
        }

        private void sendAnEmail()
        {

            string usersPassword = returnPassword();
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("dataBaseReaderApp@hotmail.com");
            mailMessage.To.Add(emailTextbox.Text);
            if (myCounter % 2 == 0)
            {
                mailMessage.Subject = "--Şifren--";
                mailMessage.Body = "Merhaba, Şifreni Unuttuğunu Duyduk" +
                    " ,Tek Kullanımlık Şifren = " + usersPassword + "\nProgram İçinden Bu Şifreyi Kullanarak Şifreni Güncelleyebilirsin." +
                    "\nEğer Bu İsteği Sen Oluşturmadıysan Website Aracılığı İle İletişime Geçebilir " +
                    "Yada Bu Şifre İle Giriş Yapıp Şifreni Güncelleyebilirsin.";
            }
            else
            {
                mailMessage.Subject = "--Your Password--";
                mailMessage.Body = "Hello, We Heard That You Forgot Your Password" +
                    ", Your Diposable Password Is = " + usersPassword + "\nWith This Password You Can Change Your Password." +
                    "\nIf you didn't initiate this request through our website, you can contact us through the website. " +
                    "Alternatively, you can log in with this password and update your password.";
            }

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Host = "smtp.outlook.com";
            smtpClient.Port = 587;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential("dataBaseReaderApp@hotmail.com", "A1hmet.koc");
            smtpClient.EnableSsl = true;

            try
            {
                smtpClient.Send(mailMessage);
                if (myCounter % 2 == 0)
                {
                    MessageBox.Show("Mail Gönderildi!");
                }
                else
                {
                    MessageBox.Show("Mail Sent!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private string sendCreditentials()
        {
            ForgotPasswordInfo forgotPasswordData = new ForgotPasswordInfo()
            {
                mail = emailTextbox.Text
            };
            string jsonData = JsonConvert.SerializeObject(forgotPasswordData);
            return jsonData;
        }

        static string SendGetRequest(string url)
        {
            string result = null;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                result = reader.ReadToEnd();
            }

            return result;
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
