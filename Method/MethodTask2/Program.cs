namespace MethodTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "Salam, necesiz";
            FirstLetter(word);
        }

        //public static void Area(double r)
        //{
        //    int p = 3;
        //    Console.WriteLine(p*(r*r));

        //}
        //public static void Area(double a, double b)
        //{
        //    Console.WriteLine(a*b);

        //}
        //public static void Area(double a, double b, double c)
        //{
        //    Console.WriteLine(2*(a*b+a*c+b*c));

        //}
        //public static void Area(double r, double a, double b, double c)
        //{
        //    double p = (a + b + c) / 2;
        //    Console.WriteLine(p*r);
        //}

        //public static string DelSpace(string word)
        //{
        //    string newWord=" ";
        //    for(int i=0; i < word.Length; i++)
        //    {
        //        if(word[i] !=' ')
        //        {
        //            newWord += word[i];
        //        }
        //    }
        //    return newWord;
        //}

        public static void FirstLetter(string word)
        {
            string first = " ";
           if (word[0]!= ' ')
            {
                first += word[0];
            }
            for (int i = 0; i < word.Length-1; i++)
            {

                    if (word[i] == ' '&& word[i+1]!=' ')
                    {
                        
                        first +=" "+word[i+1];
                       
                    } 
            }
            Console.WriteLine(first); 
        }

        //public static void Calculator(double num, char operant, double num2)
        //{

        //    switch (operant)
        //    {
        //        case '+':
        //            Console.WriteLine(num + num2);
        //            break;
        //        case '-':
        //            Console.WriteLine(num - num2);
        //            break;
        //        case '*':
        //            Console.WriteLine(num * num2);
        //            break;
        //        case '/':
        //              if(num2!=0)
        //            Console.WriteLine(num / num2);
        //              else
        //            Console.WriteLine("ikinci eded 0 ola bilmez");
        //            break;
        //        default:
        //            Console.WriteLine("emeliyat yoxdur");
        //            break;
        //    }
        //}
    }
}
