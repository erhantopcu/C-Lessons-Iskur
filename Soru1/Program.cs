using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru1
{
    //Klavyeden girilen sayının 0 dan farklı olup olmadıgını bulun.
    internal class Program
    {
        //public void Kontrol1()
        //{

        //    Console.WriteLine("Sayı 1 Girin");
        //    int sayi = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Sayı 2 Girin");
        //    int sayi1 = Convert.ToInt32(Console.ReadLine());

        //    if (sayi == 0 && sayi1==0)
        //    {
        //        Console.WriteLine("Sayin 0'dır");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Sayin 0 değildir sayıların toplamı : "+ (sayi + sayi1));
        //    }

        //    Console.ReadLine();
        //}
        private static void KontrolEt(int sayi)
        {
            if (sayi == 0)
            {
                Console.WriteLine("sıfırdan farklı sayı girin: ");
                sayi = Sayi1Getir();
                KontrolEt(sayi);
            }
            if (sayi == -1)
            {
                sayi = Sayi1Getir();
                KontrolEt(sayi);
            }
            else
            {
                Console.WriteLine("girilen syi : " + sayi);
                int sayi2 = Sayi2Getir();
                if(sayi2== 0)
                {
                    Console.WriteLine("sıfırdan farklı bi sayi girin: ");
                    sayi2 = Sayi2Getir();
                    KontrolEt(sayi2);
                }
                if (sayi == -1)
                {
                    sayi2 = Sayi2Getir();
                    KontrolEt(sayi2);
                }
                else
                {
                    Console.WriteLine("2. Sayi =" + sayi2);
                    int toplam = sayi + sayi2;
                    Console.WriteLine("Sonuc deger= " + toplam);
                    Console.ReadLine();
                }
            }
        }

        private static int Sayi2Getir()
        {
            int girilen2 = -1;
            try
            {
                Console.WriteLine("2.Sayi giriniz : ");
                girilen2 = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hatali giriş");
            }
            return girilen2;
        }
        private static int Sayi1Getir()
        {
            int girilen = -1;
            try
            {
                Console.WriteLine("1.Sayi giriniz : ");
                girilen = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.WriteLine("Hatali giriş");
            }
            return girilen;
        }
       
        

        static void Main(string[] args)
        {
            //Program prg = new Program();
            int sayi = Sayi1Getir();
            KontrolEt(sayi);
            //prg.Kontrol1();
            
        }
    }
}
