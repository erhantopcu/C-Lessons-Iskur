using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region veriTipleri
            //double sayi = 13.4;
            //Console.WriteLine(sayi);
            //Console.ReadKey();
            //int sayi1;
            //int sayi2;
            //int toplam = 0;
            //Console.WriteLine("lütfen 1. sayıyı giriniz");
            //sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("lütfen 1. sayıyı giriniz");
            //sayi2 = Convert.ToInt32(Console.ReadLine());

            //toplam = sayi1 + sayi2;
            //Console.WriteLine(toplam);
            //Console.ReadKey();

            //string str;
            //Console.WriteLine("lütfen bir cümle girin");
            //str = Convert.ToString(Console.ReadLine());
            //Console.WriteLine(str);
            //Console.ReadKey();

            //float sayi1;
            //float sayi2;
            //float toplam = 0f;
            //Console.WriteLine("lütfen 1. sayıyı giriniz");
            //sayi1 = float.Parse(Console.ReadLine());
            //Console.WriteLine("lütfen 2. sayıyı giriniz");
            //sayi2 = float.Parse(Console.ReadLine());

            //toplam = sayi1 + sayi2;
            //Console.WriteLine(toplam);
            //Console.ReadKey();

            //char chr;
            //Console.WriteLine("lütfen bir harf girin");
            //chr = Convert.ToChar(Console.ReadLine());
            //Console.WriteLine(chr);

            //Console.ReadKey();

            //float sayi1 = 12.3f;
            //float sayi2 = 15.9f;
            //float toplam = 0f;

            //toplam = sayi1 + sayi2;
            //Console.WriteLine(toplam);
            //Console.ReadKey();
            #endregion

            #region Operatörler
            //// = atama
            //int sayi = 5;

            //sayi = sayi + 1;

            //if (sayi ==9)
            //{
            //    Console.WriteLine("doğru");
            //}
            //else
            //{
            //    Console.WriteLine("yanlış");
            //}

            //Console.ReadLine();

            #endregion

            #region Tekrar

            //Aritmatik Operatörler

            //int sayi;
            //sayi = Convert.ToInt32(Console.ReadLine());
            //if(sayi%2 == 0)
            //{
            //    Console.WriteLine("{0} sayi çifttir", sayi);
            //}
            //else
            //{
            //    Console.WriteLine("{0} sayi tektir,", sayi);
            //}

            //Arttırma ve Azaltma

            //int sayi1 = 10;
            //int sayi2 = 15;

            ////sayi1 = sayi1+ sayi2;
            //sayi1 = ++sayi1;
            //Console.WriteLine(sayi1);
            //Console.ReadLine();



            #endregion

            #region Örnek1


            //int say1;


            //Console.WriteLine("İlk Sayı");
            //say1 = Convert.ToInt32(Console.ReadLine());


            //if (say1 % 2 == 0 && say1 !=2)
            //{
            //    Console.WriteLine("Sayi asal değidir");
            //}
            //else
            //{
            //    Console.WriteLine("Asal");
            //}
            //Console.ReadLine();


            #endregion

            #region Karar Yapıları
            //int sayi;
            //sayi = Convert.ToInt32(Console.ReadLine());
            //if (sayi % 2== 0)
            //    Console.WriteLine("{0} sayi çifttir", sayi);

            //else
            //{
            //    Console.WriteLine("Tek");

            //}
            //Console.ReadLine();
            #endregion

            #region Örnek2
            // klavyede girilen bir sayının negatif veya pozitif
            ////ab:
            ////int say;
            ////say = Convert.ToInt32(Console.ReadLine());
            ////if (say >= 0)
            ////{
            ////    Console.WriteLine("Sayı Pozitif");
            ////}
            ////else
            ////{
            ////    Console.WriteLine("Sayı Negatif");
            ////}

            ////goto ab;
            #endregion

            #region Örnek3

            //int kenar1;
            //int cevre;


            //kenar1 = Convert.ToInt16(Console.ReadLine());

            //cevre = kenar1 * 4;
            //kenar1 = kenar1 * kenar1;

            //Console.WriteLine(" Karenin alanı {0}.", kenar1);
            //Console.WriteLine(" Karenin çevresi {0}.", cevre);
            //Console.ReadLine();
            #endregion

            #region Örnek4-Diktörtgen Alan ve Çevresi

            //int kenar1;
            //int kenar2;
            //int cevre;
            //int alan;

            //Console.WriteLine("İlk kenarı girin");
            //kenar1 = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine("İkinci kenarı girin");
            //kenar2 = Convert.ToInt16(Console.ReadLine());

            //cevre = (kenar1 + kenar2) * 2;
            //alan = kenar1 * kenar2;

            //Console.WriteLine(" Dikdörtgen alanı {0}.", alan);
            //Console.WriteLine(" Dikdörtgen çevresi {0}.", cevre);
            //Console.ReadLine();
            #endregion

            #region Örnek5
            //bir manav bölümünde satılan elma, armut ve muz - elma=3TL armut  = 5TL muz=7TL 
            //kilogram fiyatlarına göre müşterinin üründen ne kadar alınmak istediği ödeyeceği ücreti belirlenmesi

            int elma=3;
            int armut=5;
            int muz=7;

            Console.WriteLine("Ne alırsınız?");
            string secim;
            secim = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Kac Kilo alırsınız");
            int kilo;
            kilo = Convert.ToInt32(Console.ReadLine());
            

            if (secim == "elma")
            {
                Console.WriteLine("Vereceğiniz ücret " + elma * kilo + " TL");
            }
            else if (secim == "armut")
            {
                Console.WriteLine("Vereceğiniz ücret " + armut * kilo + " TL");

            }
            else if (secim == "muz")
            {
                Console.WriteLine("Vereceğiniz ücret " + muz * kilo + " TL");
            }
            else
            {
            }

            Console.ReadLine();
            
            //Ödev 0 ile 50 arasındaysa yüzde 10 indirim uygulayın. eğer 50 ile 100 arasındaysa yüzde15 indirim
            // 100 üzerinde ise yüzde20 indirim uygulayın.
            #endregion
        }

    }

}
