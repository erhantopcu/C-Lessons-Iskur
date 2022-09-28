using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //class : bizim yapmak istediğimiz işlemleri gruplara ayırmak ve bu grup üzerinde
            // işlemlerimizi yapmak ayrıca rahatlıkla bu gruba ulaşmak için kullanılır.
            Musteri musteriler = new Musteri();
            Urunler urunBilgisi = new Urunler();
           
            UrunBilgisi urunDurumu = new UrunBilgisi
            {
                    ID = 1,
                    Ismı = "elma",
                    Adet = 10

            };

            MusteriBilgisi musteri = new MusteriBilgisi
            {
                ID = 2,
                Name = "Veli",
                Surname= "Konak",
                Adress= "Istanbul"

            };
            Console.WriteLine(musteri.Name);
            Console.WriteLine(urunDurumu.ID);

            musteriler.Guncelleme();
            urunBilgisi.Ekleme();
            Console.WriteLine();
            Console.ReadLine();
        }


    }
}
