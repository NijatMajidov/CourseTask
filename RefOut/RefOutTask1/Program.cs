namespace RefOutTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int num1, num2;
            num1 = 5;
            num2 = 10;
            Console.WriteLine("ilk hal" + num1 + " " + num2);
ChangeNum(ref num1, ref num2);
            Console.WriteLine("methoddan sonra:"+num1 + " " + num2);
            
        }

        public static void ChangeNum(ref int one, ref int two)  
        {
            one= one+two;
            two = one - two;
            one = one-two;
            Console.WriteLine(one+" "+two);
        }
    }
}