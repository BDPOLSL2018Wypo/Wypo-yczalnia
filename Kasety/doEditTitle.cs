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
    public partial class doEditTitle : Form
    {
        public int id;
        public doEditTitle()
        {
            InitializeComponent();
            AgeCat.Items.Add("3");
            AgeCat.Items.Add("7");
            AgeCat.Items.Add("12");
            AgeCat.Items.Add("16");
            AgeCat.Items.Add("18");
            AgeCat.SelectedIndex = 0;
        }

        private void doEditTitle_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            Title t = db.getTitles(id);
            Title.Text = t.Titl;
            Genre.Text = t.Genre;
            DirectorName.Text = t.DirectorName;
            DirectorLastname.Text = t.DirectorLastName;
            Price.Text = t.Price.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string title, genre, directorname, directorlastname, price;
            int agecat, iprice;
            bool error = false;
            title = Title.Text;
            genre = Genre.Text;
            directorname = DirectorName.Text;
            directorlastname = DirectorLastname.Text;

            price = Price.Text;

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

            if (!int.TryParse(price, out iprice))
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
                DB db = new DB();

                db.updateCassette(id.ToString(), title, genre, directorname, directorlastname, agecat, iprice);
                    labout.Text = "umieszczono";
                //wywołanie dodania tytułu i kasety;
            }
            else labout.Text = "jest jakis blad";
            Dispose();
        }
    }
}
