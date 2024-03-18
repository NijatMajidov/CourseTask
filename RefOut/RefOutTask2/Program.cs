namespace RefOutTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {-2,3, 4,-5};
            Positive(ref numbers);
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i]+" ");
            }
        }

        public static void Positive(ref int[] arr)
        {
            int[] newArray = new int[arr.Length];

            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] < 0)
                {
                    newArray[i] = arr[i]*-1;
                }
                else
                {
                    newArray[i] = arr[i];
                }
            }
            arr = newArray;
            
        }
    }
}