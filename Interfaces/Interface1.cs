using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface Interface1
    {
        void Add();
        void Update();
        void Delete();
    }
    class SqlServer : Interface1
    {
        public void Add()
        {
            Console.WriteLine("Sql Server Added.");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Server Deleted.");
        }

        public void Update()
        {
            Console.WriteLine("Sql Server Updated.");
        }
    }
    class OracleServer : Interface1
    {
        public void Add()
        {
            Console.WriteLine("Oracle Server Added.");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Server Deleted.");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Server Updated.");
        }
    }
    class VeriTabanıIslemleri
    {
        public void Ekle(Interface1 interfac1)
        {
            interfac1.Add();
        }
        public void Sil(Interface1 interfac1)
        {
            interfac1.Delete();
        }
        public void Guncelle(Interface1 interfac1)
        {
            interfac1.Update();
        }
    }
}
