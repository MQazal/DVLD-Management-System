using DVLD_DataAccessLayer;
using System;
using System.Data;

namespace DVLD_BusinessLogicLayer
{
    public class clsTestType
    {
        public int TestID { get; }
        public string TestTitle { set; get; }
        public string TestDescription { set; get; }
        public decimal TestFees { set; get; }
        public enum enTestType { VisionTest = 1, WrittenTest = 2, StreetTest = 3 };

        private clsTestType(int TestID, string TestTitle, string TestDescription, decimal TestFees)
        {
            this.TestID = TestID;
            this.TestTitle = TestTitle;
            this.TestDescription = TestDescription;
            this.TestFees = TestFees;
        }

        public static clsTestType FindTest(int TestID)
        {
            string Title = default(string), Discription = default(string);
            decimal Fees = default(decimal);
            if (clsTestTypeData.Find(TestID, ref Title, ref Discription, ref Fees))
            {
                return new clsTestType(TestID, Title, Discription, Fees);
            }
            return null;
        }

        public bool UpdateTest()
        {
            return clsTestTypeData.Update(this.TestID, this.TestTitle, this.TestDescription, this.TestFees);
        }

        public static DataTable GetTestsList()
        {
            return clsTestTypeData.LoadTestsList();
        }

        public static string GetTestTitle(enTestType TestTypeID)
        {
            return clsTestTypeData.GetTestTitle((int)TestTypeID);
        }
    }
}