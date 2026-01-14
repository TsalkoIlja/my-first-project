namespace ForRectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ristkülik");

            //teha for loopiga ristkülik
            Console.WriteLine("Sisesta pikkus");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Sisesta laius");
            int col = int.Parse(Console.ReadLine());

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            //teha kalkulatsioon, kus arvutatakse pindala ja ümbermõõt
            int S = row * col;
            int P = 2 * (row + col);
            Console.WriteLine("Pindala on " + S);
            Console.WriteLine("Ümbermõõt on " + P);
        }
    }
}
