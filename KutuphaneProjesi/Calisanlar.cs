using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneProjesi
{
    internal class Calisanlar
    {

        public void Ekleme()
        {
            Console.WriteLine("Calışanlar sisteme eklendi");
        }
        public void Silme()
        {
            Console.WriteLine("Çalışanlar sistemden silindi");
        }
        public void Guncelleme()
        {
            Console.WriteLine("Çalışanlar güncellendi.");
        }
        private int CalisanId;
        public int CalisanID { get {

                return CalisanId;
            }
            set
            {
                value = CalisanId;
            } 
        }
        public string CalisanIsmı { get; set; }
        public int Yas { get; set; }
        public string Status { get; set; }

    }
}
