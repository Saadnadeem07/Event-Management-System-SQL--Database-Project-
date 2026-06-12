using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace project2
{
    public partial class eventcreation2 : Form
    {
        string conStr = "DATA SOURCE=localhost:1521/xe;USER ID=SAAD;PASSWORD=7223";
        OracleConnection con;

        public eventcreation2()
        {
            InitializeComponent();

            // Initialize the OracleConnection
            con = new OracleConnection(conStr);
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) &&
                !string.IsNullOrEmpty(textBox2.Text) &&
                !string.IsNullOrEmpty(textBox3.Text) &&
                !string.IsNullOrEmpty(textBox4.Text) &&
                !string.IsNullOrEmpty(textBox5.Text))  // assuming textBox5 is used for EVENT_ID input
            {
                try
                {
                    con.Open();

                    using (OracleCommand insertEvent = con.CreateCommand())
                    {

                        insertEvent.CommandText = "INSERT INTO EVENT " +
                         "(EVENT_ID, EVENTNAME, EVENT_DATE, EVENT_TIME, LOCATION) " +
                         "VALUES " +
                         "(:eventId, :eventName, :eventDate, :eventTime, :location)";

                        insertEvent.Parameters.Add(":eventId", OracleDbType.Int32).Value = int.Parse(textBox5.Text);
                        insertEvent.Parameters.Add(":eventName", OracleDbType.Varchar2).Value = textBox1.Text;
                        insertEvent.Parameters.Add(":eventDate", OracleDbType.Date).Value = DateTime.Parse(textBox2.Text);
                        insertEvent.Parameters.Add(":eventTime", OracleDbType.TimeStamp).Value = DateTime.Parse(textBox3.Text);
                        insertEvent.Parameters.Add(":location", OracleDbType.Varchar2).Value = textBox4.Text;

                        int rows = insertEvent.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Event Created Successfully");
                            // Optionally, update any UI elements or grid after successful insertion
                        }
                        else
                        {
                            MessageBox.Show("No rows affected. Insertion might have failed.");
                        }
                    }
                }
                catch (FormatException ex)
                {
                    MessageBox.Show($"Invalid input for {ex.TargetSite.Name}. Please enter valid data.");
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Error while inserting data: " + ex.Message);
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
            }
            else
            {
                MessageBox.Show("Please fill all the inputs");
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (button2 != null)
            {
                new eventcreation().Show();
                this.Hide();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
