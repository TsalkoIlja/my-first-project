namespace Square
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta ruudu suurus");
            //tärnidega (*) teha for loopiga ruut
            int size = Convert.ToInt32(Console.ReadLine());

            
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            //kui suurus on sisestatud, siis kuvab meile ümbermõõdu ja pindala
            Console.WriteLine("\n");
            int area = size * size;
            int circumreference = 4 * size;
            Console.WriteLine("Pindala on " + area);
            Console.WriteLine("Ümbermõõt on " + circumreference);

        }
    }
}
