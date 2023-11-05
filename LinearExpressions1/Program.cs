using System.Linq.Expressions;

namespace LinearExpressions1
{
    internal class Program
    {
        static int Main(string[] args)
        {
            Console.Write("What is the value of a? : ");
            string aundone = Console.ReadLine();
            Console.Write("What is the value of b? : ");
            string bundone = Console.ReadLine();
            if(bundone == "0") { Console.WriteLine("b cannot be equal to 0");return 0; }
            Console.Write("What is the value of c? : ");
            string cundone = Console.ReadLine();
            if (cundone == "0") { Console.WriteLine("c cannot be equal to 0"); return 0; }
            Console.Write("What is the value of d? : ");
            string dundone = Console.ReadLine();
            if (dundone == "0") { Console.WriteLine("d cannot be equal to 0"); return 0; }
            double a = Convert.ToDouble(aundone);
            double b = Convert.ToDouble(bundone);
            double c = Convert.ToDouble(cundone);
            double d = Convert.ToDouble(dundone);
            double x = (a + 2 * b - c + d) / (c * d) + (a + b) / (c - d) - (Math.Pow(a, 2)) / (Math.Pow(b, 2));
            string formattedx = x.ToString("0.00");
            Console.WriteLine($"z is equal to {formattedx}");
            double y = 5 * (a + b) * (c - d) / (1.0 / 2 * c) + Math.Pow(d, 2) * (Math.Pow(a, 2) - Math.Pow(b, 2)) / (b - a);
            string formattedy = y.ToString("0.00");
            Console.WriteLine($"y is equal to {formattedy}");
            double z = ((Math.Pow(Math.Pow(x, 2) - 2 * x,3) - 4 * (Math.Pow(x,4) + 1)) * (1 - b))/(5 * a + 3 * b);
            string formattedz = z.ToString("0.00");
            Console.WriteLine($"z is equal to {formattedz}");
            double r = (1 / 2 * a + 3 / 4 * b - 7 / 5) / (3 * c + 1) + 1 / (a - c);
            string formattedr = r.ToString("0.00");
            Console.WriteLine($"r is equal to {formattedr}");
            return 0;
        }
    }
}