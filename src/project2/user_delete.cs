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

namespace project2
{
    public partial class user_delete : Form
    {
        string conStr = "DATA SOURCE=localhost:1521/xe;USER ID=SAAD;PASSWORD=7223";
        OracleConnection con;

        public user_delete()
        {
            InitializeComponent();
            con = new OracleConnection(conStr);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Enabled)
            {
                new user_event().Show();
                this.Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Enabled)
            {
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    try
                    {
                        int participantId = int.Parse(textBox1.Text);

                        con.Open();

                        using (OracleCommand deleteParticipant = con.CreateCommand())
                        {
                            deleteParticipant.CommandText = "DELETE FROM participant WHERE PARTICIPANT_ID = :participantId";
                            deleteParticipant.Parameters.Add(":participantId", OracleDbType.Int32).Value = participantId;

                            int rows = deleteParticipant.ExecuteNonQuery();

                            if (rows > 0)
                            {
                                MessageBox.Show("Participant Deleted Successfully");
                                // Optionally, update any UI elements or grid after successful deletion
                            }
                            else
                            {
                                MessageBox.Show("No rows affected. Deletion might have failed.");
                            }
                        }
                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show($"Invalid input for {ex.TargetSite.Name}. Please enter a valid participant ID.");
                    }
                    catch (OracleException ex)
                    {
                        MessageBox.Show("Error while deleting participant: " + ex.Message);
                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open)
                            con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a participant ID");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
