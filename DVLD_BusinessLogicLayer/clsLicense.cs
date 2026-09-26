using DVLD_DataAccessLayer;
using System;
using System.Data;

namespace DVLD_BusinessLogicLayer
{
    public class clsLicense
    {
        public int LicenseID { set; get; }
        public int ApplicationID { set; get; }
        public clsApplication ApplicationInfo;
        public int DriverID { set; get; }
        public clsDriver DriverInfo;
        public int LicenseClassID { set; get; }
        public clsLicenseClass LicenseClassInfo;
        public DateTime IssueDate { set; get; }
        public DateTime ExpirationDate { set; get; }
        public string Notes { set; get; }
        public decimal PaidFees { set; get; }
        public bool IsActive { set; get; }
        public enum enIssueReason { FirstTime = 1, Renew = 2, DamagedReplacement = 3, LostReplacement = 4 };
        public enIssueReason IssueReason { set; get; }
        public string IssueReasonText
        {
            get
            {
                return GetIssueReasonText(this.IssueReason);
            }
        }
        public int CreatedByUserID { set; get; }
        public clsUser UserInfo;
        public clsDetainedLicense DetainedLicenseInfo { set; get; }
        public bool IsDetained
        {
            get { return clsDetainedLicense.IsLicenseDetained(this.LicenseID); }
        }
        enum _enMode { AddNew, Update }
        _enMode _Mode;

        public clsLicense()
        {
            this.LicenseID = default(int);
            this.ApplicationID = default(int);
            this.DriverID = default(int);
            this.LicenseClassID = default(int);
            this.IssueDate = default(DateTime);
            this.ExpirationDate = default(DateTime);
            this.Notes = default(string);
            this.PaidFees = default(decimal);
            this.IsActive = default(bool);
            this.CreatedByUserID = default(int);
            this._Mode = _enMode.AddNew;
        }

        private clsLicense(int LicenseID, int ApplicationID, int DriverID, int LicenseClassID, DateTime IssueDate,
            DateTime ExpirationDate, string Notes, decimal PaidFees, bool IsActive, enIssueReason IssueReason,
            int CreatedByUserID)
        {
            this.LicenseID = LicenseID;
            this.ApplicationID = ApplicationID;
            this.ApplicationInfo = clsApplication.FindApplication(ApplicationID);
            this.DriverID = DriverID;
            this.DriverInfo = clsDriver.FindDriverByDriverID(DriverID);
            this.LicenseClassID = LicenseClassID;
            this.LicenseClassInfo = clsLicenseClass.FindLicenseClass(LicenseClassID);
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.Notes = Notes;
            this.PaidFees = PaidFees;
            this.IsActive = IsActive;
            this.IssueReason = IssueReason;
            this.CreatedByUserID = CreatedByUserID;
            this.UserInfo = clsUser.FindUserByUserID(CreatedByUserID);
            this.DetainedLicenseInfo = clsDetainedLicense.FindByLicenseID(LicenseID);
            this._Mode = _enMode.Update;
        }

        public static string GetIssueReasonText(enIssueReason IssueReason)
        {
            switch (IssueReason)
            {
                case enIssueReason.FirstTime:
                    return "First Time";
                case enIssueReason.Renew:
                    return "Renew";
                case enIssueReason.DamagedReplacement:
                    return "Replacement for Damaged";
                case enIssueReason.LostReplacement:
                    return "Replacement for Lost";
                default:
                    return "First Time";
            }
        }

        private bool _AddNewLicense()
        {
            this.LicenseID = clsLicenseData.Add(this.ApplicationID, this.DriverID, this.LicenseClassID, this.IssueDate,
            this.ExpirationDate, this.Notes, this.PaidFees, this.IsActive, (byte)this.IssueReason, this.CreatedByUserID);
            return (this.LicenseID != -1);
        }

