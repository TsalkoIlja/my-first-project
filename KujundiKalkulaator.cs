namespace KujundiKalkulaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kujundi kalkulaator");

            // Ruudu sees asub ring. Ringi raadius on 3 ühikut.
            //Leia ja väljasta ekraanile ruudu pindala ja ümbermõõt.

            int roundRaudius = 3;
            int squeareSide = 2 * roundRaudius;
            int squareArea = squeareSide * squeareSide;

            int squarePerimeter = 4 * squeareSide;
            Console.WriteLine("Ruudu pindala:" + squareArea);
            Console.WriteLine("Ruudu ümbermõõt:" + squarePerimeter);

        }
    }
}
