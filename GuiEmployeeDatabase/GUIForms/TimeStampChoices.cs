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
        public TimeStampChoices()
        {
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
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ToString();
            con.Open();

            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "insert into [tblTimeStamp](Clock_In)values(@nm)";
            var param = cmd.Parameters.AddWithValue("@nm", DateTime.Now);
            param.OleDbType = OleDbType.Date;
            cmd.Connection = con;
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Inserted");
            }
        }
    }
}
