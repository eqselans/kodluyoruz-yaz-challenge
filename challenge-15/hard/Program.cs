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
            int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            // Sayı dizisi oluşturuldu  

            Console.Write("Hedef sayı giriniz : ");
            int hedef = Convert.ToInt32(Console.ReadLine());
            // Hedef sayı istendi
            
            KombinasyonBul(sayilar, hedef,"",0);
            // Metot çağırıldı

            Console.ReadLine();
        }
        
        static void KombinasyonBul(int[] sayilar, int hedef,string kombinasyon,int index)
        {
            if (hedef == 0)
            {   // Kombinasyon yazılır ve metottan çıkılır
                Console.WriteLine(kombinasyon);
                return;
            }
            if (hedef < 0 || index == sayilar.Length)
            {
                return;
            }


            KombinasyonBul(sayilar, hedef - sayilar[index],kombinasyon+ sayilar[index]+" ",index);
            // hedefden indeks değeri çıkarılır ve kombinasyon metnine eklenir  
            
            KombinasyonBul(sayilar,hedef,kombinasyon,index+1);
            // hedef değiştirilmeden ve kombinasyon metni değiştirilmeden bir sonraki indeks değeri kullanılır
        }
    }   
        
}
