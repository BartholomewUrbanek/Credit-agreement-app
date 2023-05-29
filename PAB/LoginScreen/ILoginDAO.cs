using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAB.LoginScreen
{
    public interface ILoginDAO
    {
        bool CheckLoginData(string alias, string password);
    }
}
