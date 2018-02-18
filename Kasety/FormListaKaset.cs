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
    public partial class FormListaKaset : Form
    {
        public FormListaKaset()
        {
            InitializeComponent();
            
            Lista.Width = this.Size.Width;
            Lista.Height = this.Height;
           
            DB db = new DB();
            List<Cassette> lista = db.getList();
            Lista.DataSource = lista;
            

            
        }

        private void Finder_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            if (title.Text.Length != 0)
            {
                string tytul = title.Text;
                
                List<Cassette> lista = db.getList(tytul);
                Lista.DataSource = lista;
            }
            else
            {
                List<Cassette> lista = db.getList();
                Lista.DataSource = lista;
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            title.Text = "";
            List<Cassette> lista = db.getList();
            Lista.DataSource = lista;
        }
    }
}
