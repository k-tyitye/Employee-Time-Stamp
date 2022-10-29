using Microsoft.VisualStudio.TestTools.UnitTesting;
using GuiEmployeeDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiEmployeeDatabase.Tests
{
    [TestClass()]
    public class DatabaseInteractionTests
    {

        [TestMethod()]
        public void getEmployeeByIdTestUsingTestDB()
        {
            DatabaseInteraction db = new DatabaseInteraction(true);

            Assert.IsTrue(db.getEmployeeById(1));
        }

        [TestMethod()]
        public void getEmployeeByIdTestUsingMainDB()
        {
            DatabaseInteraction db = new DatabaseInteraction(false);

            Assert.IsTrue(db.getEmployeeById(1));
        }

        [TestMethod()]
        public void insertClockInTimeTest()
        {
            DatabaseInteraction db = new DatabaseInteraction(false);

            Assert.IsTrue(db.insertClockInTime(1));

        }

        [TestMethod()]
        public void insertClockOutTimeTest()
        {
            DatabaseInteraction db = new DatabaseInteraction(false);

            Assert.IsTrue(db.insertClockOutTime(1));
        }
    }
}