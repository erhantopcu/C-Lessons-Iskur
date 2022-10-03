using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_10_22_Soru2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // elemanları tam sayı olan bir a dizisinin (20 elemanlı) rastgale sayıları atayan, sonra dizi elemanlarının aritmatik ortalamasın
            //hesaplayan ve elemanlardan kac tanesinin bu elemanlardan küçük ve büyük olduğınu yazın.
           
            int[] dizi = new int[20];
            Random rnd = new Random();
            int diziToplami = 0, ortalamadanBuyuk = 0, ortalamadanKucuk = 0;
            double diziOrtalamasi = 0;

            for (int i = 0; i < dizi.Length; i++)
            {
                
                dizi[i] = rnd.Next(1, 50);

                diziToplami += dizi[i]; // diziToplami = diziToplami+ dizi[i];

                Console.WriteLine($"{i+1}. Sayı :" + dizi[i]);
                
            }
            Console.WriteLine("Toplam : " + diziToplami);

            diziOrtalamasi = diziToplami / 20;

            foreach (int var in dizi)
            {
                if (var > diziOrtalamasi)
                {
                    ortalamadanBuyuk = ortalamadanBuyuk + 1;
                }

                else
                {
                    ortalamadanKucuk += 1;
                }

            }
            Console.WriteLine("Ortalama : " + diziOrtalamasi);
            Console.WriteLine("büyük : " + ortalamadanBuyuk);
            Console.WriteLine("küçük : " + ortalamadanKucuk);
            Console.ReadLine();

        }
    }
}
