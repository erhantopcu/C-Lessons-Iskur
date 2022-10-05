using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_10_22_Soru4
{// KarelerinToplami(int sayi) adlı kendini çağıran bir metot yazınız. Metot kendisine parametre olarak yollanan sayıdan bire(1) kadar olan sayıların karelerinin toplamını bulup geri döndürecektir. Eğer parametre olarak yollanan sayı 0 veya negatif ise “Hesaplama Ġşlemi Yapılamaz.” ġeklinde bir mesajı ekrana yazdırıp geriye -1 döndürecektir.
    internal class Program
    {
        static int KarelerinToplami(int sayi)
        {
            int toplam = 0;

            if (sayi <= 0)
            {

                Console.WriteLine("Hesaplama ypaılamaz");
                toplam = -1;
            }
            else
            {
                for (int i = sayi; i > 0; i--)
                {

                    toplam += i * i;
                }
                Console.WriteLine(toplam);
            }

            return toplam;
        }

        static void Main(string[] args)
        {

            KarelerinToplami(5);
            Console.ReadLine();
        }
    }
}
