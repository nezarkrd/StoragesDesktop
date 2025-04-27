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
    public class clsCategory
    {
        public enum enMode { AddMode = 0, UpdateMode = 1 }
        enMode Mode = enMode.AddMode;
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }




        public clsCategory()
        {
            this.CategoryID = -1;
            this.CategoryName = "";
            this.Description = "";
           


            Mode = enMode.AddMode;
        }


        private clsCategory(int CategoryID, string CategoryName, string Description)
        {
            this.CategoryID = CategoryID;
            this.CategoryName = CategoryName;
            this.Description = Description;
         

            Mode = enMode.UpdateMode;
        }

        public static clsCategory Find(int CategoryID)
        {


            string CategoryName = ""; string Description = "";
           
            
            bool isFound = clsCategoryData.GetCategoryByCategoryID(CategoryID, ref CategoryName, ref Description);

            if (isFound == true)
            {
                return new clsCategory( CategoryID,  CategoryName,  Description);

            }
            else
            {
                return null;
            }





        }

        public static clsCategory Find(string CategoryName)
        {
            int CategoryID = -1;
            string Description = "";

          
            bool isFound =clsCategoryData.GetCategoryByCategoryName(CategoryName, ref CategoryID, ref Description);

            if (isFound == true)
            {

                return new clsCategory(CategoryID, CategoryName, Description);
            }
            else
            {
                return null;
            }





        }

        public static bool isCategoryExist(int CategoryID)
        {

            return clsCategoryData.IsCategoryExist(CategoryID);

        }
        public static bool isCategoryExist(string CategoryName)
        {
            return clsCategoryData.IsCategoryExist(CategoryName);

        }





        private bool _AddNewCategory()
        {
        
            this.CategoryID =clsCategoryData.AddNewCategory(this.CategoryName, this.Description);
            return (this.CategoryID != -1);


        }
        private bool _UpdateCategory()
        {

            return clsCategoryData.UpdateCategory(this.CategoryID, this.CategoryName,this.Description);
            

        }


        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddMode:
                    if (_AddNewCategory())
                    {
                        Mode = enMode.UpdateMode;
                        return true;
                    }
                    else
                    {

                        return false;
                    }

                case enMode.UpdateMode:
                    return _UpdateCategory();

            }
            return false;
        }


        public static bool DeleteCategory(int CategoryID)
        {
            return clsCategoryData.DeleteCategory(CategoryID);  
           

        }

        public static DataTable GetAllCategories()
        {

            return clsCategoryData.GetAllCategories();
         

        }




    }
}
