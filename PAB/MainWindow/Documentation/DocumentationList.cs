using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace PAB.MainWindow
{
    public class DocumentationList : IDocumentationList
    {
        private string _connectionString;
        public DocumentationList(string connectionString)
        {
            this._connectionString = connectionString;
        }

        public ListViewItem[] DisplayDocumentation(string status)
        {
            List<ListViewItem> listaDokumentacji = new List<ListViewItem>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {       
                using (SqlCommand command = new SqlCommand("PobierzDokumentacjęStatusem", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Status", status);

                    connection.Open();
                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string decisionId = (string)reader["Numer decyzji"];
                            string customerName = (string)reader["Nazwa Klienta"];
                            string numberKRS = (string)reader["Numer KRS"];
                            DateTime creationDate = (DateTime)reader["Data utworzenia"];
                            string documentationStatus = (string)reader["Status dokumentacji"];
                            ListViewItem item = new ListViewItem(status);
                            item.SubItems.Add(decisionId);
                            item.SubItems.Add(customerName);
                            item.SubItems.Add(numberKRS);
                            item.SubItems.Add(creationDate.ToString());
                            listaDokumentacji.Add(item);
                        }
                    }                   
                }               
            }
            return listaDokumentacji.ToArray();
        }
        public void UpdateStatus(string decisionId, string tableName)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string sqlQuerry = $"update {tableName} set [Id statusu] = (select [Id statusu] from Status where Nazwa = 'Gotowa') where [Id Decyzji] = @decisionId";
                connection.Open();
                using (SqlCommand command = new SqlCommand(sqlQuerry, connection))
                {
                    command.Parameters.AddWithValue("@decisionId", decisionId);
                    command.ExecuteScalar();

                }
            }
        }
    }
}
