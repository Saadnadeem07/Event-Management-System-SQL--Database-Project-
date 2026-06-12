using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace project2
{
    public partial class Register : Form
    {
        string conStr = "DATA SOURCE=localhost:1521/xe;USER ID=SAAD;PASSWORD=7223";
        OracleConnection con;


        public Register()
        {
            InitializeComponent();
            con = new OracleConnection(conStr);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Enabled)
            {
                new user_event().Show();
                this.Hide();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) &&  // assuming textBox6 is used for PARTICIPANT_ID input
            !string.IsNullOrEmpty(textBox2.Text) &&
            !string.IsNullOrEmpty(textBox3.Text) &&
                !string.IsNullOrEmpty(textBox4.Text) &&
                !string.IsNullOrEmpty(textBox5.Text))
            {
                try
                {
                    con.Open();

                    using (OracleCommand insertParticipant = con.CreateCommand())
                    {
                        insertParticipant.CommandText = "INSERT INTO participant " +
                                                       "(PARTICIPANT_ID, EVENT_ID, NAME, EMAIL, PHONE) " +
                                                       "VALUES " +
                        "(:participantId, :eventId, :name, :email, :phone)";

                        insertParticipant.Parameters.Add(":participantId", OracleDbType.Int32).Value = int.Parse(textBox1.Text);
                        insertParticipant.Parameters.Add(":eventId", OracleDbType.Int32).Value = int.Parse(textBox3.Text);
                        insertParticipant.Parameters.Add(":name", OracleDbType.Varchar2).Value = textBox5.Text;
                        insertParticipant.Parameters.Add(":email", OracleDbType.Varchar2).Value = textBox2.Text;
                        insertParticipant.Parameters.Add(":phone", OracleDbType.Varchar2).Value = textBox4.Text;

                        int rows = insertParticipant.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Participant Created Successfully");
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
