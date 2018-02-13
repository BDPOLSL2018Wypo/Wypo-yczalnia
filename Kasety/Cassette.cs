using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kasety
{
    class Cassette
    {
        int ID { get; set; }
        string title { get; set; }
        //string genre;
        //string director;
        //int agecat;
        int price { get; set; }
        bool available { get; set; }
        public Cassette(int id,string t, int p, bool ava)
        {
            ID = id;
            title = t;
           // genre = g;
            //director = d;
            //agecat = age;
            price = p;
            available = ava;
        }
    }
}
