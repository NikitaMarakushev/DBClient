using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBClient
{
    public partial class ClientsTable : Form
    {
        public ClientsTable()
        {
            InitializeComponent();
            ClientsTable_Load();
        }

        private void ClientsTable_Load()
        {
            MySqlConnection connection = new MySqlConnection
                ("Server=127.0.0.1;Database=calldb;" +
                "Uid=frnicky;Pwd=111;SslMode=none;Charset=utf8;Convert Zero Datetime=True");
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter
                ("SELECT * FROM `client`"
                , connection);
            DataTable loadDataTable = new DataTable();
            dataAdapter.Fill(loadDataTable);
            clientsDataGridView.DataSource = loadDataTable;
        }

        private void addClientLoad(object sender, EventArgs e)
        {
            AddClients editClientsForm = new AddClients();
            editClientsForm.ShowDialog();
            ClientsTable_Load();
        }
        private void updateClientLoad(object sender, EventArgs e)
        {
            UpdateClients updateClientsForm = new UpdateClients();
            updateClientsForm.ShowDialog();
            ClientsTable_Load();
        }

        private void deleteClientLoad(object sender, EventArgs e)
        {
            DeleteClients deleteClientsForm = new DeleteClients();
            deleteClientsForm.ShowDialog();
            ClientsTable_Load();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                int id = Convert.ToInt32(clientsDataGridView[0, e.RowIndex].Value);
                AddClients etf = new AddClients(id);
                etf.ShowDialog();
                ClientsTable_Load();
            }
        }

        private void searchClientHandler_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection cn = new MySqlConnection("Server=127.0.0.1;Database=calldb;" +
                "Uid=frnicky;Pwd=111;SslMode=none;Charset=utf8;Convert Zero Datetime=True");
                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();
                    using (DataTable dt = new DataTable())
                    {
                        if (searchClientsTextBox.Text.Length > 0)
                        {
                            using (MySqlDataAdapter cmd = new MySqlDataAdapter("SELECT * from `client` where Nomer_kontakta='" + searchClientsTextBox.Text + "'", cn))
                            {
                                DataTable loadDataTable = new DataTable();
                                cmd.Fill(loadDataTable);
                                clientsDataGridView.DataSource = loadDataTable;
                                lblTotal.Text = $"Total records: {clientsDataGridView.RowCount}";
                            }
                        } else {
                            using (MySqlDataAdapter cmd = new MySqlDataAdapter("SELECT * from `client`", cn))
                            {
                                DataTable loadDataTable = new DataTable();
                                cmd.Fill(loadDataTable);
                                clientsDataGridView.DataSource = loadDataTable;
                                lblTotal.Text = $"Total records: {clientsDataGridView.RowCount}";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (filterByIdComboBox.Visible == true && filterByNumberComboBox.Visible == true)
            {
                filterByIdComboBox.Visible = false;
                filterByNumberComboBox.Visible = false;

            } else if (filterByIdComboBox.Visible == false && filterByNumberComboBox.Visible == false) {
                filtersPanel.Visible = true;

                filterByIdComboBox.Visible = true;
                filterByNumberComboBox.Visible = true;

                filterByIdComboBox.SelectedIndex = -1;
                filterByNumberComboBox.SelectedIndex = -1;

                ClientsTable_Load();
            }
        }
    }
}
