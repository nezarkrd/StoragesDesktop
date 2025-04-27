using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storages_DataAccessLayer
{
    public class clsOperationConvertStorgaesData
    {

        public static int AddNewOperationStorage(int ItemUnitID, int FromStorageID, int ToStorageID, int AmountConvert, DateTime DateOperation, string ReasonOperation, int EmployeeID, int UserID)
        {

            int NewOperationConverStoragesID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand command = new SqlCommand("SP_AddOpreationConvertStorages", connection);
            command.CommandType = CommandType.StoredProcedure;


            // Add parameters
            command.Parameters.AddWithValue("@ItemUnitID", ItemUnitID);
            command.Parameters.AddWithValue("@FromStorageID", FromStorageID);
            command.Parameters.AddWithValue("@ToStorageID", ToStorageID);
            command.Parameters.AddWithValue("@AmountConvert", AmountConvert);

            command.Parameters.AddWithValue("@DateOperation", DateOperation);
            command.Parameters.AddWithValue("@ReasonOperation", ReasonOperation);
            command.Parameters.AddWithValue("@EmployeeID", EmployeeID);
            command.Parameters.AddWithValue("@UserID", UserID);





            SqlParameter outputIdParam = new SqlParameter("@NewOperationConvertStorages", SqlDbType.Int)
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
                NewOperationConverStoragesID = (int)command.Parameters["@NewOperationConvertStorages"].Value;

            }

            catch (Exception ex) { }
            finally { connection.Close(); }


            return NewOperationConverStoragesID;



        }

        public static DataTable GetAllOperationsConvertStorages()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from vOperationConvertBetweenStorages";
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
