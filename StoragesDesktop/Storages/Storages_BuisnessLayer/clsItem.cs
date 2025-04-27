using Storages_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Storages_BuisnessLayer
{
    public class clsItem
    {

        public enum enMode { AddMode = 0, UpdateMode = 1 }
        enMode Mode = enMode.AddMode;
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public string Description { get; set; }
        public int CategoryID { get; set; }
        public clsCategory CategoryInfo { get; set; }



        public clsItem()
        {
            this.ItemID = -1;
            this.ItemName = "";
            this.Description = "";
            this.CategoryID = -1;



            Mode = enMode.AddMode;
        }


        private clsItem(int ItemID, string ItemName, string Description,int CategoryID)
        {
            this.ItemID = ItemID;
            this.ItemName = ItemName;
            this.Description = Description;
            this.CategoryID = CategoryID;


            Mode = enMode.UpdateMode;
        }





        public static clsItem Find(int ItemID)
        {


            string ItemName = ""; string Description = ""; int CategoryID = -1;

            bool isFound = clsItemsData.GetItemByItemID(ItemID, ref  ItemName, ref  Description, ref  CategoryID);
           

            if (isFound == true)
            {
                return new clsItem( ItemID,  ItemName,  Description,  CategoryID);
            
            }
            else
            {
                return null;
            }





        }

        public static clsItem Find(string ItemName)
        {
            int ItemID = -1; string Description = ""; int CategoryID = -1;

            bool isFound = clsItemsData.GetItemByItemName(ItemName, ref ItemID, ref Description, ref CategoryID);
          

            if (isFound == true)
            {
    
                return new clsItem(ItemID, ItemName, Description, CategoryID);
            }
            else
            {
                return null;
            }





        }

        public static bool isItemExist(int ItemID)
        {
            return clsItemsData.IsItemExist(ItemID);
     

        }
        public static bool isItemExist(string CategoryName)
        {
            return clsItemsData.IsItemExist(CategoryName);

        }

        private bool _AddNewItem()
        {
            if (!clsItemsData.CheckNewItem(this.ItemName)) {
                this.ItemID = clsItemsData.AddNewItem(this.ItemName, this.Description, this.CategoryID);
                return (this.ItemID != -1);


            }
            else
            {
                return false;
            }
          


        }
        private bool _UpdateItem()
        {
            if (!clsItemsData.CheckNewItem(this.ItemName)) {
                return clsItemsData.UpdateItem(this.ItemID, this.ItemName, this.Description, this.CategoryID);
            }
            else
            {
                return false;
            }


        }


        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddMode:
                    if (_AddNewItem())
                    {
                        Mode = enMode.UpdateMode;
                        return true;
                    }
                    else
                    {

                        return false;
                    }

                case enMode.UpdateMode:
                    return _UpdateItem();

            }
            return false;
        }


        public static bool DeleteItem(int ItemID)
        {
            return clsItemsData.DeleteItem(ItemID); 
          


        }

        public static DataTable GetAllItems()
        {
            return clsItemsData.GetAllItems();  
            


        }









    }
}
