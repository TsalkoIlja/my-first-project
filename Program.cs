namespace WhileDo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("While Do");
            int i = 0;
            do
            {
                Console.WriteLine();
                // i++ tahendab et sama mis i=i+1
                i++;

            } while (i <= 10);
            //kui tuli nr 11, siis tingimus et kehti enam ja tsükkel lõpeb
        }
    }
}
