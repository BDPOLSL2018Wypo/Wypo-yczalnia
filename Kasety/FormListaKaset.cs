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
            DB db = new DB();
            List<Cassette> lista = db.getList();
            Cassette[] tab = lista.ToArray<Cassette>();

            //Tabela.DataSource = tab;
            dataGridView1.DataSource = tab;

            int i = 1;
        }
    }
}
