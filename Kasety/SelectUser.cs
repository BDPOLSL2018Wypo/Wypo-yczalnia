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
    public partial class SelectUser : Form
    {
        List<Person> persons = new List<Person>();
        List<Person> kasjerzy = new List<Person>();
        List<string> per = new List<string>();
        List<string> kas = new List<string>();
        List<int> wyp = new List<int>();
        public List<int> Wyp { get => wyp; set => wyp = value; }
        public SelectUser()
        {
            InitializeComponent();
            DB db = new DB();
           
            persons = db.retriveUser();
            foreach(Person p in persons)
            {
                per.Add(p.Id +" " + p.Imie + " " + p.Nazwisko);
            }
            ListaUzytkownikow.DataSource = per;
            
            kasjerzy = db.retriveSprzedawcy();
            foreach(Person k in kasjerzy)
            {
                kas.Add(k.Id + " " + k.Imie + " " + k.Nazwisko);
            }
            Personel.DataSource = kas;
            
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> kasety = new List<string>();
            int indexU = ListaUzytkownikow.SelectedIndex;
            int indexS = Personel.SelectedIndex;
            //string s = "Użytkownik: " + persons[indexU].Id + " " + persons[indexU].Imie + " " + persons[indexU].Nazwisko + " Sprzedawca: " + kasjerzy[indexS].Id + " " + kasjerzy[indexS].Imie + " " + kasjerzy[indexS].Nazwisko;
           // MessageBox.Show(s);
            foreach (int i in wyp)
            {
                kasety.Add(i.ToString());
            }
            DB db = new DB();
            db.OdpierdolWypozyczenie(kasjerzy[indexS].Id, persons[indexU].Id, kasety);
            FormListaKaset form = new FormListaKaset();
            form.Show();
            this.Dispose();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SelectUser_Load(object sender, EventArgs e)
        {

        }
    }
}
