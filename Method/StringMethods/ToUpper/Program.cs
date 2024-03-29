namespace ToUpper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "salam";
            Console.WriteLine(word.ToUpper()); //SALAM
            Console.WriteLine(ToUpperCustom(word)); //SALAM

        }

        public static string ToUpperCustom(string word)
        {
            string upperWord = "";
      
            for(int i = 0;i<word.Length;i++) 
            {
                if (word[i] >=97 && word[i] <= 122)
                {
                    upperWord += (char)(word[i] - 32);
                }
                else
                {
                    upperWord += word[i];
                }
                
            }

            return upperWord;
        }
    }
}
