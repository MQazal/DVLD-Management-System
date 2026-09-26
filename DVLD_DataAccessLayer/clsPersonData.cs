using System;
using System.Data.SqlClient;
using System.Data;

namespace DVLD_DataAccessLayer
{
    public class clsPersonData
    {
        private static string _GetValueAsString(SqlDataReader reader, string columnName)
        {
            return reader[columnName] != DBNull.Value ? reader[columnName].ToString() : string.Empty;
        }

        public static bool FindByID(int PersonID, ref string NationalNumber, ref string FirstName, ref string SecondName,
            ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref byte Gender,
            ref string Address, ref string Phone, ref string Email, ref string ImagePath, ref int CountryID)
        {
            bool IsFound = default(bool);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM People WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    NationalNumber = (string)reader["NationalNumber"];
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    ThirdName = (string)reader["ThirdName"];
                    LastName = (string)reader["LastName"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Gender = (byte)reader["Gender"];
                    Phone = (string)reader["Phone"];
                    Email = _GetValueAsString(reader, "Email");
                    Address = (string)reader["Address"];
                    ImagePath = _GetValueAsString(reader, "ImagePath");
                    CountryID = (int)reader["CountryID"];
                    IsFound = true;
                }
                reader.Close();
            }

            catch
            {
                throw;
            }

            finally
            {
                connection.Close();
            }

            return IsFound;
        }

        public static bool FindByNationalNumber(ref int PersonID, string NationalNumber, ref string FirstName, ref string SecondName,
           ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref byte Gender,
           ref string Address, ref string Phone, ref string Email, ref string ImagePath, ref int CountryID)
        {
            bool IsFound = default(bool);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM People WHERE NationalNumber = @NationalNumber";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@NationalNumber", NationalNumber);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    PersonID = (int)reader["PersonID"];
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    ThirdName = (string)reader["ThirdName"];
                    LastName = (string)reader["LastName"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Gender = (byte)reader["Gender"];
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];
                    Email = _GetValueAsString(reader, "Email");
                    ImagePath = _GetValueAsString(reader, "ImagePath");
                    CountryID = (int)reader["CountryID"];
                    IsFound = true;
                }
                reader.Close();
            }

            catch
            {
                throw;
            }

            finally
            {
                connection.Close();
            }

            return IsFound;
        }

        public static int Add(string NationalNumber, string FirstName, string SecondName,
           string ThirdName, string LastName, DateTime DateOfBirth, byte Gender,
           string Address, string Phone, string Email, string ImagePath, int CountryID)
        {
            int AddedID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"INSERT INTO People (NationalNumber, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gender,
                                                 Address, Phone, Email, ImagePath, CountryID)
                             VALUES (@NationalNumber, @FirstName, @SecondName, @ThirdName, @LastName, @DateOfBirth, @Gender,
                                     @Address, @Phone, @Email, @ImagePath, @CountryID);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@NationalNumber", NationalNumber);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);

            if (Email != "")
                command.Parameters.AddWithValue("@Email", Email);
            else
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);

            if (ImagePath != "")
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

            command.Parameters.AddWithValue("@CountryID", CountryID);

            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int NewInsertedID))
                    AddedID = NewInsertedID;
            }

            catch
            {
                throw;
            }

            finally
            {
                connection.Close();
            }

            return AddedID;
        }

        public static bool Update(int PersonID, string NationalNumber, string FirstName, string SecondName,
           string ThirdName, string LastName, DateTime DateOfBirth, byte Gender,
           string Address, string Phone, string Email, string ImagePath, int CountryID)
        {
            bool IsUpdated = default(bool);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"UPDATE People SET NationalNumber = @NationalNumber, FirstName = @FirstName,
                             SecondName = @SecondName, ThirdName = @ThirdName, LastName = @LastName,
                             DateOfBirth = @DateOfBirth, Gender = @Gender, Address = @Address, Phone = @Phone,
                             Email = @Email, ImagePath = @ImagePath, CountryID = @CountryID WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@NationalNumber", NationalNumber);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);

            if (Email != "")
                command.Parameters.AddWithValue("@Email", Email);
            else
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);

            if (ImagePath != "")
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

            command.Parameters.AddWithValue("@CountryID", CountryID);

            try
            {
                connection.Open();

                int AffectedRows = command.ExecuteNonQuery();

                if (AffectedRows > 0)
                    IsUpdated = true;
            }

            catch
            {
                throw;
            }

            finally
            {
                connection.Close();
            }

            return IsUpdated;
        }

        public static bool Delete(int PersonID)
        {
            bool IsDeleted = default(bool);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"DELETE FROM People WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                int AffectedRows = command.ExecuteNonQuery();

                if (AffectedRows > 0)
                    IsDeleted = true;
            }

            catch
            {
                throw;
            }

            finally
            {
                connection.Close();
            }

            return IsDeleted;
        }

        public static DataTable LoadPeopleList()
        {
            DataTable Table = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @" SELECT People.PersonID, People.NationalNumber, People.FirstName, People.SecondName,
                              People.ThirdName, PeoplE.LastName, People.DateOfBirth,
                              CASE
                              	WHEN People.Gender = 0 THEN 'Male'
                              	ELSE 'Female'
                              END AS Gender,
                              People.Phone, People.Email, People.Address, Countries.CountryName, People.ImagePath
                              FROM People JOIN Countries ON People.CountryID = Countries.CountryID ORDER BY People.FirstName;";

            SqlCommand command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    Table.Load(reader);
                }

                reader.Close();
            }

            catch
            {
                throw;
            }

            finally
            {
                connection.Close();
            }

            return Table;
        }

        public static bool IsExist(int PersonID)
        {
            bool IsFound = default(bool);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT Found = 1 FROM People WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();

                if (Result != null)
                    IsFound = true;
            }

            catch
            {
                throw;
            }

            finally
            {
                connection.Close();
            }

            return IsFound;
        }

        public static bool IsExist(string NationalNumber)
        {
            bool IsFound = default(bool);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT Found = 1 FROM People WHERE NationalNumber = @NationalNumber";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@NationalNumber", NationalNumber);

            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();

                if (Result != null)
                    IsFound = true;
            }

            catch
            {
                throw;
            }

            finally
            {
                connection.Close();
            }

            return IsFound;
        }
    }
}