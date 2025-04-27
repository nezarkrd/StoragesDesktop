using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Storages_DataAccessLayer;
namespace Storages_BuisnessLayer
{
    public class clsUnit
    {
        public enum enMode { AddMode = 0, UpdateMode = 1 }
        enMode Mode = enMode.AddMode;
        public int UnitID { get; set; }
        public string UnitName { get; set; }
        public int SmallerUnitID { get; set; }
        public int NumberOfContent { get; set; }
        public clsUnit infoUnit { get; set; }


        public clsUnit()
        {
            this.UnitID = -1;
            this.UnitName = "";
            this.SmallerUnitID = -1;
            this.NumberOfContent = -1;
           

            Mode = enMode.AddMode;
        }


        private clsUnit(int UnitID, string UnitName, int SmallerUnitID, int NumberOfContent)
        {
            this.UnitID = UnitID;
            this.UnitName = UnitName;
            this.SmallerUnitID = SmallerUnitID;
            this.NumberOfContent = NumberOfContent;
          
            Mode = enMode.UpdateMode;
        }

        public static clsUnit Find(int UnitID)
        {

        
            string UnitName = ""; int SmallerUnitID=-1,  NumberOfContent = -1;


            bool isFound = clsUnitsData.GetUnitByUnitID(UnitID, ref  UnitName, ref  SmallerUnitID, ref  NumberOfContent);

            if (isFound == true)
            {
                return new clsUnit(UnitID,  UnitName,  SmallerUnitID,  NumberOfContent);
               
            }
            else
            {
                return null;
            }





        }

        public static clsUnit Find(string UnitName)
        {
         

            int UnitID = -1; int SmallerUnitID = -1, NumberOfContent = -1;


           
            bool isFound = clsUnitsData.GetUnitByUnitName(UnitName, ref UnitID, ref SmallerUnitID, ref NumberOfContent);

            if (isFound == true)
            {

                 return new clsUnit(UnitID, UnitName, SmallerUnitID, NumberOfContent);
            }
            else
            {
                return null;
            }





        }

        public static bool isUnitExist(int UnitID)
        {
            return clsUnitsData.IsUnitExist(UnitID);    
           
        }
        public static bool isUnitExist(string UnitName)
        {
            return clsUnitsData.IsUnitExist(UnitName);
            
        }





        private bool _AddNewUnit()
        {
            if (!clsUnitsData.CheckNewUnit(this.UnitName))
            {
                this.UnitID = clsUnitsData.AddNewUnit(this.UnitName, this.SmallerUnitID, this.NumberOfContent);
                return (this.UnitID != -1);
            }
            else
            {
                return false;
            }
          


        }
        private bool _UpdateUnit()
        {
            if (!clsUnitsData.CheckNewUnit(this.UnitName))
            {
                return clsUnitsData.UpdateUnit(this.UnitID, this.UnitName, this.SmallerUnitID, this.NumberOfContent);
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
                    if (_AddNewUnit())
                    {
                        Mode = enMode.UpdateMode;
                        return true;
                    }
                    else
                    {

                        return false;
                    }

                case enMode.UpdateMode:
                    return _UpdateUnit();

            }
            return false;
        }


        public static bool DeleteUnit(int UnitID)
        {

            return clsUnitsData.DeleteUnit(UnitID); 
           

        }

        public static DataTable GetAllUnits()
        {
            return clsUnitsData.GetAllUnits();

        }
        public static DataTable GetAllUnitsByItemID(int ItemID)
        {
            return clsUnitsData.GetAllUnitsByItemID(ItemID);

        }


    }
}
