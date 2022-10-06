using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_10_22_EnUzunKelime
{
    internal class Program
    {
        // Kendisine değişken sayıda parametre yollanan kelimelerden en uzun kelimeyi bulup geri döndüren "EnUzunKelime" adındaki metodu yazınız.
        public string EnUzunKelime(params string[] kelimeler)
        {
            string enuzun = " ";
            for (int i = 0; i < kelimeler.Length; i++)
            {
                if (enuzun.Length < kelimeler[i].Length)
                {
                    enuzun = kelimeler[i];
                }
            }
            Console.WriteLine($"En uzun kelimenin uzunluğu: {enuzun.Length}"); 
            return enuzun;
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine(program.EnUzunKelime("Erhan", "Berkcan", "Kapıkuleliler"));
            Console.ReadLine();
        }
    }
}
