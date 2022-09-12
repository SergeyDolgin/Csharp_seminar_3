void palindrom ()
{
try
{
    Console.Write("Enter five-digits number ");
    int n = Convert.ToInt32(Console.ReadLine());
    if (n-10000 < 0 || n-100000 > 0)
    {
        Console.WriteLine("You have entered not a five-digits number");
    }
    if (n-10000 > 0 && n-100000 < 0)
    {
        a = n % 10000; 
        first digit is "+(n  / 10000)):
        b = n % 1000;
        c = n % 100;
        d = n % 10;
C
Console.WriteLine("The first digit is "+(n  / 10000));

    }
}
//     if (n-1000 > 0 && n-10000 < 0)
//     {
//         Console.WriteLine("three digit is "+(n  / 10) % 10);
//     }
//     if (n-10000 > 0 && n-100000 < 0)
//     {
//         Console.WriteLine("three digit is "+(n  / 100) % 10);
//     }
//     if (n-100000 > 0 && n-1000000 < 0)
//     {
//         Console.WriteLine("three digit is "+(n  / 1000) % 10);
//     }
//     if (n < 100 )
//     {
//         Console.WriteLine("Threre is no third digit");
//     }
// }
catch
{
    Console.WriteLine("You have entered not a number");
}
}

palindrom ();
