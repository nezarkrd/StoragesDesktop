using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Storages_DataAccessLayer
{
    public class clsItemsUnitsData
    {



        public static bool GetItemUnitByItemUnitID(int ItemUnitID, ref int ItemID, ref int UnitID, ref decimal BuyPrice, ref decimal SellPrice)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from ItemsUnits where ItemUnitID=@ItemUnitID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ItemUnitID", ItemUnitID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;

                    ItemID = (int)reader["ItemID"];
                    UnitID = (int)reader["UnitID"];
                    BuyPrice = (decimal)reader["BuyPrice"];
                    SellPrice= (decimal)reader["SellPrice"];

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





        public static bool IsItemUnitIDExist(int ItemUnitID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select FOUND=1 from ItemsUnits where ItemUnitID=@ItemUnitID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ItemUnitID", ItemUnitID);
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

        public static bool IsUnitIDExist(int ItemID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select FOUND=1 from ItemsUnits where ItemID=@ItemID";
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

        public static bool CheckNewItemUnit(int UnitID,int ItemID)
        {

            using (var connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (var command = new SqlCommand("SP_CheckNewItemUnit", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@NewUnitID", UnitID);
                    command.Parameters.AddWithValue("@NewItemID", ItemID);
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
        public static int AddNewItemUnit(int ItemID,  int UnitID,  decimal BuyPrice,  decimal SellPrice)
        {

            int ItemUnitID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"
         

           INSERT INTO ItemsUnits
           (ItemID
           ,UnitID
           ,BuyPrice
           ,SellPrice)
            VALUES
           (@ItemID
           ,@UnitID
           ,@BuyPrice
		   ,@SellPrice)
           SELECT SCOPE_IDENTITY();

           ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ItemID", ItemID);
            command.Parameters.AddWithValue("@UnitID", UnitID);
            command.Parameters.AddWithValue("@BuyPrice", BuyPrice);
            command.Parameters.AddWithValue("@SellPrice", SellPrice);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {

                    ItemUnitID = insertedID;
                }
            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return ItemUnitID;

        }

        public static bool UpdateItemUnit(int ItemUnitID, int ItemID, int UnitID, decimal BuyPrice, decimal SellPrice)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"UPDATE ItemsUnits
             SET ItemID = @ItemID
             ,UnitID = @UnitID
             ,BuyPrice = @BuyPrice
             ,SellPrice = @SellPrice
             WHERE ItemUnitID=@ItemUnitID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ItemUnitID", ItemUnitID);
            command.Parameters.AddWithValue("@ItemID", ItemID);
            command.Parameters.AddWithValue("@UnitID", UnitID);
            command.Parameters.AddWithValue("@BuyPrice", BuyPrice);
            command.Parameters.AddWithValue("@SellPrice", SellPrice);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();


            }
            catch (Exception ex) { return false; }
            finally { connection.Close(); }


            return (rowsAffected > 0);
        }

        public static bool DeleteItemUnit(int ItemUnitID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"delete ItemsUnits where ItemUnitID=@ItemUnitID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ItemUnitID", ItemUnitID);
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }


            return (rowsAffected > 0);


        }

        public static DataTable GetAllItemsUnits()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT ItemUnitID,ItemID ,UnitID ,BuyPrice,SellPrice  FROM ItemsUnits ";
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

        public static DataTable GetAllItemsUnitsByItemID(int ItemID)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT ItemsUnits.ItemUnitID,Items.ItemName ,Units.UnitName ,ItemsUnits.BuyPrice,ItemsUnits.SellPrice  FROM ItemsUnits\r\njoin Units on Units.UnitID=ItemsUnits.UnitID\r\njoin Items on Items.ItemID=ItemsUnits.ItemID\r\nwhere ItemsUnits.ItemID=@ItemID ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ItemID", ItemID);
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

        public static bool GetUnitItemID(  int ItemID,  int UnitID, ref int ItemUnitID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT ItemUnitID  FROM ItemsUnits  where ItemID=@ItemID and UnitID=@UnitID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ItemID", ItemID);
            command.Parameters.AddWithValue("@UnitID", UnitID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;

                    ItemUnitID = (int)reader["ItemUnitID"];
               

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




    }
}
