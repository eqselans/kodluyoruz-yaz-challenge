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
            Console.Write("Dogum gününüz:");
            int dogumGunu = Convert.ToInt32(Console.ReadLine());
            // Kullanıcıdan doğum günü alındı

            Console.Write("Dogum ayınız:");
            int dogumAyi = Convert.ToInt32(Console.ReadLine());
            // Kullanıcıdan doğum ayı alındı

            Console.Write("Dogum yılınız:");
            int dogumYili = Convert.ToInt32(Console.ReadLine());
            // Kullanıcıdan doğum yılı alındı

            DateTime dogumTarihi = new DateTime(dogumYili,dogumAyi,dogumGunu);

            DateTime bugun = DateTime.Today;


            int yas = bugun.Year - dogumTarihi.Year;
            // Yıl farkları yapıldı


            if (dogumTarihi > bugun.AddYears(-yas) )
            {
                // Eğer doğum tarihi gün ve ay bakımından bugünün yaş yıl kadar öncesinden büyükse
                // yaşın bir değer azaltılması sağlandı

                yas--;
            }
            Console.Write("Yaşınız {0}",yas);

            Console.ReadLine();
        }
    }
}
