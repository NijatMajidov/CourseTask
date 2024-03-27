using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask2
{
    internal class User:Human
    {
        private string _userName;
        private string _password;

        public string UserName
        {
            get { return _userName; }
            set {
                if(value.Length>=6 && value.Length<=25)
                _userName = value; 
            }
        }

        public string Password 
        {
            get { return _password; } 
            set { 
                if(value.Length>=8 && value.Length<=25)
                _password = value; 
            } 
        }

        public User(string name, string surname, string userName, string password):base(name,surname)
        {
            _userName = userName;
            _password = password;
            Console.WriteLine("\n Created new User! ");
            
        }


    }
}
