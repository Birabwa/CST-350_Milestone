using Microsoft.Data.SqlClient;
using CST_350_Milestone.Models;

namespace CST_350_Milestone.Services
{
    public class SecurityDAO
    {
        string connectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=RegDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public bool FindUserByNameAndPassword(RegisterModel user)
        {
            bool success = false;

            string sqlStatment = "SELECT * FROM dbo.Register WHERE username = @username and password = @password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlStatment, connection);

                command.Parameters.Add("@USERNAME", System.Data.SqlDbType.VarChar, 50).Value = user.Username;
                command.Parameters.Add("@PASSWORD", System.Data.SqlDbType.VarChar, 50).Value = user.Password;

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                        success = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                };

            }
            return success;
        }
    }
}
