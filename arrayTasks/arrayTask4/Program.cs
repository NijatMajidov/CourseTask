namespace arrayTask4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task1
            //string[] words = { "lorem", "impus" };
            //string axtarilan = "impus";

            //for(int i = 0; i < words.Length; i++)
            //{
            //    if(words[i] == axtarilan)
            //    {
            //        Console.WriteLine(words[i]);    
            //    }
            //}
            #endregion

            #region task2
            //string word = "salam ";
            //char herf = 'm';
            //bool test = false;
            //for(int i = 0; i < words.Length; i++)
            //{
            //    if (herf == word[i])
            //    {
            //        test = true;
            //        break;
            //    }
            //}
            //Console.WriteLine(test);
            #endregion

            #region task3
            string[] words = { "salam", "hello", "world" };
            
            for(int i = 0; i < words.Length; i++)
            {
                for (int j=words[i].Length-1; j >=0 ; j--)
                {
                    Console.Write(words[i][j]);
                }
                Console.Write(" ");
            }
            #endregion

            #region task4
            //string[] words = { "salam", "hello", "world" };
            //string[] revs = new string[words.Length];
            //for(int i = words.Length-1; i >=0 ; i--)
            //{
                    //test[words.Length-1-i]=words[i];
            //        Console.Write(words[i]+" ");

            //}
            #endregion

        }
    }
}