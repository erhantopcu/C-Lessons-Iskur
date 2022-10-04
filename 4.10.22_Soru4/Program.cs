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
            bool sonuc;
            sonuc = false;
            string[] kelimeler = kelime.Split(' ');
            foreach (string kelimem in kelimeler)
            {
                if (kelimem == kelime) sonuc = true;
                break;
            }
            return sonuc;
        }

        static void Main(string[] args)
        {
            bool sonuc = KelimeVarmi("osman bizi ışınla", "bizi");
            if (sonuc) Console.WriteLine("Var");
            else Console.WriteLine("YOK");
        }
    }
}
