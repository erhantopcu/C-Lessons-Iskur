using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_10_22_Soru2
{
    internal class Program
    { //eleman sayısı klavyeden girilerek bir sayısal dizi oluşturulacaktır. dizide 0-1000 arasında rastgele ve 5(beş) in katlarında deger atanacaktır. diziye deger atandıktan sonra dizi elemanları ekrana yazdırılacaktır. Bu işlemin kodlarını yazdırın.

        public void Dizis()
        {

            Console.WriteLine("Dizinin eleman sayılarını girin");
           int  elemanSayisi = Convert.ToInt32(Console.ReadLine());
            int[] dizi = new int[elemanSayisi];
            
            Random rand = new Random();

            for (int i = 0; i < dizi.Length; i++)
            {
                start1:

                 int sayi = rand.Next(0, 1000);

                if (sayi % 2 == 1 & sayi % 5 == 0)
                {
                    dizi[i] = sayi;
                    Console.WriteLine(dizi[i]);
                }
                else
                {
                    goto start1;
                }
                
            }
            Console.ReadLine();

        }
        static void Main(string[] args)
        {
            Program prg = new Program();
            prg.Dizis();
            
            
        }
    }
}
