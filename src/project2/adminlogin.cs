using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace project2
{
    public partial class adminlogin : Form
    {
        // Assuming connectionString is the connection string to your database
        // private string connectionString = "Your_Connection_String_Here";
        string conStr = "DATA SOURCE=localhost:1521/xe;USER ID=SAAD;PASSWORD=7223";
        OracleConnection con;

        public adminlogin()
        {
            InitializeComponent();
            con = new OracleConnection(conStr);
            updateGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if username and password are entered
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Enter username and password");
            }
            else
            {
                // Validate the credentials against the Oracle database
                if (ValidateCredentials(textBox1.Text, textBox2.Text))
                {
                    MessageBox.Show("Login Successful");
                    // Redirect to the next form or perform other actions
                    new eventcreation().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }
            }
        }

        private bool ValidateCredentials(string username, string password)
        {
            using (OracleCommand cmd = new OracleCommand("SELECT * FROM admin WHERE username = :username AND password = :password", con))
            {
                // Use parameters to prevent SQL injection
                cmd.Parameters.Add("username", OracleDbType.Varchar2).Value = username;
                cmd.Parameters.Add("password", OracleDbType.Varchar2).Value = password;
                //if(con != null)
                //{
                //    con = null;
                //}
                con.Open();
                using (OracleDataReader reader = cmd.ExecuteReader())
                {
                    return reader.HasRows;
                }
            }
        }

        private void updateGrid()
        {
            // Add logic to update the grid if needed
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button1.Enabled)
            {
                new mainform().Show();
                this.Hide();
            }
        }

        // ... Rest of your code
    }
}
