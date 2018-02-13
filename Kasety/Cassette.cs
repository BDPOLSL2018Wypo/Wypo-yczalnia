using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kasety
{
    class Cassette
    {
        public int ID { get; set; }
        public string Tytul { get; set; }
        public string Gatunek { get; set; }
        public string Rezyser { get; set; }
        public int KategoriaWiekowa { get; set; }
        public int Cena { get; set; }
        public bool Dostepnosc { get; set; }
        public Cassette(int id,string t,string g,string d,int age, int p, bool ava)
        {
            ID = id;
            Tytul = t;
            Gatunek = g;
            Rezyser = d;
            KategoriaWiekowa = age;
            Cena = p;
            Dostepnosc = ava;
        }
    }
}
