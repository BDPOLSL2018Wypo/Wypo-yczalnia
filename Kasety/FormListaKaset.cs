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
        List<int> wypo = new List<int>();
        List<Cassette> lista;
        public FormListaKaset()
        {
            InitializeComponent();
            
            Lista.Width = this.Size.Width;
            //Lista.Height = this.Height;
           
            DB db = new DB();
            lista = db.getList();
            Lista.DataSource = lista;
            DataGridViewButtonColumn col1 = new DataGridViewButtonColumn();
            col1.HeaderText = "";
            col1.Text = "Wypożycz";
            col1.UseColumnTextForButtonValue = true;
            col1.Name = "wyp";
            Lista.Columns.Add(col1);
            
            foreach(int i in wypo)
            {
                label1.Text += i.ToString() + ",";
            }
            
        }
        

        private void Finder_Click(object sender, EventArgs e)
        {
            
            DB db = new DB();
            if (title.Text.Length != 0)
            {
                string tytul = title.Text;
                if (!db.EscapeSQL(tytul))
                {
                    List<Cassette> lista = db.getList(tytul);
                    Lista.DataSource = lista;
                }
                else
                {
                    MessageBox.Show("Nie tolerujemy SQLInjection!", "SQLInjection");
                    title.Text = "";
                }
                
                
                
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

        private void FormListaKaset_Load(object sender, EventArgs e)
        {

        }

        private void Lista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                if (wypo.Count < 5)
                {
                    int index = e.RowIndex + 1;
                    bool err = false;
                    foreach(int i in wypo)
                    {
                        if (index == i) err = true;
                    }
                    if (!err)
                    {
                        DB db = new DB();


                        if (db.isAvailable(index))
                        {
                            wypo.Add(index);
                            label1.Text += index;
                            label1.Text += ",";
                        }
                    }
                    
                    
                }
                
            }
        }

        private void wyp_Click(object sender, EventArgs e)
        {
            if (wypo.Count > 0)
            {
                SelectUser form = new SelectUser();
                form.Wyp = wypo;
                form.ShowDialog();
                DB db = new DB();
                lista = db.getList();
                Lista.DataSource = lista;
                wypo = new List<int>();
                label1.Text = "";
                title.Text = "";

            }
        }
    }
}
