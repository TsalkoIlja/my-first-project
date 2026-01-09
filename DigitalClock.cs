using System.Diagnostics;

namespace DigitalClock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Digital Clock";
            Console.CursorVisible = false;

            //while (true)
            //{
            //    Console.Clear();
            //    Console.WriteLine("Digital Clock\n");
            //    Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
            //    Thread.Sleep(1000);
            //}

            //ts[kkel
            //while (true)
            //{
            //    //puhastab konsooli
            //    Console.Clear();
            //    //muutuja time, millel on arvutiaeg
            //    string time = DateTime.Now.ToString("HH:mm:ss");
            //    //kella horisontaalne asetus
            //    int x = (Console.WindowWidth - time.Length) / 2;
            //    //kella vertikaalne asetus
            //    int y = Console.WindowHeight / 2;
            //    //positsioon
            //    Console.SetCursorPosition(x, y);
            //    //näitab aega
            //    Console.Write(time);
            //    //peale 1 sek laseb tsükklil edasi minna
            //    Thread.Sleep(1000);
            //}
            //ctrl + k + c

            //for loopiga teha digitaalne kell

            for ( ; ; )
            {
                Console.Clear();
                Console.WriteLine("Digital Clock\n");
                Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
                Thread.Sleep(1000);
            }
        }
    }
}
