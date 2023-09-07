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

            Console.Write("Hesaplanacak sayıyı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            int faktoriyel =1;

            for (int i = 1; i <= sayi; i++)
            {
                faktoriyel *= i;
            }

            Console.WriteLine("{0} ! = {1}",sayi, faktoriyel);
            Console.ReadLine();

        }
    }
}
