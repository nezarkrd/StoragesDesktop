using Storages_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Storages_BuisnessLayer
{
    public class clsItemUnits
    {

        public enum enMode { AddMode = 0, UpdateMode = 1 }
        enMode Mode = enMode.AddMode;
        
        public int ItemUnitID { get; set; }
        public int ItemID { get; set; }
        public int UnitID { get; set; }
        public decimal BuyPrice { get; set; }
        public decimal SellPrice { get; set; }




        public clsItemUnits()
        {
            this.ItemUnitID = -1;
            this.ItemID =-1;
            this.UnitID = -1;
            this.BuyPrice = 0;
            this.SellPrice = 0; 




            Mode = enMode.AddMode;
        }


        private clsItemUnits(int ItemUnitID, int ItemID, int UnitID, decimal BuyPrice, decimal SellPrice)
        {
            this.ItemUnitID = ItemUnitID;
            this.ItemID = ItemID;
            this.UnitID = UnitID;
            this.BuyPrice = BuyPrice;
            this.SellPrice = SellPrice;


            Mode = enMode.UpdateMode;
        }





        public static clsItemUnits Find(int ItemUnitID)
        {


            int ItemID = -1 , UnitID = -1;
            decimal BuyPrice = 0, SellPrice = 0;
            
            bool isFound = clsItemsUnitsData.GetItemUnitByItemUnitID(ItemUnitID, ref ItemID, ref UnitID, ref BuyPrice, ref SellPrice);
        


            if (isFound == true)
            {
                return new clsItemUnits(ItemUnitID, ItemID, UnitID, BuyPrice, SellPrice);
     

            }
            else
            {
                return null;
            }





        }

       

        public static bool isItemUnitExist(int ItemUnitID)
        {
            return clsItemsUnitsData.IsItemUnitIDExist(ItemUnitID);
          

        }
    

        private bool _AddNewItemUnit()
        {

            if(!clsItemsUnitsData.CheckNewItemUnit(this.UnitID, this.ItemID))
            {
                this.ItemUnitID = clsItemsUnitsData.AddNewItemUnit(this.ItemID, this.UnitID, this.BuyPrice, this.SellPrice);
                return (this.ItemUnitID != -1);
            }
            else
            {
                return false;
            }
          


        }
        private bool _UpdateItemUnit()
        {
           
            
           return clsItemsUnitsData.UpdateItemUnit(this.ItemUnitID, this.ItemID, this.UnitID, this.BuyPrice, this.SellPrice);
            
          

        }


        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddMode:
                    if (_AddNewItemUnit())
                    {
                        Mode = enMode.UpdateMode;
                        return true;
                    }
                    else
                    {

                        return false;
                    }

                case enMode.UpdateMode:
                    return _UpdateItemUnit();

            }
            return false;
        }


        public static bool DeleteItemUnit(int ItemUnitID)
        {
            return clsItemsUnitsData.DeleteItemUnit(ItemUnitID);
        }
        
         public static bool IsUnitIDExist(int ItemID)
        {
            return clsItemsUnitsData.IsUnitIDExist(ItemID);
        }

        public static DataTable GetAllItemsUnits()
        {
            return clsItemsUnitsData.GetAllItemsUnits();



        }

        public static DataTable GetAllItemsUnitsByItemID(int ItemID)
        {
            return clsItemsUnitsData.GetAllItemsUnitsByItemID(ItemID);



        }

        public static bool GetUnitItemID(int ItemID, int UnitID, ref int ItemUnitID)
        {
            return clsItemsUnitsData.GetUnitItemID( ItemID,  UnitID, ref ItemUnitID);
        }
      





    }
}
