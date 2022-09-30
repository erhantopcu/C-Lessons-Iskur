using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru1._2
{
    internal class Program
    {
        // b = a*a c= b*a
        public void Hesaplama()
        {
            int[] a = { 1, 2, 3, 4, 5 };
            int[] b = new int[5];
            int[] c = new int[5];

            for (int i = 0; i < a.Length; i++)
            {
                b[i] = a[i] * a[i];
                c[i] = b[i] * a[i];
                Console.Write(" " + b[i]);

                Console.WriteLine(" ");

                Console.WriteLine(" " + c[i]);
            }

            Console.ReadLine();


        }
        static void Main(string[] args)
        {
            Program prg = new Program();
            prg.Hesaplama();
        }

    }
}
