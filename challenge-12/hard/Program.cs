using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double giris1_hiz = 1.0 / 10;
            double giris2_hiz = 1.0 / 15;
            double bosalma_hiz = 1.0 / 30;

            double sonuc = havuzDolumSuresi(giris1_hiz, giris2_hiz, bosalma_hiz);

            if (sonuc == 0)
            {
                Console.WriteLine("Havuz hiç dolmaz.");
            }
            else
            {
                Console.WriteLine("Havuzun dolma süresi: " + Math.Round(sonuc, 2) + " saat");
            }

            Console.ReadLine();
        }

        static double havuzDolumSuresi(double hiz1, double hiz2, double bosalma)
        {
            double toplamHiz = hiz1 + hiz2 - bosalma;

            if (toplamHiz <= 0)
            {
                return 0;
            }
            else
            {
                double dolumSuresi = 1.0 / toplamHiz;
                return dolumSuresi;
            }
        }
    }
}
