using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICalisan[] workers = new ICalisan[]
            {
                new Manager(),
                new Employer(),
                new Robot()
            };
            foreach ( var item in workers)
            {
                item.Work();
            }
            Console.ReadLine();
        }
        interface INeOlsun
        {
            interface IMaas { void Maas(); }

            interface IYemek { void Yemek(); }
            interface ICalisan { void Calisan(); }
        }
        class Manager : INeOlsun
        {
            public void Calisan()
            {
                throw new NotImplementedException();
            }

            public void Maas()
            {
                throw new NotImplementedException();
            }

            public void Yemek()
            {
                throw new NotImplementedException();
            }
        }
        class Employer : INeOlsun
        {
            public void Calisan()
            {
                throw new NotImplementedException();
            }

            public void Maas()
            {
                throw new NotImplementedException();
            }

            public void Yemek()
            {
                throw new NotImplementedException();
            }
        }
        class Robot : INeOlsun
        {
            public void Calisan()
            {
                throw new NotImplementedException();
            }

            public void Maas()
            {
                throw new NotImplementedException();
            }

            public void Yemek()
            {
                throw new NotImplementedException();
            }
        }
    }
}
