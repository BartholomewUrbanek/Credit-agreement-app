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
                            string idDecyzji = (string)reader["Numer decyzji"];
                            string nazwaKlienta = (string)reader["Nazwa Klienta"];
                            string numerKRS = (string)reader["Numer KRS"];
                            DateTime dataUtworzenia = (DateTime)reader["Data utworzenia"];
                            string statusDoku = (string)reader["Status dokumentacji"];
                            ListViewItem item = new ListViewItem(status);
                            item.SubItems.Add(idDecyzji);
                            item.SubItems.Add(nazwaKlienta);
                            item.SubItems.Add(numerKRS);
                            item.SubItems.Add(dataUtworzenia.ToString());
                            listaDokumentacji.Add(item);
                        }
                    }                   
                }               
            }
            return listaDokumentacji.ToArray();
        }

    }
}
