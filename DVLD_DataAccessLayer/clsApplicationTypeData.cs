using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccessLayer
{
    public class clsApplicationTypeData
    {
        public static bool Find(int ApplicationID, ref string ApplicationTitle, ref decimal ApplicationFees)
        {
            bool IsFound = default(bool);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM ApplicationTypes WHERE ApplicationTypeID = @ApplicationID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    ApplicationTitle = (string)reader["ApplicationTitle"];
                    ApplicationFees = (decimal)reader["ApplicationFees"];
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

        public static bool Update(int ApplicationID, string ApplicationTitle, decimal ApplicationFees)
        {
            bool IsUpdated = default(bool);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"UPDATE ApplicationTypes SET ApplicationTitle = @ApplicationTitle,
                             ApplicationFees = @ApplicationFees WHERE ApplicationTypeID = @ApplicationID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue(@"ApplicationID", ApplicationID);
            command.Parameters.AddWithValue(@"ApplicationTitle", ApplicationTitle);
            command.Parameters.AddWithValue(@"ApplicationFees", ApplicationFees);

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

        public static DataTable LoadApplicationsList()
        {
            DataTable Table = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM ApplicationTypes";

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

        public static string GetApplicationTitle(int ApplicationTypeID)
        {
            string ApplicationTitle = default(string);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT ApplicationTitle FROM ApplicationTypes WHERE ApplicationTypeID = @ApplicationTypeID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();

                if (Result != null)
                    ApplicationTitle = Result.ToString();
            }

            catch
            {
                throw;
            }

            finally
            {
                connection.Close();
            }

            return ApplicationTitle;
        }

        public static decimal GetApplicationFees(int ApplicationTypeID)
        {
            decimal ApplicationFees = default(decimal);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT ApplicationFees FROM ApplicationTypes WHERE ApplicationTypeID = @ApplicationTypeID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();

                if (Result != null)
                    ApplicationFees = Convert.ToDecimal(Result);
            }

            catch
            {
                throw;
            }

            finally
            {
                connection.Close();
            }

            return ApplicationFees;
        }
    }
}