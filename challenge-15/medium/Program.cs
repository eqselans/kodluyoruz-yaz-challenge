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
            Console.WriteLine("Kelime - Cümle giriniz: ");
            string yazi = Console.ReadLine();
            char[] harfler = yazi.ToCharArray();

            int enBuyukHarfSayisi = 0;
            int enBuyukEsitHarflerSayisi = 0;
            char enBuyukHarf = '\0';

            for (int i = 0; i < harfler.Length; i++)
            {
                int toplam = 0;
                
                for(int j = 0; j < harfler.Length; j++)
                {
                    if ((harfler[i] == harfler[j]) && (enBuyukHarf != harfler[i]))
                    {
                        toplam++;
                    }
                }

                if (toplam > enBuyukHarfSayisi )
                {
                    enBuyukHarfSayisi = toplam;
                    enBuyukHarf = harfler[i];
                }
                else if(toplam == enBuyukHarfSayisi)
                {
                    enBuyukEsitHarflerSayisi = toplam;
                }
            }
            if (enBuyukHarfSayisi > enBuyukEsitHarflerSayisi)
            {
                Console.WriteLine("En çok tekrar eden harf: {0}", enBuyukHarf);
                Console.WriteLine("En çok tekrar eden harf sayısı: {0}", enBuyukHarfSayisi);
            }
            else
            {
                Console.WriteLine("En çok tekrar eden sayı bulunamadı");
            }
            Console.ReadLine();
        }
    }
}
