namespace Concat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "first";
            string str2 = " Second";

            Console.WriteLine(String.Concat(str1,str2));
            Console.WriteLine(ConcatCustom(str1,str2));
        }

        public static string ConcatCustom(string str1, string str2)
        {
            string concatWord = str1 + str2;
            return concatWord;
        }
    }
}
