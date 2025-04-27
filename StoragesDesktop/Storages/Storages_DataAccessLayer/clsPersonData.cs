using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storages_DataAccessLayer
{
    public class clsPersonData
    {
        public static bool GetPersonByID(int PersonID, ref string FirstName, ref string LastName, ref string Phone, ref string Email, ref short Gendor, ref DateTime DateBirth, ref string ImagePath, ref int NationalCountryID, ref string NationalNO)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from people where PersonID=@PersonID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    Phone = (string)reader["Phone"];
                    if (reader["Email"] != DBNull.Value) { Email = (string)reader["Email"]; }
                    else { Email = ""; }

                    Gendor = (byte)reader["Gendor"];
                    DateBirth = (DateTime)reader["DateBirth"];
                    if (reader["ImagePath"] != DBNull.Value) { ImagePath = (string)reader["ImagePath"]; }
                    else { ImagePath = ""; }
                    NationalCountryID = (int)reader["NationalCountryID"];
                    NationalNO = (string)reader["NationalNO"];

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

        public static bool GetPersonByNationalNO(string NationalNO, ref int PersonID, ref string FirstName, ref string LastName, ref string Phone, ref string Email, ref short Gendor, ref DateTime DateBirth, ref string ImagePath, ref int NationalCountryID)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from people where NationalNO=@NationalNO";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNO", NationalNO);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    PersonID = (int)reader["PersonID"];
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    Phone = (string)reader["Phone"];
                    if (reader["Email"] != DBNull.Value) { Email = (string)reader["Email"]; }
                    else { Email = ""; }
                    Gendor = (byte)reader["Gendor"];
                    DateBirth = (DateTime)reader["DateBirth"];
                    if (reader["ImagePath"] != DBNull.Value) { ImagePath = (string)reader["ImagePath"]; }
                    else { ImagePath = ""; }
                    NationalCountryID = (int)reader["NationalCountryID"];

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

        public static bool IsPersonExist(int PersonID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select FOUND=1 from people where PersonID=@PersonID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
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
        public static bool IsPersonExist(string NationalNO)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select FOUND=1 from people where NationalNO=@NationalNO";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNO", NationalNO);
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

        public static int AddNewPerson(string FirstName, string LastName, string Phone, string Email, short Gendor, DateTime DateBirth, string ImagePath, int NationalCountryID, string NationalNO)
        {

            int PersonID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO People (FirstName,LastName,Phone,Email,Gendor,DateBirth,ImagePath,NationalCountryID,NationalNO)
                             VALUES(@FirstName, @LastName, @Phone, @Email, @Gendor, @DateBirth, @ImagePath, @NationalCountryID, @NationalNO)
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Phone", Phone);
            if (Email != "" && Email != null) { command.Parameters.AddWithValue("@Email", Email); }
            else { command.Parameters.AddWithValue("@Email", System.DBNull.Value); }

            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@DateBirth", DateBirth);
            if (ImagePath != "" && ImagePath != null) { command.Parameters.AddWithValue("@ImagePath", ImagePath); }
            else { command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value); }

            command.Parameters.AddWithValue("@NationalCountryID", NationalCountryID);
            command.Parameters.AddWithValue("@NationalNO", NationalNO);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {

                    PersonID = insertedID;
                }
            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return PersonID;

        }

        public static bool UpdatePerson(int PersonID, string FirstName, string LastName, string Phone, string Email, short Gendor, DateTime DateBirth, string ImagePath, int NationalCountryID, string NationalNO)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"UPDATE People SET FirstName =@FirstName,LastName =@LastName ,Phone =@Phone,Email =@Email,Gendor=@Gendor ,DateBirth =@DateBirth ,ImagePath =@ImagePath ,NationalCountryID =@NationalCountryID ,NationalNO =@NationalNO  WHERE PersonID=@PersonID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Phone", Phone);
            if (Email != "" && Email != null) { command.Parameters.AddWithValue("@Email", Email); }
            else { command.Parameters.AddWithValue("@Email", System.DBNull.Value); }

            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@DateBirth", DateBirth);
            if (ImagePath != "" && ImagePath != null) { command.Parameters.AddWithValue("@ImagePath", ImagePath); }
            else { command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value); }

            command.Parameters.AddWithValue("@NationalCountryID", NationalCountryID);
            command.Parameters.AddWithValue("@NationalNO", NationalNO);
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();


            }
            catch (Exception ex) { return false; }
            finally { connection.Close(); }


            return (rowsAffected > 0);
        }

        public static bool DeletePerson(int PersonID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"delete from People where PersonID=@PersonID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", @PersonID);
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }


            return (rowsAffected > 0);


        }

        public static DataTable GetAllPeople()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT PersonID,FirstName,LastName ,Phone,Email,Case when People.Gendor=0 then 'ذكر' when People.Gendor=1 then 'انثى' END  AS Gendor    ,DateBirth     ,ImagePath     ,Countries.CountryName as Nationality      ,NationalNO  FROM People inner join  Countries ON Countries.CountryID=People.NationalCountryID";
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
