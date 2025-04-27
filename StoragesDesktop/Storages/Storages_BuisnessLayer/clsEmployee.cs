using Storages_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storages_BuisnessLayer
{
    public class clsEmployee
    {
        public enum enMode { AddMode = 0, UpdateMode = 1 }
        enMode Mode = enMode.AddMode;
        public int EmployeeID { get; set; }
        public int PersonID { get; set; }
        public string UserNameEmployee { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }





        public clsEmployee()
        {
            this.EmployeeID = -1;
            this.PersonID = -1;
            this.UserNameEmployee = "";
            this.Password = "";
            this.IsActive =true;


            Mode = enMode.AddMode;
        }


        private clsEmployee(int EmployeeID, int PersonID, string UserNameEmployee, string Password, bool IsActive)
        {
            this.EmployeeID = EmployeeID;
            this.PersonID = PersonID;
            this.UserNameEmployee = UserNameEmployee;
            this.Password = Password;
            this.IsActive = IsActive;
            Mode = enMode.UpdateMode;

        }





        public static clsEmployee Find(int EmployeeID)
        {

            int PersonID = -1; string UserNameEmployee = "", Password = "";
            bool IsActive = true;


            bool isFound = clsEmployeeData.GetEmployeeByEmployeeID(EmployeeID, ref PersonID, ref UserNameEmployee, ref Password, ref IsActive);

            if (isFound == true)
            {
                return new clsEmployee(EmployeeID, PersonID, UserNameEmployee, Password, IsActive);
     
            }
            else
            {
                return null;
            }

        }

        public static clsEmployee Find(string UserNameEmployee)
        {

            int PersonID = -1, EmployeeID = -1; string Password = "";
            bool IsActive = true;

           
            bool isFound = clsEmployeeData.GetEmployeeByUserNameEmployee(UserNameEmployee, ref EmployeeID, ref PersonID, ref Password, ref IsActive);

            if (isFound == true)
            {
                return new clsEmployee(EmployeeID, PersonID, UserNameEmployee, Password, IsActive);
               
            }
            else
            {
                return null;
            }

        }

        public static clsEmployee FindByPersonID(int PersonID)
        {

            int EmployeeID = -1; string Password = "", UserNameEmployee = "";
            bool IsActive = true;

            
            bool isFound = clsEmployeeData.GetEmployeeByPersonID(PersonID, ref EmployeeID, ref UserNameEmployee, ref Password, ref IsActive);

            if (isFound == true)
            {
                return new clsEmployee(EmployeeID, PersonID, UserNameEmployee, Password, IsActive);
            }
            else
            {
                return null;
            }

        }






        public static bool isEmployeeExist(int EmployeeID)
        {
            return clsEmployeeData.IsEmployeeExist(EmployeeID);
           
        }
        public static bool isEmployeeExist(string UserNameEmployee)
        {
            return clsEmployeeData.IsEmployeeExist(UserNameEmployee);
            

        }
        public static bool isEmployeeExistByPersonID(int PersonID)
        {
            return clsEmployeeData.IsEmployeeExistPersonID(PersonID);
        

        }



        private bool _AddNewEmployee()
        {

            this.EmployeeID = clsEmployeeData.AddNewEmployee(PersonID, UserNameEmployee, Password, IsActive);
            return (this.EmployeeID != -1);


        }
        private bool _UpdateClient()
        {

            return clsEmployeeData.UpdateEmployee(EmployeeID, PersonID, UserNameEmployee, Password, IsActive);
           
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddMode:
                    if (_AddNewEmployee())
                    {
                        Mode = enMode.UpdateMode;
                        return true;
                    }
                    else
                    {

                        return false;
                    }

                case enMode.UpdateMode:
                    return _UpdateClient();

            }
            return false;
        }


        public static bool DeleteEmployee(int EmployeeID)
        {
            return clsEmployeeData.DeleteEmployee(EmployeeID);  
    

        }

        public static DataTable GetAllEmployees()
        {
            return clsEmployeeData.GetAllEmployees();   
        

        }





    }
}
