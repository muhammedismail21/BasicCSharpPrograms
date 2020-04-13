using System;
using System.Data.SqlClient;

namespace ADO.NET
{
    class InsertStatementwithSqlParameters
    {
        public static void Main()
        {
            int empId;
            string empName;
            double salary;
            string designation;
            int departmentId;
            string band;
            string connectionString = "server=localhost;user id=sa;password=pass;initial catalog=sampledb;";
            string sqlString = "";
            SqlConnection connection = null;
            SqlCommand insertCommand = null;

            Console.Write("Enter Employee ID: ");
            empId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Em=nter Employee Name: ");
            empName = Console.ReadLine();
            Console.Write("Enter Salary: ");
            salary = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Designation: ");
            designation = Console.ReadLine();
            Console.Write("Enter Department Id: ");
            departmentId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter band: ");
            band = Console.ReadLine();

            sqlString = "insert into Employee values(@empId,@empName, @salary, @designation, @departmentId, @band)";

            try
            {
                connection = new SqlConnection(connectionString);
                insertCommand = new SqlCommand(sqlString, connection);
                SqlParameter p_empId = new SqlParameter("@empId", empId);
                SqlParameter p_empName = new SqlParameter("@empName", empName);
                SqlParameter p_salary = new SqlParameter("@salary", salary);
                SqlParameter p_designation = new SqlParameter("@designation", designation);
                SqlParameter p_departmentId = new SqlParameter("@departmentId", departmentId);
                SqlParameter p_band = new SqlParameter("@band", band);

                insertCommand.Parameters.Add(p_empId);
                insertCommand.Parameters.Add(p_empName);
                insertCommand.Parameters.Add(p_salary);
                insertCommand.Parameters.Add(p_designation);
                insertCommand.Parameters.Add(p_departmentId);
                insertCommand.Parameters.Add(p_band);

                connection.Open();
                insertCommand.ExecuteNonQuery();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Employee record saved successfully.");
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
