﻿namespace SwitchNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta number");
            //peab saama sisestada numbrit ja muudab selle int andmetüübiks
            int number = Convert.ToInt32(Console.ReadLine());
            //tuleb teha switch, kus on esimene case 10, teine on 20 ja kolmas on 30
            //kindlasti tuleb ka default lõppu teha
            switch (number)
            {
                case 10:
                    Console.WriteLine("Sisestasid 10");
                    break;
                case 20:
                    Console.WriteLine("Sisestasid 20");
                    break;
                case 30:
                    Console.WriteLine("Sisestasid 30");
                    break;
                default:
                    Console.WriteLine("Sisestasid mingi muu numbri");
                    break;
            }

        }
    }
}
