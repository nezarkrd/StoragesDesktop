using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storages_DataAccessLayer
{
    public class clsItemsData
    {

        public static bool GetItemByItemID(int ItemID, ref string ItemName, ref string Description, ref int CategoryID)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from Items where ItemID=@ItemID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ItemID", ItemID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                   
                    ItemName = (string)reader["ItemName"];
                    Description = (string)reader["Description"];
                    CategoryID = (int)reader["CategoryID"];

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
        public static bool GetItemByItemName( string ItemName ,ref int ItemID, ref string Description, ref int CategoryID)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Items where ItemName=@ItemName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ItemName", ItemName);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    ItemID = (int)reader["ItemID"];

                    Description = (string)reader["Description"];
                    CategoryID = (int)reader["CategoryID"];

                   

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

       


        public static bool IsItemExist(int ItemID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select FOUND=1 from Items where ItemID=@ItemID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ItemID", ItemID);
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
        public static bool IsItemExist(string ItemName)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select FOUND=1 from Items where ItemName=@ItemName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ItemName", ItemName);
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
      

        public static bool CheckNewItem(string ItemName) {

            using (var connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (var command = new SqlCommand("SP_CheckNewItem", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@NewItemName", ItemName);
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
        public static int AddNewItem(string ItemName, string Description, int CategoryID)
        {

            int ItemID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO Items
           (ItemName
           ,Description
           ,CategoryID)
             VALUES
           (@ItemName
           ,@Description
           ,@CategoryID)
            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ItemName", ItemName);
            command.Parameters.AddWithValue("@Description", Description);
            command.Parameters.AddWithValue("@CategoryID", CategoryID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {

                    ItemID = insertedID;
                }
            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return ItemID;

        }

        public static bool UpdateItem(int ItemID, string ItemName, string Description, int CategoryID)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"UPDATE Items
               SET ItemName = @ItemName
               ,Description = @Description
               ,CategoryID = @CategoryID
                WHERE  ItemID=@ItemID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ItemID", ItemID);
            command.Parameters.AddWithValue("@ItemName", ItemName);
            command.Parameters.AddWithValue("@Description", Description);
            command.Parameters.AddWithValue("@CategoryID", CategoryID);
           
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();


            }
            catch (Exception ex) { return false; }
            finally { connection.Close(); }


            return (rowsAffected > 0);
        }

        public static bool DeleteItem(int ItemID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"delete Items where ItemID=@ItemID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ItemID", ItemID);
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }


            return (rowsAffected > 0);


        }

        public static DataTable GetAllItems()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT Items.ItemID     ,Items.ItemName      ,Items.Description    ,Categories.CategoryName  FROM Items join Categories on Items.CategoryID=Categories.CategoryID ";
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
