using Storages;
using Storages_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storages_BuisnessLayer
{
    public class clsStorageContent
    {
        public enum enMode { AddMode = 0, UpdateMode = 1 }
        enMode Mode = enMode.AddMode;
        public int StoreContentID { get; set; }
        public int ItemUnitID { get; set; }
        public int ItemID { get; set; }
        public int StorageID { get; set; }
        public int Amount { get; set; }
        public decimal BuyPrice { get; set; }
        public decimal TotalBuyPrice { get; set; }
        public decimal SellPrice { get; set; }
        public decimal TotalSellPrice { get; set; }
        
       


        public clsStorageContent()
        {
            this.StoreContentID = -1;
            this.ItemUnitID = -1;
            this.ItemID = -1;
            this.StorageID =-1;
            this.Amount = 0;
            this.BuyPrice = 0;
            this.TotalBuyPrice =0;
            this.SellPrice =0;
            this.TotalSellPrice = 0;
          

            Mode = enMode.AddMode;
        }


        private clsStorageContent(int StoreContentID, int ItemUnitID, int ItemID, int StorageID, int Amount, decimal BuyPrice, decimal TotalBuyPrice, decimal SellPrice, decimal TotalSellPrice)
        {
            this.StoreContentID = -StoreContentID;
            this.ItemUnitID = ItemUnitID;
            this.ItemID = ItemID;
            this.StorageID = StorageID;
            this.Amount = Amount;
            this.BuyPrice = BuyPrice;
            this.TotalBuyPrice = TotalBuyPrice;
            this.SellPrice = SellPrice;
            this.TotalSellPrice = TotalSellPrice;
            //this.infoCountry = clsCountry.Find(NationalCountryID);
            Mode = enMode.UpdateMode;
        }

        public static clsStorageContent Find(int StoreContentID)
        {

            int ItemUnitID = -1, ItemID = -1, StorageID = -1, Amount = 0;
            decimal BuyPrice = 0, TotalBuyPrice=0, SellPrice=0, TotalSellPrice=0;

            bool isFound = clsStorageContentData.GetStorageContentByID(StoreContentID, ref ItemUnitID, ref ItemID, ref StorageID, ref Amount, ref BuyPrice, ref TotalBuyPrice, ref SellPrice, ref TotalSellPrice);
            

            if (isFound == true)
            {
                return new clsStorageContent(StoreContentID, ItemUnitID, ItemID, StorageID, Amount, BuyPrice, TotalBuyPrice, SellPrice, TotalSellPrice);
              
            }
            else
            {
                return null;
            }





        }

        public static clsStorageContent FindByStorageID(int StorageID)
        {
            int ItemUnitID = -1, ItemID = -1, StoreContentID = -1, Amount = 0;
            decimal BuyPrice = 0, TotalBuyPrice = 0, SellPrice = 0, TotalSellPrice = 0;

            bool isFound = clsStorageContentData.GetStorageContentByStorageID(StorageID, ref StoreContentID, ref ItemUnitID, ref ItemID, ref Amount, ref BuyPrice, ref TotalBuyPrice, ref SellPrice, ref TotalSellPrice);

          

            if (isFound == true)
            {
                return new clsStorageContent(StoreContentID, ItemUnitID, ItemID, StorageID, Amount, BuyPrice, TotalBuyPrice, SellPrice, TotalSellPrice);

            }
            else
            {
                return null;
            }





        }

        public static bool isStorageExist(int StoreContentID)
        {
            return clsStorageContentData.IsStorageExist(StoreContentID);
          
        }



        public static bool isItemInStoragesExist(int ItemID)
        {
            return clsStorageContentData.IsItemExistInStorages( ItemID);

        }


        

       public static bool IsItemUnitExistInStorages(int ItemUnitID, int StorageID)
        {
            return clsStorageContentData.IsItemUnitExistInStorage(ItemUnitID, StorageID);

        }
        
       public static bool IsAmountItemUnitExistInStorage(int ItemUnitID, int StorageID,int Amount)
        {
            return clsStorageContentData.IsAmountItemUnitExistInStorage(ItemUnitID, StorageID, Amount);

        }

        public static bool isPersonExist(int StorageID)
        {

            return clsStorageContentData.IsStorageExistByStorageID(StorageID);

        }


        public static DataTable GetAllStorageContents()
        {
            return clsStorageContentData.GetAllStoragesContents();

        }



        public static DataTable GetAllStorageContentsByStorageID(int StorageID)
        {
            return clsStorageContentData.GetAllStoragesContentsByStorageID(StorageID);

        }

        public static DataTable GetAllStorageContentsByItemID(int ItemID)
        {
            return clsStorageContentData.GetAllStoragesContentsByItemID(ItemID);

        }





    }
}
