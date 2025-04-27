using Storages_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Storages_DataAccessLayer;

namespace Storages_BuisnessLayer
{
    public class clsStorage
    {


        public enum enMode { AddMode = 0, UpdateMode = 1 }
        enMode Mode = enMode.AddMode;
        public int StorageID { get; set; }
        public string StorageName { get; set; }
        public string Location { get; set; }
        public string Information { get; set; }



        public clsStorage()
        {
            this.StorageID = -1;
            this.StorageName = "";
            this.Location = "";
            this.Information = "";


            Mode = enMode.AddMode;
        }


        private clsStorage(int StorageID, string StorageName, string Location, string Information)
        {
            this.StorageID = StorageID;
            this.StorageName = StorageName;
            this.Location = Location;
            this.Information = Information;

            Mode = enMode.UpdateMode;
        }

        public static clsStorage Find(int StorageID)
        {


            string StorageName = ""; string Location = "", Information = "";


            bool isFound = clsStoragesData.GetStorageByStorageID(StorageID, ref StorageName, ref Location, ref Information);

            if (isFound == true)
            {

                return new clsStorage(StorageID, StorageName, Location, Information);
               

            }
            else
            {
                return null;
            }





        }

        public static clsStorage Find(string StorageName)
        {
            int StorageID = -1;  string Location = "", Information = "";


            bool isFound = clsStoragesData.GetStorageByStorageName(StorageName, ref StorageID, ref Location, ref Information);

            if (isFound == true)
            {

                return new clsStorage(StorageID, StorageName, Location, Information);


            }
            else
            {
                return null;
            }


        }

        public static bool isStorageExist(int StorageID)
        {
            return clsStoragesData.IsStorageExist(StorageID);   
           

        }
        public static bool isStorageExist(string StorageName)
        {
            return clsStoragesData.IsStorageExist(StorageName);

        }





        private bool _AddNewStorage()
        {
            if (!clsStoragesData.CheckNewStorage(this.StorageName)) {
                this.StorageID = clsStoragesData.AddNewStorage(this.StorageName, this.Location, this.Information);
                return (this.StorageID != -1);
            }
            else
            {
                return false;   
            }


        }
        private bool _UpdateStorage()
        {
            if (!clsStoragesData.CheckNewStorage(this.StorageName))
            {
                return clsStoragesData.UpdateStorage(this.StorageID, this.StorageName, this.Location, this.Information);
            }
            else
            {
                if (this.StorageName== Find(this.StorageID).StorageName)
                {
                    return clsStoragesData.UpdateStorage(this.StorageID, this.StorageName, this.Location, this.Information);
                }
                else
                {
                    return false;
                }
               
            }

        }


        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddMode:
                    if (_AddNewStorage())
                    {
                        Mode = enMode.UpdateMode;
                        return true;
                    }
                    else
                    {

                        return false;
                    }

                case enMode.UpdateMode:
                    return _UpdateStorage();

            }
            return false;
        }


        public static bool DeleteStorage(int StorageID)
        {
            return clsStoragesData.DeleteStorage(StorageID);
            


        }

        public static DataTable GetAllStorages()
        {
            return clsStoragesData.GetAllStorages();

        }






    }
}
