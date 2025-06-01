using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities;
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
    public partial class AddClients : Form
    {
        public AddClients()
        {
            InitializeComponent();
            LoadComboBox();
            addRecordHandler.Visible = true;
        }

        int id;
        public AddClients(int _id)
        {
            InitializeComponent();
            LoadComboBox();
            id = _id;
        }

        private void LoadString()
        {
            MySqlConnection clientsRecordsConnection = new MySqlConnection
               ("Server=127.0.0.1;Database=calldb;" +
               "Uid=frnicky;Pwd=111;SslMode=none;Charset=utf8");
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter
                ("SELECT * FROM `client` WHERE ID_Client=" + id, clientsRecordsConnection);
            DataTable clientsDateTables = new DataTable();
            mySqlDataAdapter.Fill(clientsDateTables);
        }
        private void LoadComboBox()
        {
            MySqlConnection connectionForClientTypes = new MySqlConnection
              ("Server=127.0.0.1;Database=calldb;" +
              "Uid=frnicky;Pwd=111;SslMode=none;Charset=utf8");
            MySqlDataAdapter clientsTypeDataAdapter = new MySqlDataAdapter
                ("SELECT * FROM `typ_clienta`", connectionForClientTypes);
            DataTable clientsTypeDataTable = new DataTable();
            clientsTypeDataAdapter.Fill(clientsTypeDataTable);
            clientTypeSelector.DataSource = clientsTypeDataTable;
            clientTypeSelector.DisplayMember = "ID_Typ_clienta";
            clientTypeSelector.ValueMember = "ID_Typ_clienta";
        }

        private void AddRecordHandler(object sender, EventArgs e)
        {
            MySqlConnection connectionInstance = new MySqlConnection
               ("Server=127.0.0.1;Database=calldb;" +
               "Uid=frnicky;Pwd=111;SslMode=none;Charset=utf8");

            int comboboxSelectValue = Convert.ToUInt16(clientTypeSelector.Text);
            string contactsNumberValue = Convert.ToString(contactsNumberInput.Text);
            string dateOfConclusion = dateOfConclusionInput.Value.ToString("yyyy-MM-dd");

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(
                "INSERT INTO `client` (`Data_zaklucheniya`, `Nomer_kontakta`, `ID_Typ_clienta`) VALUES ('" + dateOfConclusion + "', '" + contactsNumberValue +"' ,  '" + comboboxSelectValue + "')"
                , connectionInstance);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            Close();
        }
    }
}
