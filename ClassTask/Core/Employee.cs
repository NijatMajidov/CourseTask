using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Employee
    {
        private static int _id;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get; set; }
        public int DepartmentNo { get; set; }
        public string Position { get; set; }
        private double _salary;
        public double Salary {
            get {  return _salary; }
            set { if(value > 0) _salary = value;}
        }

        public Employee(string name, string surname, byte age, int depNo, string position, double salary)
        {
            _id++;
            Id = _id;
            Name = name;
            Surname = surname;
            Age = age;
            DepartmentNo = depNo;
            Position = position;
            _salary = salary;
            Console.WriteLine("Yeni employee elave edildi");
        }
        public void ShowInfo()
        {
            Console.WriteLine($"{Id}, {Name}, {Surname}, {Age}, {DepartmentNo}, {Position}, {Salary}");
        }

    }
}
