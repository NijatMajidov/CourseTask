using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask2
{
    internal class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        private byte _age;
        public byte Age {
            get { return _age; }

            set
            {
                if(value > 0)
                _age = value;
            }
        }

        public Human(string name, string surname)
        {
            Name = name;
            Surname = surname;  
        }
        public Human(string name, string surname, byte age): this(name, surname)
        {
            _age = age;
            Console.WriteLine("\n Added new Human! ");
        }
    }
}
