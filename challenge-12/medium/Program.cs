using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medium
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int koyun;
            int toplamBacak;
            int hayvanToplam = 36;


            for (int tavuk = 0; tavuk < hayvanToplam+1; tavuk++)
            {
                koyun = 36 - tavuk;
                toplamBacak = (tavuk*2) + (koyun*4);

                if (toplamBacak == 100)
                {
                    Console.WriteLine("Çiftlikteki tavuk sayısı : {0}\t Koyun sayısı:{1}", tavuk, koyun);
                }
            }
            Console.ReadLine();
        }
    }
}
