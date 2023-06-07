using Microsoft.Data.SqlClient;
using System.Data;

namespace PAB.MainWindow.Customer
{
    public class Customer : ICustomer
    {
        private string _connectionString;
        public Customer(string connectionString)
        {
            this._connectionString = connectionString;
        }

        public DataTable ClientList(string searchedValue, string columnName)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string sqlQuerry = "select * from WyszukajTabelaKlient(@wyszukiwanaWartosc,@nazwaKolumny)";               
                using (SqlCommand cmd = new SqlCommand(sqlQuerry, conn))
                {
                    cmd.Parameters.AddWithValue("@wyszukiwanaWartosc", searchedValue);
                    cmd.Parameters.AddWithValue("@nazwaKolumny", columnName);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }
    }
}
