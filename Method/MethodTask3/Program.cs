namespace MethodTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 5, 1, 77, 32, 45 };
            Console.WriteLine("Verilmis array : 2, 5, 1, 77, 32, 45");
            Console.WriteLine(MaxElement(arr));
            Console.WriteLine("Polindrom oldugunu yoxlamaq istediyiniz eded: ");
            int number = Convert.ToInt32(Console.ReadLine()); 
            PolindromCheck(number);
        }

        public static int MaxElement(int[] arr)
        {
            int max = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            return max;
        }

        public static void PolindromCheck(int num)
        {
            int copyNum = num;
            int revsNum = 0;
            int digit = 0;
            while(copyNum > 0)
            {
                digit=copyNum% 10;
                revsNum = revsNum * 10 + digit;
                copyNum -= digit;
                copyNum /= 10;
            }
            if (num == revsNum)
                Console.WriteLine(" Palindrom ededdir");
            else
                Console.WriteLine(" Palindrom eded deyil");
        }
    }
}