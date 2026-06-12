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
    public partial class participant_view : Form
    {

        string conStr = "User Id=SAAD;Password=7223;Data Source=localhost:1521/xe";

        OracleConnection con;

        public participant_view()
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        //private void button2_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (!string.IsNullOrEmpty(textBox1.Text))
        //        {
        //            int participantId = int.Parse(textBox1.Text);

        //            using (OracleConnection oracleConnection = new OracleConnection(conStr))
        //            {
        //                oracleConnection.Open();

        //                using (OracleCommand getParticipantEvents = oracleConnection.CreateCommand())
        //                {
        //                    // Modify the query to filter events based on participant ID
        //                    getParticipantEvents.CommandText = "SELECT e.EVENT_ID, e.EVENTNAME, e.EVENT_DATE, e.EVENT_TIME, e.LOCATION " +
        //                                                      "FROM EVENT e " +
        //                                                      "JOIN PARTICIPANT p ON e.EVENT_ID = p.EVENT_ID " +
        //                                                      "WHERE p.PARTICIPANT_ID = :participantId";

        //                    getParticipantEvents.Parameters.Add(":participantId", OracleDbType.Int32).Value = participantId;

        //                    OracleDataAdapter adapter = new OracleDataAdapter(getParticipantEvents);
        //                    DataTable dataTable = new DataTable();
        //                    adapter.Fill(dataTable);

        //                    // Clear the existing columns and data in the DataGridView
        //                    dataGridView1.Columns.Clear();
        //                    dataGridView1.DataSource = null;

        //                    // Bind the DataTable to the DataGridView
        //                    dataGridView1.DataSource = dataTable;

        //                    // Manually create columns
        //                    foreach (DataColumn column in dataTable.Columns)
        //                    {
        //                        dataGridView1.Columns.Add(column.ColumnName, column.ColumnName);
        //                    }

        //                    // Optionally, you can customize column headers or other properties
        //                    dataGridView1.Columns["EVENT_ID"].HeaderText = "Event ID";
        //                    dataGridView1.Columns["EVENTNAME"].HeaderText = "Event Name";
        //                    dataGridView1.Columns["EVENT_DATE"].HeaderText = "Event Date";
        //                    dataGridView1.Columns["EVENT_TIME"].HeaderText = "Event Time";
        //                    dataGridView1.Columns["LOCATION"].HeaderText = "Location";
        //                }
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Please enter a Participant ID");
        //        }
        //    }
        //    catch (FormatException ex)
        //    {
        //        MessageBox.Show($"Invalid input for {ex.TargetSite.Name}. Please enter a valid Participant ID.");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error: {ex.Message}");
        //    }
        //}


        //private void button2_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (!string.IsNullOrEmpty(textBox1.Text))
        //        {
        //            int participantId = int.Parse(textBox1.Text);

        //            using (OracleConnection oracleConnection = new OracleConnection(conStr))
        //            {
        //                oracleConnection.Open();

        //                using (OracleCommand getParticipantEvents = oracleConnection.CreateCommand())
        //                {
        //                    // Modify the query to filter events based on participant ID
        //                    getParticipantEvents.CommandText = "SELECT e.EVENT_ID, e.EVENTNAME, e.EVENT_DATE, e.EVENT_TIME, e.LOCATION " +
        //                                                      "FROM EVENT e " +
        //                                                      "JOIN PARTICIPANT p ON e.EVENT_ID = p.EVENT_ID " +
        //                                                      "WHERE p.PARTICIPANT_ID = :participantId";

        //                    getParticipantEvents.Parameters.Add(":participantId", OracleDbType.Int32).Value = participantId;

        //                    OracleDataAdapter adapter = new OracleDataAdapter(getParticipantEvents);
        //                    DataTable dataTable = new DataTable();
        //                    adapter.Fill(dataTable);

        //                    // Clear the existing columns and data in the DataGridView
        //                    dataGridView1.Columns.Clear();
        //                    dataGridView1.DataSource = null;

        //                    // Bind the DataTable to the DataGridView
        //                    dataGridView1.DataSource = dataTable;

        //                    // Manually create columns
        //                    foreach (DataColumn column in dataTable.Columns)
        //                    {
        //                        dataGridView1.Columns.Add(column.ColumnName, column.ColumnName);
        //                    }

        //                    // Optionally, you can customize column headers or other properties
        //                    dataGridView1.Columns["EVENT_ID"].HeaderText = "Event ID";
        //                    dataGridView1.Columns["EVENTNAME"].HeaderText = "Event Name";
        //                    dataGridView1.Columns["EVENT_DATE"].HeaderText = "Event Date";
        //                    dataGridView1.Columns["EVENT_TIME"].HeaderText = "Event Time";
        //                    dataGridView1.Columns["LOCATION"].HeaderText = "Location";
        //                }
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Please enter a Participant ID");
        //        }
        //    }
        //    catch (FormatException ex)
        //    {
        //        MessageBox.Show($"Invalid input for {ex.TargetSite.Name}. Please enter a valid Participant ID.");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error: {ex.Message}");
        //    }
        //}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void participant_view_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.EVENT' table. You can move, or remove it, as needed.
            this.eVENTTableAdapter.Fill(this.dataSet1.EVENT);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
