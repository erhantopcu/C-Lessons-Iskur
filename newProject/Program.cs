﻿using System;
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
            ////bir manav bölümünde satılan elma, armut ve muz - elma=3TL armut  = 5TL muz=7TL 
            ////kilogram fiyatlarına göre müşterinin üründen ne kadar alınmak istediği ödeyeceği ücreti belirlenmesi

            //int elma=3;
            //int armut=5;
            //int muz=7;

            //Console.WriteLine("Ne alırsınız?");
            //string secim;
            //secim = Convert.ToString(Console.ReadLine());
            //Console.WriteLine("Kac Kilo alırsınız");
            //int kilo;
            //kilo = Convert.ToInt32(Console.ReadLine());


            //if (secim == "elma")
            //{
            //    Console.WriteLine("Vereceğiniz ücret " + elma * kilo + " TL");
            //}
            //else if (secim == "armut")
            //{
            //    Console.WriteLine("Vereceğiniz ücret " + armut * kilo + " TL");

            //}
            //else if (secim == "muz")
            //{
            //    Console.WriteLine("Vereceğiniz ücret " + muz * kilo + " TL");
            //}
            //else
            //{
            //}

            //Console.ReadLine();

            ////Ödev 0 ile 50 arasındaysa yüzde 10 indirim uygulayın. eğer 50 ile 100 arasındaysa yüzde15 indirim
            //// 100 üzerinde ise yüzde20 indirim uygulayın.
            #endregion

            #region Örnek-Notlar
            ////1. sınav 2. sınav proje not ortalaması hesaplama
            ////1. sınav yüzde 30 - 2.sınav yüzde 50 - proje yüzde 20
            //// ortalama 0-50 kaldı / 50-70 geçti / 70-100 çok iyi

            //int ilkSinav;
            //int ikinciSinav;
            //int proje;
            //int puan;
            //ab:


            //Console.WriteLine("İlk Sınav Notu");
            //ilkSinav = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine("İkinci Sınav Notu");
            //ikinciSinav = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine("Proje Notu");
            //proje = Convert.ToInt16(Console.ReadLine());

            //puan = ilkSinav * 30 / 100 + ikinciSinav * 50/100 + proje*20/100;
            //Console.WriteLine("puanı :" + puan);

            //if(ilkSinav>100 || ikinciSinav>100 || proje>100 || ilkSinav<100 || ikinciSinav<100 || proje < 100)
            //        {
            //    Console.WriteLine("YANLIS NOT");
            //    goto ab;
            //}
            //    else if (puan >= 0 && puan <= 50)
            //    {
            //        Console.WriteLine("Kaldı");
            //    }
            //    else if (puan > 50 && puan <= 70)
            //    {
            //        Console.WriteLine("geçti");
            //    }
            //    else if (puan < 70 && puan >= 100)
            //    {
            //        Console.WriteLine("çok iyi");
            //    }

            //Console.ReadLine();

            ////string mevsim;
            ////string kis, ilkbahar, sonbahar, yaz;


            ////Console.WriteLine("Lütfen mevsim giriniz");
            ////mevsim = Convert.ToString(Console.ReadLine());


            ////if (mevsim == "Kış")
            ////{
            ////    Console.WriteLine("ocak, şubat , aralık");
            ////}
            ////else if (mevsim == "Yaz")
            ////{
            ////    Console.WriteLine("haziran, temmuz, ağustos");
            ////}

            ////else if (mevsim == " İlkbahar")
            ////{
            ////    Console.WriteLine( "mart , nisan , mayıs");
            ////}
            ////else if (mevsim == " Sonbahar")
            ////{
            ////    Console.WriteLine( "eylül, ekim , kasım");
            ////}
            ////Console.ReadLine();
            #endregion

            #region switch

            //string deger = Convert.ToString(Console.ReadLine());
            //switch (deger)
            //{
            //    case "salih":
            //        Console.WriteLine("Hg");
            //        break;
            //        case "cihat":
            //        Console.WriteLine("Hg");
            //        break;
            //        case "mehmet":
            //        Console.WriteLine("Hg");
            //        break;
            //        case "ahmet":
            //        Console.WriteLine("Hg");
            //        break;
            //    default:
            //        Console.WriteLine("Sen kimsin");
            //        break;

            //}
            //Console.ReadLine();

            //string mevsim = Convert.ToString(Console.ReadLine());
            //switch (mevsim)
            //{
            //    case "Ilkbahar":
            //        Console.WriteLine("Mart, Nisan , Mayıs");
            //        break;
            //    case "Yaz":
            //        Console.WriteLine("Haziran, Temmuz, Ağustos");
            //        break;
            //    case "Sonbahar":
            //        Console.WriteLine("Eylül, Ekim, Kasım");
            //        break;
            //    case "Kıs":
            //        Console.WriteLine("Aralık, Ocak, Şubat");
            //        break;
            //    default:
            //        Console.WriteLine("Yanlış girdiniz");
            //        break;

            //}
            //Console.ReadLine();

            //string gunler = Convert.ToString(Console.ReadLine());
            //switch (gunler)
            //{
            //    case "1":
            //        Console.WriteLine("Pazartesi");
            //        break;
            //    case "2":
            //        Console.WriteLine("Salı");
            //        break;
            //    case "3":
            //        Console.WriteLine("Çarşamba");
            //        break;
            //    case "4":
            //        Console.WriteLine("Perşembe");
            //        break;
            //    case "5":
            //        Console.WriteLine("Cuma");
            //        break;
            //    case "6":
            //        Console.WriteLine("Cumartesi");
            //        break;
            //    case "7":
            //        Console.WriteLine("Pazar");
            //        break;
            //    default :
            //        Console.WriteLine("Yanlış girdiniz");
            //        break ;
            //}

            //Console.ReadLine();
            #endregion

            #region switch case 4 işlem
            Console.WriteLine("Değer 1");
            int sayi1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Değer 2");
            int sayi2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Hangi işlemi yapıcağınızı seçin");
            string islem = Convert.ToString(Console.ReadLine());

            switch (islem)
            {
                case "Toplam":
                    Console.WriteLine("Toplam Değer", sayi1 + sayi2);
                    break;
                case "Çıkarma":
                    Console.WriteLine("Çıkarma Sonuç", sayi1 - sayi2);
                    break;
                case "Bölme":
                    Console.WriteLine("Bölme Sonuç", sayi1 / sayi2);
                    break;
                case "Çarpma":
                    Console.WriteLine("Çarpma Sonuç", sayi1 * sayi2);
                    break;

                default:
                    Console.WriteLine("Deger Yok");
                    break;

            }
            Console.ReadLine();
            #endregion

        }

    }
}
