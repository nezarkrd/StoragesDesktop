using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storages_DataAccessLayer
{
    public class clsOperationsStoragesData
    {


        public static bool GetOperationStorageByOperationStorageID(int OperationStorageID, ref int ItemUnitID, ref int StorageID, ref int OldAmount, ref int Amount, ref short TypeOperation, ref int NewAmount, ref DateTime DateOperation,ref string ReasonOperation, ref int EmployeeID, ref int UserID)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT OperationStorageID ,ItemUnitID ,StorageID ,OldAmount ,Amount ,TypeOperation,NewAmount,DateOperation ,EmployeeID ,UserID  FROM OperationsStorages where OperationStorageID=@OperationStorageID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@OperationStorageID", OperationStorageID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    ItemUnitID = (int)reader["ItemUnitID"];
                    StorageID = (int)reader["StorageID"];
                    OldAmount = (int)reader["OldAmount"];
                    Amount = (int)reader["Amount"];
                    TypeOperation = (short)reader["TypeOperation"];
                    NewAmount = (int)reader["NewAmount"];
                    DateOperation = (DateTime)reader["DateOperation"];
                    ReasonOperation = (string)reader["ReasonOperation"];
                    EmployeeID = (int)reader["EmployeeID"];
                    UserID = (int)reader["UserID"];


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


      

        public static bool IsOperationStorageExist(int OperationStorageID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select FOUND=1 from OperationsStorages where OperationStorageID=@OperationStorageID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@OperationStorageID", OperationStorageID);
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
       



        public static int AddNewOperationStorage(int ItemUnitID, int StorageID,int Amount,short TypeOperation,DateTime DateOperation,string ReasonOperation, int EmployeeID,int UserID)
        {

            int NewOperationStorageID = -1;
           
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand command = new SqlCommand("SP_AddOpreationStorage", connection);
            command.CommandType = CommandType.StoredProcedure;


            // Add parameters
            command.Parameters.AddWithValue("@ItemUnitID", ItemUnitID);
            command.Parameters.AddWithValue("@StorageID", StorageID);
            //command.Parameters.AddWithValue("@OldAmount", OldAmount);
            command.Parameters.AddWithValue("@Amount", Amount);
            command.Parameters.AddWithValue("@TypeOperation", TypeOperation);
            //command.Parameters.AddWithValue("@NewAmount", NewAmount);
            command.Parameters.AddWithValue("@DateOperation", DateOperation);
            command.Parameters.AddWithValue("@ReasonOperation", ReasonOperation);
            command.Parameters.AddWithValue("@EmployeeID", EmployeeID);
            command.Parameters.AddWithValue("@UserID", UserID);





            SqlParameter outputIdParam = new SqlParameter("@NewOperationStorage", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };
            command.Parameters.Add(outputIdParam);


            try
            {
                // Execute
                connection.Open();
                command.ExecuteNonQuery();

                // Retrieve the ID of the new person
                NewOperationStorageID = (int)command.Parameters["@NewOperationStorage"].Value;

            }

            catch (Exception ex) { }
            finally { connection.Close(); } 


            return NewOperationStorageID;



        }

        public static bool UpdateOperationStorage(int OperationStorageID, int ItemUnitID, int StorageID, int OldAmount, int Amount, short TypeOperation, int NewAmount, DateTime DateOperation,string ReasonOperation, int EmployeeID, int UserID)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"UPDATE OperationsStorages
               SET ItemUnitID = @ItemUnitID
              ,StorageID = @StorageID
              ,OldAmount = @OldAmount
              ,Amount = @Amount
              ,TypeOperation = @TypeOperation
              ,NewAmount = @NewAmount
              ,DateOperation= @DateOperation
              ,ReasonOperation=@ReasonOperation
              ,EmployeeID = @EmployeeID
              ,UserID =@UserID
             WHERE OperationStorageID=@OperationStorageID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ItemUnitID", ItemUnitID);
            command.Parameters.AddWithValue("@StorageID", StorageID);
            command.Parameters.AddWithValue("@OldAmount", OldAmount);
            command.Parameters.AddWithValue("@Amount", Amount);
            command.Parameters.AddWithValue("@TypeOperation", TypeOperation);
            command.Parameters.AddWithValue("@NewAmount", NewAmount);
            command.Parameters.AddWithValue("@DateOperation", DateOperation);
            command.Parameters.AddWithValue("@ReasonOperation", ReasonOperation);
            command.Parameters.AddWithValue("@EmployeeID", EmployeeID);
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();


            }
            catch (Exception ex) { return false; }
            finally { connection.Close(); }


            return (rowsAffected > 0);
        }

        public static bool DeleteOperationStorage(int OperationStorageID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"DELETE FROM OperationsStorages
                           WHERE OperationStorageID=@OperationStorageID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@OperationStorageID", OperationStorageID);
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }


            return (rowsAffected > 0);


        }

        public static DataTable GetAllOperationsStorages()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from vOperationStorage";
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
