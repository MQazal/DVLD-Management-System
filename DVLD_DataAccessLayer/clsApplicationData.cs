using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccessLayer
{
    public class clsApplicationData
    {
        public static int Add(DateTime ApplicationDate, byte ApplicationStatus, DateTime LastStatusDate,
            decimal PaidFees, int ApplicationTypeID, int ApplicantPersonID, int CreatedByUserID)
        {
            int AddedID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"INSERT INTO Applications (ApplicationDate, ApplicationStatus, LastStatusDate,
                             PaidFees, ApplicationTypeID, ApplicantPersonID, CreatedByUserID)
                             VALUES (@ApplicationDate, @ApplicationStatus, @LastStatusDate,
                             @PaidFees, @ApplicationTypeID, @ApplicantPersonID, @CreatedByUserID);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
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

        public static bool Update(int ApplicationID, DateTime ApplicationDate, byte ApplicationStatus, DateTime LastStatusDate,
            decimal PaidFees, int ApplicationTypeID, int ApplicantPersonID, int CreatedByUserID)
        {
            bool IsUpdated = default(bool);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"UPDATE Applications SET ApplicationDate = @ApplicationDate, ApplicationStatus = @ApplicationStatus,
                             LastStatusDate = @LastStatusDate, PaidFees = @PaidFees, ApplicationTypeID = @ApplicationTypeID,
                             ApplicantPersonID = @ApplicantPersonID, CreatedByUserID = @CreatedByUserID
                             WHERE ApplicationID = @ApplicationID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

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

        public static bool Find(int ApplicationID, ref DateTime ApplicationDate, ref byte ApplicationStatus,
            ref DateTime LastStatusDate, ref decimal PaidFees, ref int ApplicationTypeID, ref int ApplicantPersonID,
            ref int CreatedByUserID)
        {
            bool IsFound = default(bool);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM Applications WHERE ApplicationID = @ApplicationID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    ApplicationDate = (DateTime)reader["ApplicationDate"];
                    ApplicationStatus = (byte)reader["ApplicationStatus"];
                    LastStatusDate = (DateTime)reader["LastStatusDate"];
                    PaidFees = (decimal)reader["PaidFees"];
                    ApplicationTypeID = (int)reader["ApplicationTypeID"];
                    ApplicantPersonID = (int)reader["ApplicantPersonID"];
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

        public static bool Delete(int ApplicationID)
        {
            bool IsDeleted = default(bool);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"DELETE FROM Applications WHERE ApplicationID = @ApplicationID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

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

        public static DataTable LoadApplicationsList()
        {
            DataTable Table = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM Applications";

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

        // Any type of Applications Except LDL
        public static int GetActiveApplicationID(int ApplicantPersonID, int ApplicationTypeID)
        {
            int ActiveApplicationID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT ApplicationID FROM Applications WHERE ApplicantPersonID = @ApplicantPersonID AND ApplicationTypeID = @ApplicationTypeID AND ApplicationStatus = 1";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int AppID))
                {
                    ActiveApplicationID = AppID;
                }
            }

            catch
            {
                throw;
            }

            finally
            {
                connection.Close();
            }

            return ActiveApplicationID;
        }

        public static bool DoesPersonHaveActiveApplication(int ApplicantPersonID, int ApplicationTypeID)
        {
            return GetActiveApplicationID(ApplicantPersonID, ApplicationTypeID) != -1;
        }

        // LDL Application
        public static int GetActiveApplicationID(int ApplicantPersonID, int ApplicationTypeID, int LicenseClassID)
        {
            int ActiveApplicationID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT Applications.ApplicationID FROM Applications JOIN LocalDrivingLicenseApplications
                             ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID
                             WHERE ApplicantPersonID = @ApplicantPersonID AND
                             ApplicationTypeID = @ApplicationTypeID AND
                             ClassID = @LicenseClassID AND ApplicationStatus = 1;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int AppID))
                {
                    ActiveApplicationID = AppID;
                }
            }

            catch
            {
                throw;
            }

            finally
            {
                connection.Close();
            }

            return ActiveApplicationID;
        }

        public static bool DoesPersonHaveActiveApplication(int ApplicantPersonID, int ApplicationTypeID, int LicenseClassID)
        {
            return GetActiveApplicationID(ApplicantPersonID, ApplicationTypeID, LicenseClassID) != -1;
        }

        public static bool UpdateStatus(int ApplicationID, byte NewStatus)
        {
            bool IsUpdated = default(bool);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"UPDATE Applications SET ApplicationStatus = @ApplicationStatus WHERE ApplicationID = @ApplicationID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@ApplicationStatus", NewStatus);

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