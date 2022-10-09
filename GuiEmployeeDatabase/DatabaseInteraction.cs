using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

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
                connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"..\\..\\..\\..\\Kari Tyitye - Activity 6.accdb\"");
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

    }
}
