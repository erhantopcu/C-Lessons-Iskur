using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._10._22_Soru4
{
    internal class Program
    {// Kendisine parametre olarak gelen cümle içinde yine kendisine parametre olarak gelen kelimeyi arayıp ve eğer kelime var ise geriye ture , yok ise false değeri döndüre KelimeVarmi adında metodu yazın.
        static bool KelimeVarmi(string cumle, string kelime)
        {
            string[] kelimeler = cumle.Split(' ');
          
            return Array.IndexOf(kelimeler, kelime) == -1;
        }

        static void Main(string[] args)
        {
            bool sonuc = KelimeVarmi("Erhan yazılımı çok seviyor", "nane");
            if (sonuc)
            {
                Console.WriteLine("yok");
            }
            else
            {
                Console.WriteLine("var");
            }
            Console.ReadLine();
        }
    }
}
