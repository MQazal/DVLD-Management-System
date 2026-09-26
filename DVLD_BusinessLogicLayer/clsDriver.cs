using DVLD_DataAccessLayer;
using System;
using System.Data;

namespace DVLD_BusinessLogicLayer
{
    public class clsDriver
    {
        enum _enMode { AddNew , Update }
        _enMode _Mode;

        public int DriverID { set; get; }
        public int PersonID { set; get; }
        public clsPerson PersonInfo;
        public int CreatedByUserID { set; get; }
        public clsUser UserInfo;
        public DateTime CreatedDate { set; get; }

        public clsDriver()
        {
            this.DriverID = default(int);
            this.PersonID = default(int);
            this.CreatedByUserID = default(int);
            this.CreatedDate = default(DateTime);
            this._Mode = _enMode.AddNew;
        }

        private clsDriver(int DriverID, int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            this.DriverID = DriverID;
            this.PersonID = PersonID;
            PersonInfo = clsPerson.FindPerson(PersonID);
            this.CreatedByUserID = CreatedByUserID;
            UserInfo = clsUser.FindUserByUserID(CreatedByUserID);
            this.CreatedDate = CreatedDate;
            this._Mode = _enMode.Update;
        }

        private bool _AddNewDriver()
        {
            this.DriverID = clsDriverData.Add(this.PersonID, this.CreatedByUserID, this.CreatedDate);
            return (this.DriverID != -1);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case _enMode.AddNew:
                    if (_AddNewDriver())
                    {
                        _Mode = _enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
            }
            return true;
        }

        public static DataTable GetDriversList()
        {
            return clsDriverData.LoadDriversList();
        }

        public static clsDriver FindDriverByDriverID(int DriverID)
        {
            int PersonID = default(int), CreatedByUserID = default(int); DateTime CreatedDate = default(DateTime);

            if (clsDriverData.GetDriverInfoByDriverID(DriverID, ref PersonID, ref CreatedByUserID, ref CreatedDate))
                return new clsDriver(DriverID, PersonID, CreatedByUserID, CreatedDate);
            else
                return null;
        }

        public static clsDriver FindDriverByPersonID(int PersonID)
        {
            int DriverID = default(int), CreatedByUserID = default(int); DateTime CreatedDate = default(DateTime);

            if (clsDriverData.GetDriverInfoByPersonID(ref DriverID, PersonID, ref CreatedByUserID, ref CreatedDate))
                return new clsDriver(DriverID, PersonID, CreatedByUserID, CreatedDate);
            else
                return null;
        }

        public static bool IsDriverExist(int PersonID)
        {
            return clsDriverData.IsDriverExist(PersonID);
        }
    }
}