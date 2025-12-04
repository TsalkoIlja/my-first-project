namespace SwitchWeekday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //tuleb kasutada switchi
            //kui on esmaspäev, siis konsoolis kuvatakse
            //"Esmaspäev on tööpäev"
            //peate kasutama DayOfWeek enumeratsiooni

            switch (DateTime.Now.DayOfWeek)
            {   
                case DayOfWeek.Monday:
                    Console.WriteLine("Esmaspäev on tööpäev");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("Teisipév on tööpäev");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("Kolmapäev on tööpäev");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("Neljapäev on tööpäev");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("Reede on tööpäev");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("Laupäev on vabapäev");
                    break;
                case DayOfWeek.Sunday:
                    Console.WriteLine("Pühapäev on vabapäev");
                    break;
                default:
                    break;
            }
        }
    }
}
