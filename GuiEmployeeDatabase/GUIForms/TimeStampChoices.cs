using Microsoft.Office.Interop.Access.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuiEmployeeDatabase
{
    public partial class TimeStampChoices : Form
    {
        protected string? currentUserID;

        public TimeStampChoices()
        {
            currentUserID = null;
            InitializeComponent();
        }

        public TimeStampChoices(string? userID)
        {
            currentUserID = userID;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ToString();
            conn.Open();

            OleDbCommand cmd = new OleDbCommand();

            cmd.CommandText = "insert into [tblTimeStamp](Employee_ID, Clock_In) values(@cuid, @tm)";
            var param1 = cmd.Parameters.AddWithValue("@cuid", currentUserID);
            var param2 = cmd.Parameters.AddWithValue("@tm", DateTime.Now);
            param1.OleDbType = OleDbType.VarWChar;
            param2.OleDbType = OleDbType.Date;
            cmd.Connection = conn;
            int a = cmd.ExecuteNonQuery();

            conn.Close();
           
            this.Hide();
            DisplayTimeStamp displayTimeStamp = new DisplayTimeStamp();
            displayTimeStamp.Show();

            if (a > 0)
            {
                MessageBox.Show("Time stamp recorded.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ToString();
            conn.Open();

            OleDbCommand cmd = new OleDbCommand();

            cmd.CommandText = "UPDATE tblTimeStamp SET Clock_Out = @ts WHERE Employee_ID = '" + currentUserID + "'";
            var param1 = cmd.Parameters.AddWithValue("@ts", DateTime.Now);
            param1.OleDbType = OleDbType.Date;
            cmd.Connection = conn;
            int a = cmd.ExecuteNonQuery();
            conn.Close();

            this.Hide();
            DisplayTimeStamp displayTimeStamp = new DisplayTimeStamp();
            displayTimeStamp.Show();

            if (a > 0)
            {
                MessageBox.Show("Time stamp recorded.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ToString();
            conn.Open();

            OleDbCommand cmd = new OleDbCommand();

            cmd.CommandText = "UPDATE tblTimeStamp SET Clock_In_Lunch = @ts WHERE Employee_ID = '" + currentUserID + "'";
            var param1 = cmd.Parameters.AddWithValue("@ts", DateTime.Now);
            param1.OleDbType = OleDbType.Date;
            cmd.Connection = conn;
            int a = cmd.ExecuteNonQuery();
            conn.Close();

            this.Hide();
            DisplayTimeStamp displayTimeStamp = new DisplayTimeStamp();
            displayTimeStamp.Show();

            if (a > 0)
            {
                MessageBox.Show("Time stamp recorded.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ToString();
            conn.Open();

            OleDbCommand cmd = new OleDbCommand();

            cmd.CommandText = "UPDATE tblTimeStamp SET Clock_Out_Lunch = @ts WHERE Employee_ID = '" + currentUserID + "'";
            var param1 = cmd.Parameters.AddWithValue("@ts", DateTime.Now);
            param1.OleDbType = OleDbType.Date;
            cmd.Connection = conn;
            int a = cmd.ExecuteNonQuery();
            conn.Close();

            this.Hide();
            DisplayTimeStamp displayTimeStamp = new DisplayTimeStamp();
            displayTimeStamp.Show();

            if (a > 0)
            {
                MessageBox.Show("Time stamp recorded.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ToString();
            conn.Open();

            OleDbCommand cmd = new OleDbCommand();

            cmd.CommandText = "UPDATE tblTimeStamp SET Clock_In_Break = @ts WHERE Employee_ID = '" + currentUserID + "'";
            var param1 = cmd.Parameters.AddWithValue("@ts", DateTime.Now);
            param1.OleDbType = OleDbType.Date;
            cmd.Connection = conn;
            int a = cmd.ExecuteNonQuery();
            conn.Close();

            this.Hide();
            DisplayTimeStamp displayTimeStamp = new DisplayTimeStamp();
            displayTimeStamp.Show();

            if (a > 0)
            {
                MessageBox.Show("Time stamp recorded.");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ToString();
            conn.Open();

            OleDbCommand cmd = new OleDbCommand();

            cmd.CommandText = "UPDATE tblTimeStamp SET Clock_Out_Break = @ts WHERE Employee_ID = '" + currentUserID + "'";
            var param1 = cmd.Parameters.AddWithValue("@ts", DateTime.Now);
            param1.OleDbType = OleDbType.Date;
            cmd.Connection = conn;
            int a = cmd.ExecuteNonQuery();
            conn.Close();

            this.Hide();
            DisplayTimeStamp displayTimeStamp = new DisplayTimeStamp();
            displayTimeStamp.Show();

            if (a > 0)
            {
                MessageBox.Show("Time stamp recorded.");
            }
        }
    }
}
