using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Department
    {
        private static int _no;
        public int No { get; set; }

        public Department()
        {
            _no++;
            No = _no;
            Console.WriteLine($"{No}-cu department yaradildi");
        }

        Employee[] employees = new Employee[0];

        private int _empLimit;
        public int EmployeeLimit { get { return _empLimit; } set { if(_empLimit>0) _empLimit = value; } }

        public void AddEmployee(Employee employee)
        {
            Array.Resize(ref employees, employees.Length+1);
            employees[employees.Length-1] = employee;
            Console.WriteLine($"{employee.Name} ugurla departmente elave edildi\n");
        }

        public void GetEmployee(int id)
        {
            for(int i = 0; i < employees.Length; i++)
            {
                if (employees[i].Id == id)
                {
                    employees[i].ShowInfo();
                    
                } 
            }
        }

        public Employee[] GetAllEmployee() 
        {
            Employee[] allEmployees = new Employee[0];
            for (int i = 0;i < employees.Length;i++)
            {
                Array.Resize(ref allEmployees, allEmployees.Length + 1);
                allEmployees[allEmployees.Length - 1] = employees[i];
            }

            return allEmployees;
        }

        public Employee[] GetAllEmployeesBySalary(int min, int max)
        {
            Employee[] fillEmployees = new Employee[0];

            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i].Salary >= min && employees[i].Salary <= max)
                {
                    Array.Resize(ref fillEmployees, fillEmployees.Length + 1);
                    fillEmployees[fillEmployees.Length - 1] = employees[i];
                }
            }

            return fillEmployees;
        }

        public Employee[] GetAllEmployeesByPosition(string position)
        {
            {
                Employee[] fillEmployees = new Employee[0];

                for (int i = 0; i < employees.Length; i++)
                {
                    if (employees[i].Position == position)
                    {
                        Array.Resize(ref fillEmployees, fillEmployees.Length + 1);
                        fillEmployees[fillEmployees.Length - 1] = employees[i];
                    }
                }

                return fillEmployees;
            }
        }


    }
}
