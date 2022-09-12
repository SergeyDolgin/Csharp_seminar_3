double lengthBetween(int x1, int y1, int x2, int y2, int z1, int z2)
{
    // (x1 - x2) ^2
    // (y1 - y2) ^ 2
    // N мерное 
    double xres = (x1 - x2) * (x1 - x2);
    double yres = (y1 - y2) * (y1 - y2);
    double zres = (z1 - z2) * (z1 - z2);
    double res = Math.Sqrt(xres + yres + zres);
    return res;
}

Console.WriteLine("Введите координаты первой точки");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Расстояние между точками = {lengthBetween(x1,y1,x2,y2,z1,z2)}");
