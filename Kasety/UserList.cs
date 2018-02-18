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
        public UserList()
        {
            DB db = new DB();
            List<Person> lista = db.retriveUser();
            InitializeComponent();
            list.DataSource = lista;
        }
    }
}
