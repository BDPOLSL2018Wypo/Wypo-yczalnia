using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kasety
{
    public partial class ReturnCas : Form
    {
        List<Person> kasjerzy = new List<Person>();
        List<string> kas = new List<string>();
        public ReturnCas()
        {
            InitializeComponent();
            DB db = new DB();
           
            kasjerzy = db.retriveSprzedawcy();
            foreach (Person k in kasjerzy)
            {
                kas.Add(k.Id + " " + k.Imie + " " + k.Nazwisko);
            }
            personel.DataSource = kas;
        }

        private void ret_Click(object sender, EventArgs e)
        {
            int id;
            string numer = index.Text;
            if (Int32.TryParse(numer, out id))
            {
                DB db = new DB();
                bool av = db.isAvailable(id);
                if (!av)
                {
                    int idS = personel.SelectedIndex;
                    ReturnTheCassette cas=db.OdpierdolOddanieKasety(kasjerzy[idS].Id, id);
                    
                    MessageBox.Show(cas.Delay.ToString()+" "+cas.Price.ToString()+" "+cas.IdKlientaWKolejce.ToString());
                }
                else
                {
                    MessageBox.Show("nie mozna zwrocic kasety, ktora jest niewypozyczona...");
                }
            }
        }
    }
}
