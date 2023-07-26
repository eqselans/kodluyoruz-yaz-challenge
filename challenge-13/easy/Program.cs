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
            Console.WriteLine("Sayı giriniz : ");
            
            int say = Convert.ToInt32(Console.ReadLine());

            int sayac = 0;

            for (int i = 1; i < say; i++)
            {
                
                if (say % i == 0)
                {
                    sayac++;
                       
                }
            }
            if (sayac == 1)
            {
                Console.WriteLine("Bu bir asal sayıdır");
            }
            else
            {
                Console.WriteLine("Bu bir asal sayı değildir");
            }
        
            Console.ReadLine();
        }

    }
}
