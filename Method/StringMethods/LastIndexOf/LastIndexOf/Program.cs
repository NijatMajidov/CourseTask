namespace LastIndexOf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "Salamlar";

            Console.WriteLine(word.LastIndexOf('a'));//6
            Console.WriteLine(word.LastIndexOf('y'));//-1
            Console.WriteLine(LastIndexOfCustom(word, 'a'));//6
            Console.WriteLine(LastIndexOfCustom(word, 'y'));//-1
        }

        public static int LastIndexOfCustom(string word, char chr)
        {
            int index = -1;

            for (int i = word.Length-1;i>=0;i--)
            {
                if (chr == word[i])
                {
                    index= i;
                    break;
                }
                
            }
            return index;
        }
    }
}
