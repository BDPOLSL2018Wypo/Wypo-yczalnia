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
    public partial class addToQueue : Form
    {
        public int id;
        List<Person> uzytkownicy = new List<Person>();
        List<string> uzy = new List<string>();
        public addToQueue()
        {
            InitializeComponent();
            DB db = new DB();
            uzytkownicy = db.retriveUser();
            foreach(Person u in uzytkownicy)
            {
                uzy.Add(u.Id + " " + u.Imie + " " + u.Nazwisko);
            }
            users.DataSource = uzy;
        }

        private void addToQueue_Load(object sender, EventArgs e)
        {
            
            
            
        }

        private void doQueue_Click(object sender, EventArgs e)
        {
            int index = users.SelectedIndex;
            int idU = uzytkownicy[index].Id;
            DB db = new DB();
            db.AddClientToQueue(idU.ToString(), id.ToString());
            Dispose();
        }
    }
}
