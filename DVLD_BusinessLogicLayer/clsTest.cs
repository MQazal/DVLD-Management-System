using DVLD_DataAccessLayer;
using System;

namespace DVLD_BusinessLogicLayer
{
    public class clsTest
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode = enMode.AddNew;

        public int TestID { set; get; }
        public int AppointmentID { set; get; }
        public clsTestAppointment TestAppointmentInfo { set; get; }
        public bool TestResult { set; get; }
        public string Notes { set; get; }
        public int CreatedByUserID { set; get; }

        public clsTest()
        {
            this.TestID = default(int);
            this.AppointmentID = default(int);
            this.TestResult = default(bool);
            this.Notes = default(string);
            this.CreatedByUserID = default(int);
            _Mode = enMode.AddNew;
        }

        private clsTest(int TestID, int AppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            this.TestID = TestID;
            this.AppointmentID = AppointmentID;
            this.TestAppointmentInfo = clsTestAppointment.Find(AppointmentID);
            this.TestResult = TestResult;
            this.Notes = Notes;
            this.CreatedByUserID = CreatedByUserID;
            _Mode = enMode.Update;
        }

        private bool _AddNewTest()
        {
            this.TestID = clsTestData.Add(this.AppointmentID, this.TestResult, this.Notes, this.CreatedByUserID);
            return (this.TestID != -1);
        }

        private bool _UpdateTest()
        {
            return clsTestData.Update(this.TestID, this.Notes);
        }

        public static clsTest FindTestByTestAppointment(int AppointmentID)
        {
            int TestID = default(int), CreatedByUserID = default(int);
            bool TestResult = default(bool); string Notes = default(string);

            if (clsTestData.Find(ref TestID, AppointmentID, ref TestResult, ref Notes, ref CreatedByUserID))
                return new clsTest(TestID, AppointmentID, TestResult, Notes, CreatedByUserID);
            else
                return null;
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTest())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:

                    return _UpdateTest();
            }
            return false;
        }
    }
}