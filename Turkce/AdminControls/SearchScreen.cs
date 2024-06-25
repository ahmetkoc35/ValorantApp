using System.Data;
using System.Data.SqlClient;


namespace DataBaseReaderProgram
{
    public partial class SearchScreen : Form
    {

        int myCounter = 0;

        public SearchScreen()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;
        DataTable table = new DataTable();
        string myDatabase = "data source=DESKTOP-BDGSR15\\SQLEXPRESS;initial catalog=MyApp;integrated security=true";


        private void searchButton_Click(object sender, EventArgs e)
        {

            if (searchCombobox.SelectedIndex == 1)
            {
                serachByUsername();
            }
            else if (searchCombobox.SelectedIndex == 0)
            {
                searchByID();
            }
            else
            {
                searchByID();
            }
        }

        private void serachByUsername()

        {
            con = new SqlConnection(@myDatabase);
            string selectquery;

            if (userList().Contains(usernameTextbox.Text))
            {
                selectquery = "select * from dbo.UserInfo where Usernames = '" + usernameTextbox.Text + "'";
                cmd = new SqlCommand(selectquery, con);
                SqlDataAdapter adpt = new SqlDataAdapter(selectquery, con);
                DataTable table = new DataTable();
                adpt.Fill(table);
                dataGridView1.DataSource = table;
                usernameTextbox.Clear();
                MessageBox.Show("User Exists");
            }
            else
            {
                MessageBox.Show("User Does Not Exists");
            }
            con.Close();
        }

        private void searchByID()
        {
            con = new SqlConnection(@myDatabase);
            string selectquery;

            if (userIdList().Contains(usernameTextbox.Text))
            {
                selectquery = "select * from dbo.UserInfo where UserID = '" + usernameTextbox.Text + "'";
                cmd = new SqlCommand(selectquery, con);
                SqlDataAdapter adpt = new SqlDataAdapter(selectquery, con);
                DataTable table = new DataTable();
                adpt.Fill(table);
                dataGridView1.DataSource = table;
                usernameTextbox.Clear();
                MessageBox.Show("User Exists");
            }
            else
            {
                MessageBox.Show("User Does Not Exists");
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

        private List<string> userIdList()
        {
            List<string> columnData = new List<string>();

            using (SqlConnection connection = new SqlConnection(@myDatabase))
            {
                connection.Open();
                string query = "SELECT UserID FROM dbo.UserInfo";
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

        private void backButton_Click(object sender, EventArgs e)
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
