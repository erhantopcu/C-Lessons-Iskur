using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_10_22_Soru3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4 katlı bir binanın her katında 3 daire var klavyede her dairede bulunan kisi sayısını girdikten sonra binada kaç 
            //kişi oldugunu hesaplayın.


            ////int[,] dizi = new int[4, 3];

            ////int kisi = 0;
            ////int toplam = 0;


            ////Console.WriteLine("Dairede bulunan kişi sayısı");
            ////kisi = Convert.ToInt32(Console.ReadLine());

            ////for (int i = 0; i < dizi.GetLength(0); i++)
            ////{
            ////    for (int j = 0; j < dizi.GetLength(1); j++)
            ////    {
            ////        Console.WriteLine("{0}. kat {1}. dairede oturan kisi sayisini girdiniz ", i + 1, j + 1);
            ////        kisi = Convert.ToInt32(Console.ReadLine());

            ////        toplam = toplam + kisi;
            ////    }
            ////}
            ////Console.WriteLine("Toplam kişi sayisi {0}", toplam);
            ////Console.ReadLine();


            //{
            //int kisi;
            //int toplam;

            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.WriteLine($"Lütfen {i}. kat {k} dairede kaç kişi kalıyor?");
            //        kisi = int.Parse(Console.ReadLine());
            //        toplam = toplam + kişi;

            //    }
            //    Console.WriteLine("bu binada {0} kişi kalıyor", toplam);
            //    Console.ReadLine();
            //}

            //Console.WriteLine("Cumle girin");
            //string cumle = Convert.ToString(Console.ReadLine());

            //for (int i = cumle.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(cumle[i]);

            //}
            //Console.ReadLine();

            //Klavyede girilen bir cümleyi yazdırılacak . kullanıcı bu cümle girdikten sonra enter tuşuna bastıktan sonra önce cümleyi 
            //yazdırcak daha sonra cümle tersten yazılacak. A yerine ? E yerine * I veya i yerine ise = , o ve ö yerine ise & yazılıcak.

            Console.WriteLine("Cumle girin");
            string cumle = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Griilen cümle : {0}", cumle);
            Console.Write("şifreli hali : ");
            Console.ReadKey();
            char harf;
            int sayac = 0;
            
            for (int i = cumle.Length - 1; i >= 0; i--)
            {
                harf = cumle[i];

                if (harf == 'a' || harf == 'A')
                {
                    harf = '?';
                    sayac++;
                }
                else if (harf == 'e' || harf == 'E')
                {
                    harf = '*';
                    sayac++;
                }
                else if (harf == 'i' || harf == 'I')
                {
                    harf = '=';
                    sayac++;
                }
                else if (harf == 'o' || harf == 'Ö')
                {
                    harf = '&';
                    sayac++;
                }
                else if (i == 0) Console.WriteLine("{0}", harf);

                else Console.Write("{0}", harf);

                Console.WriteLine("Toplam {0} tane harf şifrelendi"+ "{1} tanesi şifrelenmedi", sayac, cumle.Length-sayac);
                Console.Write(harf);
               
            }
            
            Console.ReadLine();
        }
    }

}

