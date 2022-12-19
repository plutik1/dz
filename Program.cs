using static System.Console;
Console.WriteLine("введите число а");
int i = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите число б");
int b = Convert.ToInt32(Console.ReadLine());
if (i > b)
    Console.Write("наибольшее число");
    Console.Write( i );
 
 if (i < b)
    Console.Write("наибольшее число = ");
    Console.Write( b );
