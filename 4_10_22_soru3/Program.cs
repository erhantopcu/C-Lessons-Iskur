using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_10_22_soru3
{
    internal class Program
    {
        static bool AsalSayi(int sayi)
        {
            bool sonuc;
            int sayac = 0;

            for (int i = 1; i <= sayi; i++)
            {
                if (sayi % i == 0)
                {
                    sayac += 1;
                }
            }

            if (sayac == 2)
            {

                sonuc = true;
            }
            else
            {
                sonuc = false;
            }
            return sonuc;

        }

        static void Main(string[] args)
        {
            //parametre olarak yollanan bir sayının asal sayı olup olmadıgını geriye döndüren bir metot yazınız. Eğer sayı asal ise geriye "true" değil ise "false degeri döndürülecektir.

            bool sonuc = AsalSayi(29);
            if (sonuc) Console.WriteLine("Asal Sayi");
            else Console.WriteLine("Asal değil");
            Console.ReadLine();
        }
    }
}
