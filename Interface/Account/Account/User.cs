using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    internal class User: IAccount 
    {
        private int _id;
        public int Id { get; set; }

        public string FullName { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }

        public User(string name, string email)
        {
            _id++;
            Id = _id;
            FullName = name;
            Email = email;
        }

        public void PasswordChecker(string password)
        {
            if( password.Length>=8 )
            {
                bool numChck = false;
                bool lowChck = false;
                bool upChck = false;

                for( int i = 0; i < password.Length; i++ )
                {
                    if (char.IsDigit(password[i])) numChck = true; 

                    if (char.IsUpper(password[i])) upChck = true;

                    if (char.IsLower(password[i])) lowChck = true; 

                    }

                Console.WriteLine(numChck && lowChck && upChck);

            }
            }
        public void ShowInfo()
        {
            Console.WriteLine($"{Id} {FullName} {Email}");
        }
        
    } 
}
