using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storages_DataAccessLayer
{
    public class clsStoragesData
    {
        
        public static bool GetStorageByStorageID(int StorageID, ref string StorageName, ref string Location, ref string Information)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from Storages where StorageID=@StorageID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@StorageID", StorageID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    StorageName = (string)reader["StorageName"];
                    Location = (string)reader["Location"];
                    Information = (string)reader["Information"];


                }
                else
                {
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex) { isFound = false; }
            finally { connection.Close(); }

            return isFound;
        }


        public static bool GetStorageByStorageName(string StorageName, ref int StorageID, ref string Location, ref string Information)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Storages where StorageName=@StorageName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@StorageName", StorageName);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    StorageID = (int)reader["StorageID"];
                    Location = (string)reader["Location"];
                    Information = (string)reader["Information"];


                }
                else
                {
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex) { isFound = false; }
            finally { connection.Close(); }




            return isFound;
        }




        public static bool IsStorageExist(int StorageID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select FOUND=1 from Storages where StorageID=@StorageID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@StorageID", StorageID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    isFound = true;


                }
                else
                {
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex) { isFound = false; }
            finally { connection.Close(); }




            return isFound;
        }
        public static bool IsStorageExist(string StorageName)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select FOUND=1 from Storages where StorageName=@StorageName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@StorageName", StorageName);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    isFound = true;


                }
                else
                {
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex) { isFound = false; }
            finally { connection.Close(); }




            return isFound;
        }

        public static bool CheckNewStorage(string StorageName)
        {

            using (var connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (var command = new SqlCommand("SP_CheckNewStorage", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@NewStorageName", StorageName);
                    var outputIdParam = new SqlParameter("@Result", SqlDbType.Bit)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(outputIdParam);
                    connection.Open();
                    command.ExecuteNonQuery();
                    return (bool)outputIdParam.Value;
                }
            }


        }

        public static int AddNewStorage(string StorageName, string Location, string Information)
        {

            int StorageID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO Storages
           (StorageName
           ,Location
           ,Information)
            VALUES
           (@StorageName,@Location,@Information)

           SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@StorageName", StorageName);
            command.Parameters.AddWithValue("@Location", Location);
            command.Parameters.AddWithValue("@Information", Information);


            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {

                    StorageID = insertedID;
                }
            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return StorageID;

        }

        public static bool UpdateStorage(int StorageID, string StorageName, string Location, string Information)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"UPDATE Storages SET StorageName = @StorageName,Location = @Location,Information = @Information WHERE StorageID=@StorageID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@StorageID", StorageID);
            command.Parameters.AddWithValue("@StorageName", StorageName);
            command.Parameters.AddWithValue("@Location", Location);
            command.Parameters.AddWithValue("@Information", Information);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();


            }
            catch (Exception ex) { return false; }
            finally { connection.Close(); }


            return (rowsAffected > 0);
        }

        public static bool DeleteStorage(int StorageID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"DELETE FROM Storages WHERE StorageID=@StorageID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@StorageID", StorageID);
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }


            return (rowsAffected > 0);


        }

        public static DataTable GetAllStorages()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT StorageID ,StorageName ,Location,Information FROM Storages ";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();
            }

            catch (Exception ex) { }
            finally
            {
                connection.Close();
            }

            return dt;


        }










    }
}
