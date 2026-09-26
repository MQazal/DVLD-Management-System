using System;
using DVLD_DataAccessLayer;
using System.Data;

namespace DVLD_BusinessLogicLayer
{
    public class clsApplicationType
    {
        public int ApplicationTypeID { get; }
        public string ApplicationTitle { set; get; }
        public decimal ApplicationFees { set; get; }

        private clsApplicationType(int ApplicationTypeID, string ApplicationTitle, decimal ApplicationFees)
        {
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationTitle = ApplicationTitle;
            this.ApplicationFees = ApplicationFees;
        }

        public static clsApplicationType FindApplicationType(int ApplicationTypeID)
        {
            string ApplicationTitle = default(string);
            decimal ApplicationFees = default(decimal);
            if (clsApplicationTypeData.Find(ApplicationTypeID, ref ApplicationTitle, ref ApplicationFees))
            {
                return new clsApplicationType(ApplicationTypeID, ApplicationTitle, ApplicationFees);
            }
            return null;
        }

        public bool UpdateApplicationType()
        {
            return clsApplicationTypeData.Update(this.ApplicationTypeID, this.ApplicationTitle, this.ApplicationFees);
        }

        public static DataTable GetApplicationTypesList()
        {
            return clsApplicationTypeData.LoadApplicationsList();
        }

        public static string GetApplicationTypeTitle(int ApplicationTypeID)
        {
            return clsApplicationTypeData.GetApplicationTitle(ApplicationTypeID);
        }

        public static decimal GetApplicationTypeFees(int ApplicationTypeID)
        {
            return clsApplicationTypeData.GetApplicationFees(ApplicationTypeID);
        }
    }
}