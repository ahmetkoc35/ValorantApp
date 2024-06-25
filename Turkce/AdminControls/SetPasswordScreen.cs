using System.Data;
using System.Data.SqlClient;
namespace DataBaseReaderProgram
{
    public partial class SetPasswordScreen : Form
    {
        int myCounter = 0;

        public SetPasswordScreen()
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



        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@myDatabase);
            if ((newPasswordCheckText.Text).Equals(newPasswordText.Text))
            {
                string newPassword = "update dbo.userInfo set Passwords = '" + newPasswordText.Text + "' where Usernames = '" + userPasswordText.Text + "'";
                cmdFirst = new SqlCommand(newPassword, con);
                SqlDataAdapter adpt2 = new SqlDataAdapter(newPassword, con);
                DataTable table2 = new DataTable();
                adpt2.Fill(table2);

                string selectQuery = "select * from dbo.UserInfo";
                adpt2 = new SqlDataAdapter(selectQuery, con);
                DataTable table3 = new DataTable();
                adpt2.Fill(table3);
                dataGridView2.DataSource = table3;
                dataGridView1.Hide();
                MessageBox.Show("Password Changed!");
                userPasswordText.Clear();
                newPasswordText.Clear();
                newPasswordCheckText.Clear();
            }
            else
            {
                MessageBox.Show("Please Check Passwords!");
                newPasswordText.Clear();
                newPasswordCheckText.Clear();
            }
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
