namespace arrayTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //en boyuk eded
            int[] array = {4511, 7998,475,956,254};
           
            int maxElement = int.MinValue;
            int second = int.MinValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxElement)
                {
                    second = maxElement;
                    maxElement = array[i];
                }
                else if (array[i] > second)
                {
                    second = array[i];
                }
               
             
            }
            Console.WriteLine(maxElement);
            Console.WriteLine(second);
        }
    }
}