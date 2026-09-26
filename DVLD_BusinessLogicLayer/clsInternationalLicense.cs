using DVLD_DataAccessLayer;
using System;
using System.Data;

namespace DVLD_BusinessLogicLayer
{
    public class clsInternationalLicense
    {
        public int InternationalLicenseID { get; set; }
        public int ApplicationID { get; set; }
        public clsApplication ApplicationInfo;
        public int DriverID { get; set; }
        public clsDriver DriverInfo;
        public int IssuedUsingLocalLicenseID { get; set; }
        public clsLicense LocalLicenseInfo;
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByUserID { get; set; }
        public clsUser UserInfo;
        enum _enMode { AddNew, Update }
        _enMode _Mode;

        public clsInternationalLicense()
        {
            this.InternationalLicenseID = default(int);
            this.ApplicationID = default(int);
            this.DriverID = default(int);
            this.IssuedUsingLocalLicenseID = default(int);
            this.IssueDate = default(DateTime);
            this.ExpirationDate = default(DateTime);
            this.IsActive = default(bool);
            this.CreatedByUserID = default(int);
            this._Mode = _enMode.AddNew;
        }

        private clsInternationalLicense(int InternationalLicenseID, int ApplicationID, int DriverID, int IssuedUsingLocalLicenseID,
            DateTime IssueDate, DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {
            this.InternationalLicenseID = InternationalLicenseID;
            this.ApplicationID = ApplicationID;
            this.ApplicationInfo = clsApplication.FindApplication(ApplicationID);
            this.DriverID = DriverID;
            this.DriverInfo = clsDriver.FindDriverByDriverID(DriverID);
            this.IssuedUsingLocalLicenseID = IssuedUsingLocalLicenseID;
            this.LocalLicenseInfo = clsLicense.FindLicenseByLicenseID(IssuedUsingLocalLicenseID);
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.IsActive = IsActive;
            this.CreatedByUserID = CreatedByUserID;
            this.UserInfo = clsUser.FindUserByUserID(CreatedByUserID);
            this._Mode = _enMode.Update;
        }

        private bool _AddNewInternationalLicense()
        {
            this.InternationalLicenseID = clsInternationalLicenseData.Add(this.ApplicationID, this.DriverID,
                this.IssuedUsingLocalLicenseID, this.IssueDate, this.ExpirationDate, this.IsActive, this.CreatedByUserID);
            return (this.InternationalLicenseID != -1);
        }

        private bool _UpdateInternationalLicense()
        {
            return clsInternationalLicenseData.Update(this.InternationalLicenseID, this.ExpirationDate,
                this.IsActive);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case _enMode.AddNew:
                    if (_AddNewInternationalLicense())
                    {
                        _Mode = _enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case _enMode.Update:
                    return _UpdateInternationalLicense();
            }
            return false;
        }

        public static DataTable GetInternationalLicensesList()
        {
            return clsInternationalLicenseData.LoadInternationalLicensesList();
        }

        public static DataTable GetInternationalLicensesList(int DriverID)
        {
            return clsInternationalLicenseData.LoadInternationalLicensesList(DriverID);
        }

        public static clsInternationalLicense FindInternationalLicenseByInternationalLicenseID(int InternationalLicenseID)
        {
            int ApplicationID = default(int), DriverID = default(int), IssuedUsingLocalLicenseID = default(int),
                CreatedByUserID = default(int); DateTime IssueDate = default(DateTime), ExpirationDate = default(DateTime);
            bool IsActive = default(bool);

            if (clsInternationalLicenseData.FindInternationalLicenseByInternationalLicenseID(InternationalLicenseID,
                ref ApplicationID, ref DriverID, ref IssuedUsingLocalLicenseID, ref IssueDate, ref ExpirationDate, ref IsActive,
                ref CreatedByUserID))
                return new clsInternationalLicense(InternationalLicenseID, ApplicationID, DriverID,
                    IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID);
            else
                return null;
        }

        public static int GetActiveInternationalLicenseIDByDriverID(int DriverID)
        {
            return clsInternationalLicenseData.GetActiveInternationalLicenseIDByDriverID(DriverID);
        }
    }
}