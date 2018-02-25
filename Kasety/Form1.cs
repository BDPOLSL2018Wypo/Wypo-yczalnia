using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace Kasety
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //DB db = new DB();
            //DateTime date = new DateTime(2017, 02, 12);
            //db.insertUser("Sprzedawca", "Kasjer", date, "Nasza wypozyczalnia", "nie mamy ulicy", "pewnie jakis jest", "Email", "997", "sprzedawca");
            //Person p=db.retriveUser(1);
            //textBox1.Text = p.GetBirthDate().ToString();
            //db.insertTitle("tytul", "gatunek", "Imie", "Nazwisko", 18, 20);
            //db.insertTitle("tytul2", "gatunek2", "Imie2", "Nazwisko2", 18, 20);
            //db.insertTitle("tytul3", "gatunek", "Imie", "Nazwisko", 18, 20);
            //db.updateUser(1, "chuj", "dupa", new DateTime(), "kurwa", "cipa", "przejebane", "sladu", "to", "pedal");

            //db.EscapeSQL("uuu drop uuu");
            //List<string> kasty=new List<string>(); kasty.Add("1"); kasty.Add("2");
            //db.OdpierdolWypozyczenie(1, 2, kasty);

            //List<string> kasty2 = new List<string>(); kasty2.Add("3"); kasty2.Add("4");
            //db.OdpierdolWypozyczenie(2, 3, kasty2);
            //db.OdpierdolOddanieKasety(1, 2, 1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDodajKasete form2 = new FormDodajKasete();
            form2.ShowDialog();
            form2.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormListaKaset form3 = new FormListaKaset();
            form3.ShowDialog();
        }

        private void Users_Click(object sender, EventArgs e)
        {
            UserList form = new UserList();
            form.ShowDialog();
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            AddUser form = new AddUser();
            form.ShowDialog();
        }

        private void Ustawienia_Click(object sender, EventArgs e)
        {
            Settings form = new Settings();
            form.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void returning_Click(object sender, EventArgs e)
        {
            ReturnCas form = new ReturnCas();
            form.ShowDialog();
        }
    }
}
