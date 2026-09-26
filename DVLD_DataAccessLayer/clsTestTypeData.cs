using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccessLayer
{
    public class clsTestTypeData
    {
        public static bool Find(int ID, ref string Title, ref string Description, ref decimal Fees)
        {
            bool IsFound = default(bool);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM TestTypes WHERE TestTypeID = @ID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Title = (string)reader["TestTypeTitle"];
                    Description = (string)reader["TestTypeDescription"];
                    Fees = (decimal)reader["TestTypeFees"];
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

        public static bool Update(int ID, string Title, string Description, decimal Fees)
        {
            bool IsUpdated = default(bool);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"UPDATE TestTypes SET TestTypeTitle = @Title,
                             TestTypeDescription = @Description, TestTypeFees = @Fees WHERE TestTypeID = @ID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue(@"ID", ID);
            command.Parameters.AddWithValue(@"Title", Title);
            command.Parameters.AddWithValue(@"Description", Description);
            command.Parameters.AddWithValue(@"Fees", Fees);

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

        public static DataTable LoadTestsList()
        {
            DataTable Table = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM TestTypes";

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

        public static string GetTestTitle(int TestTypeID)
        {
            string TestTitle = default(string);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT TestTypes.TestTypeTitle FROM TestTypes WHERE TestTypes.TestTypeID = @TestTypeID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();

                if (Result != null)
                    TestTitle = Result.ToString();
            }

            catch
            {
                throw;
            }

            finally
            {
                connection.Close();
            }

            return TestTitle;
        }
    }
}