        private bool _UpdateLicense()
        {
            return clsLicenseData.Update(this.LicenseID, this.ExpirationDate, this.Notes, this.IsActive, (byte)this.IssueReason);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case _enMode.AddNew:
                    if (_AddNewLicense())
                    {
                        _Mode = _enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case _enMode.Update:
                    return _UpdateLicense();
            }
            return false;
        }

        public static DataTable GetLicensesList(int DriverID)
        {
            return clsLicenseData.LoadLicensesList(DriverID);
        }

        public static clsLicense FindLicenseByLicenseID(int LicenseID)
        {
            int ApplicationID = default(int), DriverID = default(int), LicenseClassID = default(int),
                CreatedByUserID = default(int);
            DateTime IssueDate = default(DateTime), ExpirationDate = default(DateTime);
            string Notes = default(string); decimal PaidFees = default(decimal);
            bool IsActive = default(bool); byte IssueReason = default(byte);

            if (clsLicenseData.FindLicenseByLicenseID(LicenseID, ref ApplicationID, ref DriverID, ref LicenseClassID, ref IssueDate,
                ref ExpirationDate, ref Notes, ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID))
                return new clsLicense(LicenseID, ApplicationID, DriverID, LicenseClassID, IssueDate, ExpirationDate, Notes,
                    PaidFees, IsActive, (enIssueReason)IssueReason, CreatedByUserID);
            else
                return null;
        }

        public static clsLicense FindLicenseByApplicationID(int ApplicationID)
        {
            int LicenseID = default(int), DriverID = default(int), LicenseClassID = default(int),
                CreatedByUserID = default(int);
            DateTime IssueDate = default(DateTime), ExpirationDate = default(DateTime);
            string Notes = default(string); decimal PaidFees = default(decimal);
            bool IsActive = default(bool); byte IssueReason = default(byte);

            if (clsLicenseData.FindLicenseByApplicationID(ref LicenseID, ApplicationID, ref DriverID, ref LicenseClassID, ref IssueDate,
                ref ExpirationDate, ref Notes, ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID))
                return new clsLicense(LicenseID, ApplicationID, DriverID, LicenseClassID, IssueDate, ExpirationDate, Notes,
                    PaidFees, IsActive, (enIssueReason)IssueReason, CreatedByUserID);
            else
                return null;
        }

        public static int GetActiveLicenseIDByPersonID(int PersonID, int LicenseClassID)
        {
            return clsLicenseData.GetActiveLicenseID(PersonID, LicenseClassID);
        }

        public static bool IsLicenseExit(int PersonID, int LicenseClassID)
        {
            return clsLicenseData.GetActiveLicenseID(PersonID, LicenseClassID) != -1;
        }

        public static bool IsLicenseExit(int ApplicationID)
        {
            return clsLicenseData.IsLicesneExit(ApplicationID);
        }

        public bool IsLicenseExpired()
        {
            return (this.ExpirationDate < DateTime.Today.Date);
        }

        public bool DeactiveCurrentLicense()
        {
            return clsLicenseData.DeactivateLicense(this.LicenseID);
        }

        public clsLicense RenewLicense(string Notes, int CreatedByUserID)
        {
            clsApplication NewApp = new clsApplication();
            NewApp.ApplicationDate = DateTime.Today.Date;
            NewApp.ApplicationStatus = clsApplication.enApplicationStatus.Completed;
            NewApp.LastStatusDate = DateTime.Today.Date;
            NewApp.ApplicationTypeID = Convert.ToInt32(clsApplication.enApplicationType.RenewDrivingLicense);
            NewApp.PaidFees = clsApplicationType.GetApplicationTypeFees((int)clsApplication.enApplicationType.RenewDrivingLicense);
            NewApp.ApplicantPersonID = this.DriverInfo.PersonInfo.PersonID;
            NewApp.CreatedByUserID = CreatedByUserID;

            if (NewApp.Save())
            {
                clsLicense NewLicense = new clsLicense();
                NewLicense.ApplicationID = NewApp.ApplicationID;
                NewLicense.DriverID = this.DriverInfo.DriverID;
                NewLicense.LicenseClassID = this.LicenseClassInfo.LicenseClassID;
                NewLicense.IssueDate = DateTime.Today.Date;
                NewLicense.ExpirationDate = DateTime.Today.Date.AddYears(this.LicenseClassInfo.DefaultValidityLength);
                NewLicense.Notes = Notes;
                NewLicense.PaidFees = this.LicenseClassInfo.Fees;
                NewLicense.IsActive = true;
                NewLicense.IssueReason = enIssueReason.Renew;
                NewLicense.CreatedByUserID = CreatedByUserID;

                if (NewLicense.Save())
                {
                    if (this.DeactiveCurrentLicense())
                        return NewLicense;
                }
            }

            return null;
        }

