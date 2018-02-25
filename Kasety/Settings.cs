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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            DB db = new DB();
            punish.Text = db.getKara().ToString();
            days.Text = db.getIloscDniDoZwrotu().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            int kara, dni;
            bool error = false;
            if (db.EscapeSQL(punish.Text))
            {
                MessageBox.Show("Nie tolerujemy SQLInjection!", "SQLInjection");
                error = true;
            }
            if (db.EscapeSQL(days.Text))
            {
                MessageBox.Show("Nie tolerujemy SQLInjection!", "SQLInjection");
                error = true;
            }
            if (punish.Text.Length == 0)
            {
                error = true;
                punishErr.Visible = true;
                //błąd
            }
            else punishErr.Visible = false;

            if (!Int32.TryParse(punish.Text, out kara))
            {
                error = true;
                punishErr.Visible = true;
                //błąd2
            }
            else punishErr.Visible = false;

            if (days.Text.Length == 0)
            {
                error = true;
                daysErr.Visible = true;
                //błąd
            }
            else daysErr.Visible = false;

            if (!Int32.TryParse(days.Text, out dni))
            {
                error = true;
                daysErr.Visible = true;
                //błąd2
            }
            else daysErr.Visible = false;

            if (!error)
            {
                
                db.SetSettings(kara, dni);
                Saved.Visible = true;
                err.Visible = false;
                
            }
            else
            {
                Saved.Visible = false;
                err.Visible = true;
            }

        }

        private void err_Click(object sender, EventArgs e)
        {

        }
    }
}
