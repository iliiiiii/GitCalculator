using System;

namespace GitCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna ensimmäinen numero: ");
            int eka = Convert.ToInt32(Console.ReadLine());
            Console.Write("Anna toinen numero: ");
            int toka = Convert.ToInt32(Console.ReadLine());
            yhteenlasku(eka, toka);
            Console.ReadLine();
        }
        public static void yhteenlasku(int eka, int toka)
        {
            Console.WriteLine(eka + toka);
        }
    }
}
