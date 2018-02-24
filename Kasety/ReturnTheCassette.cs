using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kasety
{
    class ReturnTheCassette
    {
        public int price;
        public int delay;
        public int idKlientaWKolejce;
        public ReturnTheCassette(int Price, int Delay, int IdKlientaWKolejce)
        {
            price = Price;
            delay = Delay;
            idKlientaWKolejce = IdKlientaWKolejce;
        }
    }
}
