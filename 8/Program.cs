using static System.Console;
Console.WriteLine("введите число а");
double a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("все четные числа до вашего числа: ");
for (int i = 2; i <= a; i= i+2)
{
    
    Console.WriteLine(i);
}

