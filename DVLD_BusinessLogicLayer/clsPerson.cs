using DVLD_DataAccessLayer;
using System;
using System.Data;

namespace DVLD_BusinessLogicLayer
{
    public class clsPerson
    {
        private int _PersonID { set; get; }
        public int PersonID
        {
            get { return _PersonID; }
        }
        public string NationalNumber { set; get; }
        public string FirstName { set; get; }
        public string SecondName { set; get; }
        public string ThirdName { set; get; }
        public string LastName { set; get; }
        public string FullName
        {
            get { return FirstName + " " + SecondName + " " + ThirdName + " " + LastName; }

        }
        public DateTime DateOfBirth { set; get; }
        public byte Gender { set; get; }
        public string Address { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }
        public string ImagePath { set; get; }
        public int CountryID { set; get; }
        enum enMode { AddNew, Update }
        enMode _Mode;
        public clsCountry CountryInfo;

        // Default Constructor -> Add New Person
        public clsPerson()
        {
            this.NationalNumber = default(string);
            this.FirstName = default(string);
            this.SecondName = default(string);
            this.ThirdName = default(string);
            this.LastName = default(string);
            this.DateOfBirth = default(DateTime);
            this.Gender = default(byte);
            this.Address = default(string);
            this.Phone = default(string);
            this.Email = default(string);
            this.ImagePath = default(string);
            this.CountryID = default(int);
            _Mode = enMode.AddNew;
        }

        // Parametrized Constructor -> Find/Update Person
        private clsPerson(int PersonID, string NationalNumber, string FirstName, string SecondName, string ThirdName,
            string LastName, DateTime DateOfBirth, byte Gender, string Address, string Phone,
            string Email, string ImagePath, int CountryID)
        {
            this._PersonID = PersonID;
            this.NationalNumber = NationalNumber;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gender = Gender;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.ImagePath = ImagePath;
            this.CountryID = CountryID;
            _Mode = enMode.Update;
            this.CountryInfo = clsCountry.Find(this.CountryID);
        }

        public static clsPerson FindPerson(int PersonID)
        {
            string NationalNumber = default(string), FirstName = default(string), SecondName = default(string),
                ThirdName = default(string), LastName = default(string), Address = default(string),
                Phone = default(string), Email = default(string), ImagePath = default(string);
            DateTime DateOfBirth = default(DateTime);
            byte Gender = default(byte);
            int CountryID = default(int);

            if (clsPersonData.FindByID(PersonID, ref NationalNumber, ref FirstName, ref SecondName, ref ThirdName,
                ref LastName, ref DateOfBirth, ref Gender, ref Address, ref Phone, ref Email, ref ImagePath, ref CountryID))
            {
                return new clsPerson(PersonID, NationalNumber, FirstName, SecondName, ThirdName, LastName,
                    DateOfBirth, Gender, Address, Phone, Email, ImagePath, CountryID);
            }
            return null;
        }

        public static clsPerson FindPerson(string NationalNumber)
        {
            string FirstName = default(string), SecondName = default(string),
                ThirdName = default(string), LastName = default(string), Address = default(string),
                Phone = default(string), Email = default(string), ImagePath = default(string);
            DateTime DateOfBirth = default(DateTime);
            byte Gender = default(byte);
            int PersonID = default(int), CountryID = default(int);

            if (clsPersonData.FindByNationalNumber(ref PersonID, NationalNumber, ref FirstName, ref SecondName, ref ThirdName,
                ref LastName, ref DateOfBirth, ref Gender, ref Address, ref Phone, ref Email, ref ImagePath, ref CountryID))
            {
                return new clsPerson(PersonID, NationalNumber, FirstName, SecondName, ThirdName, LastName,
                    DateOfBirth, Gender, Address, Phone, Email, ImagePath, CountryID);
            }
            return null;
        }

        private bool _AddNewPerson()
        {
            this._PersonID = clsPersonData.Add(this.NationalNumber, this.FirstName, this.SecondName, this.ThirdName,
            this.LastName, this.DateOfBirth, this.Gender, this.Address, this.Phone, this.Email, this.ImagePath, this.CountryID);
            return (this._PersonID != -1);
        }

        private bool _UpdatePerson()
        {
            return clsPersonData.Update(this._PersonID, this.NationalNumber, this.FirstName, this.SecondName, this.ThirdName,
            this.LastName, this.DateOfBirth, this.Gender, this.Address, this.Phone, this.Email, this.ImagePath, this.CountryID);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdatePerson();
            }

            return false;
        }

        public static bool DeletePerson(int PersonID)
        {
            return clsPersonData.Delete(PersonID);
        }

        public static DataTable GetPeopleList()
        {
            return clsPersonData.LoadPeopleList();
        }

        public static bool IsPersonExist(int PersonID)
        {
            return clsPersonData.IsExist(PersonID);
        }

        public static bool IsPersonExist(string NationalNumber)
        {
            return clsPersonData.IsExist(NationalNumber);
        }
    }
}