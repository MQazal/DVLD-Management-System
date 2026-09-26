using System;
using DVLD_DataAccessLayer;
using System.Data;

namespace DVLD_BusinessLogicLayer
{
    public class clsUser
    {
        private int _UserID { set; get; }
        public int UserID
        {
            get { return _UserID; }
        }
        public string Username { set; get; }
        public string Password { set; get; }
        public bool IsActive { set; get; }
        public int PersonID { set; get; }
        public clsPerson PersonInfo;
        private static byte _EncryptionKey = 5;
        enum enMode { AddNew, Update }
        enMode _Mode;

        // Default Constructor -> Add New User
        public clsUser()
        {
            this.Username = default(string);
            this.Password = default(string);
            this.IsActive = default(bool);
            _Mode = enMode.AddNew;
        }

        // Parametrized Constructor -> Find/Update User
        private clsUser(int UserID, string Username, string Password, bool IsActive, int PersonID)
        {
            this._UserID = UserID;
            this.Username = Username;
            this.Password = Password;
            this.IsActive = IsActive;
            this.PersonID = PersonID;
            PersonInfo = clsPerson.FindPerson(this.PersonID);
            _Mode = enMode.Update;
        }

        private static int _GetASCII(char Letter)
        {
            return (int)Letter;
        }

        private static char _GetLetter(int ASCII)
        {
            return (char)ASCII;
        }

        private static string _EncryptPassword(string OriginalPassword)
        {
            string EncryptedPassword = default(string);
            for (byte i = 0; i < OriginalPassword.Length; i++)
            {
                EncryptedPassword += _GetLetter(_GetASCII(OriginalPassword[i]) + _EncryptionKey);
            }
            return EncryptedPassword;
        }

        private static string _DecryptPassword(string EncryptedPassword)
        {
            string DecryptedPassword = default(string);
            for (byte i = 0; i < EncryptedPassword.Length; i++)
            {
                DecryptedPassword += _GetLetter(_GetASCII(EncryptedPassword[i]) - _EncryptionKey);
            }
            return DecryptedPassword;
        }

        private bool _AddNewUser()
        {
            this._UserID = clsUserData.Add(this.Username, _EncryptPassword(this.Password), this.IsActive, this.PersonID);
            return (this._UserID != -1);
        }

        private bool _UpdateUser()
        {
            return clsUserData.Update(this.UserID, this.IsActive);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateUser();
            }

            return false;
        }

        public static bool DeleteUser(int UserID, int PersonID)
        {
            if (clsUserData.Delete(UserID))
            {
                return clsPerson.DeletePerson(PersonID);
            }
            return false;
        }

        public static clsUser FindUserByUserID(int UserID)
        {
            int PersonID = default(int);
            string Username = default(string), Password = default(string);
            bool IsActive = default(bool);
            if (clsUserData.FindByUserID(UserID, ref Username, ref Password, ref IsActive, ref PersonID))
            {
                return new clsUser(UserID, Username, _DecryptPassword(Password), IsActive, PersonID);
            }
            return null;
        }

        public static clsUser FindUserByUsernameAndPassword(string Username, string Password)
        {
            int UserID = default(int), PersonID = default(int);
            bool IsActive = default(bool);
            Password = _EncryptPassword(Password);
            if (clsUserData.FindByUsernameAndPassword(ref UserID, Username, Password, ref IsActive, ref PersonID))
            {
                return new clsUser(UserID, Username, _DecryptPassword(Password), IsActive, PersonID);
            }
            return null;
        }

        public static clsUser FindUserByPersonID(int PersonID)
        {
            int UserID = default(int);
            string Username = default(string), Password = default(string);
            bool IsActive = default(bool);
            if (clsUserData.FindByPersonID(ref UserID, ref Username, ref Password, ref IsActive, PersonID))
            {
                return new clsUser(UserID, Username, _DecryptPassword(Password), IsActive, PersonID);
            }
            return null;
        }

        public bool IsUserActive()
        {
            return this.IsActive;
        }

        public static DataTable GetUsersList()
        {
            return clsUserData.LoadUsersList();
        }

        public bool ChangePassword(int UserID, string NewPassword)
        {
            this.Password = NewPassword;
            return clsUserData.UpdatePassword(UserID, _EncryptPassword(NewPassword));
        }

        public static bool IsUserExistByPersonID(int PersonID)
        {
            return clsUserData.IsUserExist(PersonID);
        }
    }
}