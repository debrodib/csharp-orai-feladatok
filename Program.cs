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
                    Console.WriteLine($"A háromszög átfogója: {Math.Round(Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)), 2)}");
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

    static void F12()
    {
        Console.Write("Adj meg az \"a\" értékét: ");
        double a = GetInput.Double();
        Console.Write("Adj meg a \"b\" értékét: ");
        double b = GetInput.Double();
        Console.Write("Adj meg a \"c\" értékét: ");
        double c = GetInput.Double();
        Console.WriteLine($"A téglatest felszíne: {2 * (a * b + b * c + a * c)}");
        Console.WriteLine($"A téglatest térfogata: {a * b * c}");
    }

    static void F13()
    {
        Console.Write("Add meg a kör átmérőjét: ");
        double d = GetInput.Double();
        if (d > 0)
        {
            Console.WriteLine($"A kör kerülete: {Math.PI * d}");
            Console.WriteLine($"A kör területe: {Math.PI * Math.Pow(d / 2, 2)}");
        }
        else
        {
            Console.WriteLine("Érvénytelen átmérő");
        }
    }

    static void F14()
    {
        Console.Write("Add meg a körív sugarát: ");
        double r = GetInput.Double();
        Console.Write("Add meg a középponti szöget fokban: ");
        double alpha = GetInput.Double();
        if (r > 0 && alpha > 0 && alpha <= 360)
        {
            double length = 2 * Math.PI * r * (alpha / 360);
            double area = Math.PI * r * r * (alpha / 360);
            Console.WriteLine($"A körív hossza: {length}");
            Console.WriteLine($"A körív területe: {area}");
        }
        else
        {
            Console.WriteLine("Érvénytelen bemenet");
        }
    }

    static void F15()
    {
        Console.Write("Add meg a számot: ");
        int n = GetInput.Int();
        if (n > 0)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i);
                if (i < n)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Érvénytelen bemenet");
        }
    }

    static void F16()
    {
        Console.Write("Adj meg egy pozitív egész számot: ");
        int n = GetInput.Int();
        if (n > 0)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
        else
        {
            Console.WriteLine("Érvénytelen bemenet");
        }
    }

    static void F17()
    {
        Console.Write("Adj meg egy pozitív egész számot: ");
        int n = GetInput.Int();
        if (n > 0)
        {
            Console.WriteLine($"{n} osztói:");
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        else
        {
            Console.WriteLine("Érvénytelen bemenet");
        }
    }

    static void F18()
    {
        Console.Write("Adj meg egy pozitív egész számot: ");
        int n = GetInput.Int();
        if (n > 0)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine($"{n} osztóinak összege: {sum}");
        }
        else
        {
            Console.WriteLine("Érvénytelen bemenet");
        }
    }

    static void F19()
    {
        Console.Write("Adj meg egy pozitív egész számot: ");
        int n = GetInput.Int();
        if (n > 0)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }
            
            if (sum == 2 * n)
            {
                Console.WriteLine($"{n} tökéletes szám.");
            }
            else
            {
                Console.WriteLine($"{n} nem tökéletes szám.");
            }
        }
        else
        {
            Console.WriteLine("Érvénytelen bemenet");
        }
    }

    static void F20()
    {
        Console.Write("Hatványalap: ");
        double a = GetInput.Double();
        Console.Write("Kitevő: ");
        int n = GetInput.Int();
        double result = Math.Pow(a, n);
        Console.WriteLine($"{a} {n} -dik hatványa: {result}");
    }

    static void F21()
    {
        double num;
        do
        {
            Console.Write("Adj meg egy pozitív számot: ");
            num = GetInput.Double();
            if (num <= 0)
            {
                Console.WriteLine("Hibás bemenet, próbáld újra.");
            }
        } while (num <= 0);
    }

    static void F22()
    {
        int sum = 0;
        int count = 0;
        while (true)
        {
            Console.Write("Adj meg egy számot (10-nél kisebbet): ");
            int n = GetInput.Int();
            if (n < 10)
            {
                sum += n;
                count++;
            }
            else
            {
                break;
            }
        }
        Console.WriteLine($"A beolvasott számok összege: {sum}");
    }

    static void F23()
    {
        Console.Write("Kérek egy egész számot: ");
        int number = GetInput.Int();
        int original = number;
        int twoPowerCount = 0;

        while (number % 2 == 0)
        {
            number /= 2;
            twoPowerCount++;
        }

        Console.Write($"{original} = ");
        if (twoPowerCount == 0)
        {
            Console.WriteLine(original);
        }
        else
        {
            for (int i = 0; i < twoPowerCount; i++)
            {
                Console.Write("2*");
            }
            Console.WriteLine(number);
        }
    }

    static void F24()
    {
        string input;
        do
        {
            Console.Write("Kérlek írd be az 'alma' szót: ");
            input = Console.ReadLine()?.Trim() ?? "";
            
            if (input != "alma")
            {
                Console.WriteLine("Hibás bemenet! Csak az 'alma' szót fogadom el.");
            }
        } while (input != "alma");

        Console.WriteLine("Az alma gyümölcs!");
    }

    static void F25()
    {
        Console.Write("Kérek egy egész számot: ");
        int number = GetInput.Int();
        int original = number;
        int quotient = 0;

        while (number >= 3)
        {
            number -= 3;
            quotient++;
        }

        Console.WriteLine($"{original} = {quotient}*3+{number}");
    }

    static void F26()
    {
        Console.Write("Adj meg egy pozitív egész számot: ");
        int num = GetInput.Int();

        if (num <= 1)
        {
            Console.WriteLine("A szám nem prímszám.");
            return;
        }

        bool isPrime = true;
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        if (isPrime)
            Console.WriteLine($"A(z) {num} prímszám.");
        else
            Console.WriteLine($"A(z) {num} nem prímszám.");
    }

    static void F27()
    {
        Console.Write("Adj meg egy pozitív egész számot: ");
        int limit = GetInput.Int();

        if (limit < 2)
        {
            Console.WriteLine("Nincs prímszám ebben a tartományban.");
            return;
        }

        Console.WriteLine($"Prímszámok 2-től {limit}-ig:");

        for (int num = 2; num <= limit; num++)
        {
            bool isPrime = true;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.Write(num + " ");
            }
        }
        Console.WriteLine();
    }
    static void F28()
    {
        Console.Write("Adj meg egy pozitív egész számot: ");
        int num = GetInput.Int();

        if (num <= 1)
        {
            Console.WriteLine("A számnak nincsenek prímosztói.");
            return;
        }

        Console.WriteLine($"A(z) {num} prímosztói:");
        int n = num;

        for (int i = 2; i <= n; i++)
        {
            while (n % i == 0)
            {
                Console.WriteLine(i);
                n /= i;
            }
        }
    }

    static void F29()
    {
        Console.Write("Adj meg egy pozitív egész számot: ");
        int num = GetInput.Int();

        if (num <= 1)
        {
            Console.WriteLine("A számnak nincsenek prímosztói.");
            return;
        }

        Console.WriteLine($"{num} prímosztói:");
        int n = num;

        for (int i = 2; i <= n; i++)
        {
            while (n % i == 0)
            {
                Console.WriteLine(i);
                n /= i;
            }
        }
    }

    static void F30()
    {
        Console.Write("Add meg az első számot: ");
        int a = GetInput.Int();
        Console.Write("Add meg a második számot: ");
        int b = GetInput.Int();

        int gcd = LNKO(Math.Abs(a), Math.Abs(b));
        Console.WriteLine($"{a} és {b} legnagyobb közös osztója: {gcd}");

        static int LNKO(int a, int b)
        {
            while (b > 0)
            {
            int t = b;
            b = a % b;
            a = t;
            }
            return a;
        }
    }

    static void F31()
    {
        Console.Write("Add meg az első számot: ");
        int a = GetInput.Int();
        Console.Write("Add meg a második számot: ");
        int b = GetInput.Int();

        int num1 = Math.Abs(a);
        int num2 = Math.Abs(b);

        int num1Copy = num1;
        int num2Copy = num2;
        
        while (num2Copy > 0)
        {
            int temp = num2Copy;
            num2Copy = num1Copy % num2Copy;
            num1Copy = temp;
        }
        
        int gcd = num1Copy;

        int lcm = (num1 * num2) / gcd;
        
        Console.WriteLine($"{a} és {b} legkisebb közös többszöröse: {lcm}");
    }


    static void Main(string[] args)
    {
    }
}