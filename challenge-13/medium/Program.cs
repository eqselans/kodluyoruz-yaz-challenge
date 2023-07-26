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
            Console.Write("Lütfen büyütmek istediğiniz kelimeyi giriniz: ");

            string kelime = Console.ReadLine();

            Console.WriteLine("Büyütülmüş kelime: " + kelime.ToUpper());
            
           

            Console.ReadLine();
        }
    }
}
