using System;
using DVLD_DataAccessLayer;
using System.Data;

namespace DVLD_BusinessLogicLayer
{
    public class clsTestAppointment
    {
        private int _AppointmentID { set; get; }
        public int AppointmentID { get { return _AppointmentID; } }
        public clsTestType.enTestType TestTypeID { set; get; }
        public clsTestType TestTypeInfo;
        public int LocalDrivingLicenseApplicationID { set; get; }
        public clsLocalDrivingLicenseApplication ApplicationInfo;
        public DateTime AppointmentDate { set; get; }
        public decimal PaidFees { set; get; }
        public int CreatedByUserID { set; get; }
        public clsUser UserInfo;
        public bool IsLocked { set; get; }
        public int RetakeTestApplicationID { set; get; }
        public clsApplication RetakeTestAppInfo { set; get; }
        enum enMode { AddNew = 0, Update = 1 };
        enMode _Mode;

        public clsTestAppointment()
        {
            this._AppointmentID = default(int);
            this.TestTypeID = default(int);
            this.LocalDrivingLicenseApplicationID = default(int);
            this.AppointmentDate = default(DateTime);
            this.PaidFees = default(decimal);
            this.CreatedByUserID = default(int);
            this.IsLocked = default(bool);
            this.RetakeTestApplicationID = default(int);
            _Mode = enMode.AddNew;
        }

        private clsTestAppointment(int AppointmentID, clsTestType.enTestType TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate,
                                   decimal PaidFees, int CreatedByUserID, bool IsLocked, int RetakeTestApplicationID)
        {
            this._AppointmentID = AppointmentID;
            this.TestTypeID = TestTypeID;
            TestTypeInfo = clsTestType.FindTest((int)this.TestTypeID);
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            ApplicationInfo = clsLocalDrivingLicenseApplication.FindLocalDrvingLicenseAppByLocalAppID(this.LocalDrivingLicenseApplicationID);
            this.AppointmentDate = AppointmentDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            UserInfo = clsUser.FindUserByUserID(this.CreatedByUserID);
            this.IsLocked = IsLocked;
            this.RetakeTestApplicationID = RetakeTestApplicationID;
            RetakeTestAppInfo = clsApplication.FindApplication(this.RetakeTestApplicationID);
            _Mode = enMode.Update;
        }

        private bool _AddNewTestAppointment()
        {
            this._AppointmentID = clsTestAppointmentData.Add((byte)this.TestTypeID, this.LocalDrivingLicenseApplicationID, this.AppointmentDate,
                                                            this.PaidFees, this.CreatedByUserID, this.IsLocked, this.RetakeTestApplicationID);
            return this._AppointmentID != -1;
        }

        private bool _UpdateTestAppointment()
        {
            return clsTestAppointmentData.Update(this.AppointmentID, this.AppointmentDate, this.IsLocked);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTestAppointment())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                case enMode.Update:
                    return _UpdateTestAppointment();
            }
            return false;
        }

        public static clsTestAppointment Find(int AppointmentID)
        {
            int TestTypeID = default(int), LocalDrivingLicenseApplicationID = default(int), CreatedByUserID = default(int),
                RetakeTestApplicationID = default(int);
            DateTime AppointmentDate = default(DateTime); decimal PaidFees = default(decimal);
            bool IsLocked = default(bool);

            if (clsTestAppointmentData.Find(AppointmentID, ref TestTypeID, ref LocalDrivingLicenseApplicationID,
            ref AppointmentDate, ref PaidFees, ref CreatedByUserID, ref IsLocked, ref RetakeTestApplicationID))
                return new clsTestAppointment(AppointmentID, (clsTestType.enTestType)TestTypeID, LocalDrivingLicenseApplicationID,
                AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID);
            else
                return null;
        }

        public static bool IsAppointmentExistByTestType(int LocalDrivingLicenseApplicationID, clsTestType.enTestType TestTypeID)
        {
            return clsTestAppointmentData.IsAppointmentExistByTestType(LocalDrivingLicenseApplicationID, (int)TestTypeID);
        }

        public static DataTable GetTestAppointmentsList(int LocalDrivingLicenseApplicationID, string TestTypeTitle)
        {
            return clsTestAppointmentData.LoadTestAppointmentsList(LocalDrivingLicenseApplicationID, TestTypeTitle);
        }

        public static clsTestAppointment GetLastTestAppointment(int LocalDrivingLicenseApplicationID, clsTestType.enTestType TestTypeID)
        {
            int TestAppointmentID = default(int), CreatedByUserID = default(int), RetakeTestApplicationID = default(int);
            DateTime AppointmentDate = default(DateTime); decimal PaidFees = default(decimal);
            bool IsLocked = false;

            if (clsTestAppointmentData.GetLastTestAppointment(LocalDrivingLicenseApplicationID, (int)TestTypeID,
                ref TestAppointmentID, ref AppointmentDate, ref PaidFees, ref CreatedByUserID, ref RetakeTestApplicationID))
                return new clsTestAppointment(TestAppointmentID, TestTypeID, LocalDrivingLicenseApplicationID,
             AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID);
            else
                return null;
        }

        public bool HasPassedTestForAppointment()
        {
            return clsTestAppointmentData.HasPassedTestForAppointment(this.AppointmentID);
        }
    }
}