﻿using Storages_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storages_BuisnessLayer
{
    public class clsCountry
    {

        public int CountryID { get; set; }
        public string CountryName { get; set; }

        public clsCountry()
        {
            CountryID = -1;
            CountryName = "";
        }
        private clsCountry(int CountryID, string CountryName)
        {
            this.CountryID = CountryID;
            this.CountryName = CountryName;


        }


        public static clsCountry Find(int CountryID)
        {

            string CountryName = "";
            if (clsCountryData.GetCountryById(CountryID, ref CountryName))
            {
                return new clsCountry(CountryID, CountryName);
            }
            else
            {
                return null;
            }
        }


        public static clsCountry Find(string CountryName)
        {

            int CountryID = -1;
            if (clsCountryData.GetCountryByName(CountryName, ref CountryID))
            {
                return new clsCountry(CountryID, CountryName);
            }
            else
            {
                return null;
            }
        }




        public static DataTable GetAllCountries()
        {

            return clsCountryData.GetAllCountries();
        }








    }
}
