using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflar
{
    internal class MusteriBilgisi
    {
        string _adi;
        public int ID { get; set; }
        public string Name
        {
            get
            {
                return "Dr." + _adi;
            }
            set
            {
                _adi = value;
            }
        }
        public string Surname { get; set; }
        public string Adress { get; set; }

    }
}
