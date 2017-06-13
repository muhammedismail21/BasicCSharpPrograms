using System;
using System.Data.SqlClient;

namespace ADO.NET
{
    class DeleteRecordfromDatabase
    {
        public static void Main()
        {
            int empId;
          
            string connectionString = "server=localhost;user id=sa;password=pass;initial catalog=sampledb;";
            string sqlString = "";
            SqlConnection connection = null;
            SqlCommand insertCommand = null;

            Console.Write("Enter Employee ID: ");
            empId = Convert.ToInt32(Console.ReadLine());

            sqlString = "DElete from Employee where EmpId=@empId";

            try
            {
                connection = new SqlConnection(connectionString);
                insertCommand = new SqlCommand(sqlString, connection);
                SqlParameter p_empId = new SqlParameter("@empId", empId);

                insertCommand.Parameters.Add(p_empId);
                connection.Open();
                insertCommand.ExecuteNonQuery();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Employee record deleted successfully.");
            }
            catch (SqlException sqlex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro: " + sqlex.Message);
            }
            finally
            {
                Console.ResetColor();
                connection.Close();
            }
        }
    }
}
