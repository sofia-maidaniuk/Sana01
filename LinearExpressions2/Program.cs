using System;


class Program
{
    static void Main(string[] args)
    {
        System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
        System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
        customCulture.NumberFormat.NumberDecimalSeparator = ".";
        System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

        Console.Write("Input double n: ");
        double m = double.Parse(Console.ReadLine());

        Console.Write("Input double m: ");
        double n = double.Parse(Console.ReadLine());

        Console.Write("Input double a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Input double b: ");
        double b = double.Parse(Console.ReadLine()); 
        
        Console.Write("Input double x: ");
        double x = double.Parse(Console.ReadLine());
        
        double y;
        double z1;
        double z2;

        z1 = ((m-1)*Math.Sqrt(m) - (n-1) * Math.Sqrt(n))/ (Math.Sqrt(Math.Pow(m,3) * n) + n*m + Math.Pow(m,2) - m);
        z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
        y = 2.4 * Math.Abs((Math.Pow(m,2) + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2)*(x - b);

        Console.WriteLine("\nResults: ");
        Console.WriteLine($"y = {y}");
        Console.WriteLine($"z1 = {z1}");
        Console.WriteLine($"z2 = {z2}");
    }
}

