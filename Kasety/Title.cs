using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kasety
{
    class Title
    {
        private int id;
        private string titl, genre, directorName,directorLastName;
        private int age, price;
        public Title()
        {

        }
        public Title(int i, string t, string g, string dN,string dLN, int a, int p)
        {
            id = i;
            titl = t;
            genre = g;
            directorName = dN;
            directorLastName = dLN;
            age = a;
            price = p;
        }
        public int Id { get => id; set => id = value; }
        public string Titl { get => titl; set => titl = value; }
        public string Genre { get => genre; set => genre = value; }
        public string DirectorName { get => directorName; set => directorName = value; }
        public string DirectorLastName { get => directorLastName; set => directorLastName = value; }
        public int Age { get => age; set => age = value; }
        public int Price { get => price; set => price = value; }
    }
}
