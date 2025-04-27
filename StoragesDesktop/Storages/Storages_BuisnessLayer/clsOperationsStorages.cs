using Storages_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storages_BuisnessLayer
{
    public class clsOperationsStorages
    {


        public enum enMode { AddMode = 0, UpdateMode = 1 }
        enMode Mode = enMode.AddMode;
        public int OperationStorageID { get; set; }
        public int ItemUnitID { get; set; }
        public int StorageID { get; set; }
        public int OldAmount { get; set; }
        public int Amount { get; set; }
        public short TypeOperation { get; set; }
        public int NewAmount { get; set; }
        public DateTime DateOperation { get; set; }
        public string ReasonOperation { get; set; }
        public int EmployeeID { get; set; }
        public int UserID { get; set; }
        
  

        public clsOperationsStorages()
        {
            this.OperationStorageID = -1;
            this.ItemUnitID = -1;
            this.StorageID = -1;
            this.OldAmount = -1;
            this.Amount =-1;
            this.TypeOperation = -1;
            this.NewAmount =-1;
            this.DateOperation = DateTime.Now;
            this.ReasonOperation = "";
            this.EmployeeID = -1;
            this.UserID = -1;


            Mode = enMode.AddMode;
        }


        private clsOperationsStorages(int OperationStorageID, int ItemUnitID, int StorageID, int OldAmount,int Amount, short TypeOperation, int NewAmount,DateTime DateOperation,string ReasonOperation, int EmployeeID,int UserID)
        {
            this.OperationStorageID = OperationStorageID;
            this.ItemUnitID = ItemUnitID;
            this.StorageID = StorageID;
            this.OldAmount = OldAmount;
            this.Amount = Amount;
            this.TypeOperation = TypeOperation;
            this.NewAmount = NewAmount;
            this.DateOperation = DateOperation;
            this.ReasonOperation = ReasonOperation;
            this.EmployeeID = EmployeeID;
            this.UserID = UserID;


            Mode = enMode.UpdateMode;
        }





        public static clsOperationsStorages Find(int OperationStorageID)
        {


            int ItemUnitID = -1; int StorageID =-1; int OldAmount = -1;
            int Amount = -1; short TypeOperation = -1; int NewAmount = -1;
            DateTime DateOperation=DateTime.Now;    int EmployeeID = -1, UserID = -1;
            string ReasonOperation = "";

            bool isFound = clsOperationsStoragesData.GetOperationStorageByOperationStorageID(OperationStorageID, ref ItemUnitID, ref StorageID, ref OldAmount, ref Amount, ref TypeOperation, ref NewAmount, ref DateOperation,ref ReasonOperation, ref EmployeeID, ref UserID);




            if (isFound == true)
            {
                return new clsOperationsStorages(OperationStorageID, ItemUnitID, StorageID, OldAmount, Amount, TypeOperation, NewAmount, DateOperation, ReasonOperation, EmployeeID, UserID);

            }
            else
            {
                return null;
            }





        }

 

        public static bool isOperationStorageExist(int OperationStorageID)
        {
            return clsOperationsStoragesData.IsOperationStorageExist(OperationStorageID);   
        
        }
    

        private bool _AddOperationStorage()
        {
           this.OperationStorageID= clsOperationsStoragesData.AddNewOperationStorage(this.ItemUnitID, this.StorageID,this.Amount, this.TypeOperation,this.DateOperation,this.ReasonOperation, this.EmployeeID, this.UserID);
           
            return (this.OperationStorageID != -1);


        }
        private bool _UpdateOperationStorage()
        {
            return clsOperationsStoragesData.UpdateOperationStorage(this.OperationStorageID, this.ItemUnitID, this.StorageID, this.OldAmount, this.Amount, this.TypeOperation, this.NewAmount, this.DateOperation, this.ReasonOperation, this.EmployeeID, this.UserID);
        
        }


        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddMode:
                    if (_AddOperationStorage())
                    {
                        Mode = enMode.UpdateMode;
                        return true;
                    }
                    else
                    {

                        return false;
                    }

                case enMode.UpdateMode:
                    return _UpdateOperationStorage();

            }
            return false;
        }


        public static bool DeleteOperationStorage(int OperationStorageID)
        {

            return clsOperationsStoragesData.DeleteOperationStorage(OperationStorageID);
          

        }

        public static DataTable GetAllOperationsStorages()
        {
            return clsOperationsStoragesData.GetAllOperationsStorages();



        }




        public static bool GetUnitItemID(int ItemID,int UnitID,ref int ItemUnitID)
        {

            return clsItemsUnitsData.GetUnitItemID(ItemID, UnitID, ref ItemUnitID);
        }














    }
}
