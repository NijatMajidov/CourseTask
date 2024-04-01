using Core;

namespace ClassTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Name", "Surname", 35, 1, "Ceo", 1550);
            Employee employee1 = new Employee("Filankes", "Filankesov", 18, 1, "techer", 500);
            Employee employee2 = new Employee("Fikes", "Fikesov", 22, 1, "Doc", 1000);
            Department department = new Department();
            department.AddEmployee(employee);
            department.AddEmployee(employee1);
            department.AddEmployee(employee2);

            bool check = true;
            string choise;
            do
            {
                Console.WriteLine("\n -------------------------------------------------------------\n" +
                "\n|~~~~~~~~~~~~~~~~~~~~~~ Xos gelmisiniz! ~~~~~~~~~~~~~~~~~~~~~~|" +
                "\n|~~~~~~ Zehmet olmasa etmek istediyiniz emeliyati secin ~~~~~~|" +
                "\n|~~~~ 1. Isci elave et " +
                "\n|~~~~ 2. Butun iscilere bax " +
                "\n|~~~~ 3. Maas aralıgına gore iscileri axtarıs et " +
                "\n|~~~~ 4. Positiona gore iscileri axtarıs et " +
                "\n|~~~~ 5. Id gore iscileri axtarıs et " +
                "\n|~~~~ 0. Proqramı bitir! " +
                 "\n -------------------------------------------------------------");
                choise = Console.ReadLine();
                switch (choise)
                {
                    case "1":
                        Console.WriteLine("Yeni işçinin məlumatlarını daxil edin:");
                        Console.Write("Ad: ");
                        string ad = Console.ReadLine();
                        Console.Write("Soyad: ");
                        string soyad = Console.ReadLine();

                        byte age;
                        do
                        {
                            Console.Write("Yaş: ");
                        } while (!byte.TryParse(Console.ReadLine(), out age) && age > 17);

                        byte depNo;
                        do
                        {
                            Console.Write("Department No: ");
                        } while (!byte.TryParse(Console.ReadLine(), out depNo) && depNo > 0);

                        Console.Write("Pasition: ");
                        string departamentAdi = Console.ReadLine();


                        double salary;
                        do
                        {
                            Console.Write("Maaş: ");
                        } while (!double.TryParse(Console.ReadLine(), out salary) && salary > 0);

                        Employee yeniIsci = new Employee(ad, soyad, age, depNo, departamentAdi, salary);
                        department.AddEmployee(yeniIsci);
                        Console.WriteLine("Yeni isci elave edildi.");
                        break;

                    case "2":
                        Employee[] arr = department.GetAllEmployee();
                        for (int i = 0; i < arr.Length; i++)
                        {
                            arr[i].ShowInfo();
                        }
                        break;

                    case "3":
                        Console.WriteLine("Maas aralıgına gore axtarıs etmek ucun min ve max deyer daxil edin");
                        int min, max;
                        do
                        {
                            Console.Write("Maaş: ");
                        } while (!int.TryParse(Console.ReadLine(), out min) && min > 0);
                        do
                        {
                            Console.Write("Maaş: ");
                        } while (!int.TryParse(Console.ReadLine(), out max) && max > 0);
                        Employee[] arr2 = department.GetAllEmployeesBySalary(min,max);
                        for (int i = 0; i < arr2.Length; i++)
                        {
                            arr2[i].ShowInfo();
                        }
                        break;

                    case "4":
                        Console.WriteLine("Positiona gore axtarıs etmek ucun min ve max deyer daxil edin");
                        string position = Console.ReadLine();
                        
                        Employee[] arr3 = department.GetAllEmployeesByPosition(position);
                        for (int i = 0; i < arr3.Length; i++)
                        {
                            arr3[i].ShowInfo();
                        }
                        break;

                    case "5":
                        byte id;
                        do
                        {
                            Console.Write("Id daxil edin: ");
                        } while (!byte.TryParse(Console.ReadLine(), out id) && id > 0);
                        department.GetEmployee(id);
                        break;
                    case "0":
                        Console.WriteLine(" -------------------------------------------------------------\n|~~~~~~~~~~~~~~~~~~~~~~~~ Proses bitdi ~~~~~~~~~~~~~~~~~~~~~~~|");
                        Console.WriteLine("|~~~~~~~~~~~~~~~~~~~~~~~~~~ Sagolun! ~~~~~~~~~~~~~~~~~~~~~~~~~|\n -------------------------------------------------------------");
                        break;

                    default:
                        Console.WriteLine("Bele bir secim yox idi axi!?");
                        break;
                }

            } while (check);


        }

    }
}
