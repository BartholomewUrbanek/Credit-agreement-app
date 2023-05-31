using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReaLTaiizor.Forms;


namespace PAB.MainWindow
{
    public partial class GeneralMenu : MetroForm
    {
        private IDocumentationList DocumentationList { get; set; }
        public GeneralMenu(IDocumentationList documentationList)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.DocumentationList = documentationList;
        }

        private void btnOczekujace_Click(object sender, EventArgs e)
        {
            Guid statusId = DocumentationList.GetStatusID(btnOczekujace.Text);
            lvDokumentacja.Items.AddRange(DocumentationList.DisplayDocumentation(statusId));
        }
    }
}
