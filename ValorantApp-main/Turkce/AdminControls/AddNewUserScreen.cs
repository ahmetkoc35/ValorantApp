using System.Data;
using System.Data.SqlClient;


namespace DataBaseReaderProgram
{
    public partial class AddNewUserScreen : Form
    {
        int myCounter = 0;
        public AddNewUserScreen()
        {
            InitializeComponent();
            addUser();
        }

        SqlConnection con;
        SqlCommand cmdFirst;
        SqlCommand cmdSecond;
        DataTable table = new DataTable();
        string myDatabase = "data source=DESKTOP-BDGSR15\\SQLEXPRESS;initial catalog=MyApp;integrated security=true";

        void addUser()
        {
            con = new SqlConnection(@myDatabase);
            string selectQuery = "select dbo.userInfo.*, dbo.userMail.MailAddress from dbo.userInfo, " +
                "dbo.userMail where dbo.userInfo.Usernames = dbo.userMail.Usernames order by dbo.userInfo.UserID asc";
            cmdFirst = new SqlCommand(selectQuery, con);
            SqlDataAdapter adpt = new SqlDataAdapter(selectQuery, con);
            DataTable table1 = new DataTable();
            adpt.Fill(table1);
            dataGridView1.DataSource = table1;
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            addingUser();
        }

        private void addingUser()
        {
            con = new SqlConnection(@myDatabase);
            int userCount = userIdList()+1;
            string addUser = "insert into dbo.userInfo values (" + userCount + ", '" + enterUsernameTextbox.Text +
                                             "', '" + enterPasswordTextbox.Text + "', 'User' ); insert into " +
                                             "dbo.userMail values ('" + enterUsernameTextbox.Text + "', '" +
                                             mailTextbox.Text + "')";
            if (userList().Contains(enterUsernameTextbox.Text))
            {
                MessageBox.Show("Username Already Exists");
            }
            else if (enterUsernameTextbox.Text.Length < 3)
            {
                MessageBox.Show("Username Is Too Short");
                enterUsernameTextbox.Clear();
            }
            else if (enterUsernameTextbox.Text.Length > 30)
            {
                MessageBox.Show("Username Is Too Long");
                enterUsernameTextbox.Clear();
            }
            else
            {
                cmdSecond = new SqlCommand(addUser, con);
                SqlDataAdapter adpt2 = new SqlDataAdapter(addUser, con);
                DataTable table2 = new DataTable();
                adpt2.Fill(table2);
                string selectQuery = "select dbo.userInfo.*, dbo.userMail.MailAddress from dbo.userInfo, " +
                    "dbo.userMail where dbo.userInfo.Usernames = dbo.userMail.Usernames order by " +
                    "dbo.userInfo.UserID asc";
                adpt2 = new SqlDataAdapter(selectQuery, con);
                DataTable table3 = new DataTable();
                adpt2.Fill(table3);
                dataGridView2.DataSource = table3;
                dataGridView1.Hide();
                MessageBox.Show("User Added");
                enterUsernameTextbox.Clear();
                enterPasswordTextbox.Clear();
            }
            con.Close();
        }

        private List<string> userList()
        {
            List<String> columnData = new List<String>();

            using (SqlConnection connection = new SqlConnection(@myDatabase))
            {
                connection.Open();
                string query = "SELECT Usernames FROM dbo.UserInfo";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            columnData.Add(reader.GetString(0));
                        }
                    }
                }
                connection.Close();
            }
            return columnData;
        }

        private int userIdList()
        {
            int columnData = 0;

            using (SqlConnection connection = new SqlConnection(@myDatabase))
            {
                connection.Open();
                string query = "SELECT MAX(UserID) FROM dbo.UserInfo";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            columnData = int.Parse(reader.GetString(0));
                        }
                    }
                }
                connection.Close();
            }
            return columnData;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminMainPage adminMainPage = new AdminMainPage(myCounter);
            adminMainPage.Show();
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
