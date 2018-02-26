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
    public partial class QueueForm : Form
    {
        
        List<Titles> list ;
        public QueueForm()
        {
            InitializeComponent();
            DB db = new DB();
            list = db.getTitles();
            TitleList.DataSource = list;
            DataGridViewButtonColumn col1 = new DataGridViewButtonColumn();
            col1.HeaderText = "";
            col1.Text = "Zakolejkuj";
            col1.UseColumnTextForButtonValue = true;
            col1.Name = "kol";
            TitleList.Columns.Add(col1);
        }

        private void TitleList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                DB db = new DB();
                int index = e.RowIndex;
                int id = list[index].Id;
                if (db.isAvailableByTitle(id))
                {
                    MessageBox.Show("Wybrany tytuł jest dostępny.");
                }
                else
                {
                    addToQueue form = new addToQueue();
                    form.id = id;
                    form.Show();
                }
            }
            
         }
    }
}
