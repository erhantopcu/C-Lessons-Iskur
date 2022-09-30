using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigortaProjesi
{
    internal class Program
    {
        public void Musteri()
        {
            Console.WriteLine("Müsteri İsmini giriniz: ");
            string isim = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Tc Kimlik numarasını giriniz");
            ulong idn = Convert.ToUInt64(Console.ReadLine());
        }
        public void Araba()
        {
            int sigorta = 10000;
            int aracYasi;

            Console.WriteLine("Arabın Yılı giriniz: ");
            int arabanınUretimYili = Convert.ToInt32(Console.ReadLine());

            aracYasi = DateTime.Now.Year - arabanınUretimYili;
            Console.WriteLine("Arabanın üretim yılından şuana geçen yıl : " + aracYasi);

            double sigorta1 = (sigorta - (sigorta * 0.40)); // araba kazalı yası az
            double sigorta2 = (sigorta - (sigorta * 0.60)); // araba kazalı yası cok

            double sigorta3 = (sigorta - (sigorta * 0.10)); // araba kazasız yası az
            double sigorta4 = (sigorta - (sigorta * 0.25)); // araba kazasız yası cok

            Console.WriteLine("Araç Kazası var mı varsa 1'e basın yoksa 0'a basın ");
            string durum = Convert.ToString(Console.ReadLine());

            if (true) // araba kazalıysa
            {
                if (aracYasi > 10) //yaş
                {
                    Console.WriteLine("sigorta miktarınız: " + sigorta1);
                }
                else
                {
                    Console.WriteLine("sigorta miktarınız: " + sigorta2);
                }
            }
            else // araba kazalı değilse
            {
                if (aracYasi > 10)
                {
                    Console.WriteLine("sigorta miktarınız: " + sigorta3);
                }
                else
                {
                    Console.WriteLine("sigorta miktarınız: " + sigorta4);
                }
            }
            //switch (durum)
            //{
            //    case "evet":

            //        Console.WriteLine("Sayiniz: " + (number + sayi1));
            //        break;
            //    case "-":

            //        Console.WriteLine("Sayiniz: " + (number * sayi1));
            //        break;
            //    default:
            //        Console.WriteLine("hatalı secim");
            //        break;
            //}
        }
        static void Main(string[] args)
        {

            Program prg = new Program();

            prg.Araba();
            Console.ReadLine();

        }
    }
}
