using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccessLayer
{
    public class clsLicenseClassData
    {
        public static bool Find(int ClassID, ref string ClassName, ref string ClassDescription,
            ref byte MinumumAllowedAge, ref byte DefaultValidityLength, ref decimal Fees)
        {
            bool IsFound = default(bool);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM LicenseClasses WHERE ClassID = @ClassID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@ClassID", ClassID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    ClassName = (string)reader["ClassName"];
                    ClassDescription = (string)reader["ClassDescription"];
                    MinumumAllowedAge = (byte)reader["MinimumAllowedAge"];
                    DefaultValidityLength = (byte)reader["DefalutValidityLength"];
                    Fees = (decimal)reader["ClassFees"];
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

        public static bool Find(string ClassName, ref int LicenseClassID,
            ref string ClassDescription, ref byte MinimumAllowedAge, ref byte DefaultValidityLength, ref decimal Fees)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM LicenseClasses WHERE ClassName = @ClassName";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClassName", ClassName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    LicenseClassID = (int)reader["ClassID"];
                    ClassDescription = (string)reader["ClassDescription"];
                    MinimumAllowedAge = (byte)reader["MinimumAllowedAge"];
                    DefaultValidityLength = (byte)reader["DefaultValidityLength"];
                    Fees = (decimal)reader["ClassFees"];
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

        public static DataTable LoadClassesList()
        {
            DataTable Table = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM LicenseClasses";

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

        public static byte GetFees(string ClassName)
        {
            byte Fees = default(byte);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT ClassFees FROM LicenseClasses WHERE ClassName = @ClassName";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@ClassName", ClassName);

            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();

                if (Result != null && byte.TryParse(Result.ToString(), out byte FoundFees))
                    Fees = FoundFees;
            }

            catch
            {
                throw;
            }

            finally
            {
                connection.Close();
            }

            return Fees;
        }

        public static bool Update(int LicenseClassID, string ClassName, string ClassDescription, byte MinimumAllowedAge,
            byte DefaultValidityLength, decimal Fess)
        {
            bool IsUpdated = default(bool);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"UPDATE LicenseClasses SET ClassName = @ClassName, ClassDescription = @ClassDescription,
                             MinimumAllowedAge = @MinimumAllowedAge, DefaultValidityLength = @DefaultValidityLength,
                             Fees = @Fees WHERE LicenseClassID = @LicenseClassID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            command.Parameters.AddWithValue("@ClassName", ClassName);
            command.Parameters.AddWithValue("@ClassDescription", ClassDescription);
            command.Parameters.AddWithValue("@MinimumAllowedAge", MinimumAllowedAge);
            command.Parameters.AddWithValue("@DefaultValidityLength", DefaultValidityLength);
            command.Parameters.AddWithValue("@Fees", Fess);

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
    }
}