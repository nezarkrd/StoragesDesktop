using Storages_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storages
{
    public class clsStorageContentData
    {
        
        public static bool GetStorageContentByID(int StoreContentID, ref int ItemUnitID, ref int ItemID, ref int StorageID, ref int Amount, ref decimal BuyPrice, ref decimal TotalBuyPrice, ref decimal SellPrice, ref decimal TotalSellPrice)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from StoresContents where StoreContentID=@StoreContentID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@StoreContentID", StoreContentID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    ItemUnitID = (int)reader["ItemUnitID"];
                    ItemID = (int)reader["ItemID"];
                    StorageID = (int)reader["StorageID"];
                    Amount = (int)reader["Amount"];
                    BuyPrice = (decimal)reader["BuyPrice"];
                    TotalBuyPrice = (decimal)reader["TotalBuyPrice"];
                    SellPrice = (decimal)reader["SellPrice"];
                    TotalSellPrice = (decimal)reader["TotalSellPrice"];
                

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

        public static bool GetStorageContentByStorageID( int StorageID,ref int StoreContentID, ref int ItemUnitID, ref int ItemID, ref int Amount, ref decimal BuyPrice, ref decimal TotalBuyPrice, ref decimal SellPrice, ref decimal TotalSellPrice)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from people where StorageID=@StorageID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@StorageID", StorageID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    StoreContentID= (int)reader["StoreContentID"]; ;
                    ItemUnitID = (int)reader["ItemUnitID"];
                    ItemID = (int)reader["ItemID"];
                    Amount = (int)reader["Amount"];
                    BuyPrice = (decimal)reader["BuyPrice"];
                    TotalBuyPrice = (decimal)reader["TotalBuyPrice"];
                    SellPrice = (decimal)reader["SellPrice"];
                    TotalSellPrice = (decimal)reader["TotalSellPrice"];

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

        public static bool IsStorageExist(int StoreContentID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select FOUND=1 from StoresContents where StoreContentID=@StoreContentID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@StoreContentID", StoreContentID);
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
        public static bool IsStorageExistByStorageID(int StorageID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select FOUND=1 from StoresContents where StorageID=@StorageID";
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
        
        public static bool IsItemExistInStorages(int ItemID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select FOUND=1 from StoresContents where StoresContents.ItemID=@ItemID";
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

        public static bool IsItemUnitExistInStorage(int ItemUnitID,int StorageID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select FOUND=1 from StoresContents where ItemUnitID=@ItemUnitID and StorageID=@StorageID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ItemUnitID", ItemUnitID);
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
        public static bool IsAmountItemUnitExistInStorage(int ItemUnitID, int StorageID,int Amount)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select FOUND=1 from StoresContents where ItemUnitID=@ItemUnitID and StorageID=@StorageID and Amount>=@Amount";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ItemUnitID", ItemUnitID);
            command.Parameters.AddWithValue("@StorageID", StorageID);
            command.Parameters.AddWithValue("@Amount", Amount);
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
        public static DataTable GetAllStoragesContents()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT StoresContents.StoreContentID\r\n      ,StoresContents.ItemUnitID\r\n      ,Items.ItemName\r\n\t  ,Units.UnitName\r\n\t  ,StoresContents.Amount\r\n      ,Storages.StorageName\r\n      ,StoresContents.BuyPrice\r\n      ,StoresContents.TotalBuyPrice\r\n      ,StoresContents.SellPrice\r\n      ,StoresContents.TotalSellPrice\r\n  FROM StoresContents join Items on StoresContents.ItemID=Items.ItemID join Storages on StoresContents.StorageID=Storages.StorageID join ItemsUnits on ItemsUnits.ItemUnitID=StoresContents.ItemUnitID join Units on Units.UnitID=ItemsUnits.UnitID\r\n";
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


        public static DataTable GetAllStoragesContentsByStorageID(int StorageID)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT StoresContents.StoreContentID\r\n      ,StoresContents.ItemUnitID\r\n      ,Items.ItemName\r\n\t  ,Units.UnitName\r\n\t  ,StoresContents.Amount\r\n      ,Storages.StorageName\r\n      ,StoresContents.BuyPrice\r\n      ,StoresContents.TotalBuyPrice\r\n      ,StoresContents.SellPrice\r\n      ,StoresContents.TotalSellPrice\r\n  FROM StoresContents join Items on StoresContents.ItemID=Items.ItemID join Storages on StoresContents.StorageID=Storages.StorageID join ItemsUnits on ItemsUnits.ItemUnitID=StoresContents.ItemUnitID join Units on Units.UnitID=ItemsUnits.UnitID\r\n where StoresContents.StorageID=@StorageID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("StorageID", StorageID);

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

        public static DataTable GetAllStoragesContentsByItemID(int ItemID)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT StoresContents.StoreContentID      ,StoresContents.ItemUnitID    ,Items.ItemName  ,Units.UnitName ,StoresContents.Amount     ,Storages.StorageName     ,StoresContents.BuyPrice     ,StoresContents.TotalBuyPrice    ,StoresContents.SellPrice      ,StoresContents.TotalSellPrice FROM StoresContents join Items on StoresContents.ItemID=Items.ItemID join Storages on StoresContents.StorageID=Storages.StorageID join ItemsUnits on ItemsUnits.ItemUnitID=StoresContents.ItemUnitID join Units on Units.UnitID=ItemsUnits.UnitID\r\nwhere StoresContents.ItemID=@ItemID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("ItemID", ItemID);

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
