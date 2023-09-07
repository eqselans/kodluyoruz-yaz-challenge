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
            int[] sayilar = {1, 2, 3, 4, 5,6};

            float tane = sayilar.Length;
            float sayi = 0;

            for (int i = 0; i < tane; i++)
            {
                sayi += sayilar[i];
            }
            float ort = sayi / tane;

            Console.WriteLine(ort);
            Console.ReadLine();

        }
    }
}
