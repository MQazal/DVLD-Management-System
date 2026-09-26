using DVLD_DataAccessLayer;
using System;
using System.Data;

namespace DVLD_BusinessLogicLayer
{
    public class clsDetainedLicense
    {
        public int DetainID { set; get; }
        public int LicenseID { set; get; }
        public clsLicense LicenseInfo;
        public DateTime DetainDate { set; get; }
        public decimal FineFees { set; get; }
        public int CreatedByUserID { set; get; }
        public clsUser CreatedByUserInfo { set; get; }
        public bool IsReleased { set; get; }
        public DateTime ReleaseDate { set; get; }
        public int ReleasedByUserID { set; get; }
        public clsUser ReleasedByUserInfo { set; get; }
        public int ReleaseApplicationID { set; get; }
        public clsApplication Applicationinfo;
        enum _enMode { AddNew = 0, Update = 1 };
        _enMode _Mode;

        public clsDetainedLicense()
        {
            this.DetainID = default(int);
            this.LicenseID = default(int);
            this.DetainDate = default(DateTime);
            this.FineFees = default(decimal);
            this.CreatedByUserID = default(int);
            this.IsReleased = default(bool);
            this.ReleaseDate = default(DateTime);
            this.ReleasedByUserID = default(int);
            this.ReleaseApplicationID = default(int);
            _Mode = _enMode.AddNew;
        }

        public clsDetainedLicense(int DetainID, int LicenseID, DateTime DetainDate, decimal FineFees, int CreatedByUserID,
            bool IsReleased, DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {
            this.DetainID = DetainID;
            this.LicenseID = LicenseID;
            this.DetainDate = DetainDate;
            this.FineFees = FineFees;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedByUserInfo = clsUser.FindUserByUserID(CreatedByUserID);
            this.IsReleased = IsReleased;
            this.ReleaseDate = ReleaseDate;
            this.ReleasedByUserID = ReleasedByUserID;
            this.ReleasedByUserInfo = clsUser.FindUserByUserID(ReleasedByUserID);
            this.ReleaseApplicationID = ReleaseApplicationID;
            this.Applicationinfo = clsApplication.FindApplication(ReleaseApplicationID);
            _Mode = _enMode.Update;
        }

        private bool _AddNewDetainedLicense()
        {
            this.DetainID = clsDetainedLicenseData.Add(this.LicenseID, this.DetainDate, this.FineFees, this.CreatedByUserID);
            return (this.DetainID != -1);
        }

        private bool _UpdateDetainedLicense()
        {
            return clsDetainedLicenseData.Update(this.DetainID, this.IsReleased,
                this.ReleaseDate, this.ReleasedByUserID, this.ReleaseApplicationID);
        }

        public static clsDetainedLicense FindByDetainID(int DetainID)
        {
            int LicenseID = default(int), CreatedByUserID = default(int), ReleasedByUserID = default(int),
                ReleaseApplicationID = default(int);
            DateTime DetainDate = default(DateTime), ReleaseDate = default(DateTime);
            decimal FineFees = default(decimal); bool IsReleased = default(bool);

            if (clsDetainedLicenseData.GetDetainedLicenseInfoByDetianID(DetainID, ref LicenseID, ref DetainDate, ref FineFees,
                ref CreatedByUserID, ref IsReleased, ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID))
                return new clsDetainedLicense(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate,
                     ReleasedByUserID, ReleaseApplicationID);
            else
                return null;
        }

        public static clsDetainedLicense FindByLicenseID(int LicenseID)
        {
            int DetainID = default(int), CreatedByUserID = default(int), ReleasedByUserID = default(int),
                ReleaseApplicationID = default(int);
            DateTime DetainDate = default(DateTime), ReleaseDate = default(DateTime);
            decimal FineFees = default(decimal); bool IsReleased = default(bool);

            if (clsDetainedLicenseData.GetDetainedLicenseInfoByLicenseID(LicenseID, ref DetainID, ref DetainDate, ref FineFees,
                ref CreatedByUserID, ref IsReleased, ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID))
                return new clsDetainedLicense(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased,
                    ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
            else
                return null;
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case _enMode.AddNew:
                    if (_AddNewDetainedLicense())
                    {
                        _Mode = _enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case _enMode.Update:
                    return _UpdateDetainedLicense();
            }
            return false;
        }

        public static DataTable GetDetainedLicensesList()
        {
            return clsDetainedLicenseData.LoadDetainedLicensesList();
        }

        public static bool IsLicenseDetained(int LicenseID)
        {
            return clsDetainedLicenseData.IsLicenseDetained(LicenseID);
        }

        public bool ReleaseDetainedLicense()
        {
            return this._UpdateDetainedLicense();
        }
    }
}