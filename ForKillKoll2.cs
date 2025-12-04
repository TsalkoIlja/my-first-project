namespace ForKillKoll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Eelnevaid teadmisi kasutades kirjuta programm, mis väljastaks:
            //kill - koll
            //kill - koll
            //killadi + kool
            //kill - koll
            //kill - koll
            //killadi + kool
            //kill - koll
            //kill - koll
            //killadi + kool
            //kill - koll
            //VIHJE: for loop for loopi sees

            int arv = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < arv; i++)
        {
                Console.WriteLine("see on rida nt {0}",i);
                
            }
            for (int j = 0; j < 2; j++)
            {
                Console.WriteLine("kill - koll");
                
            }
            for (int k = 0; k < 1; k++)
            {
                Console.WriteLine("killandi - koll");
               
            }
                 
        }   
    }
}
