using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;


namespace PAB.LoginScreen
{
    public class LoginDAO : ILoginDAO
    {
        private string _connectionDatabase;

        public LoginDAO(string connectionDatabase)
        {
            _connectionDatabase = connectionDatabase;
        }


        public bool CheckLoginData(string alias, string password)
        {
            bool isValid = false;

            using (SqlConnection connection = new SqlConnection(_connectionDatabase))
            {
                connection.Open();

                string query = "select count(*) from [Dane Logowania] where Alias = @alias and Hasło = @password ";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@alias", alias);
                    command.Parameters.AddWithValue("@password", password);
                    int count = (int)command.ExecuteScalar();
                    if (count > 0) isValid = true;
                }
                return isValid;
            }
        }

       
        

    }
}
