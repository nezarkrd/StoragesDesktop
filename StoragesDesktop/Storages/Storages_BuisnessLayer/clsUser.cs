using Storages_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storages_BuisnessLayer
{
    public class clsUser
    {
        public enum enPermissions { pAll = -1, pPeople = 1, pUser = 2, pEmployees = 4, pUnits = 8, pCategories = 16, pItems = 32, pStorages = 64, pOperationStorages = 128,pOperationConvertBetweenStprages=256 }
        public enum enMode { AddMode = 0, UpdateMode = 1 }
        enMode Mode = enMode.AddMode;
        public int UserID { get; set; }
        public int PersonID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public short Permission { get; set; }
        public bool IsActive { get; set; }
        public clsPerson PersonInfo { get; set; }




        public clsUser()
        {
            this.UserID = -1;

            this.UserName = "";
            this.Password = "";
            this.Permission = -1;
            this.IsActive = true;

            Mode = enMode.AddMode;
        }


        private clsUser(int UserID, int PersonID, string UserName, string Password, short Permission, bool IsActive)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.UserName = UserName;
            this.Password = Password;
            this.Permission = Permission;
            this.IsActive = IsActive;
            this.PersonInfo = clsPerson.Find(PersonID);
            Mode = enMode.UpdateMode;
        }





        public static clsUser Find(int UserID)
        {

            int PersonID = -1; string UserName = "", Password = "";
            short Permission = -1;
            bool IsActive = true;

            bool isFound = clsUserData.GetUserByUserID(UserID, ref PersonID, ref UserName, ref Password, ref Permission, ref IsActive);


            if (isFound == true)
            {
                //clsUser(int UserID, int PersonID, string UserName, string Password, int Permission, bool IsActive)
                return new clsUser(UserID, PersonID, UserName, Password, Permission, IsActive);
            }
            else
            {
                return null;
            }

        }

        public static clsUser Find(string UserName)
        {

            int PersonID = -1, UserID = -1; string Password = "";
            short Permission = -1;
            bool IsActive = true;

            bool isFound = clsUserData.GetUserByUserName(UserName, ref UserID, ref PersonID, ref Password, ref Permission, ref IsActive);


            if (isFound == true)
            {
                //clsUser(int UserID, int PersonID, string UserName, string Password, int Permission, bool IsActive)
                return new clsUser(UserID, PersonID, UserName, Password, Permission, IsActive);
            }
            else
            {
                return null;
            }

        }
        public static clsUser FindByPersonID(int PersonID)
        {

            int UserID = -1; string UserName = "", Password = "";
            short Permission = -1;
            bool IsActive = true;

            bool isFound = clsUserData.GetUserByPersonID(PersonID, ref UserID, ref UserName, ref Password, ref Permission, ref IsActive);


            if (isFound == true)
            {
                //clsUser(int UserID, int PersonID, string UserName, string Password, int Permission, bool IsActive)
                return new clsUser(UserID, PersonID, UserName, Password, Permission, IsActive);
            }
            else
            {
                return null;
            }

        }

        public static clsUser FindByUsernameAndPassword(string UserName, string Password)
        {
            int UserID = -1;
            int PersonID = -1;
            short Permission = -1;
            bool IsActive = false;

            bool IsFound = clsUserData.GetUserByUserNameAndPassword(UserName, Password, ref UserID, ref PersonID, ref Permission, ref IsActive);

            if (IsFound)
                //we return new object of that User with the right data
                return new clsUser(UserID, PersonID, UserName, Password, Permission, IsActive);
            else
                return null;
        }





        public static bool isUserExist(int UserID)
        {

            return clsUserData.IsUserExist(UserID);
        }
        public static bool isUserExist(string UserName)
        {

            return clsUserData.IsUserExist(UserName);

        }
        public static bool isUserExistByPersonID(int PersonID)
        {

            return clsUserData.IsUserExistPersonID(PersonID);

        }



        private bool _AddNewUser()
        {
            this.UserID = clsUserData.AddNewUser(this.PersonID, this.UserName, this.Password, this.Permission, this.IsActive);
            return (this.UserID != -1);


        }
        private bool _UpdateUser()
        {

            return clsUserData.UpdateUser(this.UserID, this.PersonID, this.UserName, this.Password, this.Permission, this.IsActive);



        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddMode:
                    if (_AddNewUser())
                    {
                        Mode = enMode.UpdateMode;
                        return true;
                    }
                    else
                    {

                        return false;
                    }

                case enMode.UpdateMode:
                    return _UpdateUser();

            }
            return false;
        }


        public static bool DeleteUser(int UserID)
        {
            return clsUserData.DeleteUser(UserID);

        }

        public static DataTable GetAllUsers()
        {
            return clsUserData.GetAllUsers();

        }
        public bool CheckPermissions(enPermissions permission)
        {

            if (this.Permission == (short)enPermissions.pAll) { return true; }

            if ((this.Permission & (short)permission) == (short)permission) { return true; }

            else
            {

                return false;
            }



        }

    }
}
