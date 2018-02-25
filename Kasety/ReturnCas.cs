using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

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
                nrErr.Visible = false;
                DB db = new DB();
                bool av = db.isAvailable(id);
                if (!av)
                {
                    int idS = personel.SelectedIndex;
                    ReturnTheCassette cas=db.OdpierdolOddanieKasety(kasjerzy[idS].Id, id);
                    
                    MessageBox.Show("Do zapłaty: "+cas.Price.ToString()+" PLN.","Zapłata");
                    
                
                    if (cas.IdKlientaWKolejce > 0)
                    {
                        wyslij("jakas tresc");
                    }
                   
                }
                else
                {
                    MessageBox.Show("Kaseta nie jest wypożyczona.","Pomyłka");
                }
                
                
            }
            else
            {
                nrErr.Visible = true;
            }
            index.Text = "";
        }
        public void wyslij(string tresc)
        {

            SmtpClient smtpClient = new SmtpClient(); //tworzymy klienta smtp
            smtpClient.UseDefaultCredentials = false;
            smtpClient.EnableSsl = true;
            smtpClient.Port = 587;
            MailMessage message = new MailMessage();//tworzymy wiadomość
            MailAddress from = new MailAddress("domzur1025@gmail.com", "wypozyczalnia");//adres nadawcy i nazwa nadawcy
            
            message.From = from;
            message.To.Add("nencik666@gmail.com");//adres odbiorcy
            message.Subject = "Temat wiadomosci.";//temat wiadomości
            message.Body = tresc; //treść wiadomości
            smtpClient.Host = "smtp.gmail.com"; //host serwera
            smtpClient.Credentials = new System.Net.NetworkCredential("domzur1025@gmail.com", "FI11235813fi1994");//nazwa nadawcy i hasło
            try
            {
                smtpClient.SendAsync(message, "nencik666@gmail.com");//nazwa odbiorcy, wysyłamy wiadomość
            }
            catch (SmtpException ex)
            {

                throw new ApplicationException("Klient SMTP wywołał wyjątek. Sprawdź połączenie z internetem." + ex.Message);

            }
        }
    }
}
