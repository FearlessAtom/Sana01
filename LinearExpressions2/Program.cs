namespace LinearExpressions2
{
    internal class Program
    {
        static int Main(string[] args)
        {
            Console.Write("What is the value of m ? : ");
            string mundone = Console.ReadLine();
            if(mundone == "0") { Console.WriteLine("m cannot be equal to 0!");return 0; }
            double m = Convert.ToDouble(mundone);
            Console.Write("What is the value of n ? : ");
            string nundone = Console.ReadLine();
            double n = Convert.ToDouble(mundone);
            Console.Write("What is the value of x? : ");
            string xundone = Console.ReadLine();
            double x = Convert.ToDouble(xundone);
            Console.Write("What is the value of a? : ");
            string aundone = Console.ReadLine();
            if(aundone == "0") { Console.WriteLine("a cannot be equal to 0!");return 0; }
            double a = Convert.ToDouble(xundone);
            Console.Write("What is the value of b? : ");
            string bundone = Console.ReadLine();
            double b = Convert.ToDouble(xundone);
            double z1 = ((m - 1) * Math.Pow(m, 1.0 / 2) - (n - 1) * Math.Pow(n, 1.0 / 2)) / (Math.Pow(Math.Pow(m, 3) * n, 1.0 / 2) + n * m + Math.Pow(m, 2) - m);
            string formattedz1 = z1.ToString("0.00");
            Console.WriteLine($"z1 is equal to {z1}");
            double z2 = (Math.Pow(m,1.0/2)  - Math.Pow(n,1.0/2) / (m));
            string formattedz2 = z2.ToString("0.00");
            Console.WriteLine($"z2 is equal to {z2}");
            double y = 2.4 * (Math.Abs(Math.Pow(x, 2) + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b);
            string formattedy = y.ToString("0.00");
            Console.WriteLine($"y is equal to {formattedy}");
            return 0;
        
        }
    }
}