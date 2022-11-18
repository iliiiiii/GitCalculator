using System;

namespace GitCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna kaksi lukua");
            int eka = Convert.ToInt32(Console.ReadLine());
            int toka = Convert.ToInt32(Console.ReadLine());
            int vastaus1 = Summa(eka, toka);
            int vastaus2 = Erotus(eka, toka);
            int vastaus3 = Kerto(eka, toka);
            double vastaus4 = Jako(eka, toka);
            Console.WriteLine("Summa: {0}\n" + "Erotus: {1} \n" + "Kerto: {2} \n" + "Jako: {3} \n", vastaus1, vastaus2, vastaus3, vastaus4);
        }

        public static int Summa(int eka, int toka)
        {
            return eka + toka;
        }

        public static int Erotus(int eka, int toka)
        {
            return eka - toka;
        }
        public static int Kerto(int eka, int toka)
        {
            return eka * toka;
        }
        public static double Jako(int eka, int toka)
        {
            return eka / toka;
        }

    }
}
