using static System.Console;
Console.WriteLine("введите число а");
double a = Convert.ToInt32(Console.ReadLine());
double del;

del = a % 2;

if (del == 0)

Console.Write("число четное");

if (del == 1)
Console.Write("число нечетное");


