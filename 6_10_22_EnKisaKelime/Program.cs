using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_10_22_EnKisaKelime
{
    internal class Program
    { //KEndisine değişken sayıda parametre yollanan dizideki her bir elemanı bir kelime olan dizinin en kısa kelimesinin ekrana yazıp geriye döndüren "EnKisaKelime" adındaaki metodu yazın.

        public static string EnKisaKelime(params string[] kelimeler)
        {
            string enKisa = kelimeler[0];
            int indexNumber = 0;
            for (int i = 1; i < kelimeler.Length; i++)
            {
                if (kelimeler[i].Length < enKisa.Length)
                {
                    enKisa = kelimeler[i];
                    indexNumber = i;
                    
                }
            }
            Console.WriteLine($"En uzun kelimenin uzunluğu: {enKisa.Length} " + enKisa + indexNumber);
            return enKisa;
        }
        static void Main(string[] args)
        {
            EnKisaKelime("kapıkuleliler", "ahmet", "mehmet");
            Console.ReadLine();
        }
    }
}
