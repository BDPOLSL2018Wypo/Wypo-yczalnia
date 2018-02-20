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
            DB db = new DB();
            DateTime date = new DateTime(2017, 02, 12);
            db.insertUser("Imie", "Nazwisko", date, "adres", "ulica", "kodpocztowy", "Email", "997", "kucharz");
            Person p=db.retriveUser(1);
            textBox1.Text = p.GetBirthDate().ToString();
            db.insertTitle("tytul", "gatunek", "Imie", "Nazwisko", 18, 20);
            db.insertTitle("tytul2", "gatunek2", "Imie2", "Nazwisko2", 18, 20);
            db.insertTitle("tytul3", "gatunek", "Imie", "Nazwisko", 18, 20);
            db.updateUser(1, "chuj", "dupa", new DateTime(), "kurwa", "cipa", "przejebane", "sladu", "to", "pedal");

            db.EscapeSQL("uuu drop uuu");

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
    }
}
