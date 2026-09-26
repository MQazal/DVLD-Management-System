using DVLD_DataAccessLayer;
using System;
using System.Data;

namespace DVLD_BusinessLogicLayer
{
    public class clsLocalDrivingLicenseApplication : clsApplication
    {
        private int _LocalDrivingLicenseApplicationID { set; get; }
        public int LocalDrivingLicenseApplicationID { get { return _LocalDrivingLicenseApplicationID; } }
        public int LicenseClassID { set; get; }
        public clsLicenseClass LicenseClassInfo;
        enum enMode { AddNew, Update }
        enMode _Mode;

        public clsLocalDrivingLicenseApplication()
        {
            this._LocalDrivingLicenseApplicationID = default(int);
            this.LicenseClassID = default(int);
            _Mode = enMode.AddNew;
        }

        private clsLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID, int LicenseClassID, int ApplicationID,
            DateTime ApplicationDate, enApplicationStatus ApplicationStatus, DateTime LastStatusDate,
            decimal PaidFees, int ApplicationTypeID, int ApplicantPersonID, int CreatedByUserID) :
            base (ApplicationID, ApplicationDate, ApplicationStatus, LastStatusDate,
             PaidFees, ApplicationTypeID, ApplicantPersonID, CreatedByUserID)
        {
            this._LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.LicenseClassID = LicenseClassID;
            this.LicenseClassInfo = clsLicenseClass.FindLicenseClass(this.LicenseClassID);
            this.ApplicationID = ApplicationID;
            this.ApplicationDate = ApplicationDate;
            this.ApplicationStatus = ApplicationStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicantPersonID = ApplicantPersonID;
            this.CreatedByUserID = CreatedByUserID;
            _Mode = enMode.Update;
        }

        private bool _AddNewLocalDrivingLicenseApplication()
        {
            this._LocalDrivingLicenseApplicationID = clsLocalDrivingLicenseApplicationData.Add(this.ApplicationID, this.LicenseClassID);
            return (this._LocalDrivingLicenseApplicationID != -1);
        }

        private bool _UpdateLocalDrivingLicenseApplication()
        {
            return clsLocalDrivingLicenseApplicationData.Update(this._LocalDrivingLicenseApplicationID, this.LicenseClassID);
        }

        public static clsLocalDrivingLicenseApplication FindLocalDrvingLicenseAppByLocalAppID(int LocalDrivingLicenseApplicationID)
        {
            int ApplicationID = 0, LicenseClassID = 0;

            if (clsLocalDrivingLicenseApplicationData.GetLocalDrivingLicenseApplicationInfoByID(LocalDrivingLicenseApplicationID, ref ApplicationID, ref LicenseClassID))
            {
                clsApplication App = clsApplication.FindApplication(ApplicationID);
                return new clsLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID, LicenseClassID, ApplicationID,
                App.ApplicationDate, (enApplicationStatus)App.ApplicationStatus, App.LastStatusDate,
                App.PaidFees, App.ApplicationTypeID, App.ApplicantPersonID, App.CreatedByUserID);
            }
            return null;
        }

        public static clsLocalDrivingLicenseApplication FindLocalDrvingLicenseAppByApplicationID(int ApplicationID)
        {
            int LocalDrivingLicenseApplicationID = 0, LicenseClassID = 0;

            if (clsLocalDrivingLicenseApplicationData.GetLocalDrivingLicenseApplicationInfoByApplicationID(ref LocalDrivingLicenseApplicationID, ApplicationID, ref LicenseClassID))
            {
                clsApplication App = clsApplication.FindApplication(ApplicationID);
                return new clsLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID, LicenseClassID, ApplicationID,
                App.ApplicationDate, (enApplicationStatus)App.ApplicationStatus, App.LastStatusDate,
                App.PaidFees, App.ApplicationTypeID, App.ApplicantPersonID, App.CreatedByUserID);
            }
            return null;
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewLocalDrivingLicenseApplication())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateLocalDrivingLicenseApplication();
            }

            return false;
        }

        public static DataTable GetLocalDrivingLicenseApplicationsList()
        {
            return clsLocalDrivingLicenseApplicationData.LoadLocalDrivingLicenseApplications();
        }

        public static bool DeleteLocalDrivingLicenseApplication(int ApplicationID)
        {
            return clsLocalDrivingLicenseApplicationData.Delete(ApplicationID) ? clsApplication.DeleteApplication(ApplicationID) : false;
        }

        public byte TotalTrialsPerTest(clsTestType.enTestType TestTypeID)
        {
            return clsLocalDrivingLicenseApplicationData.TotalTrialsPerTest(this.LocalDrivingLicenseApplicationID, (int)TestTypeID);
        }

        public bool DoesAttendTestType(clsTestType.enTestType TestTypeID)
        {
            return clsLocalDrivingLicenseApplicationData.DoesAttendTestType(this.LocalDrivingLicenseApplicationID, (int)TestTypeID);
        }

        public static bool IsPersonPassTestType(int LocalDrivingLicenseApplicationID, clsTestType.enTestType TestTypeID)
        {
            if (clsLocalDrivingLicenseApplicationData.DoesAttendTestType(LocalDrivingLicenseApplicationID, (int)TestTypeID))
            {
                return clsLocalDrivingLicenseApplicationData.IsPersonPassTestType(LocalDrivingLicenseApplicationID, (int)TestTypeID);
            }
            return false;
        }

        public byte TotalPassedTests()
        {
            return clsLocalDrivingLicenseApplicationData.TotalPassedTests(this.LocalDrivingLicenseApplicationID);
        }

        public bool SetApplicationInCompletedStatus()
        {
            return clsApplicationData.UpdateStatus(this.ApplicationID, (byte)enApplicationStatus.Completed);
        }

        public bool IssueDrivingLicenseForFirstTime(string IssueNotes, int CreatedByUserID)
        {
            clsDriver Driver = new clsDriver();

            if (clsDriver.IsDriverExist(this.PersonInfo.PersonID))
            {
                Driver = clsDriver.FindDriverByPersonID(this.PersonInfo.PersonID);
            }

            else
            {
                Driver.PersonID = this.PersonInfo.PersonID;
                Driver.CreatedByUserID = CreatedByUserID;
                Driver.CreatedDate = DateTime.Today.Date;
            }

            if (Driver.Save())
            {
                clsLicense NewLicense = new clsLicense();
                NewLicense.ApplicationID = this.ApplicationID;
                NewLicense.DriverID = Driver.DriverID;
                NewLicense.LicenseClassID = this.LicenseClassInfo.LicenseClassID;
                NewLicense.IssueDate = DateTime.Today.Date;
                NewLicense.ExpirationDate = DateTime.Today.Date.AddYears(this.LicenseClassInfo.DefaultValidityLength);
                NewLicense.Notes = IssueNotes;
                NewLicense.PaidFees = this.LicenseClassInfo.Fees;
                NewLicense.IsActive = true;
                NewLicense.IssueReason = clsLicense.enIssueReason.FirstTime;
                NewLicense.CreatedByUserID = CreatedByUserID;

                if (NewLicense.Save())
                {
                    return this.SetApplicationInCompletedStatus();
                }
            }

            return false;
        }
    }
}