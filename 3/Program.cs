using static System.Console;
Console.WriteLine("введите число а");
int a = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("введите число б");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите число c");
int c = Convert.ToInt32(Console.ReadLine());

    if (a >= b && a>=c )
    {
    Console.Write("наибольшее число: ");
    Console.Write( a );

    }

    if (a <= b && b>=c )
    {
    Console.Write("наибольшее число: ");
    Console.Write( b );
    }
    if (b <= c && a <=c )
    {
    Console.Write("наибольшее число: ");
    Console.Write( c );
    }

    
    
 