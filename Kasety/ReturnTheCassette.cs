using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kasety
{
    class ReturnTheCassette
    {
        private int price;
        private double delay;
        private int idKlientaWKolejce;

        public int Price { get => price; set => price = value; }
        public double Delay { get => delay; set => delay = value; }
        public int IdKlientaWKolejce { get => idKlientaWKolejce; set => idKlientaWKolejce = value; }

        public ReturnTheCassette(int Price, double Delay, int IdKlientaWKolejce)
        {
            this.Price = Price;
            this.Delay = Delay;
            this.IdKlientaWKolejce = IdKlientaWKolejce;
        }
    }
}
