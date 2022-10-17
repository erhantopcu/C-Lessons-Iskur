using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_10_22_Soru3
{
    internal class Program
    {//20 öğrenciye ait vize ve final bilgilerirastgele atandıktan sonra, her bir öğrencinin ortalamasını hesaplanacak ve ekrana eger öğrenci 70 ve üzeri ise geçti degilse kaldı programı cok boyutlu dizi.

        public void Notlar()
        {

            //int rastgeleVizeNot;
            //int rastgeleFinalNot;
            //double ortalama;
            //int[] dizi = new int[20];
            //Random rand = new Random();

            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    rastgeleVizeNot = rand.Next(0, 100);
            //    rastgeleFinalNot = rand.Next(0, 100);
            //    ortalama = (rastgeleFinalNot + rastgeleVizeNot) / 2;

            //    if(ortalama >= 70)
            //    {

            //        Console.WriteLine("VizeNotu: " + rastgeleVizeNot+ " FinalNotu: "+ rastgeleFinalNot +" Ortalama : " + ortalama + " : Gecti");
            //    }
            //    else { Console.WriteLine("VizeNotu : " + rastgeleVizeNot + " FinalNotu : " + rastgeleFinalNot + " Ortalama : " + ortalama + " : Kaldı"); }

            int[,] dizi = new int[20, 2];
            Random r = new Random();
            for (int i = 0; i < dizi.GetLength(0); i++)
            {
                dizi[i, 0] = r.Next(0, 101); // vize 
                dizi[i, 1] = r.Next(0, 101); // final
                int ortalama = (dizi[i, 0] + dizi[i, 1]) / 2;
                string sonuc = " Geçti";
                if (ortalama < 70)
                {
                    sonuc = "Kaldı";
                }
                Console.WriteLine($"{i+1}. Öğrenci Vize Notu: {dizi[i,0]} Final Notu: {dizi[i,1]} Ortalama : { ortalama} Sonuc: {sonuc}");
            }
            
        }
        static void Main(string[] args)
        {
            Program prg =new Program(); 
            prg.Notlar();
            Console.ReadLine();
        }
    }
}
