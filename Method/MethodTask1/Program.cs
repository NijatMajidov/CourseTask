namespace MethodTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char  simvol= 'A';
            string word = "Salam Admin";
            Console.WriteLine(Check(word, simvol)); 
        }

        public static bool Check (string word, char herf)
        {
            for(int i = 0; i < word.Length; i++)
            {
                if(word[i] == herf)
                {
                    return true;
                }
            }
            return false;
        }
    }
}