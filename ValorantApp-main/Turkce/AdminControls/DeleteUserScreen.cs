using System.Data;
using System.Data.SqlClient;


namespace DataBaseReaderProgram
{
    public partial class DeleteUserScreen : Form
    {
        int myCounter = 0;
        public DeleteUserScreen()
        {
            InitializeComponent();
            deleteUser();
        }

        SqlConnection con;
        SqlCommand cmdFirst;
        SqlCommand cmdSecond;
        DataTable table = new DataTable();
        string myDatabase = "data source=DESKTOP-BDGSR15\\SQLEXPRESS;initial catalog=MyApp;integrated security=true";

        void deleteUser()
        {
            con = new SqlConnection(@myDatabase);
            string selectQuery = "select dbo.userInfo.*, dbo.userMail.MailAddress from dbo.userInfo, " +
                "dbo.userMail where dbo.userInfo.Usernames = dbo.userMail.Usernames order by dbo.userInfo.UserID asc";
            cmdFirst = new SqlCommand(selectQuery, con);
            SqlDataAdapter adpt = new SqlDataAdapter(selectQuery, con);
            DataTable table1 = new DataTable();
            adpt.Fill(table1);
            dataGridView1.DataSource = table1;
            con.Close();
        }
        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@myDatabase);
            string deleteQuery = "delete from dbo.userInfo where Usernames = '" + deleteUserTextbox.Text + "'" +
                                 "delete from dbo.userMail where Usernames = '" + deleteUserTextbox.Text + "'";

            if (userList().Contains(deleteUserTextbox.Text))
            {
                cmdSecond = new SqlCommand(deleteQuery, con);
                SqlDataAdapter adpt2 = new SqlDataAdapter(deleteQuery, con);
                DataTable table2 = new DataTable();
                adpt2.Fill(table2);
                string selectQuery = "select dbo.userInfo.*, dbo.userMail.MailAddress from dbo.userInfo, " +
                "dbo.userMail where dbo.userInfo.Usernames = dbo.userMail.Usernames order by dbo.userInfo.UserID asc";
                adpt2 = new SqlDataAdapter(selectQuery, con);
                DataTable table3 = new DataTable();
                adpt2.Fill(table3);
                dataGridView2.DataSource = table3;
                dataGridView1.Hide();

                MessageBox.Show("User Deleted");
                deleteUserTextbox.Clear();
            }
            else
            {
                MessageBox.Show(deleteUserTextbox.Text + " Does Not In The Database");
            }
            con.Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminMainPage adminMainPage = new AdminMainPage(myCounter);
            adminMainPage.Show();
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
