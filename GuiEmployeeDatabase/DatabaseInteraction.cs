using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Configuration;
using System.Data;

/**
 * Requirements to get the database connection working:
 * 
 * Microsoft Access 2016 64-bit Version
 * The accessdb file in the Resources folder
 * Tools > NuGet Package Manager > NuGet Package Manager Console > Type "install-package system.data.oledb" and click enter.
 * 
 * Connection String (without escaped characters):
 * Provider=Microsoft.ACE.OLEDB.12.0;Data Source=".\Kari Tyitye - Activity 6.accdb"
 */
namespace GuiEmployeeDatabase
{
    public class DatabaseInteraction
    {

        OleDbConnection connection;

        public DatabaseInteraction(bool useTestDB = false)
        {
            if (useTestDB)
            {
                connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"..\\..\\..\\testDB.accdb\"");
            } else
            {
                connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"..\\..\\..\\..\\GuiEmployeeDatabase\\Resources\\EmployeeDatabase.accdb\"");
            }
        }

        public bool getEmployeeById(int employeeID)
        {
            bool success;

            string stringEmployeeID = employeeID.ToString();
            
            while (stringEmployeeID.Length < 5)
            {
                stringEmployeeID = "0" + stringEmployeeID;
            }

            try
            {
                OleDbCommand command = new OleDbCommand(string.Format("SELECT * FROM tblEmployees WHERE (Emp_ID = '{0}')", stringEmployeeID), connection);
                connection.Open();
                var grabbed = command.ExecuteScalar(); //This only gets the number
                connection.Close();
                success = true;
            } 
            catch (Exception)
            {
                success = false;
            }

            return success;
        }

        public bool insertClockOutTime(int employeeID)
        {

            int rowsUpdated;

            string currentUserID = employeeID.ToString();
            while (currentUserID.Length < 5)
            {
                currentUserID = "0" + currentUserID;
            }

            try
            {
                connection.Open();

                OleDbDataAdapter timestampDataTable = new OleDbDataAdapter("SELECT COUNT(*) FROM tblTimeStamp WHERE Employee_ID='" + currentUserID + "'", connection);
                DataTable foundTimestampEntries = new DataTable();
                timestampDataTable.Fill(foundTimestampEntries);
                if (foundTimestampEntries.Rows[0][0].ToString() != "1")
                {
                    return false;
                }

                OleDbCommand command = new OleDbCommand();
                command.CommandText = "UPDATE tblTimeStamp SET Clock_Out = @ts WHERE Employee_ID = '" + currentUserID +"'";
                var param1 = command.Parameters.AddWithValue("@ts", DateTime.Now);
                param1.OleDbType = OleDbType.Date;
                command.Connection = connection;
                rowsUpdated = command.ExecuteNonQuery();
                
                connection.Close();
            }
            catch (Exception)
            {
                return false;
            }

            if (rowsUpdated > 0)
            {
                return true;
            }
            return false;

        }

        public bool insertClockInTime(int employeeID)
        {

            int rowsUpdated;

            string currentUserID = employeeID.ToString();
            while (currentUserID.Length < 5)
            {
                currentUserID = "0" + currentUserID;
            }

            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand();

                // http://www.carlprothman.net/Technology/DataTypeMapping/tabid/97/Default.aspx
                command.CommandText = "INSERT INTO [tblTimeStamp](Employee_ID, Clock_In) values(@cuid, @ts)";
                var param1 = command.Parameters.AddWithValue("@cuid", currentUserID);
                var param2 = command.Parameters.AddWithValue("@ts", DateTime.Now);
                param1.OleDbType = OleDbType.VarWChar;
                param2.OleDbType = OleDbType.Date;
                command.Connection = connection;
                rowsUpdated = command.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception)
            {
                return false;
            }

            if (rowsUpdated > 0)
            {
                return true;
            }
            return false;

        }


    }
}
