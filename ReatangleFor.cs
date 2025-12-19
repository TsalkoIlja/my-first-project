namespace RectangleFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta ristküliku külje mõõdud");

            Console.WriteLine("Pikkus");
            double leght = double.Parse(Console.ReadLine());

            Console.WriteLine("Laius");
            double witdh = double.Parse(Console.ReadLine());

            //kasutada for loopi
            //peab tuleb ristküliku kujund

            for (int row = 0; row < leght; row++)
            {
                for (int col = 1; col < witdh; col++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();

            }
        }
    }
}
