void palindrom ()
{
try
{
    Console.Write("Enter five-digits number ");
    int n = Convert.ToInt32(Console.ReadLine());
    int a, b, c, d, e;
    if (n-10000 < 0 || n-100000 > 0)
    {
        Console.WriteLine("You have entered not a five-digits number");
    }
    if (n-10000 > 0 && n-100000 < 0)
    {
        a = n / 10000; 
        b = (n / 1000) % 10;
        d = (n / 10) % 10;
        e = n  % 10;
        if (a == e)
        {
            if (b==d)
            {
                Console.WriteLine("This NUMBER is a palidrom ");
            }
            else
            {
                Console.WriteLine("This NUMBER is not a palidrom ");
            }
        }
        else 
        {
            Console.WriteLine("This NUMBER is not a palidrom ");
        }
    }
}

catch
{
    Console.WriteLine("You have entered not a number");
}
}

palindrom ();
