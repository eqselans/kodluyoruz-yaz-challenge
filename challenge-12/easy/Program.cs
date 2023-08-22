using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace easy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hız = 60;
            int yol = 240;

            Console.WriteLine("Aracın {0} km/h hızla {1} km yol gidebilmesi için {2} saat gereklidir", hız, yol, yol / hız);
            Console.ReadLine();
        }
    }
}
