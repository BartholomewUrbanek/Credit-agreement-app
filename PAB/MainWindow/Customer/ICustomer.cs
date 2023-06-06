using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PAB.MainWindow.Customer
{
    public interface ICustomer
    {
        DataTable ClientList(string searchedValue, string columnName);
    }
}
