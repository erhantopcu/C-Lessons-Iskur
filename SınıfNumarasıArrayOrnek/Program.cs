using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SınıfNumarasıArrayOrnek
{
    internal class Program
    {
    //    public void Random()
    //    {

    //        string[] siraIsmı = { "Berkcan", "Erhan", "Sena", "Büşra", "Burak", "Mert", "m.Kutlu", "Mısra", "Devrim", "Muhammet", "Bedirhan", "Salih", "Cihat", "İlker" };
    //        int uretilen = 0;
    //        Random rnd = new Random();

    //        while (uretilen != 0)
    //        {
    //            int index = rnd.Next(siraIsmı.Length);
    //            if (!siraIsmı.Contains(siraIsmı[index]))
    //            {
    //                siraIsmı[uretilen] = index;
    //                uretilen++;
    //            }
    //        }
    //        foreach (int item in siraIsmı)
    //        {
    //            Console.WriteLine("Rastgele isim seçildi isim :" + siraIsmı[index]);
    //        }
    //        //Console.WriteLine("Rastgele isim seçildi isim :" + siraIsmı[index]); //$"Rastgele isim seçildi isim :  {siraIsmı[index]}"

    //    }
    //    static void Main(string[] args)
    //    {
    //        Program prg = new Program();
    //        prg.Random();
    //        Console.ReadLine();
    //    }
       // }
        private void Randomdizi()//metot ile yapıldı.
        {
            string[] isimler = { "Sena", "büşra", "Erhan", "Mertk", "Mertt", "Mısra", "Devrim", "bedirhan", "salih", "Muhammet Bedir", "Devrim" };
            Random rnd = new Random();
            string[] isimler2 = new string[isimler.Length];

            for (int i = 0; i < isimler.Length; i++)
            {

                int rastgele = rnd.Next(0, isimler.Length);
                if (isimler2.Contains(isimler[rastgele]))
                {
                    i--;
                }
                else
                {
                    isimler2[i] = isimler[rastgele];
                    Console.WriteLine(isimler[rastgele]);

                }  
            }
            for (int j = 3; j < isimler.Length ; j++)
            {
                Console.WriteLine(" ");
            }
            foreach (var aa in isimler)
            {
                //Dizinin tüm eleman sayılarını yazdırıyor
                Console.WriteLine(aa);
            }


        }
        static void Main(string[] args)
        {
            // 0 ile 15 arası diziler ile random atama
            Program prg = new Program();
            prg.Randomdizi();
            Console.ReadLine();
        }
        //Her üç grupta bir boşluk

    }
}
