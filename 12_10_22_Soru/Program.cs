using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_10_22_Soru
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Banka Seçiniz.");
            Console.WriteLine("1.İş Bankası");
            Console.WriteLine("2.Ziraat Bankası");
            Console.WriteLine("3.Yapıkredi");

            int bank = Convert.ToInt32(Console.ReadLine());


            if (bank == 1)
            {
                Console.WriteLine("İş Bankasına Hg.");
            }
            else if (bank == 2)
            {
                Console.WriteLine("Ziraat Bankasına Hg.");
            }
            else if (bank == 3)
            {
                Console.WriteLine("Yapıkredi'ye Hg.");
            }
            Console.WriteLine("Kredi Türünü seçiniz");
            Console.WriteLine("1.Bireysel Kredi");
            Console.WriteLine("2.Kurumsal Kredi");
            int tur = Convert.ToInt32(Console.ReadLine());

            if (tur == 1)
            {
                double kalanfaiz = 0, odeme = 0, hesaplama = 0, vade = 0;
                Console.WriteLine("Bankamızın faiz oranı 1.9'dur");
                
                Console.WriteLine("Aylık Vade girin");
                int ay = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Almak istediğiniz miktarı girin");
                double kredi = Convert.ToDouble(Console.ReadLine());
                hesaplama = kredi + (kredi * ay * 1.9 / 120);
                
                Console.WriteLine("Faizli ödemeniz gereken: " + hesaplama);
                double taksit;
                taksit = hesaplama / ay;


                Console.BackgroundColor = ConsoleColor.DarkBlue;
                for (int i = 0; i < ay; i++)
                {
                    Console.WriteLine("Krediyi kapatmak istiyor musunuz ? - Kapatmak için 1 , ödemeye devam etmek için 2 'ye basın");

                    int bitir = Convert.ToInt32(Console.ReadLine());



                    if (bitir == 2)
                    {
                        taksit = taksit - (taksit * 0.19);
                        Console.WriteLine("Aylık taksit tutarı =" + hesaplama / ay);
                        Console.WriteLine($"{i + 1}.Faiz tutarı = " + taksit);
                        Console.WriteLine("Anapara =" + (hesaplama / ay - taksit));
                    }
                    else if (bitir == 1)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Krediniz kapanmıştır. Ödemeniz gereken kalan toplam tutar : " + (hesaplama - (taksit*(i+1))));
                        i++;
                        break;
                    }
                   
                }



            }
            else if (tur == 2)
            {
                Console.WriteLine("Kullanıcı adı girin");
                string id = Convert.ToString(Console.ReadLine());
                Console.WriteLine("şifre girin");
                int pw = Convert.ToInt32(Console.ReadLine());

                double hesaplama = 0, vade = 0, taksit;
                Console.WriteLine("Bankamızın faiz oranı 1.9'dur");
                Console.WriteLine("Almak istediğiniz miktarı girin");
                double kredi = Convert.ToDouble(Console.ReadLine());
                hesaplama = kredi + (kredi * vade * 1.9 / 120);
                Console.WriteLine("Aylık Vade girin");
                int ay = Convert.ToInt32(Console.ReadLine());

                //taksit miktarı hesaplama
                taksit = hesaplama / ay;

                for (int i = 0; i < ay; i++)
                {
                    Console.WriteLine("Krediyi kapatmak istiyor musunuz ? - Kapatmak için 1 , ödemeye devam etmek için 2 'ye basın");

                    int bitir = Convert.ToInt32(Console.ReadLine());

                    

                    if (bitir == 2)
                    {
                        taksit = taksit - (taksit * 0.19);
                        Console.WriteLine("Aylık taksit tutarı =" + hesaplama / ay);
                        Console.WriteLine($"{i + 1}.Faiz tutarı = " + taksit);
                        Console.WriteLine("Anapara =" + (hesaplama / ay - taksit));
                    }
                    else if (bitir ==1 )
                    {
                        Console.WriteLine("Ödemeniz gereken tutar" + (hesaplama / ay - taksit));
                    }
                }

            }


            Console.ReadLine();
        }
    }
}
