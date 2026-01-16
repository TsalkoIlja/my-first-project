using System.Reflection.Metadata;

namespace Variant_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta täht ja vajuta enter");

            string input = Console.ReadLine();

            switch (input)
            {
                case "a":
                    Püramiid();
                    break;

                case "e":
                    Ruud();
                    break;

                case "i":
                    Ruutvõrrand();



                    break;

                default:
                    Console.WriteLine("Ei ole vokaal");
                    break;
            }

        }
        static void Püramiid()
        {
            int i, j, n;

            Console.Write("Loo romb tärnidest: \n");
            Console.Write("----------------------");
            Console.Write("\n\n");
            Console.WriteLine("Sisesta rombi suurus");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i <= n; i++)
            {
                for (j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            for (i = n - 1; i >= 1; i--)
            {
                for (j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }


        }

        static void Ruud()
        {
            Console.WriteLine("Teine meetod - ruud");
            int size = int.Parse(Console.ReadLine());

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n");
            int area = size * size;
            int circumreference = 4 * size;
            Console.WriteLine("Pindala on " + area);
            Console.WriteLine("Ümbermõõt on " + circumreference);
        }



        static void Ruutvõrrand()
        {
            Console.WriteLine("Ruutvõrrand");


            Console.Write("Sisesta a väärtus ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Sisesta p väärtus ");
            double p = double.Parse(Console.ReadLine());

            Console.Write("Sisesta c väärtus ");
            double q = double.Parse(Console.ReadLine());

            Console.Write("Sisesta x väärtus ");
            double x = double.Parse(Console.ReadLine());

            double y = a * (x - p) * 2 * 2 + q;

            Console.WriteLine($"x1 = {(-p + Math.Sqrt(y)) / (2 * a)}, " +
                $"x2 = {(-p + Math.Sqrt(y)) / (2 * a)}");
        }


    }
}







