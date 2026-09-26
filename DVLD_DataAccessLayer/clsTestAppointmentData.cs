using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccessLayer
{
    public class clsTestAppointmentData
    {
        public static int Add(byte TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, decimal PaidFees,
                              int CreatedByUserID, bool IsLocked, int RetakeTestApplicationID)
        {
            int AddedID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"INSERT INTO TestAppointments (TestTypeID,LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees,
                                                           CreatedByUserID, IsLocked, RetakeTestApplicationID)
                             VALUES (@TestTypeID, @LocalDrivingLicenseApplicationID, @AppointmentDate, @PaidFees,
                                     @CreatedByUserID, @IsLocked, @RetakeTestApplicationID);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@IsLocked", IsLocked);
            if (RetakeTestApplicationID == -1)
                command.Parameters.AddWithValue("@RetakeTestApplicationID", DBNull.Value);
            else
                command.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);

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

        public static bool Update(int AppointmentID, DateTime AppointmentDate, bool IsLocked)
        {
            bool IsUpdated = default(bool);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE TestAppointments SET AppointmentDate = @AppointmentDate, IsLocked = @IsLocked
                             WHERE AppointmentID = @AppointmentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AppointmentID", AppointmentID);
            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            command.Parameters.AddWithValue("@IsLocked", IsLocked);

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

        public static bool Find(int AppointmentID, ref int TestTypeID, ref int LocalDrivingLicenseApplicationID,
                                ref DateTime AppointmentDate, ref decimal PaidFees, ref int CreatedByUserID, ref bool IsLocked,
                                ref int RetakeTestApplicationID)
        {
            bool IsFound = default(bool);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM TestAppointments WHERE AppointmentID = @AppointmentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AppointmentID", AppointmentID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    TestTypeID = (int)reader["TestTypeID"];
                    LocalDrivingLicenseApplicationID = (int)reader["LocalDrivingLicenseApplicationID"];
                    AppointmentDate = (DateTime)reader["AppointmentDate"];
                    PaidFees = (decimal)reader["PaidFees"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsLocked = (bool)reader["IsLocked"];

                    if (reader["RetakeTestApplicationID"] == DBNull.Value)
                        RetakeTestApplicationID = -1;
                    else
                        RetakeTestApplicationID = (int)reader["RetakeTestApplicationID"];

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

        public static bool IsAppointmentExistByTestType(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            bool IsFound = default(bool);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT TRUE = 1 FROM TestAppointments WHERE
                             LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID AND TestTypeID = @TestTypeID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

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

        public static DataTable LoadTestAppointmentsList(int LocalDrivingLicenseApplicationID, string TestTypeTitle)
        {
            DataTable Table = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM TestAppointments_View WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID
                             AND TestTypeTitle = @TestTypeTitle ORDER BY AppointmentDate DESC";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);

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

        public static bool GetLastTestAppointment(int LocalDrivingLicenseApplicationID, int TestTypeID, ref int TestAppointmentID,
            ref DateTime AppointmentDate, ref decimal PaidFees, ref int CreatedByUserID, ref int RetakeTestApplicationID)
        {
            bool IsFound = default(bool);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT TOP 1 * FROM TestAppointments WHERE
                            LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID
                            AND TestTypeID = @TestTypeID AND IsLocked = 0";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    TestAppointmentID = (int)reader["AppointmentID"];
                    AppointmentDate = (DateTime)reader["AppointmentDate"];
                    PaidFees = (decimal)reader["PaidFees"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];

                    if (reader["RetakeTestApplicationID"] == DBNull.Value)
                        RetakeTestApplicationID = -1;
                    else
                        RetakeTestApplicationID = (int)reader["RetakeTestApplicationID"];

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

        public static bool HasPassedTestForAppointment(int AppointmentID)
        {
            bool IsPassed = default(bool);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT PassTest = 1 FROM TestAppointments JOIN Tests
                             ON TestAppointments.AppointmentID = Tests.AppointmentID
                             WHERE TestAppointments.AppointmentID = @AppointmentID AND Tests.TestResult = 1";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@AppointmentID", AppointmentID);

            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();

                if (Result != null)
                    IsPassed = true;
            }

            catch
            {
                throw;
            }

            finally
            {
                connection.Close();
            }

            return IsPassed;
        }
    }
}