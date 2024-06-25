
using PlayValorant.Interfaces;

namespace DataBaseReaderProgram.UserControls
{
    public partial class UserMainPage : Form
    {

        string mail;
        int myCounter;
        Implementation implementation = new Implementation();
        public UserMainPage(string mail, int myCounter)
        {
            InitializeComponent();
            this.mail = mail;
            this.myCounter = myCounter;
            if (!(myCounter % 2 == 0))
            {
                implementation.VpsAlToBuy(buyVpsButton);
                implementation.VpAlToBuy(buyVpButton);
                implementation.kacToMany(showVpsButton);
                implementation.katilToJoin(joinDiscordServerButton);
                implementation.takipToFollow(instagramButton);
                implementation.turnuvaToTournament(tournamentsButton);
                implementation.gitToOpen(goToWebsiteButton);
                implementation.iletisimToContact(contactUsButton);
                implementation.sifreToPassword(changePasswordButton);
                implementation.cikisToExit(exitButton);
            }
        }

        

        private void buyVpsButton_Click(object sender, EventArgs e)
        {
            var uri = "https://playvalorant.com.tr/index.php?route=product/category&path=223";
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = uri;
            System.Diagnostics.Process.Start(psi);
        }

        private void buyVpButton_Click(object sender, EventArgs e)
        {
            var uri = "https://playvalorant.com.tr/index.php?route=product/category&path=224";
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = uri;
            System.Diagnostics.Process.Start(psi);
        }

        private void joinDiscordServerButton_Click(object sender, EventArgs e)
        {
            var uri = "https://discord.com/invite/ZwrXWV48RN";
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = uri;
            System.Diagnostics.Process.Start(psi);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            LogInPage logInPage = new LogInPage(myCounter);
            logInPage.Show();
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            UserChangePasswordScreen userChangePasswordScreen = new UserChangePasswordScreen(mail,myCounter);
            userChangePasswordScreen.Show();
            this.Close();
        }

        private const int CP_NOCLOSE_BUTTON = 0x200;

        private void tournamentsButton_Click(object sender, EventArgs e)
        {
            var uri = "https://www.twitch.tv/valorantlivetournaments/";
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = uri;
            System.Diagnostics.Process.Start(psi);
        }

        private void instagramButton_Click(object sender, EventArgs e)
        {
            var uri = "https://www.instagram.com/playvalorantcomtr/";
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = uri;
            System.Diagnostics.Process.Start(psi);
        }

        private void contactUsButton_Click(object sender, EventArgs e)
        {
            var uri = "https://playvalorant.com.tr/index.php?route=information/contact";
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = uri;
            System.Diagnostics.Process.Start(psi);
        }

        private void goToWebsiteButton_Click(object sender, EventArgs e)
        {
            var uri = "https://playvalorant.com.tr/";
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = uri;
            System.Diagnostics.Process.Start(psi);
        }

        private void showVpsButton_Click(object sender, EventArgs e)
        {
            var uri = "https://playvalorant.com.tr/index.php?route=account/reward";
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = uri;
            System.Diagnostics.Process.Start(psi);
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
