using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kasety
{
    class Titles
    {
        private int id;
        private string title, genre, director;
        private int age, price;

        public Titles(int i, string t, string g, string d,int a, int p)
        {
            id = i;
            title = t;
            genre = g;
            director = d;
            age = a;
            price = p;
        }
        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string Genre { get => genre; set => genre = value; }
        public string Diector { get => director; set => director = value; }
        public int Age { get => age; set => age = value; }
        public int Price { get => price; set => price = value; }
        
    }
}
