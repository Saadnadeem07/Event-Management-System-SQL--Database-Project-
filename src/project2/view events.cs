using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace project2
{
    public partial class view_events : Form
    {
        string conStr = "User Id=SAAD;Password=7223;Data Source=localhost:1521/xe";
        
        OracleConnection con;

        //
        public view_events()
        {
            InitializeComponent();
            con = new OracleConnection(conStr);

        }

        private void view_events_Load(object sender, EventArgs e)
        {
            // You may need to uncomment the following line if it's necessary to load data on form load
            // this.eVENTTableAdapter.Fill(this.dataSet1.EVENT);
        }

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        using (OracleConnection oracleConnection = new OracleConnection(conStr))
        //        {
        //            oracleConnection.Open();

        //            using (OracleCommand getAllEvents = oracleConnection.CreateCommand())
        //            {
        //                getAllEvents.CommandText = "SELECT EVENT_ID, EVENTNAME, EVENT_DATE, EVENT_TIME, LOCATION FROM EVENT";
        //                OracleDataAdapter adapter = new OracleDataAdapter(getAllEvents);
        //                DataTable dataTable = new DataTable();
        //                adapter.Fill(dataTable);

        //                // Assuming you have a DataGridView named dataGridView1
        //                dataGridView1.DataSource = dataTable;

        //                // Optionally, you can customize column headers or other properties
        //                dataGridView1.Columns["EVENT_ID"].HeaderText = "Event ID";
        //                dataGridView1.Columns["EVENTNAME"].HeaderText = "Event Name";
        //                dataGridView1.Columns["EVENT_DATE"].HeaderText = "Event Date";
        //                dataGridView1.Columns["EVENT_TIME"].HeaderText = "Event Time";
        //                dataGridView1.Columns["LOCATION"].HeaderText = "Location";
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error: {ex.Message}");
        //    }
        //}

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (OracleConnection oracleConnection = new OracleConnection(conStr))
                {
                    oracleConnection.Open();

                    using (OracleCommand getAllEvents = oracleConnection.CreateCommand())
                    {
                        getAllEvents.CommandText = "SELECT EVENT_ID, EVENTNAME, EVENT_DATE, EVENT_TIME, LOCATION FROM EVENT";
                        OracleDataAdapter adapter = new OracleDataAdapter(getAllEvents);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Clear the existing columns and data in the DataGridView
                        dataGridView1.DataSource = null;

                        // Bind the DataTable to the DataGridView
                        dataGridView1.DataSource = dataTable;

                        // Manually create columns
                        foreach (DataColumn column in dataTable.Columns)
                        {
                            dataGridView1.Columns.Add(column.ColumnName, column.ColumnName);
                        }

                        // Optionally, you can customize column headers or other properties
                        dataGridView1.Columns["EVENT_ID"].HeaderText = "Event ID";
                        dataGridView1.Columns["EVENTNAME"].HeaderText = "Event Name";
                        dataGridView1.Columns["EVENT_DATE"].HeaderText = "Event Date";
                        dataGridView1.Columns["EVENT_TIME"].HeaderText = "Event Time";
                        dataGridView1.Columns["LOCATION"].HeaderText = "Location";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            new eventcreation().Show();
            this.Hide();
        }
    }




}
