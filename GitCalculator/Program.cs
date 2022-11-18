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
            
            Console.WriteLine("Summa:");
            Console.WriteLine(eka + toka);
            
            Console.WriteLine("Erotus:");
            Console.WriteLine(eka - toka);
        }
    }
}
