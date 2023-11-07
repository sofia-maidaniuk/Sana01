using System; 


class Program
{
    static void Main(string[] args)
    {
        System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
        System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
        customCulture.NumberFormat.NumberDecimalSeparator = ".";
        System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

        Console.Write("Input double a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Input double b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Input double c: ");
        double c = double.Parse(Console.ReadLine());

        Console.Write("Input double d: ");
        double d = double.Parse(Console.ReadLine());

        double x;
        double y;
        double z;
        double r;

        x = (a + 2 * b - c + d) / (c * d) + (a + b) / (c - d) - (a * a) / (b * b);
        y = (5 * (a + b) * (c - d)) / (1 / 2.0 * c) + d * d * ((a * a - b * b) / (b - a));
        z = (Math.Pow((x * x - 2 * x), 3) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b) / (5 * a + 3 * b);
        r = (1.0 / 2 * a + 3.0 / 4 * b - 7.0 / 5) / (3 * c + 1) + 1 / (a - c);
        
        Console.WriteLine("\nResults: ");
        Console.WriteLine("x = " + x);
        Console.WriteLine("y = " + y);
        Console.WriteLine("z = " + z);
        Console.WriteLine("r = " + r);
    }
}

