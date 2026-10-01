using System.Runtime.InteropServices;
using System.Security.Principal;

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

while (n > 10)
{
    int x = n;
    int temp = n;
    int sum = 0;
    int count = 0;
    while (temp > 0)
    {
        count++;
        temp /= 10;
    }
    while (x > 0)
    {
        int d;
        d = x % 10;
        Console.WriteLine(d);
        if (count % 2 == 1)
        {

            sum += d;
        }
        else
        {

            sum -= d;
        }

            
        count--;

    }
    n = sum;
}
Console.WriteLine(n);

