using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadaciObjektno3
{
    class Program
    {
        static void Main(string[] args)
        {
            Brod a = new Brod();
            a.KudaVozi(); 
            Zrakoplov b = new Zrakoplov(); 
            b.KudaVozi();

            Console.ReadKey();
        }
    }
}
