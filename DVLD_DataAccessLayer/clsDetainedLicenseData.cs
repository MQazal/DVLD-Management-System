using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccessLayer
{
    public class clsDetainedLicenseData
    {
        public static int Add(int LicenseID, DateTime DetainDate, decimal FineFees, int CreatedByUserID)
        {
            int AddedID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"INSERT INTO DetainedLicenses (LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased,
                             ReleaseDate, ReleasedByUserID, ReleaseApplicationID)
                             VALUES (@LicenseID, @DetainDate, @FineFees, @CreatedByUserID, 0, NULL, NULL, NULL);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@DetainDate", DetainDate);
            command.Parameters.AddWithValue("@FineFees", FineFees);
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

        public static bool Update(int DetainID, bool IsReleased, DateTime ReleaseDate,
            int ReleasedByUserID, int ReleaseApplicationID)
        {
            bool IsUpdated = default(bool);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"UPDATE DetainedLicenses SET IsReleased = @IsReleased, ReleaseDate = @ReleaseDate,
                             ReleasedByUserID = @ReleasedByUserID, ReleaseApplicationID = @ReleaseApplicationID
                             WHERE DetainID = @DetainID;";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@DetainID", DetainID);
            command.Parameters.AddWithValue("@IsReleased", IsReleased);
            command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
            command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
            command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);

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

        public static DataTable LoadDetainedLicensesList()
        {
            DataTable Table = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM detainedLicenses_View ORDER BY IsReleased, DetainID;";

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

        public static bool GetDetainedLicenseInfoByDetianID(int DetainID, ref int LicenseID, ref DateTime DetainDate,
            ref decimal FineFees, ref int CreatedByUserID, ref bool IsReleased, ref DateTime ReleaseDate,
            ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {
            bool IsFound = default(bool);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM DetainedLicenses WHERE DetainID = @DetainID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DetainID", DetainID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    LicenseID = (int)reader["LicenseID"];
                    DetainDate = (DateTime)reader["DetainDate"];
                    FineFees = (decimal)reader["FineFees"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsReleased = (bool)reader["IsReleased"];

                    if (reader["ReleaseDate"] == DBNull.Value)
                        ReleaseDate = default(DateTime);
                    else
                        ReleaseDate = (DateTime)reader["ReleaseDate"];

                    if (reader["ReleasedByUserID"] == DBNull.Value)
                        ReleasedByUserID = -1;
                    else
                        ReleasedByUserID = (int)reader["ReleasedByUserID"];

                    if (reader["ReleaseApplicationID"] == DBNull.Value)
                        ReleaseApplicationID = -1;
                    else
                        ReleaseApplicationID = (int)reader["ReleaseApplicationID"];

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

        public static bool GetDetainedLicenseInfoByLicenseID(int LicenseID, ref int DetainID, ref DateTime DetainDate,
            ref decimal FineFees, ref int CreatedByUserID, ref bool IsReleased, ref DateTime ReleaseDate,
            ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {
            bool IsFound = default(bool);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT TOP 1 * FROM DetainedLicenses WHERE LicenseID = @LicenseID ORDER BY DetainID DESC";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    DetainID = (int)reader["DetainID"];
                    DetainDate = (DateTime)reader["DetainDate"];
                    FineFees = (decimal)reader["FineFees"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsReleased = (bool)reader["IsReleased"];

                    if (reader["ReleaseDate"] == DBNull.Value)
                        ReleaseDate = default(DateTime);
                    else
                        ReleaseDate = (DateTime)reader["ReleaseDate"];

                    if (reader["ReleasedByUserID"] == DBNull.Value)
                        ReleasedByUserID = -1;
                    else
                        ReleasedByUserID = (int)reader["ReleasedByUserID"];

                    if (reader["ReleaseApplicationID"] == DBNull.Value)
                        ReleaseApplicationID = -1;
                    else
                        ReleaseApplicationID = (int)reader["ReleaseApplicationID"];

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

        public static bool IsLicenseDetained(int LicenseID)
        {
            bool IsDetained = default(bool);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT LicenseIsDetained = 1 FROM DetainedLicenses WHERE LicenseID = @LicenseID AND IsReleased = 0;";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();

                if (Result != null)
                    IsDetained = true;
            }

            catch
            {
                throw;
            }

            finally
            {
                connection.Close();
            }

            return IsDetained;
        }
    }
}