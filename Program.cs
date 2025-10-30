namespace switchMultiple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //sisestad konsooli väärtuse
            //loeb sisestatud vüürtuse stringina
            //tuleb kasutada switchi

            //esimeses cases on väärtused "Intro to C#", "Variables",
            //"Date Types" ja vastuseks Basic

            //teises cases on vääärtused "OOP", "Classes",
            //"objects" ja vastuseks Intermediate

            //kolmandas cases on väärtused "Ancynchrouns Programming", "LINQ",
            //"Delegates" ja vastuseks Advanced
            Console.WriteLine("Sisesta vüäärtus");
            string input = Console.ReadLine();
            switch (input)
            {
                case "Intro to C#":
                case "variables":
                case "Date types":

                    Console.WriteLine("Basic");
                    break;
                case "OOP":
                case "Classes":
                case "Object":

                    Console.WriteLine("intermediate");
                    break;
                case "Ancynchrouns Programming":
                case "LINQ":
                case "Delegates":

                    Console.WriteLine("Advanced");
                    break;




            }
        }
    }
}