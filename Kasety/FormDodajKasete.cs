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
    public partial class FormDodajKasete : Form
    {
        public FormDodajKasete()
        {
            InitializeComponent();
            AgeCat.Items.Add("3");
            AgeCat.Items.Add("7");
            AgeCat.Items.Add("12");
            AgeCat.Items.Add("16");
            AgeCat.Items.Add("18");
            AgeCat.SelectedIndex = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            string title, genre, directorname, directorlastname, price;
            int agecat,iprice;
            bool error = false;
            title = Title.Text;
            genre = Genre.Text;
            directorname = DirectorName.Text;
            directorlastname = DirectorLastname.Text;
            
            price = Price.Text;
            if (db.EscapeSQL(title))
            {
                MessageBox.Show("Nie tolerujemy SQLInjection!", "SQLInjection");
                error = true;
            }
            if (db.EscapeSQL(genre))
            {
                MessageBox.Show("Nie tolerujemy SQLInjection!", "SQLInjection");
                error = true;
            }
            if (db.EscapeSQL(directorlastname))
            {
                MessageBox.Show("Nie tolerujemy SQLInjection!", "SQLInjection");
                error = true;
            }
            if (db.EscapeSQL(directorname))
            {
                MessageBox.Show("Nie tolerujemy SQLInjection!", "SQLInjection");
                error = true;
            }
            if (db.EscapeSQL(price))
            {
                MessageBox.Show("Nie tolerujemy SQLInjection!", "SQLInjection");
                error = true;
            }
            if (title.Length == 0)
            {
                TitleErr.Visible = true;
                error = true;
            }
            else TitleErr.Visible = false;

            if (genre.Length == 0)
            {
                GenreErr.Visible = true;
                error = true;
            }
            else GenreErr.Visible = false;

            if (directorname.Length == 0)
            {
                DirNameErr.Visible = true;
                error = true;
            }
            else DirNameErr.Visible = false;

            if (directorlastname.Length == 0)
            {
                DirLNameErr.Visible = true;
                error = true;
            }
            else DirLNameErr.Visible = false;

            if (price.Length == 0)
            {
                PriceErr.Visible = true;
                error = true;
            }
            else PriceErr.Visible = false;

            if (!int.TryParse(price,out iprice))
            {
                PriceErr.Visible = true;
                error = true;
            }
            else PriceErr.Visible = false;

            if (!int.TryParse(AgeCat.Text, out agecat))
            {
                AgeCatErr.Visible = true;
                error = true;
            }
            else AgeCatErr.Visible = false;

            if (!error)
            {
                
                labout.Text = "nie ma błędu";

                db.InsertCassette(title, genre, directorname, directorlastname, agecat, iprice);
                
                //wywołanie dodania tytułu i kasety;
            }
            
           
        }
    }
}
