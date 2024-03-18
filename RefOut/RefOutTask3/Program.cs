using System.Diagnostics.CodeAnalysis;

namespace RefOutTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Birinci ededi daxil edin: ");
            string str1=Console.ReadLine();
            Console.Write("İkinci ededi daxil edin: ");
            string str2=Console.ReadLine();
            int sum = 0;
            sum=SumInteger(str1, str2);
            Console.WriteLine("Ededlerin cemi: " + sum);




        }
       
        public static int SumInteger(string str1,string str2)
        {
            int num1, num2;
            int sum;
            if (int.TryParse(str1, out num1) && int.TryParse(str2, out num2))
            {
                sum = num1 + num2;
                return sum;
            }
            else
            {
                Console.WriteLine("integer deyer deyil!");
                
            }


            return 0;
        }
    }
}
/*static void Main(string[] args)
    {
        

        int sayi1, sayi2;
        
        if (int.TryParse(str1, out sayi1) && int.TryParse(str2, out sayi2))
        {
            int toplam = Toplama(sayi1, sayi2);
            Console.WriteLine("İki sayının toplamı: " + toplam);
        }
        else
        {
            Console.WriteLine("Geçersiz bir giriş yaptınız!");
        }

        Console.ReadKey();
    }

    public static int Toplama(int a, int b)
    {
       return a + b;
    }
}*/




//2 int parametr qabul eden bir method yazirsiniz. bu ededleri consoldan daxil edirsiniz ve eger int e cevrile bilirse cemini qaytarin. ededler mutleq sekilde method daxilinde assign olunmalidir
/*
try
{
    int number = Convert.ToInt32(str);
    Console.WriteLine("Girdiğiniz sayı: " + number);
}
catch (FormatException)
{
    Console.WriteLine("Geçersiz bir sayı girdiniz!");
}

Console.ReadKey();
    }

 {
    Console.Write("Bir sayı girin: ");
    string str = Console.ReadLine();

    if (IsAllDigits(str))
    {
        Console.WriteLine("Girdiğiniz değer sadece rakamlardan oluşuyor.");
    }
    else
    {
        Console.WriteLine("Girdiğiniz değer rakamlardan oluşmuyor.");
    }

    Console.ReadKey();
}

public static bool IsAllDigits(string str)
{
    foreach (char c in str)
    {
        if (!char.IsDigit(c))
        {
            return false;
        }
    }

    return true;
}*/