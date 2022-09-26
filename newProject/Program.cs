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
            //Console.WriteLine("Değer 1");
            //int sayi1 = Convert.ToInt16(Console.ReadLine());

            //Console.WriteLine("Değer 2");
            //int sayi2 = Convert.ToInt16(Console.ReadLine());

            //Console.WriteLine("Hangi işlemi yapıcağınızı seçin");
            //string islem = Convert.ToString(Console.ReadLine());

            //switch (islem)
            //{
            //    case "Toplam":
            //        Console.WriteLine("Toplam Değer", sayi1 + sayi2);
            //        break;
            //    case "Çıkarma":
            //        Console.WriteLine("Çıkarma Sonuç", sayi1 - sayi2);
            //        break;
            //    case "Bölme":
            //        Console.WriteLine("Bölme Sonuç", sayi1 / sayi2);
            //        break;
            //    case "Çarpma":
            //        Console.WriteLine("Çarpma Sonuç", sayi1 * sayi2);
            //        break;

            //    default:
            //        Console.WriteLine("Deger Yok");
            //        break;

            //}
            //Console.ReadLine();
            #endregion

            #region Ödev2
            // ödev 
            //111112222333445   
            //555554444333221 çıktı bu olucak

            //int say = Convert.ToInt16(Console.ReadLine());

            //for (int i = 1; i <= say; i++)
            //{

            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write(i);
            //    }
            //}
            //Console.ReadLine();
            #endregion

            #region 23.09.2022

            #region Örnekler

            //int sayi = 50, toplam = 0;

            //for (int i = 0; i < sayi; i++)
            //{
            //    toplam += i;
            //}
            //Console.WriteLine(toplam);

            //Console.ReadLine();

            //**************** Tek sayılar toplamı
            //int sayi = 50, toplam = 0;

            //for (int i = 1; i < sayi; i+=2)
            //{
            //    toplam +=i ;
            //}
            //Console.WriteLine(toplam);

            //Console.ReadLine();

            //**************** 77 nin 9a tam bölünenleri

            //for (int i = 1; i < 77; i++)
            //{
            //    if (i % 9 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.ReadLine();

            //****************Fibonacci
            //int a = 1;
            //int b = 1;
            //int c;

            //Console.Write("1" + " 1");
            //for(int i = 1; i <= 10; i++)
            //{
            //    c = a + b;
            //    a = b;
            //    b = c;

            //    Console.Write(" "+ c);
            //}

            //Console.ReadLine(); 

            //******************* Asal Sayıların Çıktısı

            //int durum = 0; //bool durum= true;
            //Console.WriteLine("Sayı Girin");
            //int sayi = Convert.ToInt16(Console.ReadLine());

            //for (int i = 2; i < sayi; i++)
            //{
            //    if (sayi % i == 0)
            //    {
            //        durum++; // bool durum = false;
            //    }
            //}
            //if (durum != 0) // if(durum) ==> asaldır.
            //    Console.WriteLine("Girdiğiniz sayı asal değildir.");
            //else
            //    Console.WriteLine("Girdiğiniz sayı asaldır.");
            //Console.ReadLine();
            //}

            //**************** 555554444333221

            //for (int i = 5; i > 0; i--)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write(i);
            //    }

            //}

            //**************** 1111122223334455

            //for ( int i=1; i>6; i++)
            //{
            //    for (int j = 6; j > 1; j--)
            //    {
            //        Console.Write(i);
            //    }
            //}

            //**************** 1-100 arasındaki asal sayıların toplamları- alttaki cevap eksik
            //int toplam = 0;
            //bool durum = true;
            //int sayi = 100;
            //for (int i = 2; i < sayi; i++)
            //{
            //    for (int j = 2; j < i; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            durum = false;

            //        }
            //    }

            //    if (durum)
            //    {
            //        toplam = toplam + i;
            //    }

            //}
            //Console.WriteLine(toplam);

            //Console.ReadLine();

            #endregion

            #region while döngüsü

            //int topla=0;
            //int j=0;
            //while (j<10)
            //{
            //    topla = topla + j;
            //    j++;
            //}  
            //    Console.WriteLine(topla);

            //Console.ReadLine();


            //********* 1'den 10a kadar tek sayı

            //int topla = 0;
            //int j = 1;
            //while (j < 10)
            //{

            //    topla = topla + j;
            //    Console.WriteLine(j);
            //    j = j +2;

            //}
            //Console.WriteLine(topla);

            //Console.ReadLine();

            //int sayi;
            //int fac = 1;
            //Console.WriteLine("Sayı girin");
            //sayi = Convert.ToInt16(Console.ReadLine());

            //while (sayi > 1)
            //{

            //    fac = fac * sayi;
            //    sayi--;
            //}
            //Console.WriteLine(fac);
            //Console.ReadLine();

            #endregion

            #region DİZİLER
            //Aynı türden değişkenlerin bir arada bulundugu saklanma alanı dizidir.

            //*/******* Tek boyutlu diziler

            //int[] sayilar = {5,6,7,8,9 };


            //sayilar[0] = 5;
            //sayilar[1] = 6;
            //sayilar[2] = 7;
            //sayilar[3] = 8;
            //sayilar[4] = 9;


            //Console.WriteLine(sayilar.Length);

            //char[] sayilar = { 'a', 'b', 'c' };
            //Console.WriteLine(sayilar[0]);
            //Console.ReadLine();

            //Bir dizi tanımla int olarak. klavyeden sor kaç elemanlı olsun. sonra tekrar sorsun.

            ////Console.WriteLine("Kaç elemanlı olsun");

            //int[] sayi;

            ////int deger = Convert.ToInt32(Console.ReadLine()); // dizi boyutu belirliyoruz

            ////int[] sayi = new int[deger]; //dizinin boyutunu belirliyoruz

            ////for (int i = 0; i < deger; i++)
            ////{
            ////    Console.WriteLine(i + ".ci elemanı gir."); //dizi elemanlarını belirliyoruz.
            ////    int eleman = Convert.ToInt16(Console.ReadLine());
            ////    sayi[i] = eleman;
            ////}
            ////Console.WriteLine("dizi girme işlemi tamamlandı. \n dizi elemanları");

            ////for (int j = 0; j < deger; j++)

            ////{
            ////    Console.WriteLine(sayi[j]);
            ////}
            ///

            //string[] isimler = { "ahmet", "mehmet", "kazım", "fatih" };

            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    Console.WriteLine(isimler[i]);
            //}
            //Console.ReadLine();
            #endregion

            #endregion

            #region 26.09.2022

            #region Soru1
            //   *
            //  ***
            // *****
            //*******
            // *****
            //  ***
            //   *
            //for(int i = 0; i <4; i++)
            //{
            //    Console.WriteLine(" ");
            //    for (int j = 3-i; j >0 ; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 0; k < 2*i+1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //}
            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine(" ");
            //    for (int j = 0; j <=i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 5-(i*2); k >0 ; k--)
            //    {
            //        Console.Write("*");
            //    }
            //}
            //Console.ReadLine();

            #endregion

            #region TekBoyutluDizi

            //string[] dizi = { "mehmet", "ahmet", "yusuf" };

            //Console.WriteLine("***************************");
            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    Console.WriteLine(dizi[i]);
            //}

            //Console.WriteLine("***************************");
            //foreach (string d in dizi)
            //{
            //    Console.WriteLine(d);
            //}

            //Console.WriteLine("***************************");
            //Console.WriteLine(dizi[0]);
            //Console.WriteLine(dizi[1]);
            //Console.WriteLine(dizi[2]);

            //Console.WriteLine("***************************");

            //int j = 0;
            //while (j < dizi.Length)

            //{
            //    Console.WriteLine(dizi[j]);
            //    j++;
            //}

            //Console.ReadLine();



            //bool durum = true;
            //while(durum)
            //{
            //    string ad;
            //    Console.WriteLine("Lütfen adınızı giriniz: ");
            //    ad = Convert.ToString(Console.ReadLine());
            //    string soyad;
            //    Console.WriteLine("Lütfen soyadınızı giriniz: ");
            //    soyad = Convert.ToString(Console.ReadLine());
            //    Console.WriteLine(ad + " " + soyad + " Hoşgeldiniz");

            //}
            //Console.ReadLine();
            #endregion


            #region Soru 2
            //18,5> zayıf 18,5-24,9 normal 24,9 ile 29,9 kilolu erkek-kadın için

            //bool durum = true;
            //while (durum)
            //{
            //    double index;
            //    double kilo;
            //    double boy;
            //    string cinsiyet;

            //    Console.WriteLine("Cinsiyetinizi girin");
            //    cinsiyet = (Console.ReadLine());

            //    Console.WriteLine("Lütfen kilo giriniz :");
            //    kilo = Convert.ToDouble(Console.ReadLine());

            //    Console.WriteLine("Lütfen boy giriniz :");
            //    boy = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine(index = ((kilo) / (boy * boy)) * 10000);

            //    if (index < 18.5)
            //    {
            //        Console.WriteLine("Boy Kilo index'iniz: ");
            //        Console.WriteLine(index = ((kilo) / (boy * boy)) * 10000);
            //        Console.WriteLine("Zayıfsınız");
            //    }
            //    else if (18.5 < index && index<24.9)
            //    {
            //        Console.WriteLine("Boy Kilo index'iniz: ");
            //        Console.WriteLine(index = ((kilo) / (boy * boy)) * 10000);
            //        Console.WriteLine("Kilonuz Normal");
            //    }
            //    else if (24.9 < index)
            //    {
            //        Console.WriteLine("Boy Kilo index'iniz: ");
            //        Console.WriteLine(index = ((kilo) / (boy * boy)) * 10000);
            //        Console.WriteLine("Aşırı Kilolu");
            //    }

            //    switch (cinsiyet)
            //    {
            //        case "erkek":

            //            index = index = ((kilo) / (boy * boy)) * 10000;
            //            if (index < 18.5)
            //            {
            //                Console.WriteLine("Zayıf " + index);
            //            }
            //            else if (index > 18.5 && index < 24.9)
            //            {
            //                Console.WriteLine("Normal " + index);
            //            }
            //            else
            //            {
            //                Console.WriteLine("Aşırı Kilolu " + index);
            //            }
            //            break;

            //        case "kadın":
            //            index = index = ((0.9 * kilo) / (boy * boy)) * 10000;
            //            if (index < 18.5)
            //            {
            //                Console.WriteLine("Zayıf " + index);
            //            }
            //            else if (index > 18.5 && index < 24.9)
            //            {
            //                Console.WriteLine("Normal " + index);
            //            }
            //            else
            //            {
            //                Console.WriteLine("Aşırı Kilolu " + index);
            //            }
            //            break;
            //    }
            //    break;
            //}
            //Console.ReadLine();
            #endregion

            #region fonksiyonlar
            //double sayi;
            //Console.WriteLine("Lütfen sayi");
            //sayi = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("yuvarla" + Math.Floor(sayi));
            //Console.ReadLine();

            #endregion

            #region rastgele

            //Random rastgele = new Random();
            //int b;
            //b=rastgele.Next(0,10);
            //Console.WriteLine(b);

            //Console.ReadLine();

            //Random random = new Random();
            //Console.WriteLine("atama");

            //string[] sehir = { "Istanbul", "Sakarya", "Izmıt", "Bursa", "Ankara" };
            //int a;
            //a = random.Next(0, sehir.Length);
            //Console.WriteLine(a);
            //Console.WriteLine(sehir[a]);
            //Console.ReadLine();




            #endregion

            #region ÇokBoyutluDiziler

            //string[,] dizi = { { "mehmet", "salih" }, { "ali", "veli" } };
            //string[,] dizi2 = new string[2, 2];
            //dizi2[0, 0] = "mehmet";
            //dizi2[0, 1] = "salih";
            //dizi2[1, 0] = "cihat";
            //dizi2[1, 1] = "bedir";

            ////int[,] dizi2 = new int[2, 2];
            ////dizi2[0, 0] = 2;
            ////dizi2[0, 1] = 3;
            ////dizi2[1, 0] = 4;
            ////dizi2[1, 1] = 5;

            //int[,] dizi2= { { 14, 17, 18, 12, 19 }, { 13, 17, 11, 14, 19 }, { 15, 18, 10, 14, 20 } }; //yukarının farklı bir yöntemi

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.Write( dizi2[i, j]);
            //        Console.Write(" ");
            //    }
            //    Console.WriteLine(" ");
            //}
            //Console.ReadLine();


            //int[,] dizi2 = { { 14, 17, 18, 12, 19 }, { 13, 17, 11, 14, 19 }, { 15, 18, 10, 14, 20 } };
            //int[,] dizi3 = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 } };
            //int[,] dizi4 = new int[3, 5];

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.Write(dizi2[i, j] + dizi3[i,j]);
            //        Console.Write(" ");
            //    }
            //    Console.WriteLine(" ");
            //}
            //Console.ReadLine();

            int satır;      //kullanıcı tarafından girilen satır ve sutun
            int sutun;
            
            Console.WriteLine("sutun");
            sutun = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("satır");             //kullanıcı tarafından girilen degerler
            satır = Convert.ToInt16(Console.ReadLine());
          
            int[,] dizi = new int[satır, sutun]; //dizi tanımla


            for (int i = 0; i < satır; i++) //satır sutun degeri bellekte tutuyoruz
            {
                for (int j = 0; j < sutun; j++)
                {
                    Console.WriteLine("satır {0}x{1} sutun", i+1, j+1);
                    dizi[i, j] = Convert.ToInt16(Console.ReadLine());
                    
                }
                
            }
            Console.WriteLine();

            for (int i = 0; i < satır; i++) // bellekte bulunan degerleri ekrana yazdırıyoruz
            {
                for (int j = 0; j < sutun; j++)
                {
                    Console.Write(dizi[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();


            #endregion
            #endregion


        }
    }
}

