using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storages_DataAccessLayer
{
    public class clsEmployeeData
    {

        public static bool GetEmployeeByEmployeeID(int EmployeeID, ref int PersonID, ref string UserNameEmployee, ref string Password, ref bool IsActive)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from Employees where EmployeeID=@EmployeeID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@EmployeeID", EmployeeID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    PersonID = (int)reader["PersonID"];
                    UserNameEmployee = (string)reader["UserNameEmployee"];
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];

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
        public static bool GetEmployeeByPersonID(int PersonID, ref int EmployeeID, ref string UserNameEmployee, ref string Password, ref bool IsActive)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Employees where PersonID=@PersonID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    EmployeeID = (int)reader["EmployeeID"];

                    UserNameEmployee = (string)reader["UserNameEmployee"];
                    Password = (string)reader["Password"];

                    IsActive = (bool)reader["IsActive"];

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

        public static bool GetEmployeeByUserNameEmployee(string UserNameEmployee, ref int EmployeeID, ref int PersonID, ref string Password, ref bool IsActive)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Employees where UserNameEmployee=@UserNameEmployee";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserNameEmployee", UserNameEmployee);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    EmployeeID = (int)reader["EmployeeID"];
                    PersonID = (int)reader["PersonID"];
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];

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
        public static bool GetEmployeeByUserNameEmployeerAndPassword(string UserNameEmployee, string Password, ref int EmployeeID, ref int PersonID, ref bool IsActive)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from Employees where UserNameEmployee=@UserNameEmployee and Password=@Password";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserNameEmployee", UserNameEmployee);
            command.Parameters.AddWithValue("@Password", Password);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    EmployeeID = (int)reader["EmployeeID"];
                    PersonID = (int)reader["PersonID"];
                    IsActive = (bool)reader["IsActive"];

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



        public static bool IsEmployeeExist(int EmployeeID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select FOUND=1 from Employees where EmployeeID=@EmployeeID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@EmployeeID", EmployeeID);
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
        public static bool IsEmployeeExist(string UserNameEmployee)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select FOUND=1 from Employees where UserNameEmployee=@UserNameEmployee";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserNameEmployee", UserNameEmployee);
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
        public static bool IsEmployeeExistPersonID(int PersonID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select FOUND=1 from Employees where PersonID=@PersonID";
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


        public static int AddNewEmployee(int PersonID, string UserNameEmployee, string Password, bool IsActive)
        {

            int EmployeeID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO Employees (PersonID, UserNameEmployee, Password,IsActive)
                             VALUES(@PersonID, @UserNameEmployee, @Password,@IsActive)
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserNameEmployee", UserNameEmployee);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {

                    EmployeeID = insertedID;
                }
            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return EmployeeID;

        }
        public static bool UpdateEmployee(int EmployeeID, int PersonID, string UserNameEmployee, string Password, bool IsActive)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"UPDATE Employees SET PersonID =@PersonID ,UserNameEmployee =@UserNameEmployee,Password =@Password,IsActive=@IsActive WHERE EmployeeID=@EmployeeID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@EmployeeID", EmployeeID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserNameEmployee", UserNameEmployee);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();


            }
            catch (Exception ex) { return false; }
            finally { connection.Close(); }


            return (rowsAffected > 0);
        }

        public static bool DeleteEmployee(int EmployeeID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"delete Employees where EmployeeID=@EmployeeID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@EmployeeID", EmployeeID);
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }


            return (rowsAffected > 0);


        }
        public static DataTable GetAllEmployees()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT EmployeeID ,PersonID,UserNameEmployee ,IsActive  FROM Employees ";
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


        public static bool ChangePassword(int EmployeeID, int NewPassword)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"UPDATE Employees SET Password =@NewPassword WHERE EmployeeID=@EmployeeID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@EmployeeID", EmployeeID);
            command.Parameters.AddWithValue("@NewPassword", NewPassword);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();


            }
            catch (Exception ex) { return false; }
            finally { connection.Close(); }


            return (rowsAffected > 0);
        }





    }
}
