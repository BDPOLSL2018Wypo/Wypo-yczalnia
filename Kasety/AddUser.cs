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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
            role.Items.Add("Użytkownik");
            role.Items.Add("Pracownik");
            role.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool error = false;
            string Imie = firstname.Text;
            string Nazwisko = lastname.Text;
            DateTime DataUrodzenia;
            
            
            string Adres = addr.Text;
            string Ulica = street.Text;
            string KodPocztowy = postcode.Text;
            string Email = email.Text;
            string NrTelefonu = phone.Text;
            string Rola = role.Text;
            int tmp;

            if (Imie.Length == 0)
            {
                ErrName.Visible = true;
                error = true;
            }
            else ErrName.Visible = false;

            if (Nazwisko.Length == 0)
            {
                ErrSName.Visible = true;
                error = true;
            }
            else ErrSName.Visible = false;

            if (Adres.Length == 0)
            {
                ErrAddr.Visible = true;
                error = true;
            }
            else ErrAddr.Visible = false;

            if (Ulica.Length == 0)
            {
                ErrStr.Visible = true;
                error = true;
            }
            else ErrStr.Visible = false;

            if (KodPocztowy.Length == 0)
            {
                ErrPost.Visible = true;
                error = true;
            }
            else ErrPost.Visible = false;

            if (Email.Length == 0)
            {
                ErrEmail.Visible = true;
                error = true;
            }
            else ErrEmail.Visible = false;

            if (NrTelefonu.Length == 0)
            {
                ErrPhone.Visible = true;
                error = true;
            }
            else ErrPhone.Visible = false;

            if(!Int32.TryParse(NrTelefonu,out tmp))
            {
                ErrPhone.Visible = true;
                error = true;
            }else ErrPhone.Visible = false;

            if (!DateTime.TryParse(bdate.Text, out DataUrodzenia))
            {
                ErrBdate.Visible = true;
                error = true;
            }
            else ErrBdate.Visible = false;

            if (!error)
            {
                DB db = new DB();
                db.insertUser(Imie, Nazwisko, DataUrodzenia, Adres, Ulica, KodPocztowy, Email, NrTelefonu, Rola);
            }
            
        }

        private void ErrAddr_Click(object sender, EventArgs e)
        {

        }
    }
}
