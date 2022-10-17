using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_10_2022_Soru2
{
    internal class Program
    {
        //Bir otoparka park eden taksinin 1 saati 5TL, minibüsün 1 saati 6TL, ticari aracın 1 saati 6.5TL dir. Taksi 1 saatten sonraki her saat başı için %20 daha fazla, minibüs 1 saatten sonraki her saat başı için toplamda %21.5 ve ticari araç 1 saatten sonraki her saat başı için toplamda %25 daha fazla ödeme yapmaktadır. Buna göre klavyeden girilen araba tipi ve kalınan saat bilgisi girildikten sonra ekrana ödenecek otopark ücretini hesaplayan programın kodlarını yazınız.
        static void Main(string[] args)
        {

            double toplamTutar = 0;
            int sure = 0;
            int aracTipi = 0;

        basa:

            try
            {
                Console.WriteLine("Araç Tipleri Taksi : 1, Minübüs : 2, Ticari : 3");
                Console.Write("Lütfen Araç Tipini Giriniz : ");
                aracTipi = Convert.ToInt32(Console.ReadLine());
                Console.Write("Kalan Süreyi Giriniz : ");
                sure = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine(" Hata");

            }
            if (sure > 1)
            {
                if (aracTipi == 1)
                {
                    toplamTutar = toplamTutar + (sure * 5 * 1.20);
                }
                else if (aracTipi == 2)
                {
                    toplamTutar = toplamTutar + (sure * 6 * 1.215);
                }
                else if (aracTipi == 3)
                {
                    toplamTutar = toplamTutar + (sure * 6.5 * 1.25);
                }
            }
            else
            {
                if (aracTipi == 1)
                {
                    toplamTutar = toplamTutar + (sure * 5);
                }
                else if (aracTipi == 2)
                {
                    toplamTutar = toplamTutar + (sure * 6);
                }
                else if (aracTipi == 3)
                {
                    toplamTutar = toplamTutar + (sure * 6.5);
                }
            }
            Console.WriteLine("Tutar " + toplamTutar + " TL");
            goto basa;
            Console.ReadLine();
        }

    }

}




