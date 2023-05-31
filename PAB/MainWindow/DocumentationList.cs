using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace PAB.MainWindow
{
    public class DocumentationList : IDocumentationList
    {
        private string _connectionString;
        public DocumentationList(string connectionDatabase)
        {
            this._connectionString = connectionDatabase;
        }

        public ListViewItem[] DisplayDocumentation(Guid guid)
        {
            Guid idStatusu = guid;
            List<ListViewItem> listaDokumentacji = new List<ListViewItem>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string queryDokumentacja = "select * from Dokumentacja where [Id statusu] = @idStatusu";
                using (SqlCommand command = new SqlCommand(queryDokumentacja, connection))
                {
                    command.Parameters.AddWithValue("@idStatusu", idStatusu);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        DateTime dataUtworzenia = (DateTime)reader["Dta utworzenia"];
                        Guid idDecyzji = (Guid)reader["Id Decyzji"];

                        string queryDecyzja = "select * from Decyzji where [Id Decyzji] = @idDecyzji ";
                        using (SqlCommand decyzjaCommand = new SqlCommand(queryDecyzja, connection))
                        {
                            decyzjaCommand.Parameters.AddWithValue("@idDecyzji", idDecyzji);
                            object numerDecyzjiObj = decyzjaCommand.ExecuteScalar();
                            string numerDecyzji = numerDecyzjiObj != null ? numerDecyzjiObj.ToString() : string.Empty; //

                            Guid idKlienta = (Guid)reader["Id Klienta"];

                            string queryKlient = "select * from Klient where [Id Klienta] = @idKlienta";
                            using(SqlCommand klientCommand = new SqlCommand(queryKlient, connection))
                            {
                                decyzjaCommand.Parameters.AddWithValue("@idKlienta", idKlienta);
                                SqlDataReader klientReader = klientCommand.ExecuteReader();
                                if (klientReader.Read())
                                {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                                    string nazwaKlienta = klientReader["Nazwa"].ToString();
                                    string numerKrsKlient = klientReader["KRS"].ToString();
                                    string daneSaduKlient = klientReader["[Dane sadu"].ToString();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                                    ListViewItem item = new ListViewItem(numerDecyzji);
                                    item.SubItems.Add(nazwaKlienta);
                                    item.SubItems.Add(numerKrsKlient);
                                    item.SubItems.Add(daneSaduKlient);
                                    item.SubItems.Add(dataUtworzenia.ToString());
                                    listaDokumentacji.Add(item);
                                }
                            }
                        }
                    }
                }
                
            }
            return listaDokumentacji.ToArray();
        }

        public Guid GetStatusID(string nazwaStatusu)
        {
            Guid guid;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string statusQuerry = "select [Id statusu] from Status where Nazwa = @nazwaStatusu";
                using (SqlCommand cmd = new SqlCommand(statusQuerry, connection))
                {
                    cmd.Parameters.AddWithValue("@nazwaStatusu", nazwaStatusu);
                    guid = (Guid)cmd.ExecuteScalar();
                }
            }
            return guid;
        }
    }
}