        public clsLicense ReplaceLicense(enIssueReason IssueReason, string Notes, int CreatedByUserID)
        {
            clsApplication NewApp = new clsApplication();
            NewApp.ApplicationDate = DateTime.Today.Date;
            NewApp.ApplicationStatus = clsApplication.enApplicationStatus.Completed;
            NewApp.LastStatusDate = DateTime.Today.Date;
            NewApp.ApplicationTypeID = IssueReason == enIssueReason.DamagedReplacement ?
                Convert.ToInt32(clsApplication.enApplicationType.ReplaceDamagedDrivingLicense)
                : Convert.ToInt32(clsApplication.enApplicationType.ReplaceLostDrivingLicense);
            NewApp.PaidFees = clsApplicationType.GetApplicationTypeFees(NewApp.ApplicationTypeID);
            NewApp.ApplicantPersonID = this.DriverInfo.PersonInfo.PersonID;
            NewApp.CreatedByUserID = CreatedByUserID;

            if (NewApp.Save())
            {
                clsLicense NewLicense = new clsLicense();
                NewLicense.ApplicationID = NewApp.ApplicationID;
                NewLicense.DriverID = this.DriverInfo.DriverID;
                NewLicense.LicenseClassID = this.LicenseClassInfo.LicenseClassID;
                NewLicense.IssueDate = DateTime.Today.Date;
                NewLicense.ExpirationDate = this.ExpirationDate;
                NewLicense.Notes = Notes;
                NewLicense.PaidFees = 0;
                NewLicense.IsActive = true;
                NewLicense.IssueReason = IssueReason;
                NewLicense.CreatedByUserID = CreatedByUserID;

                if (NewLicense.Save())
                {
                    if (this.DeactiveCurrentLicense())
                        return NewLicense;
                }
            }

            return null;
        }

        public bool ReleaseDetainedLicense(int ReleasedByUserID)
        {
            clsApplication NewApp = new clsApplication();
            NewApp.ApplicationDate = DateTime.Today.Date;
            NewApp.ApplicationStatus = clsApplication.enApplicationStatus.Completed;
            NewApp.LastStatusDate = DateTime.Today.Date;
            NewApp.ApplicationTypeID = Convert.ToInt32(clsApplication.enApplicationType.ReleaseDetainedDrivingLicense);
            NewApp.PaidFees = clsApplicationType.GetApplicationTypeFees((int)clsApplication.enApplicationType.ReleaseDetainedDrivingLicense);
            NewApp.ApplicantPersonID = this.DriverInfo.PersonInfo.PersonID;
            NewApp.CreatedByUserID = ReleasedByUserID;

            if (NewApp.Save())
            {
                this.DetainedLicenseInfo.IsReleased = true;
                this.DetainedLicenseInfo.ReleaseDate = DateTime.Today.Date;
                this.DetainedLicenseInfo.ReleasedByUserID = ReleasedByUserID;
                this.DetainedLicenseInfo.ReleaseApplicationID = NewApp.ApplicationID;

                if (this.DetainedLicenseInfo.ReleaseDetainedLicense())
                    return true;
            }

            return false;
        }
    }
}