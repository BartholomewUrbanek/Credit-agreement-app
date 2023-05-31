using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAB.MainWindow
{
    public interface IDocumentationList
    {
        ListViewItem[] DisplayDocumentation(Guid idStatusu);
        Guid GetStatusID(string nazwaStatusu);
    }
}
