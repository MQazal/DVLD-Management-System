using DVLD_DataAccessLayer;
using System;
using System.Data;

namespace DVLD_BusinessLogicLayer
{
    public class clsApplication
    {
        public enum enApplicationType
        {
            NewLocalLicense = 1, RenewDrivingLicense = 2, ReplaceLostDrivingLicense = 3,
            ReplaceDamagedDrivingLicense = 4, ReleaseDetainedDrivingLicense = 5, NewInternationalLicense = 6, RetakeTest = 7
        };

        public int ApplicationID { set; get; }
        public DateTime ApplicationDate { set; get; }

        public enum enApplicationStatus { New = 1, Cancelled = 2, Completed = 3 };
        public enApplicationStatus ApplicationStatus { set; get; }
        public string StatusText
        {
            get
            {
                switch (ApplicationStatus)
                {
                    case enApplicationStatus.New:
                        return "New";
                    case enApplicationStatus.Cancelled:
                        return "Cancelled";
                    case enApplicationStatus.Completed:
                        return "Completed";
                    default:
                        return "Unknown";
                }
            }
        }

        public DateTime LastStatusDate { set; get; }
        public decimal PaidFees { set; get; }

        public int ApplicationTypeID { set;  get; }
        public clsApplicationType ApplicationTypeInfo;

        public int ApplicantPersonID { set; get; }
        public string ApplicantFullName
        {
            get { return PersonInfo.FullName; }
        }
        public clsPerson PersonInfo;

        public int CreatedByUserID { set;  get; }
        public clsUser CreatedByUserInfo;

        enum enMode { AddNew, Update }
        enMode _Mode;

        // Default Constructor -> Add New Application
        public clsApplication()
        {
            this.ApplicationDate = default(DateTime);
            this.ApplicationStatus = default(byte);
            this.LastStatusDate = default(DateTime);
            this.ApplicationStatus = enApplicationStatus.New;
            this.PaidFees = default(decimal);
            this.ApplicationTypeID = default(int);
            this.ApplicantPersonID = default(int);
            this.CreatedByUserID = default(int);
            _Mode = enMode.AddNew;
        }

        // Parametrized Constructor -> Find Application
        protected clsApplication(int ApplicationID, DateTime ApplicationDate, enApplicationStatus ApplicationStatus, DateTime LastStatusDate,
            decimal PaidFees, int ApplicationTypeID, int ApplicantPersonID, int CreatedByUserID)
        {
            this.ApplicationID = ApplicationID;
            this.ApplicationDate = ApplicationDate;
            this.ApplicationStatus = ApplicationStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicantPersonID = ApplicantPersonID;
            this.CreatedByUserID = CreatedByUserID;
            ApplicationTypeInfo = clsApplicationType.FindApplicationType(this.ApplicationTypeID);
            PersonInfo = clsPerson.FindPerson(this.ApplicantPersonID);
            CreatedByUserInfo = clsUser.FindUserByUserID(CreatedByUserID);
            _Mode = enMode.Update;
        }

        private bool _AddNewApplication()
        {
            this.ApplicationID = clsApplicationData.Add(this.ApplicationDate, (byte)this.ApplicationStatus, this.LastStatusDate,
            this.PaidFees, this.ApplicationTypeID, this.ApplicantPersonID, this.CreatedByUserID);
            return (this.ApplicationID != -1);
        }

        private bool _UpdateApplication()
        {
            return clsApplicationData.Update(this.ApplicationID, this.ApplicationDate, (byte)this.ApplicationStatus, this.LastStatusDate,
                                             this.PaidFees, this.ApplicationTypeID, this.ApplicantPersonID, this.CreatedByUserID);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewApplication())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateApplication();
            }

            return false;
        }

        public static clsApplication FindApplication(int ApplicationID)
        {
            DateTime ApplicationDate = default(DateTime), LastStatusDate = default(DateTime);
            byte ApplicationStatus = default(byte);
            decimal PaidFees = default(decimal);
            int ApplicationTypeID = default(int), ApplicantPersonID = default(int), CreatedByUserID = default(int);

            if (clsApplicationData.Find(ApplicationID, ref ApplicationDate, ref ApplicationStatus, ref LastStatusDate,
                ref PaidFees, ref ApplicationTypeID, ref ApplicantPersonID, ref CreatedByUserID))
            {
                return new clsApplication(ApplicationID, ApplicationDate, (enApplicationStatus)ApplicationStatus, LastStatusDate, PaidFees, ApplicationTypeID,
                    ApplicantPersonID, CreatedByUserID);
            }
            return null;
        }

        public static bool DeleteApplication(int ApplicationID)
        {
            return clsApplicationData.Delete(ApplicationID);
        }

        public static DataTable GetApplicationsList()
        {
            return clsApplicationData.LoadApplicationsList();
        }

        public bool Cancel()
        {
            return clsApplicationData.UpdateStatus(this.ApplicationID, 2);
        }

        public bool SetComplete()
        {
            return clsApplicationData.UpdateStatus(this.ApplicationID, 3);
        }

        // Any type of applications except LDLA
        public static bool DoesPersonHaveActiveApplication(int ApplicantPersonID, clsApplication.enApplicationType ApplicationTypeID)
        {
            return clsApplicationData.DoesPersonHaveActiveApplication(ApplicantPersonID, (int)ApplicationTypeID);
        }

        // Local Driving License Application
        public static bool DoesPersonHaveActiveApplication(int ApplicantPersonID, clsApplication.enApplicationType ApplicationTypeID, int LicenseClassID)
        {
            return clsApplicationData.DoesPersonHaveActiveApplication(ApplicantPersonID, (int)ApplicationTypeID, LicenseClassID);
        }
    }
}