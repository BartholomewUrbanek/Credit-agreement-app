using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace PAB.MainWindow.Documentation
{
    public class GeneratePDF : IGeneratePDF
    {
        private string _connectionString;
        public GeneratePDF(string connectionString)
        {
            this._connectionString = connectionString;
        }

        public void GeneratePdfDocument(string idKlienta)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string sqlQuery = "select * from DaneDoFinalnejDokumentacji(@IdKlienta)";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@IdKlienta", idKlienta);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF Files|*.pdf";
                saveFileDialog.Title = "Save PDF File";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Document document = new Document();
                    PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(saveFileDialog.FileName, FileMode.Create));
                    document.Open();

                    foreach (DataRow row in dataTable.Rows)
                    {
                        foreach (DataColumn column in dataTable.Columns)
                        {
                            string value = column.ColumnName + " : " + row[column].ToString();
                            Paragraph paragraph = new Paragraph(value);
                            document.Add(paragraph);
                        }

                        document.Add(new Paragraph("\n"));
                    }
                    document.Close();

                    MessageBox.Show("PDF file saved successfully!");
                }
            }
        }
    }
}