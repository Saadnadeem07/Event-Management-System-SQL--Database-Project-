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
using Oracle.ManagedDataAccess;

namespace project2
{
    public partial class admin_deletion : Form
    {
        string conStr = "DATA SOURCE=localhost:1521/xe;USER ID=SAAD;PASSWORD=7223";// compulsory part 
        OracleConnection con;
        public admin_deletion()
        {
            InitializeComponent();
            con = new OracleConnection(conStr);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Enabled)
            {
                new eventcreation().Show();
                this.Hide();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //private void button4_Click(object sender, EventArgs e)
        //{
            
        //    if (button4.Enabled)
        //    {
        //        if (!string.IsNullOrEmpty(textBox1.Text))
        //        {
        //            try
        //            {
        //                int eventId = int.Parse(textBox1.Text);

        //                con.Open();

        //                using (OracleCommand deleteevent= con.CreateCommand())
        //                {
        //                    deleteevent.CommandText = "DELETE FROM event WHERE EVENT_ID = :eventId";
        //                    deleteevent.Parameters.Add(":eventId", OracleDbType.Int32).Value = deleteevent;

        //                    int rows = deleteevent.ExecuteNonQuery();

        //                    if (rows > 0)
        //                    {
        //                        MessageBox.Show("Event Deleted Successfully");
        //                        // Optionally, update any UI elements or grid after successful deletion
        //                    }
        //                    else
        //                    {
        //                        MessageBox.Show("No rows affected. Deletion might have failed.");
        //                    }
        //                }
        //            }
        //            catch (FormatException ex)
        //            {
        //                MessageBox.Show($"Invalid input for {ex.TargetSite.Name}. Please enter a valid Event ID.");
        //            }
        //            catch (OracleException ex)
        //            {
        //                MessageBox.Show("Error while deleting participant: " + ex.Message);
        //            }
        //            finally
        //            {
        //                if (con.State == ConnectionState.Open)
        //                    con.Close();
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Please enter a Event ID");
        //        }
        //    }
        //}


        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Enabled)
            {
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    try
                    {
                        int eventId = int.Parse(textBox1.Text);

                        using (OracleConnection con = new OracleConnection(conStr))
                        {
                            con.Open();

                            using (OracleCommand deleteEventCommand = con.CreateCommand())
                            {
                                deleteEventCommand.CommandText = "DELETE FROM event WHERE EVENT_ID = :eventId";
                                deleteEventCommand.Parameters.Add(":eventId", OracleDbType.Int32).Value = eventId;

                                int rows = deleteEventCommand.ExecuteNonQuery();

                                if (rows > 0)
                                {
                                    MessageBox.Show("Event Deleted Successfully");
                                    // Optionally, update any UI elements or grid after successful deletion
                                }
                                else
                                {
                                    MessageBox.Show("No rows affected. Deletion might have failed.");
                                }
                            }
                        }
                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show($"Invalid input for {ex.TargetSite.Name}. Please enter a valid Event ID.");
                    }
                    catch (OracleException ex)
                    {
                        MessageBox.Show("Error while deleting event: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter an Event ID");
                }
            }
        }



    }
}
