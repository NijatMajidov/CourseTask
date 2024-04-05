using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    internal interface IAccount
    {
        void PasswordChecker(string password);

        void ShowInfo();
    }
}
