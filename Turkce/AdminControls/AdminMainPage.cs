using DataBaseReaderProgram.AdminControls;

namespace DataBaseReaderProgram
{
    public partial class AdminMainPage : Form
    {
        int myCounter = 0;
        public AdminMainPage(int myCounter)
        {
            InitializeComponent();
            this.myCounter=myCounter;
        }


        private void searchButton_Click(object sender, EventArgs e)
        {
            this.Close();
            SearchScreen screen = new SearchScreen();
            screen.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            LogInPage logInPage = new LogInPage(myCounter);
            logInPage.Show();
        }

        private void addNewUserButton_Click(object sender, EventArgs e)
        {
            this.Close();
            AddNewUserScreen screen = new AddNewUserScreen();
            screen.Show();
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            this.Close();
            DeleteUserScreen screen = new DeleteUserScreen();
            screen.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            SeeAllUsersScreen screen = new SeeAllUsersScreen();
            screen.Show();
        }

        private void setPasswordButton_Click(object sender, EventArgs e)
        {
            this.Close();
            SetPasswordScreen screen = new SetPasswordScreen();
            screen.Show();
        }

        private void setUserRank_Click(object sender, EventArgs e)
        {
            this.Close();
            SetRankScreen screen = new SetRankScreen();
            screen.Show();
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