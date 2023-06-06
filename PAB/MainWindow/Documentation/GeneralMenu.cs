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
using ReaLTaiizor.Forms;



namespace PAB.MainWindow
{
    public partial class GeneralMenu : MetroForm
    {
        private IDocumentationList DocumentationList { get; set; }
        private ICustomer Customer { get; set; }
        public GeneralMenu(IDocumentationList documentationList, ICustomer customer)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.DocumentationList = documentationList;
            this.Customer = customer;
        }

        private void GeneralMenu_Load(object sender, EventArgs e)
        {
            cbClientColumn.Items.Add(string.Empty);
            cbClientColumn.Items.Add("Id Klienta");
            cbClientColumn.Items.Add("Ulica");
            cbClientColumn.Items.Add("Kod");
            cbClientColumn.Items.Add("Miasto");

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
            bool status = lvDokumentacja.SelectedItems.Cast<ListViewItem>().Any(item => item.SubItems[0].Text == "Nowa" || item.SubItems[0].Text == "W trakcie");

            btnGeneruj.Visible = status;
        }

        private void btnClientSearch_Click(object sender, EventArgs e)
        {
            string searchedValue = tbClientValue.Text;
            string columnName = cbClientColumn.Text;
            dgClient.DataSource = Customer.ClientList(searchedValue, columnName);
        }
    }
}