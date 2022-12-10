void CrossDots()
{
    System.Console.WriteLine("Введите точку b1");
    double b1 = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Введите точку k1");
    double k1 = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Введите точку b2");
    double b2 = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Введите точку k2");
    double k2 = Convert.ToInt32(Console.ReadLine());


    double x = -(b1 - b2) / (k1 - k2);
    double y = k1 * x + b1;

    Math.Round(x, 2);
    Math.Round(y, 2);

    System.Console.WriteLine($"Пересечения в точке ({x} ; {y}) ");
}

System.Console.WriteLine("Ниже ведите координаты точек для проверки пересечения");
System.Console.WriteLine();
CrossDots();