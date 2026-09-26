using System;
using System.Data.SqlClient;

namespace DVLD_DataAccessLayer
{
    public class clsTestData
    {
        public static int Add(int AppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            int TestID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Tests (AppointmentID, TestResult, Notes, CreatedByUserID)
                             VALUES (@AppointmentID, @TestResult, @Notes, @CreatedByUserID);
                             UPDATE TestAppointments SET IsLocked = 1 WHERE AppointmentID = @AppointmentID;
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AppointmentID", AppointmentID);
            command.Parameters.AddWithValue("@TestResult", TestResult);

            if (Notes != "")
                command.Parameters.AddWithValue("@Notes", Notes);
            else
                command.Parameters.AddWithValue("@Notes", System.DBNull.Value);

            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int NewInsertedID))
                {
                    TestID = NewInsertedID;
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

            return TestID;
        }

        public static bool Update(int TestID, string Notes)
        {
            bool IsUpdated = default(bool);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE Tests SET Notes = @Notes WHERE TestID = @TestID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestID", TestID);
            command.Parameters.AddWithValue("@Notes", Notes);

            try
            {
                connection.Open();

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
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

        public static bool Find(ref int TestID, int AppointmentID, ref bool TestResult, ref string Notes,
            ref int CreatedByUserID)
        {
            bool IsFound = default(bool);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Tests WHERE AppointmentID = @AppointmentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AppointmentID", AppointmentID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    TestID = (int)reader["TestID"];
                    TestResult = (bool)reader["TestResult"];

                    if (reader["Notes"] == DBNull.Value)
                        Notes = "";
                    else
                        Notes = (string)reader["Notes"];

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
    }
}