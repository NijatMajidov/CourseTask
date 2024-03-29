#region task4
int n=21;
bool t = false;

for (int i = 90; i < 100; i++)
{
    if (i % 21 == 0)
    {
        t = true;
        break;
    }
}
Console.WriteLine(t);
#endregion

#region task5
int num=5643;
int sum = 0;
while (num!=0)
{
    sum += num % 10;
    num /= 10;
}
    Console.WriteLine(sum);
#endregion