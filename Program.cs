using System;
using System.Data;
using System.Data.SqlClient;

namespace ADO.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "server=localhost;user id=sa;password=pass;initial catalog=sampledb;";
            string sqlString = "select * from Employee";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlString, connection);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset, "employee");

            for(int i=0;i<dataset.Tables["employee"].Rows.Count;i++)
            {
                Console.Write("{0,-4}",dataset.Tables["employee"].Rows[i][0].ToString());
                Console.Write("{0,-12}", dataset.Tables["employee"].Rows[i][1].ToString());
                Console.Write("{0, -14}", dataset.Tables["employee"].Rows[i][3]);
                Console.Write("{0:C}", dataset.Tables["employee"].Rows[i][2]);
                
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
