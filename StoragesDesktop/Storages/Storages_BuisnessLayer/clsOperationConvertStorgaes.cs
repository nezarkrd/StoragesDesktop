using Storages_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storages_BuisnessLayer
{
    public class clsOperationConvertStorgaes
    {

        public enum enMode { AddMode = 0, UpdateMode = 1 }
        enMode Mode = enMode.AddMode;
        public int OperationConvertStoragesID { get; set; }
        public int ItemUnitID { get; set; }
        public int ToStorageID { get; set; }
        public int FromStorageID { get; set; }
        public int AmountConvert { get; set; }
        public DateTime DateOperation { get; set; }
        public string ReasonOperation { get; set; }
        public int EmployeeID { get; set; }
        public int UserID { get; set; }



        public clsOperationConvertStorgaes()
        {
            this.OperationConvertStoragesID = -1;

            this.ItemUnitID = -1;
            this.ToStorageID = -1;
            this.FromStorageID = -1;
            this.AmountConvert = -1;
          
            this.DateOperation = DateTime.Now;
            this.ReasonOperation = "";
            this.EmployeeID = -1;
            this.UserID = -1;


            Mode = enMode.AddMode;
        }


        public clsOperationConvertStorgaes(int OperationConvertStoragesID,int ItemUnitID,int ToStorageID,int FromStorageID,int AmountConvert,DateTime DateOperation,string ReasonOperation,int EmployeeID,int UserID)
        {
            this.OperationConvertStoragesID = OperationConvertStoragesID;

            this.ItemUnitID = ItemUnitID;
            this.ToStorageID = ToStorageID;
            this.FromStorageID = FromStorageID;
            this.AmountConvert = AmountConvert;

            this.DateOperation = DateTime.Now;
            this.ReasonOperation = ReasonOperation;
            this.EmployeeID = EmployeeID;
            this.UserID = -1;


            Mode = enMode.UpdateMode;
        }


        private bool _AddOperationConvertStorages()
        {
            this.OperationConvertStoragesID = clsOperationConvertStorgaesData.AddNewOperationStorage(this.ItemUnitID, this.FromStorageID, this.ToStorageID, this.AmountConvert, this.DateOperation, this.ReasonOperation, this.EmployeeID, this.UserID);
                
            return (this.OperationConvertStoragesID != -1);


        }
        private bool _UpdateOperationConvertStorages()
        {

            return false;

        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddMode:
                    if (_AddOperationConvertStorages())
                    {
                        Mode = enMode.UpdateMode;
                        return true;
                    }
                    else
                    {

                        return false;
                    }

                case enMode.UpdateMode:
                    return _UpdateOperationConvertStorages();

            }
            return false;
        }

        public static DataTable GetAllOperationsConvertStorages()
        {
            return clsOperationConvertStorgaesData.GetAllOperationsConvertStorages();



        }


    }
}
