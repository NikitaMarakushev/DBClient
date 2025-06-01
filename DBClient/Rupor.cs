using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DBClient
{
    public partial class Rupor : Form
    {
        public Rupor()
        {
            InitializeComponent();
        }

        private void getClientsMainForm(object sender, EventArgs e)
        {
            ClientsTable clientsTable = new ClientsTable();
            Hide();
            clientsTable.ShowDialog();
            Show();
        }

        private void getMangersMainForm(object sender, EventArgs e)
        {
            ManagersTable managersTable = new ManagersTable();
            Hide();
            managersTable.ShowDialog();
            Show();
        }

        private void getNomerData(object sender, EventArgs e)
        {
            Nomer nomer = new Nomer();
            Hide();
            nomer.ShowDialog();
            Show();
        }

        private void GetNomerSobesednika(object sender, EventArgs e)
        {
            NomerSobesednika nomer = new NomerSobesednika();
            Hide();
            nomer.ShowDialog();
            Show();
        }
    }
}
