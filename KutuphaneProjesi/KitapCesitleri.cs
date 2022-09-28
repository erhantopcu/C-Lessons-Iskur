using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneProjesi
{
    internal class KitapCesitleri
    {
        public void Ekleme()
        {
            Console.WriteLine("Kitaplar Secildi");
        }
        public void Silme()
        {
            Console.WriteLine("Kitaplar Silindi");
        }
        public void Guncelleme()
        {
            Console.WriteLine("Kitaplar kişiye atandı");
        }
        public int KıtapID { get; set; }
        public string Ismı { get; set; }
        public string YayınEvi { get; set; }

    }
}
