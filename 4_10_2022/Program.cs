using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_10_2022
{
    internal class Program
    {
        //aynı firmada calısan ahmet ve hasan, ahmetin aylık ücreti 1 ay yüzde 50 artmakta sonraki ay yüzde 25 azalmaktadır.
        //hasanın ücreti ise ücreti her ay yüzde 25 artmaktadır . her ikisinin de yılbaşı başlangıc ücretleri ve hesaplanacak ay bilgisi
        //klavyeden girildikten sonra ay ay ücretlerinin ne olacagını ve en sonunda hangi işçinin daha fazla veya eşit ücret alacagını hesaplayan bi program.
        static void Main(string[] args)
        {
            double baslangicMaas1;
            double baslangicMaas2;
            int ay;
            Console.WriteLine("Ay' ı girin : ");
            ay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ahmet'in yılbası baslangıc maas ücretini girin");
            baslangicMaas1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" BAŞLANGIC MAASI : " + baslangicMaas1);
            for (int i = 1; i <= ay; i++)
            {
                if (i % 2 == 0)
                {
                    baslangicMaas1 = baslangicMaas1 + (baslangicMaas1 * 1 / 2);
                }
                else
                {
                    baslangicMaas1 -= baslangicMaas1 * 1 / 4;
                }
                Console.WriteLine($"{i}. ay maaş :" + baslangicMaas1);
            }
            Console.WriteLine("Hasan'ın yılbası baslangıc maas ücretini girin");
            baslangicMaas2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("BAŞLANGIC MAASI : "+ baslangicMaas2 );
            for (int k = 1; k <= ay; k++)
            {
                baslangicMaas2 += baslangicMaas2 * 1 / 2;
                Console.WriteLine($"{k}. ay maaş :" + baslangicMaas2);
            }
            if(baslangicMaas1 > baslangicMaas2)
            {
                Console.WriteLine(" Ahmet Hasandan fazla alıyor");
            }
            else
            {
                Console.WriteLine(" Hasan Ahmetten fazla alıyor.");
            }
            Console.ReadLine();
        }
    }
}
