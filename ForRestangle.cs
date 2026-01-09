namespace ForRestangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ristkülik");

            //teha for loopiga ristkülik
            Console.Write("Sisesta laius: ");
            int row = Convert.ToInt32(Console.ReadLine());

            Console.Write("Sisesta pikkus: ");
            int col= Convert.ToInt32(Console.ReadLine());

            // joonistame ristküliku tärnidega
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();

            }
            //thea kalkulatsioon, kus arvetatakse pindala ja ümbermõõt
            int pindala = row * col;
            int umbermoot = 2 * (row + col);

            Console.WriteLine($"Pindala: {pindala}");
            Console.WriteLine($"Ümbermõõt: {umbermoot}");
        }
    }
}
