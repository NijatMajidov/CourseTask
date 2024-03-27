namespace ClassTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name=Console.ReadLine();
            string surname=Console.ReadLine();
            byte age;
            bool cheak = byte.TryParse(Console.ReadLine(),out age);

            Human person1 = new Human(name, surname,age);
            
            string userName=Console.ReadLine();
            string password=Console.ReadLine();

            User user1 = new User(name, surname, userName, password);
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine($" Ad:  {user1.Name},\n Soyad:{user1.Surname},\n Yas:{person1.Age}");
            Console.WriteLine($" Istifadeci adi: {user1.UserName}");
        }
    }
}