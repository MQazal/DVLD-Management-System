using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccessLayer
{
    public class clsInternationalLicenseData
    {
        public static int Add(int ApplicationID, int DriverID, int IssuedUsingLocalLicenseID,
            DateTime IssueDate, DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {
            int AddedID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"UPDATE InternationalLicenses SET IsActive = 0 WHERE DriverID = @DriverID;
                             INSERT INTO InternationalLicenses (ApplicationID, DriverID, IssuedUsingLocalLicenseID,
                                                               IssueDate, ExpirationDate, IsActive, CreatedByUserID)
                             VALUES (@ApplicationID, @DriverID, @IssuedUsingLocalLicenseID,
                                     @IssueDate, @ExpirationDate, @IsActive, @CreatedByUserID);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

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

        public static bool Update(int InternationalLicenseID, DateTime ExpirationDate, bool IsActive)
        {
            bool IsUpdated = default(bool);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"UPDATE InternationalLicenses SET ExpirationDate = @ExpirationDate,
                             IsActive = @IsActive WHERE InternationalLicenseID = @InternationalLicenseID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@IsActive", IsActive);

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

        public static bool FindInternationalLicenseByInternationalLicenseID(int InternationalLicenseID,
            ref int ApplicationID, ref int DriverID, ref int IssuedUsingLocalLicenseID, ref DateTime IssueDate,
            ref DateTime ExpirationDate, ref bool IsActive, ref int CreatedByUserID)
        {
            bool IsFound = default(bool);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM InternationalLicenses WHERE InternationalLicenseID = @InternationalLicenseID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    ApplicationID = (int)reader["ApplicationID"];
                    DriverID = (int)reader["DriverID"];
                    IssuedUsingLocalLicenseID = (int)reader["IssuedUsingLocalLicenseID"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];
                    IsActive = (bool)reader["IsActive"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
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

        public static int GetActiveInternationalLicenseIDByDriverID(int DriverID)
        {
            int InternationalLicenseID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT TOP 1 InternationalLicenseID FROM InternationalLicenses
                             WHERE DriverID = @DriverID AND IsActive = 1;";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int FoundID))
                    InternationalLicenseID = FoundID;
            }

            catch
            {
                throw;
            }

            finally
            {
                connection.Close();
            }

            return InternationalLicenseID;
        }

        public static DataTable LoadInternationalLicensesList()
        {
            DataTable Table = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT * FROM InternationalLicenses ORDER BY InternationalLicenseID DESC";

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

        public static DataTable LoadInternationalLicensesList(int DriverID)
        {
            DataTable Table = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT * FROM InternationalLicenses WHERE DriverID = @DriverID
                             ORDER BY InternationalLicenseID DESC";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@DriverID", DriverID);

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
    }
}