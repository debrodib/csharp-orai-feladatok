namespace ConsoleApp1;
public static class GetInput
{
    public static int Int()
    {
        int? num = null;
        do
        {
            try
            {
                num = int.Parse(Console.ReadLine()!);
            }
            catch (FormatException)
            {
                Console.WriteLine("Hibás formátum, add meg a számot újra: ");
            }
            catch (OverflowException)
            {
                Console.WriteLine($"Csak {int.MinValue} és {int.MaxValue} között adj meg számot: ");
            }
        } while (num is null);

        return num ?? int.MaxValue;
    }

    public static double Double()
    {
        double? num = null;
        do
        {
            try
            {
                num = double.Parse(Console.ReadLine()!);
            }
            catch (FormatException)
            {
                Console.WriteLine("Hibás formátum, add meg a számot újra: ");
            }
            catch (OverflowException)
            {
                Console.WriteLine($"Csak {double.MinValue} és {double.MaxValue} között adj meg számot: ");
            }
        } while (num is null);
        return num ?? double.MaxValue;
    }
}

internal static class Program
{
    
    static void F1()
    {
        Console.WriteLine("Hello world!");
    }

    static void F2()
    {
        Console.Write("Mi a neved: ");
        string input = Console.ReadLine()!;
        Console.WriteLine($"Szia {input}!");
    }

    static void F3()
    {
        Console.Write("Adj meg egy számot: ");
        double input = GetInput.Double();
        Console.WriteLine($"A megadott szám kétszerese: {input*2}");
        // Console.Write("Adj meg egy számot: ");
        // double a = double.Parse(Console.ReadLine());
        // Console.WriteLine(a*2);
    }

    static void F4()
    {
        Console.Write("Első szám: ");
        double num1 = GetInput.Double();
        Console.Write("Második szám: ");
        double num2 = GetInput.Double();
        Console.WriteLine($"A megadott számok összege: {num1 + num2}");
        Console.WriteLine($"A megadott számok különbsége: {num1 - num2}");
        Console.WriteLine($"A megadott számok szorzata:  {num1 * num2}");
        if (num2 / 1 != 0)
        {
            Console.WriteLine($"A megadott számok elosztva: {num1 / num2}");
        }
    }

    static void F5()
    {
        Console.Write("Első szám: ");
        int num1 = GetInput.Int();
        Console.Write("Második szám: ");
        int num2 = GetInput.Int();
        Console.WriteLine($"A nagyobbik szám: {Math.Max(num1, num2)}");
    }
    
    static void F6()
    {
        Console.Write("Első szám: ");
        int num1 = GetInput.Int();
        Console.Write("Második szám: ");
        int num2 = GetInput.Int();
        Console.WriteLine("Harmadik szám: ");
        int num3 = GetInput.Int();
        
        Console.WriteLine($"A legkisebb szám: {Math.Min(num1, Math.Min(num2, num3))}");
    }

    static void F7()
    {
        Console.Write("Háromszög 1. oldala: ");
        double a = GetInput.Double();
        Console.Write("Háromszög 2. oldala: ");
        double b = GetInput.Double();
        Console.Write("Háromszög 3. oldala: ");
        double c = GetInput.Double();
        
        if (a + b > c && a + c > b && b + c > a)
            Console.WriteLine("A háromszög szerkeszthető.");
        else
            Console.WriteLine("A háromszög nem szerkeszthető.");
    }

    static void F8()
    {
        Console.Write("Első szám: ");
        int num1 = GetInput.Int();
        Console.Write("Második szám: ");
        int num2 = GetInput.Int();
        Console.WriteLine($"Számtani közép: {(num1 + num2) / 2}");
        Console.WriteLine($"Mértani közép: {Math.Sqrt(num1 * num2)}");
    }

    static void F9()
    {
        Console.Write("Add meg az x négyzetet: ");
        double a = GetInput.Double();
        Console.Write("Add meg az x et: ");
        double b = GetInput.Double();
        Console.Write("Add meg a számot: ");
        double c = GetInput.Double();
        if (a == 0)
        {
            if (b == 0)
            {
                if (c == 0)
                {
                    Console.WriteLine("Az egyenletnek végtelen sok megoldása van.");
                }
                else
                {
                    Console.WriteLine("Az egyenletnek nincs megoldása.");
                }
            }
            else
            {
                double x = -c / b;
                Console.WriteLine($"Az egyenlet egy megoldása van (elsőfokú): x = {x}");
            }
        }
        else
        {
            double d = b * b - 4 * a * c;

            if (d > 0)
            {
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine($"Két valós gyök: x1 = {x1}, x2 = {x2}");
            }
            else if (d == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"Egy valós gyök (kettős gyök): x = {x}");
            }
            else
            {
                double realPart = -b / (2 * a);
                double imaginaryPart = Math.Sqrt(-d) / (2 * a);
                Console.WriteLine($"Két komplex gyök: x1 = {realPart} + {imaginaryPart}i, x2 = {realPart} - {imaginaryPart}i");
            }
        }
        
    }

    static void F10()
    {
        Console.Write("Add meg az x négyzetet: ");
        double a = GetInput.Double();
        Console.Write("Add meg az x et: ");
        double b = GetInput.Double();
        Console.Write("Add meg a számot: ");
        double c = GetInput.Double();
        if (a == 0)
        {
            if (b == 0)
            {
                if (c == 0)
                {
                    Console.WriteLine("Az egyenletnek végtelen sok megoldása van.");
                }
                else
                {
                    Console.WriteLine("Az egyenletnek nincs megoldása.");
                }
            }
            else
            {
                double x = -c / b;
                Console.WriteLine($"Az egyenlet egy megoldása van (elsőfokú): x = {x}");
            }
        }
        else
        {
            double d = b * b - 4 * a * c;

            if (d > 0)
            {
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine($"Két valós gyök: x1 = {x1}, x2 = {x2}");
            }
            else if (d == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"Egy valós gyök (kettős gyök): x = {x}");
            }
            else
            {
                double realPart = -b / (2 * a);
                double imaginaryPart = Math.Sqrt(-d) / (2 * a);
                Console.WriteLine(
                    $"Két komplex gyök: x1 = {realPart} + {imaginaryPart}i, x2 = {realPart} - {imaginaryPart}i");
            }
        }
    }

    static void F11()
    {
        Console.Write("Add meg az egyik befogót: ");
        double a = GetInput.Double();
        Console.Write("Add meg a másik befogót: ");
        double b = GetInput.Double();
        do
        {
            try
            {
                if (a > 0 && b > 0)
                {
                    Console.WriteLine($"A háromszög átfogója: {Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2))}");
                }
                else
                {
                    Console.WriteLine("Érvénytelen befogó(k)");
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Túl nagy szám!");
            }
        } while (a < 0 && b < 0);
    }
    
    static void Main(string[] args)
    {
        
    }
}