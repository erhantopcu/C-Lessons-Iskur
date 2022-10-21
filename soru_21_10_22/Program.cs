using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru_21_10_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sayi gir");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("CİFTLER");
            for (int i = 0; i < a; i+=2)
            {
                Console.Write(" "+ i*i);
            }
            Console.WriteLine("");
            Console.WriteLine("TEKLER");
            for (int j = 1; j < a; j+=2)
            {
                Console.Write(" " + j*j);
            }
            Console.ReadLine();
        }

    }
}
