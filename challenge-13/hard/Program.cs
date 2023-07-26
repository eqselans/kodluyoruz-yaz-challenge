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
            int cost, price;

            cost = 100;

            price = 150;

            if (price<cost)
            {
                Console.WriteLine("price cost'dan her zaman büyük olmalıdır.");
            }
            else
            {
                int fark = price - cost;

                for (int i = 0; i < fark; i++)
                {
                    int hedef = fark * i;

                    if (hedef>cost)
                    {
                        Console.WriteLine("Hedefe ulaşılması için {0} satım gerekiyor",i);
                        break;
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
