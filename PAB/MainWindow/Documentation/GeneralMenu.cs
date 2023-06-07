using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAB.MainWindow.Customer;
using PAB.MainWindow.Documentation;
using PAB.MainWindow.Charts;
using ReaLTaiizor.Forms;
using System.Windows.Forms.DataVisualization.Charting;





namespace PAB.MainWindow
{
    public partial class GeneralMenu : MetroForm
    {
        private string _selectedKRS;
        private string _selectedDecisionId;
        private IDocumentationList DocumentationList { get; set; }
        private ICustomer Customer { get; set; }
        private IGeneratePDF GeneratePDF { get; set; }
        private GenerateCharts GenerateCharts { get; set; }

        public GeneralMenu(IDocumentationList documentationList, ICustomer customer, IGeneratePDF generatePDF, GenerateCharts generateCharts)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.DocumentationList = documentationList;
            this.Customer = customer;
            this.GeneratePDF = generatePDF;
            this.GenerateCharts = generateCharts;
        }

        private void GeneralMenu_Load(object sender, EventArgs e)
        {
            btnGeneruj.Visible = false;
            cbClientColumn.Items.Add(string.Empty);
            cbClientColumn.Items.Add("Nazwa");
            cbClientColumn.Items.Add("Id Klienta");
            cbClientColumn.Items.Add("Ulica");
            cbClientColumn.Items.Add("Kod");
            cbClientColumn.Items.Add("Miasto");
            dgClient.DataSource = Customer.ClientList(string.Empty,string.Empty);

        }

        private void AdjustListView()
        {
            lvDokumentacja.Clear();
            lvDokumentacja.Columns.Add("Status");
            lvDokumentacja.Columns.Add("Numer decyzji");
            lvDokumentacja.Columns.Add("Nazwa klienta");
            lvDokumentacja.Columns.Add("Numer KRS");
            lvDokumentacja.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            lvDokumentacja.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lvDokumentacja.Columns[0].TextAlign = HorizontalAlignment.Right;


        }
        
        private void btnOczekujace_Click(object sender, EventArgs e)
        {
            btnGeneruj.Visible = false;
            AdjustListView();
            lvDokumentacja.Items.AddRange(DocumentationList.DisplayDocumentation(btnOczekujace.Text));
        }

        private void btnWTrakcie_Click(object sender, EventArgs e)
        {
            btnGeneruj.Visible = false;
            AdjustListView();
            lvDokumentacja.Items.AddRange(DocumentationList.DisplayDocumentation(btnWTrakcie.Text));
        }

        private void btnZakonczone_Click(object sender, EventArgs e)
        {
            btnGeneruj.Visible = false;
            AdjustListView();
            lvDokumentacja.Items.AddRange(DocumentationList.DisplayDocumentation(btnZakonczone.Text));
        }

        private void lvDokumentacja_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool status = lvDokumentacja.SelectedItems.Cast<ListViewItem>().Any(item => item.SubItems[0].Text == "W toku");

            btnGeneruj.Visible = status;

            if (lvDokumentacja.SelectedItems.Count > 0)
            {
                _selectedDecisionId = lvDokumentacja.SelectedItems[0].SubItems[1].Text;
                _selectedKRS = lvDokumentacja.SelectedItems[0].SubItems[3].Text;
            }
        }

        private void btnClientSearch_Click(object sender, EventArgs e)
        {
            string searchedValue = tbClientValue.Text;
            string columnName = cbClientColumn.Text;
            dgClient.DataSource = Customer.ClientList(searchedValue, columnName);
        }

        private void btnGeneruj_Click(object sender, EventArgs e)
        {
            try
            {
                GeneratePDF.GeneratePdfDocument(_selectedKRS);
                string tableName = "Dokumentacja";
                DocumentationList.UpdateStatus(_selectedDecisionId, tableName);
                lvDokumentacja.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wybierz najpierw umowę, którą chcesz wygnerować.");
                btnGeneruj.Visible=false;
            }
            

        }

        private void btnDokuUzytkownicy_Click(object sender, EventArgs e)
        {
            DataTable dt = GenerateCharts.DocuTrafficData();
            chart1.Series.Clear();
            Series series = new Series("Liczba umów");
            series.ChartType = SeriesChartType.Column;

            foreach(DataRow row in dt.Rows)
            {
                string firstName = row["Imie"].ToString();
                string lastName = row["Nazwisko"].ToString();
                string fullName = firstName+ "\n" +lastName;
                int docuCount = (int)row["Liczba umow"];

                series.Points.AddXY(fullName, docuCount);
            }

            chart1.Series.Add(series);
            chart1.ChartAreas[0].AxisY.Interval = 1;
            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = 0;
            chart1.ChartAreas[0].AxisY.Title = "Liczba umów";
            chart1.Refresh();
        }

        private void btnUmowyStatus_Click(object sender, EventArgs e)
        {
            DataTable dt = GenerateCharts.DocuStatusData();
            chart1.Series.Clear();
            Series series = new Series("Liczba umów");
            series.ChartType = SeriesChartType.Column;

            foreach (DataRow row in dt.Rows)
            {
                string status = row["Nazwa"].ToString();
                int docuCount = (int)row["Liczba umow"];

                series.Points.AddXY(status, docuCount);
            }

            chart1.Series.Add(series);
            chart1.ChartAreas[0].AxisY.Interval = 1;
            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = 0;
            chart1.ChartAreas[0].AxisY.Title = "Liczba umów";
            chart1.Refresh();
        }
    }
}