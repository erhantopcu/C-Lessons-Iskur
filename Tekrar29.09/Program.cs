using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekrar29._09
{
    internal class Program
    {
        public void Rndm4Islem()
        {
            Random rnd = new Random();
            double number = rnd.Next(0, 100);
            Console.WriteLine("Random sayınız");
            Console.WriteLine(number);

            Console.WriteLine(" ");
            Console.WriteLine("Sayi Girin: ");
            double sayi1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" ");
            Console.WriteLine("İşlem seçimi yapın * , / , + , - ");

            string deger = Convert.ToString(Console.ReadLine());

            switch (deger)
            {
                case "+":

                    Console.WriteLine("Sayiniz: " + (number + sayi1));
                    break;
                case "-":

                    Console.WriteLine("Sayiniz: " + (number - sayi1));
                    break;
                case "/":

                    Console.WriteLine("Sayiniz: " + (number / sayi1));
                    break;
                case "*":

                    Console.WriteLine("Sayiniz: " + (number * sayi1));
                    break;
                default:
                    Console.WriteLine("hatalı secim");
                    break;

            }
        }

        static void Main(string[] args)
        {
            //Bir sayı klavyeden girilcek diğer sayı 0-100 arasından random atıcak. sonra bu sayılarla dört işlem

            Program prg = new Program();
            
            prg.Rndm4Islem();
            Console.ReadLine();

        }
    }
}
