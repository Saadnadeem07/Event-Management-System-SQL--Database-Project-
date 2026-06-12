
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client; // Import the Oracle Managed Data Access namespace

using System.Collections.Generic;
using System.ComponentModel;

using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace project2
{
    public partial class user_report : Form
    {

        string conStr = "User Id=SAAD;Password=7223;Data Source=localhost:1521/xe";
        private void report_genrate_Load(object sender, EventArgs e)
        {
           
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Enabled)
            {
                new user_event().Show();
                this.Hide();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void user_report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.EVENT' table. You can move, or remove it, as needed.
            this.eVENTTableAdapter.Fill(this.dataSet1.EVENT);

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
