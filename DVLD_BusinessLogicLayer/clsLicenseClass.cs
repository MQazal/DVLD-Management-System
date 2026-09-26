using DVLD_DataAccessLayer;
using System;
using System.Data;

namespace DVLD_BusinessLogicLayer
{
    public class clsLicenseClass
    {
        public int LicenseClassID { set; get; }
        public string ClassName { set; get; }
        public string ClassDescription { set; get; }
        public byte MinimumAllowedAge { set; get; }
        public byte DefaultValidityLength { set; get; }
        public decimal Fees { set; get; }

        private clsLicenseClass(int LicenseClassID, string ClassName, string ClassDescription, byte MinimumAllowdAge, byte DefaultValidityLength, decimal Fees)
        {
            this.LicenseClassID = LicenseClassID;
            this.ClassName = ClassName;
            this.ClassDescription = ClassDescription;
            this.MinimumAllowedAge = MinimumAllowdAge;
            this.DefaultValidityLength = DefaultValidityLength;
            this.Fees = Fees;
        }

        public static clsLicenseClass FindLicenseClass(int LicenseClassID)
        {
            string ClassName = default(string), ClassDescription = default(string);
            byte MinimumAllowedAge = default(byte), DefaultValidityLength = default(byte);
            decimal Fees = default(decimal);
            if (clsLicenseClassData.Find(LicenseClassID, ref ClassName, ref ClassDescription, ref MinimumAllowedAge, ref DefaultValidityLength, ref Fees))
            {
                return new clsLicenseClass(LicenseClassID, ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, Fees);
            }
            return null;
        }

        public static clsLicenseClass FindLicenseClass(string ClassName)
        {
            int LicenseClassID = default(int);
            string ClassDescription = default(string);
            byte MinimumAllowedAge = default(byte), DefaultValidityLength = default(byte);
            decimal Fees = default(decimal);
            if (clsLicenseClassData.Find(ClassName, ref LicenseClassID, ref ClassDescription, ref MinimumAllowedAge, ref DefaultValidityLength, ref Fees))
            {
                return new clsLicenseClass(LicenseClassID, ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, Fees);
            }
            return null;
        }

        public static DataTable GetClassesList()
        {
            return clsLicenseClassData.LoadClassesList();
        }

        public static byte GetClassFees(string ClassName)
        {
            return clsLicenseClassData.GetFees(ClassName);
        }

        public bool UpdateLicenseClass()
        {
            return clsLicenseClassData.Update(this.LicenseClassID, this.ClassName, this.ClassDescription, this.MinimumAllowedAge, this.DefaultValidityLength, this.Fees);
        }
    }
}