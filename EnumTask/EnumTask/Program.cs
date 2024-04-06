using Core;

namespace EnumTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product()
            {
                Name = "Baker",
                Price = 0.5,
                Type = Core.Enums.Baker

            };

            Product product1 = new Product()
            {
                Name = "Soda",
                Price = 1.2,
                Type = Core.Enums.Drink

            };

            Product product2 = new Product()
            {
                Name = "Cow Meat",
                Price = 15.5,
                Type = Core.Enums.Meat

            };

            Product product3 = new Product()
            {
                Name = "Diary",
                Price = 0.5,
                Type = Core.Enums.Diary

            };

            Store store = new Store();

            store.AddProducts(product);
            store.AddProducts(product1);
            store.AddProducts(product2);
            store.AddProducts(product3);

            Console.WriteLine("1.Baker,\n 2.Drink,\n3.Meat,\n4.Diary,");
            int choice;
            do
            {
                Console.WriteLine("Secin");
            } while (!int.TryParse(Console.ReadLine(), out choice) && choice>0);

            foreach(Product pro in store.FilterProductsByType((Enums) choice))
            {
                Console.WriteLine(pro);
            }
            int no;
            
            do
            {
                Console.WriteLine("Silinecek Prouct no: ");

            } while (!int.TryParse(Console.ReadLine(), out no) && no > 0);
            store.RemoveProductByNo(no);

            Console.WriteLine("Axtarilan Poduct adi: ");
            string name = Console.ReadLine();
            foreach (Product pro in store.FilterProductsByName(name))
            {
                Console.WriteLine(pro);
            }

        }
    }
}
