using System.Data;
using System.Data.SqlClient;

namespace DataBaseReaderProgram
{
    public partial class SeeAllUsersScreen : Form
    {
        int myCounter = 0;

        SqlConnection con;
        SqlCommand cmd;
        DataTable table = new DataTable();
        public SeeAllUsersScreen()
        {
            InitializeComponent();
            seeUsers();
        }
        string myDatabase = "data source=DESKTOP-BDGSR15\\SQLEXPRESS;initial catalog=MyApp;integrated security=true";


        private void seeUsers()
        {
            con = new SqlConnection(@myDatabase);
            string selectquery = "select dbo.userInfo.*, dbo.userMail.MailAddress from dbo.userInfo, dbo.userMail " +
                "where dbo.userInfo.Usernames = dbo.userMail.Usernames order by dbo.userInfo.UserID asc;";
            cmd = new SqlCommand(selectquery, con);
            SqlDataAdapter adpt = new SqlDataAdapter(selectquery, con);
            DataTable table = new DataTable();
            adpt.Fill(table);
            dataGridView1.DataSource = table;
            con.Close();
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
