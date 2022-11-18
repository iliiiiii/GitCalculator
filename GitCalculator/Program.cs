using System;

namespace GitCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna ensimmäinen numero");
            int eka = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Anna toinen numero");
            int toka = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Kumman haluat tulostaa, 1: Summan vai 2: Erotuksen?");
            int kolmas = Convert.ToInt32(Console.ReadLine());

           if (kolmas == 1)
            {
                Console.WriteLine("Summa:");
                Console.WriteLine(eka + toka);
            }
           if (kolmas == 2)
            {
                Console.WriteLine("Erotus:");
                Console.WriteLine(eka - toka);
            }
        }
    }
}
