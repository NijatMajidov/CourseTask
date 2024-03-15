#region task1
int[] array = { 12, 31, 57, 99, 34 };
int hasil = 1;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        hasil *= array[i];
    }

}
Console.WriteLine(hasil);

#endregion

#region task2
int[] array2 = { 323, 31,2, 345,4 };
int sum = 0;

for (int i = 0; i < array2.Length; i++)
{
    if (array2[i] % 2 == 0)
    {
        sum+= array2[i];
    }

}
Console.WriteLine(sum);
#endregion

#region task3
int[] arr = { 12, 31, 57, 99, 34 };
int n = 58;
bool t=false;

for (int i = 0; i < arr.Length; i++)
{
    if (n > arr[i] )
    {
        t=true;
        break;
    }

}
Console.WriteLine(t);
#endregion

