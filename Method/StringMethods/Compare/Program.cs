namespace Compare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "AZ fghfgh";
            string str2 = "AA hghjbk";
            string str3 = "AB jhghj";
            string str4 = "AB jhghj";
            Console.WriteLine(String.Compare(str1,str2));
            Console.WriteLine(CompareCustoms(str1, str2));

            Console.WriteLine(String.Compare(str2, str3));
            Console.WriteLine(CompareCustoms(str2, str3));

            Console.WriteLine(String.Compare(str4, str3));
            Console.WriteLine(CompareCustoms(str4, str3));
        }
            
        public static int CompareCustoms(string str1, string str2)
        {
            int cheak=-1;
            

            for(int i = 0; i < Math.Min(str1.Length, str2.Length);i++)
            {
                if (str1[i] == str2[i])
                    cheak = 0;
                
                else if (str1[i] == str2[i] && str1.Length == str2.Length)
                {
                    cheak = 0;

                }
                if (str1[i] - str2[i] < 0)
                {
                  cheak = -1;
                  break;
                }
                else
                {
                    cheak = 1;
                    break;
                }
                
                
            }
            return cheak;
        }   
    }
}
