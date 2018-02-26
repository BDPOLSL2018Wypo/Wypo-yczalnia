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
    public partial class UserList : Form
    {
        List<Person> lista;
        public UserList()
        {
            DB db = new DB();
            lista = db.retriveUser();
            InitializeComponent();
            list.DataSource = lista;
            DataGridViewButtonColumn col1 = new DataGridViewButtonColumn();
            col1.HeaderText = "";
            col1.Text = "Edytuj użytkownika";
            col1.UseColumnTextForButtonValue = true;
            col1.Name = "edit";
            list.Columns.Add(col1);
        }

        private void list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                int index = e.RowIndex;
                int id = lista[index].Id;
                
                EditUser form = new EditUser();
                form.id = id;
                form.ShowDialog();
                DB db = new DB();
                lista = db.retriveUser();
                list.DataSource = lista;

            }
        }
    }
}
