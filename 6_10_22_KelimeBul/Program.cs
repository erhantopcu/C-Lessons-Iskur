using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_10_22_KelimeBul
{
    internal class Program
    {
        //string KelimeBul(string cumle, int kelimeSirasi) adında bir metot tanımlanacaktır. Metot a parametre olarak bir cümle ve bir sayi yollanacaktır. Metot geriye cümlenin istenilen sıradaki kelimesini geri döndürecektir.B Özelliklerde KelimeBul adında bir metot tanımlaynız.
        public static string KelimeBul(string cumle,int kelimeSirası)
        {
            string don = "";
            kelimeSirası -= 1;
            string[] kelimeler = cumle.Split(' ');
            Console.WriteLine(kelimeler[kelimeSirası]);
            return don;
        }
        static void Main(string[] args)
        {
            KelimeBul("Merhabalar ben erhan ", 1);
            Console.ReadLine();
        }
    }
}
