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
    public partial class UpdateClients : Form
    {
        public UpdateClients()
        {
            InitializeComponent();
            LoadComboBox();
            updateRecordHandlerUpdate.Visible = true;
        }
        private void updateRecordHandler(object sender, EventArgs e)
        {
            MySqlConnection connectionInstance = new MySqlConnection
               ("Server=127.0.0.1;Database=calldb;" +
               "Uid=frnicky;Pwd=111;SslMode=none;Charset=utf8");

            int updateRecordId = Convert.ToInt32(Client_ID.Text);
            int comboboxSelectValue = Convert.ToUInt16(clientTypeSelectorUpdate.Text);
            string contactsNumberValue = Convert.ToString(contactsNumberInputUpdate.Text);
            string dateOfConclusion = dateOfConclusionInputUpdate.Value.ToString("yyyy-MM-dd");

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(
                "UPDATE `client` SET `Data_zaklucheniya` = '"
                + dateOfConclusion + "', `Nomer_kontakta` = '"
                + contactsNumberValue + "', `ID_Typ_clienta` = '"
                + comboboxSelectValue + "' WHERE ID_Client= '" + updateRecordId + "'"
                , connectionInstance);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            Close();
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
            clientTypeSelectorUpdate.DataSource = clientsTypeDataTable;
            clientTypeSelectorUpdate.DisplayMember = "ID_Typ_clienta";
            clientTypeSelectorUpdate.ValueMember = "ID_Typ_clienta";
        }
    }
}
