using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FIrstWindowsFormsApp
{
    public partial class LoginForm : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string sqlstring;
        string constr;
        public LoginForm()
        {
            InitializeComponent();
            constr = "server=localhost;user id=sa;password=pass;initial catalog=sampledb;";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = TextBoxUsername.Text;
            string password = TextBoxPassword.Text;
            SqlParameter p_uname = new SqlParameter("@uname", username);
             sqlstring = "select * from _Users where _username=@uname";
            connection = new SqlConnection(constr);
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = sqlstring;
            command.Parameters.Add(p_uname);
            
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            
            if (reader.Read())
            {
                if (reader["_password"].ToString() == password)
                {
                    MessageBox.Show("User authenticated.\nWork in progress.");
                }
                else
                {
                    MessageBox.Show("Invalid password.");
                }
            }
            else
            {
                MessageBox.Show("Invalid user.");
            }
            reader.Close();
            connection.Close();
        }
    }
}
