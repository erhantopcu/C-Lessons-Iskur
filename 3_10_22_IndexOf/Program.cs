using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_10_22_IndexOf
{
    internal class Program
    { //dizi oluştur sınırı 6 yap rastgele sayı olustur 1-49 arası ve o sayıya göre while kontrol et if ile de index of no eşit olmayacak
        public void SayisalOto()
        {
            int[] rastgele = new int[6];

            int sayi;
            int i = 0;

            Random random = new Random();
            while(i < 6)
            {
                sayi = random.Next(1, 49);

                if(Array.IndexOf(rastgele,sayi)== -1)
                {
                    rastgele[i] = sayi;
                    i++;
                }
            }
            Array.Sort(rastgele);
            foreach (var item in rastgele)
            {
                Console.WriteLine(item + " ");

            }
           
     
        }
        static void Main(string[] args)
        {
            //int[] sayi = new int[] { 1, 2, 3 , 4, 5, 6};
            //Console.WriteLine(Array.IndexOf(sayi , 5));
            //Console.ReadLine();

            //Array isimler = new[] { "nevval", "bedirhan", "ilker" };
            //int index = Array.IndexOf(isimler , "Bedirhan");
            //if (index != -1)
            //{
            //    Console.WriteLine("var" + index);
            //}
            //else
            //{
            //    Console.WriteLine("yok");
            //}
            Program prg = new Program();
            prg.SayisalOto();
            Console.ReadLine();
        }
        
    }
}
