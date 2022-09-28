using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneProjesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KitapCesitleri cesit = new KitapCesitleri
            {
                KıtapID = 5,
                Ismı = "Anna Karina",
                YayınEvi = "GuzelEv"
            };

            Calisanlar emp = new Calisanlar
            {
                CalisanID = 1,
                CalisanIsmı= "Mehmet",
                Yas = 30,
                Status= "Yonetici"
            };

            emp.Ekleme();
            Console.WriteLine("Calısan ID: " + emp.CalisanID);
            Console.WriteLine("Calisan İsmi: " + emp.CalisanIsmı);
            Console.WriteLine("Calısan Yaşı: " + emp.Yas);
            Console.WriteLine("Calisan Statü: " + emp.Status);

            Console.WriteLine(" ");

            cesit.Ekleme();
            Console.WriteLine("Kitap numarası : " + cesit.KıtapID);
            Console.WriteLine("YayınEvi: "+ cesit.YayınEvi);
            Console.WriteLine("KitapIsmi: "+ cesit.Ismı);
            
            Console.ReadLine();
         
        }
    }
}
