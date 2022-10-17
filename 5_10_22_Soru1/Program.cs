using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_10_22_Soru1
{
    internal class Program
    { // kendisi hariç bütün pozitif çarpanları ( tam bölenleri) toplamı, yine kendisine eşit olan sayılara "mükemmel sayı" denir. Örneğinn +=1+2+3 ve 28= 1+2+4+7+14 gibi. Buna göre klavyeden girilen bir tamsayının mükemmel satı olup olmadıgını kontrol eden MukemmelSayi adından bir metot tanımlaynız. metot eger sayi mükemmel syi ise ekrana Mükkemmel sayidir degilse mükemmel sayi degildir yazubz. static voic MukemmelAsyi(int sayi)

        static void MukemmelSayi(int sayi)
        {
            int tamBolenToplami = 0;

            for (int i = 1; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    tamBolenToplami+=i;
                }
            }
            if (tamBolenToplami == sayi)
            {
                Console.WriteLine("Mükemmler sayi");
                    }
            else
            {
                Console.WriteLine("Mükemmel sayi degildir.");
                    }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Sayı girin: ");
            int deger = Convert.ToInt32(Console.ReadLine());
            MukemmelSayi(deger);
            Console.ReadLine();
        }
    }
}
