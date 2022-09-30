using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Interface1[] ınterface1s = new Interface1[] { 
            
            new SqlServer(),
            new OracleServer()
            };
            foreach (var b in ınterface1s)
            {
                b.Update();
            }
            Console.ReadLine();
        }
    }
}
