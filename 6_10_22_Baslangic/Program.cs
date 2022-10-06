using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_10_22_Baslangic
{
    internal class Program
    { // Klavyeden girilen 4 basamaklı bir sayıyı ekrana yazdıran SayiOku(int sayi) adında metot yazınız.
      // örnek SayiOku(9853); = dokuz bin sekiz yüz elli üç

       
        public static int SayiOku(int sayi)
        {
            int birlerBasamagı = 0;
            int onlarBasamagı = 0;
            int yuzlerBasamagı = 0;
            int binlerBasamagı = 0;
            int kalan = 0;
            string binlerOkunusu = " ", yuzlerOkunusu = " ", onlarOkunusu = " ", birlerOkunusu = " ";

            binlerBasamagı = sayi / 1000;
            if (binlerBasamagı == 1) binlerOkunusu = "bir";
            if (binlerBasamagı == 2) binlerOkunusu = "iki";
            if (binlerBasamagı == 3) binlerOkunusu = "üç";
            if (binlerBasamagı == 4) binlerOkunusu = "dört";
            if (binlerBasamagı == 5) binlerOkunusu = "beş";
            if (binlerBasamagı == 6) binlerOkunusu = "altı";
            if (binlerBasamagı == 7) binlerOkunusu = "yedi";
            if (binlerBasamagı == 8) binlerOkunusu = "sekiz";
            if (binlerBasamagı == 9) binlerOkunusu = "dokuz";
           
            kalan = sayi - binlerBasamagı * 1000;

            yuzlerBasamagı = kalan / 100;

            if (yuzlerBasamagı == 1) yuzlerOkunusu = "bir";
            if (yuzlerBasamagı == 2) yuzlerOkunusu = "iki";
            if (yuzlerBasamagı == 3) yuzlerOkunusu = "üç";
            if (yuzlerBasamagı == 4) yuzlerOkunusu = "dört";
            if (yuzlerBasamagı == 5) yuzlerOkunusu = "beş";
            if (yuzlerBasamagı == 6) yuzlerOkunusu = "altı";
            if (yuzlerBasamagı == 7) yuzlerOkunusu = "yedi";
            if (yuzlerBasamagı == 8) yuzlerOkunusu = "sekiz";
            if (yuzlerBasamagı == 9) yuzlerOkunusu = "dokuz";
           
            kalan = sayi - yuzlerBasamagı * 100;

            onlarBasamagı = kalan / 10;

            if (onlarBasamagı == 1) onlarOkunusu = "bir";
            if (onlarBasamagı == 2) onlarOkunusu = "iki";
            if (onlarBasamagı == 3) onlarOkunusu = "üç";
            if (onlarBasamagı == 4) onlarOkunusu = "dört";
            if (onlarBasamagı == 5) onlarOkunusu = "beş";
            if (onlarBasamagı == 6) onlarOkunusu = "altı";
            if (onlarBasamagı == 7) onlarOkunusu = "yedi";
            if (onlarBasamagı == 8) onlarOkunusu = "sekiz";
            if (onlarBasamagı == 9) onlarOkunusu = "dokuz";
           
            kalan = sayi - onlarBasamagı * 10;


            birlerBasamagı = kalan / 1;
            if (birlerBasamagı == 1) birlerOkunusu = "bir";
            if (birlerBasamagı == 2) birlerOkunusu = "iki";
            if (birlerBasamagı == 3) birlerOkunusu = "üç";
            if (birlerBasamagı == 4) birlerOkunusu = "dört";
            if (birlerBasamagı == 5) birlerOkunusu = "beş";
            if (birlerBasamagı == 6) birlerOkunusu = "altı";
            if (birlerBasamagı == 7) birlerOkunusu = "yedi";
            if (birlerBasamagı == 8) birlerOkunusu = "sekiz";
            if (birlerBasamagı == 9) birlerOkunusu = "dokuz";

           

            Console.WriteLine("{0} bin {1} yüz {2} {3}", binlerOkunusu, yuzlerOkunusu, onlarOkunusu, binlerOkunusu);
            return kalan;
        }
        
        static void Main(string[] args)
        {
            SayiOku(9849);
            Console.ReadLine();
        }
    }
}
