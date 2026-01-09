namespace Ruutvõõrand
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ruutvõõrand");

            //ax2 + bx + с

            //kasutaja peab sissestada väärtuseid a, b, ja c
            Console.Write("Sisesta a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Sisesta b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Sisesta c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            // diskriminant
            double D = b * b - 4 * a * c;

            Console.WriteLine($"\nDiskriminant D = {D}");

            if (D > 0)
            {
                double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine($"Kaks lahendit: x1 = {x1}, x2 = {x2}");
            }
            else if (D == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"Üks lahend: x = {x}");
            }
            else
            {

            }
        }
    }   
}
