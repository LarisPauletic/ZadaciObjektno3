using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadaciObjektno3
{
    class Vozilo
    {
        protected bool JeLiLeti;
        protected bool JeLiPlovi;
        public void KudaVozi() 
        {
            Console.WriteLine("{0} {1}", JeLiLeti, JeLiPlovi); 
        }
    }
}
