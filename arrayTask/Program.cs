namespace arrayTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 25, 16, 75, 82, 57 };
            int sum = 0,hasil=1;

            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    hasil*=array[i];
                    sum+=array[i];
                }
            }
            Console.Write(sum);
            Console.WriteLine("  "+ hasil);
        }
    }
}