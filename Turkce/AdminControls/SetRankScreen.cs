using System.Data;
using System.Data.SqlClient;

namespace DataBaseReaderProgram.AdminControls
{
    public partial class SetRankScreen : Form
    {

        int myCounter = 0;

        public SetRankScreen()
        {
            InitializeComponent();
            showUsers();
        }

        SqlConnection con;
        SqlCommand cmdFirst;
        SqlCommand cmdSecond;
        DataTable table = new DataTable();
        string myDatabase = "data source=DESKTOP-BDGSR15\\SQLEXPRESS;initial catalog=MyApp;integrated security=true";

        void showUsers()
        {
            con = new SqlConnection(@myDatabase);
            string selectQuery = "select * from dbo.UserInfo";
            cmdFirst = new SqlCommand(selectQuery, con);
            SqlDataAdapter adpt = new SqlDataAdapter(selectQuery, con);
            DataTable table1 = new DataTable();
            adpt.Fill(table1);
            dataGridView1.DataSource = table1;
            con.Close();
        }

        private void setRankButton_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@myDatabase);
            string setRank = "update dbo.userInfo set userRank = '"
                + rankSelectionComboBox.Text + "' where Usernames = '"
                + usernameSetRankTextbox.Text + "'";
            if (!userList().Contains(usernameSetRankTextbox.Text))
            {
                MessageBox.Show("Username Does Not Exists");
            }
            else
            {
                cmdSecond = new SqlCommand(setRank, con);
                SqlDataAdapter adpt2 = new SqlDataAdapter(setRank, con);
                DataTable table2 = new DataTable();
                adpt2.Fill(table2);


                string selectQuery = "select * from dbo.UserInfo";
                adpt2 = new SqlDataAdapter(selectQuery, con);
                DataTable table3 = new DataTable();
                adpt2.Fill(table3);
                dataGridView2.DataSource = table3;
                dataGridView1.Hide();

                MessageBox.Show("Rank Changed");
                usernameSetRankTextbox.Clear();
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
