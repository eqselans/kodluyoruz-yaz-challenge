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
            int[] siralanmisDizi = { 2, 3, 3, 5, 5, 5, 7, 8, 8, 8, 10 };


            Console.Write("Hedef sayı: ");
            int hedefSayi = Convert.ToInt32(Console.ReadLine());

            int tekrar = 0;

            foreach(int i in siralanmisDizi)
            {
                if (i == hedefSayi)
                {
                    tekrar++;
                }
                if (i>hedefSayi)
                {
                    break;
                }
            }
            Console.Write("Tekrar sayısı: "+ tekrar);
            Console.ReadLine();
        }
    }
}
