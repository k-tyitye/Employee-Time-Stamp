using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiEmployeeDatabase
{
    public class Employee
    {

        /* Properties */
        private int EmployeeID;
        private string? FirstName;
        private string? LastName;
        private string? EmployeeAddress;
        private string? EmployeeCity;
        private string? EmployeeState;
        private int? EmployeeZipcode;
        private string? EmployeePhone;

        public Employee(int employeeID)
        {
            /* The EmployeeID is mandatory */
            EmployeeID = employeeID;
        }

        #region Getters

        public int getEmployeeID()
        {
            return EmployeeID;
        }

        public string? getFirstName()
        {
            return FirstName;
        }

        public string? getLastName()
        {
            return LastName;
        }

        public string? getEmployeeAddress()
        {
            return EmployeeAddress;
        }

        public string? getEmployeeCity()
        {
            return EmployeeCity;
        }

        public string? getEmployeeState()
        {
            return EmployeeState;
        }

        public int? getEmployeeZipcode()
        {
            return EmployeeZipcode;
        }

        public string? getEmployeePhone()
        {
            return EmployeePhone;
        }

        #endregion Getters

        /* TODO: Add verification checks to Setters */
        #region Setters

        public bool setFirstName(string? firstName)
        {
            bool success = false;
            try
            {
                FirstName = firstName;
                success = true;
            }
            catch (Exception)
            {
                //Failure
            }
            return success;
        }

        public bool setLastName(string? lastName)
        {
            bool success = false;
            try
            {
                LastName = lastName;
                success = true;
            }
            catch (Exception)
            {
                //Failure
            }
            return success;
        }

        public bool setEmployeeAddress(string? employeeAddress)
        {
            bool success = false;
            try
            {
                EmployeeAddress = employeeAddress;
                success = true;
            }
            catch (Exception)
            {
                //Failure
            }
            return success;
        }

        public bool setEmployeeCity(string? employeeCity)
        {
            bool success = false;
            try
            {
                EmployeeCity = employeeCity;
                success = true;
            }
            catch (Exception)
            {
                //Failure
            }
            return success;
        }

        public bool setEmployeeState(string? employeeState)
        {
            bool success = false;
            try
            {
                EmployeeState = employeeState;
                success = true;
            }
            catch (Exception)
            {
                //Failure
            }
            return success;
        }

        public bool setEmployeeZipcode(int? employeeZipcode)
        {
            bool success = false;
            try
            {
                EmployeeZipcode = employeeZipcode;
                success = true;
            }
            catch (Exception)
            {
                //Failure
            }
            return success;
        }

        public bool setEmployeePhone(string? employeePhone)
        {
            bool success = false;
            try
            {
                EmployeePhone = employeePhone;
                success = true;
            }
            catch (Exception)
            {
                //Failure
            }
            return success;
        }

        #endregion Setters

    }
}
