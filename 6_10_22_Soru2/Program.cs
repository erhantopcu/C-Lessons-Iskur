using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_10_22_Soru2
{
    /// <summary>
    /// PARAMS
    /// </summary>
    internal class Program
    { // Kendisine değişken sayıda parametre olarak yollanan rakamlardan oluşabilecek en büyük ve en küçük sayıları oluşturup geriye döndüren int BuyukSayi(...) ve int KucukSayi(...) adındaki metodu yazın.
        // BuyukSayi(1,5,3,7,8,9) > 9875321
        // KucukSayi(1,5,3,7,8,2)> 123578

        public static int BuyukSayi(params int[] sayi)
        {
            int buyukSayi = 0;
            Array.Sort(sayi); Array.Reverse(sayi);

            for (int i = 0; i < sayi.Length; i++)
            {
                Console.Write(sayi[i]);
            }
            Console.WriteLine();

            return buyukSayi;
        }

        public static int KucukSayi(params int[] sayi)
        {
            int kucukSayi = 0;
            Array.Sort(sayi);
            foreach (var item in sayi)
            {
                Console.Write(item);
            }

            return kucukSayi;
        }

        static void Main(string[] args)
        {
            BuyukSayi(1, 5, 3, 7, 8, 9);
            KucukSayi(1, 5, 3, 7, 8, 2);
            Console.ReadLine();
        }
    }
}
