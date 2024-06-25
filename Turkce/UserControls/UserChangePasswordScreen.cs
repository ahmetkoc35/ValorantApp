using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PlayValorant.Interfaces;
using PlayValorant.Turkce.Classes;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Security.Cryptography;
using System.Text;

namespace DataBaseReaderProgram.UserControls
{
    public partial class UserChangePasswordScreen : Form
    {

        string mail;
        int myCounter;
        Implementation implementation = new Implementation();

        public UserChangePasswordScreen(string mail, int myCounter)
        {
            InitializeComponent();
            this.mail=mail;
            this.myCounter=myCounter;
            if (!(myCounter % 2 == 0))
            {
                implementation.eskiToOld(oldPassword);
                implementation.yeniToNew(newPassword);
                implementation.yeniToNew(newPasswordAgain);
                implementation.degistirToChange(changeButton);
                implementation.geriToBack(backButton);
            }
        }


        private async void changeButton_Click(object sender, EventArgs e)
        {
            string phpAddress = "http://localhost:80/ChangePassword.php";

            if (newPasswordTextbox.Text.Equals(checkPasswordTextbox.Text))
            {
                using (HttpClient client = new HttpClient())
                {
                    try
                    {
                        StringContent content = new StringContent(sendCreditentials(), Encoding.UTF8, "application/json");
                        HttpResponseMessage response = await client.PostAsync(phpAddress, content);

                        if (response.StatusCode == HttpStatusCode.OK)
                        {
                            if (myCounter % 2 == 0)
                            {
                                MessageBox.Show("Şifren Değiştirildi!");
                            }
                            else
                            {
                                MessageBox.Show("Your Password Has Been Changed!", "PlayValorant");
                            }
                            oldPasswordTextbox.Clear();
                            newPasswordTextbox.Clear();
                            checkPasswordTextbox.Clear();
                        }
                        else if (response.StatusCode == HttpStatusCode.Unauthorized)
                        {
                            if (myCounter % 2 == 0)
                            {
                                
                                MessageBox.Show("Eski Şifreni Kontrol Etmelisin!-------" + returnPassword() + "--------" + hashing(oldPasswordTextbox.Text), "PlayValorant");
                            }
                            else
                            {
                                MessageBox.Show("You Have To Check Your Old Password!", "PlayValorant");
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Bir Hata Oluştu, Lütfen Daha Sonra Tekrar Deneyin", "PlayValorant");
                    }
                }
            }
            else
            {
                if (myCounter % 2 == 0)
                {
                    MessageBox.Show("Lütfen Yeni Şifreleri Kontrol Et!", "PlayValorant");

                }
                else
                {
                    MessageBox.Show("Please Check The New Passwords!", "PlayValorant");
                }
                checkPasswordTextbox.Clear();
            }
            
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

        private string sendCreditentials()
        {
            ChangePasswordInfo changePasswordData = new ChangePasswordInfo()
            {
                userMail = mail,
                oldPassword = hashing(oldPasswordTextbox.Text),
                newPassword = hashing(newPasswordTextbox.Text)
            };
            string jsonData = JsonConvert.SerializeObject(changePasswordData);
            return jsonData;
        }

        private string returnPassword()
        {
            string apiUrl = "http://localhost:80/ChangePassword.php?mail=" + mail;
            string apiResponse = SendGetRequest(apiUrl);

            JObject jsonResponse = JObject.Parse(apiResponse);
            string UsersPassword = jsonResponse["Passwords"].ToString();

            return UsersPassword;
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

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            UserMainPage userMainPage = new UserMainPage(mail, myCounter);
            userMainPage.Show();
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
