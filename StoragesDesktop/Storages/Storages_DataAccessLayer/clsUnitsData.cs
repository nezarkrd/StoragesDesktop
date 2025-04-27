using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storages_DataAccessLayer
{
    public class clsUnitsData
    {

        public static bool GetUnitByUnitID(int UnitID,  ref string UnitName, ref int SmallerUnitID, ref int NumberOfContent)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from Units where UnitID=@UnitID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UnitID", UnitID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    UnitName = (string)reader["UnitName"];
                    if (reader["SmallerUnitID"] != DBNull.Value) { SmallerUnitID = (int)reader["SmallerUnitID"]; }
                    else { SmallerUnitID = -1; }
                   
             
                    if (reader["NumberOfContent"] != DBNull.Value) { NumberOfContent = (int)reader["NumberOfContent"]; }
                    else { NumberOfContent = -1; }



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
        

        public static bool GetUnitByUnitName(string UnitName, ref int UnitID, ref int SmallerUnitID, ref int NumberOfContent)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Units where UnitName=@UnitName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UnitName", UnitName);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    UnitID = (int)reader["UnitID"];
                    if (reader["SmallerUnitID"] != DBNull.Value) { SmallerUnitID = (int)reader["SmallerUnitID"]; }
                    else { SmallerUnitID = -1; }
                    if (reader["NumberOfContent"] != DBNull.Value) { NumberOfContent = (int)reader["NumberOfContent"]; }
                    else { NumberOfContent = -1; }
                   
                  
                   

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

        


        public static bool IsUnitExist(int UnitID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select FOUND=1 from Units where UnitID=@UnitID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UnitID", UnitID);
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
        public static bool IsUnitExist(string UnitName)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select FOUND=1 from Units where UnitName=@UnitName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UnitName", UnitName);
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

        public static bool CheckNewUnit(string UnitName)
        {

            using (var connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (var command = new SqlCommand("SP_CheckNewUnit", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@NewUnitName", UnitName);
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

        public static int AddNewUnit( string UnitName, int SmallerUnitID, int NumberOfContent)
        {

            int UnitID = -1;
            //Nullable<int> SmallerUnitIDNull=null;
            
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO Units
           (UnitName,SmallerUnitID,NumberOfContent)
           VALUES 
        
           (@UnitName
           ,@SmallerUnitID
           ,@NumberOfContent)

           SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UnitName", UnitName);
            if (SmallerUnitID == -1) {  command.Parameters.AddWithValue("@SmallerUnitID", DBNull.Value); }
            else { command.Parameters.AddWithValue("@SmallerUnitID", SmallerUnitID); }
            if (SmallerUnitID == -1)
            { command.Parameters.AddWithValue("@NumberOfContent",DBNull.Value); }
            else { command.Parameters.AddWithValue("@NumberOfContent", NumberOfContent); }  
           

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {

                    UnitID = insertedID;
                }
            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return UnitID;

        }

        public static bool UpdateUnit(int UnitID, string UnitName, int SmallerUnitID, int NumberOfContent)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"UPDATE Units SET UnitName = @UnitName,SmallerUnitID =@SmallerUnitID,NumberOfContent = @NumberOfContent WHERE UnitID=@UnitID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UnitID", UnitID);
            command.Parameters.AddWithValue("@UnitName", UnitName);
            command.Parameters.AddWithValue("@SmallerUnitID", SmallerUnitID);
            command.Parameters.AddWithValue("@NumberOfContent", NumberOfContent);
           
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();


            }
            catch (Exception ex) { return false; }
            finally { connection.Close(); }


            return (rowsAffected > 0);
        }

        public static bool DeleteUnit(int UnitID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"DELETE FROM Units WHERE UnitID=@UnitID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UnitID", UnitID);
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }


            return (rowsAffected > 0);


        }

        public static DataTable GetAllUnits()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT Units1.UnitID ,Units1.UnitName  ,Units2.UnitName as SmallUnitName  ,Units1.NumberOfContent  FROM Units  Units1  left join Units  Units2 on Units1.SmallerUnitID=Units2.UnitID ";
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

        public static DataTable GetAllUnitsByItemID(int ItemID)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT Units1.UnitID ,Units1.UnitName  ,Units2.UnitName as SmallUnitName  ,Units1.NumberOfContent  FROM Units Units1\r\nleft join Units  Units2 on Units1.SmallerUnitID=Units2.UnitID \r\nwhere Units1.UnitID in (select UnitID from ItemsUnits where ItemID=@ItemID)";
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
        




    }
}
