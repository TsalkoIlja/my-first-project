using System;

namespace SwitchCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta esimene number");
            //loeme kasutaja sisendit ja see peab olema float andmetüüp

            //konsool kirjutab, et sisesta teine number
            //loeme kasutaja sisendit ja see peab olema float andmeetüüp
            //mõlemal juhul tuleeb float ära parsida
            float Firstnumber = float.Parse(Console.ReadLine());
            Console.WriteLine(1);

            float Secondnumber = float.Parse(Console.ReadLine());
            Console.WriteLine(2);

            Console.WriteLine("Esimene number" + Firstnumber);
            Console.WriteLine("Teine number" + Secondnumber);

            //konsool kirjutab, et vali tehe:  +,-,*,/
            Console.WriteLine("Vali tehe: +,-,*,/");
            string input = Console.ReadLine();

            //kasutate switchi, et teha valik kasutraja sisendi põhjal

            switch (input)
            {
                case "+":
                    Console.WriteLine($"Tulemus:{Firstnumber + Secondnumber}");
                    break;
                case "-":
                    Console.WriteLine($"Tulemus:{Firstnumber - Secondnumber}");
                    break;
                case "*":
                    Console.WriteLine($"Tulemus:{Firstnumber * Secondnumber}");
                    break;
                case "/":
                    if (Secondnumber == 0)
                    {
                        Console.WriteLine("Nulliga jagamine ei ole lubatud");
                    }
                    else
                    {
                        Console.WriteLine($"Tulemus:{Firstnumber / Secondnumber}");
                    }  
                        break;

                default:
                    Console.WriteLine("Teha pole lubatud");
                    break;



            }
        }
    }
}
