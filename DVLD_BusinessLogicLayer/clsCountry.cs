using DVLD_DataAccessLayer;
using System;
using System.Data;

namespace DVLD_BusinessLogicLayer
{
    public class clsCountry
    {
        public int CountryID { set; get; }
        public string CountryName { set; get; }

        public clsCountry()
        {
            this.CountryID = default(int);
            this.CountryName = default(string);
        }

        private clsCountry(int CountryID, string CountryName)
        {
            this.CountryID = CountryID;
            this.CountryName = CountryName;
        }

        public static clsCountry Find(int CountryID)
        {
            string CountryName = default(string);
            if (clsCountryData.GetCountryInfoByID(CountryID, ref CountryName))
                return new clsCountry(CountryID, CountryName);
            else
                return null;
        }

        public static clsCountry Find(string CountryName)
        {
            int CountryID = default(int);
            if (clsCountryData.GetCountryInfoByName(ref CountryID, CountryName))
                return new clsCountry(CountryID, CountryName);
            else
                return null;
        }

        public static DataTable GetCountriesList()
        {
            return clsCountryData.LoadCountriesList();
        }
    }
}