using Storages_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storages_BuisnessLayer
{
    public class clsPerson
    {

        public enum enMode { AddMode = 0, UpdateMode = 1 }
        enMode Mode = enMode.AddMode;
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get { return FirstName + " " + LastName; }

        }
        public string Email { get; set; }
        public string Phone { get; set; }
        public short Gendor { get; set; }
        public DateTime DateBirth { get; set; }
        //private string _ImagePath;
        public string ImagePath { get; set; }
        public int NationalCountryID { get; set; }
        public string NationalNO { get; set; }
        public clsCountry infoCountry { get; set; }


        public clsPerson()
        {
            this.PersonID = -1;
            this.FirstName = "";
            this.LastName = "";
            this.Email = "";
            this.Phone = "";
            this.Gendor = 0;
            this.DateBirth = DateTime.Now;
            this.ImagePath = "";
            this.NationalCountryID = -1;
            this.NationalNO = "";

            Mode = enMode.AddMode;
        }


        private clsPerson(int PersonID, string FirstName, string LastName, string Phone, string Email, short Gendor, DateTime DateBirth, string ImagePath, int NationalCountryID, string NationalNO)
        {
            this.PersonID = PersonID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Phone = Phone;
            this.Gendor = Gendor;
            this.DateBirth = DateBirth;
            this.ImagePath = ImagePath;
            this.NationalCountryID = NationalCountryID;
            this.NationalNO = NationalNO;
            this.infoCountry = clsCountry.Find(NationalCountryID);
            Mode = enMode.UpdateMode;
        }

        public static clsPerson Find(int PersonID)
        {

            string FirstName = "", LastName = "", Email = "", Phone = "", ImagePath = "", NationalNO = "";
            short Gendor = 0;
            DateTime DateBirth = DateTime.Now;
            int NationalCountryID = -1;

            bool isFound = clsPersonData.GetPersonByID(PersonID, ref FirstName, ref LastName, ref Phone, ref Email, ref Gendor, ref DateBirth, ref ImagePath, ref NationalCountryID, ref NationalNO);

            if (isFound == true)
            {

                return new clsPerson(PersonID, FirstName, LastName, Phone, Email, Gendor, DateBirth, ImagePath, NationalCountryID, NationalNO);
            }
            else
            {
                return null;
            }





        }

        public static clsPerson Find(string NationalNO)
        {
            int PersonID = -1;
            string FirstName = "", LastName = "", Email = "", Phone = "", ImagePath = "";
            short Gendor = 0;
            DateTime DateBirth = DateTime.Now;
            int NationalCountryID = -1;

            bool isFound = clsPersonData.GetPersonByNationalNO(NationalNO, ref PersonID, ref FirstName, ref LastName, ref Phone, ref Email, ref Gendor, ref DateBirth, ref ImagePath, ref NationalCountryID);

            if (isFound == true)
            {

                return new clsPerson(PersonID, FirstName, LastName, Phone, Email, Gendor, DateBirth, ImagePath, NationalCountryID, NationalNO);
            }
            else
            {
                return null;
            }





        }

        public static bool isPersonExist(int PersonID)
        {

            return clsPersonData.IsPersonExist(PersonID);
        }
        public static bool isPersonExist(string NationalNO)
        {

            return clsPersonData.IsPersonExist(NationalNO);

        }





        private bool _AddNewPerson()
        {

            this.PersonID = clsPersonData.AddNewPerson(this.FirstName, this.LastName, this.Phone, this.Email, this.Gendor, this.DateBirth, this.ImagePath, this.NationalCountryID, this.NationalNO);
            return (this.PersonID != -1);


        }
        private bool _UpdatePerson()
        {

            return clsPersonData.UpdatePerson(this.PersonID, this.FirstName, this.LastName, this.Phone, this.Email, this.Gendor, this.DateBirth, this.ImagePath, this.NationalCountryID, this.NationalNO);



        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddMode:
                    if (_AddNewPerson())
                    {
                        Mode = enMode.UpdateMode;
                        return true;
                    }
                    else
                    {

                        return false;
                    }

                case enMode.UpdateMode:
                    return _UpdatePerson();

            }
            return false;
        }


        public static bool DeletePerson(int PersonID)
        {
            return clsPersonData.DeletePerson(PersonID);

        }




        public static DataTable GetAllPeople()
        {
            return clsPersonData.GetAllPeople();

        }











    }
}
