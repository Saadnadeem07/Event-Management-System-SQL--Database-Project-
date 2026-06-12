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
using Oracle.ManagedDataAccess; // compulsory part 
namespace project2
{
    public partial class eventcreation : Form
    {
        string conStr = "DATA SOURCE=localhost:1521/xe;USER ID=SAAD;PASSWORD=7223";// compulsory part 
        OracleConnection con;
        public eventcreation()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(button2.Enabled) {
                new eventcreation2().Show();
                this.Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Enabled)
            {
                new admin_deletion().Show();
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Enabled)
            {
                new Notification().Show();
                this.Hide();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            con = null;

            if (button5.Enabled)
            {
                new mainform().Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new view_events().Show();
            this.Hide();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

