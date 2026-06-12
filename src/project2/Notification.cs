using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace project2
{
    public partial class Notification : Form
    {
        // Add your connection string here
        string conStr = "User Id=SAAD;Password=7223;Data Source=localhost:1521/xe";
        // Assuming participantId is a class-level variable
        int participantId;

        public Notification()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new eventcreation().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Parse the dates from the TextBox controls
                if (DateTime.TryParse(date1.Text, out DateTime startDate) && DateTime.TryParse(date2.Text, out DateTime endDate))
                {
                    using (OracleConnection oracleConnection = new OracleConnection(conStr))
                    {
                        oracleConnection.Open();

                        using (OracleCommand getEventId = oracleConnection.CreateCommand())
                        {
                            // Select event_id from event where date between startDate and endDate
                            getEventId.CommandText = "SELECT event_id FROM event WHERE event_date BETWEEN :startDate AND :endDate";
                            getEventId.Parameters.Add(":startDate", OracleDbType.Date).Value = startDate;
                            getEventId.Parameters.Add(":endDate", OracleDbType.Date).Value = endDate;

                            OracleDataReader reader = getEventId.ExecuteReader();

                            while (reader.Read())
                            {
                                int eventId = reader.GetInt32(0);

                                // Insert into notification table
                                using (OracleCommand insertNotification = oracleConnection.CreateCommand())
                                {
                                    insertNotification.CommandText = "INSERT INTO notification (notification_id, participant_id, event_id) VALUES (notification_seq.nextval, :participantId, :eventId)";
                                    insertNotification.Parameters.Add(":participantId", OracleDbType.Int32).Value = participantId; // Use the participantId variable
                                    insertNotification.Parameters.Add(":eventId", OracleDbType.Int32).Value = eventId;

                                    int rowsAffected = insertNotification.ExecuteNonQuery();

                                    if (rowsAffected > 0)
                                    {
                                        MessageBox.Show("Notification sent successfully.");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Failed to send notification.");
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid date format. Please enter dates in the correct format.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Notification_Load(object sender, EventArgs e)
        {

        }

        private void date2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            // Assuming textbox1 is used for participantId
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                participantId = int.Parse(textBox1.Text);
            }
        }
    }
}
