namespace SwitchMultipleCases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sisestad konsooli väärtuse
            //loeb sisestatud väärtuse stringina
            string input = Console.ReadLine();

            //tuleb kasutada switchi
            switch (input)
            {
                //esimeses cases on väärtused "Intro to C#", "Variables",
                //"Data Types" ja vastuseks Basic
                case "Intro to C#" or "Variables" or "Data Types":
                    Console.WriteLine("Basic");
                    break;

                //teises cases on väärtused "OOP", "Classes",
                //"Objects" ja vastuseks Intermediate
                case "OOP" or "Classes" or "Objects":
                    Console.WriteLine("Intermediate");
                    break;

                //kolmandas cases on väärtused "Asynchronous Programming", "LINQ",
                //"Delegates" ja vastuseks Advanced
                //teine variant
                case "Asynchronous Programming":
                case "LINQ":
                case "Delegates":
                    Console.WriteLine("Advanced");
                    break;

                default:
                    Console.WriteLine("Unknown level");
                    break;
            }
        }
    }
}
