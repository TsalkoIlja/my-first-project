namespace SwitchMethodCall
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //teha switch rakendus,
            //kus kasutaja sisestab sõiduki tüübi (coupe või truck)
            //ja programm kutsub vastava meetodi (CarCoupe või Truck)
            Console.WriteLine("Sisesta väärtus");
            string input = Console.ReadLine();

            switch (input)
            {
                case "CarCoupe":
                    //kutsu meetod välja
                    CarCoupe();
                    break;
                case "Truck":
                    //kutsu meetod välja
                    Truck();
                    break;
                default:
                    Console.WriteLine("asd");
                    break;
            }
        }

        static void CarCoupe()
        {
            Console.WriteLine("You have a coupe car");
        }

        static void Truck()
        {
            Console.WriteLine("You have a truck");
        }
    }
}
