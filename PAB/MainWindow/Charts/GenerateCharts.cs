using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient; 


namespace PAB.MainWindow.Charts
{
    public class GenerateCharts
    {
        private string _connectionString;
        public GenerateCharts(string connectionString)
        {
            this._connectionString = connectionString;
        }
    
        public DataTable DocuTrafficData()
        {
            DataTable dt = new DataTable();
            using(SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string sqlQuerry = "select * from dbo.LiczbaUmowNaPracownika() ";
                using (SqlCommand cmd = new SqlCommand(sqlQuerry, conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }

            }
            return dt;
        }

        public DataTable DocuStatusData()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string sqlQuerry = "select * from dbo.LiczbaDokumentacjiStatus() ";
                using (SqlCommand cmd = new SqlCommand(sqlQuerry, conn))
                {
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
