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
    public partial class ManagersTable : Form
    {
        public ManagersTable()
        {
            InitializeComponent();
            ManagersTable_Load();
            LoadPodcluchenieManageraComboBox();
            LoadStoymostUslugComboBox();
        }

        private void LoadPodcluchenieManageraComboBox()
        {
            MySqlConnection connectionForClientTypes = new MySqlConnection
              ("Server=127.0.0.1;Database=calldb;" +
              "Uid=frnicky;Pwd=111;SslMode=none;Charset=utf8");
            MySqlDataAdapter clientsTypeDataAdapter = new MySqlDataAdapter
                ("SELECT * FROM `podcluchenie_managera`", connectionForClientTypes);
            DataTable clientsTypeDataTable = new DataTable();
            clientsTypeDataAdapter.Fill(clientsTypeDataTable);

            podclucheniyeManageraComboBox.DataSource = clientsTypeDataTable;
            podclucheniyeManageraComboBox.DisplayMember = "ID_Podcluchenie_managera";
            podclucheniyeManageraComboBox.ValueMember = "ID_Podcluchenie_managera";

            updatePodcluchenieManageraComboBox.DataSource = clientsTypeDataTable;
            updatePodcluchenieManageraComboBox.DisplayMember = "ID_Podcluchenie_managera";
            updatePodcluchenieManageraComboBox.ValueMember = "ID_Podcluchenie_managera";
        }

        private void LoadStoymostUslugComboBox()
        {
            MySqlConnection connectionStoymostUslug = new MySqlConnection
              ("Server=127.0.0.1;Database=calldb;" +
              "Uid=frnicky;Pwd=111;SslMode=none;Charset=utf8");
            MySqlDataAdapter stoymostUslugDataAdapter = new MySqlDataAdapter
                ("SELECT * FROM `stoymost_uslug`", connectionStoymostUslug);
            DataTable clientsTypeDataTable = new DataTable();
            stoymostUslugDataAdapter.Fill(clientsTypeDataTable);

            stoymostUslugComboBox.DataSource = clientsTypeDataTable;
            stoymostUslugComboBox.DisplayMember = "ID_Stoymost_uslug";
            stoymostUslugComboBox.ValueMember = "ID_Stoymost_uslug";

            updateStoymostUslugComboBox.DataSource = clientsTypeDataTable;
            updateStoymostUslugComboBox.DisplayMember = "ID_Stoymost_uslug";
            updateStoymostUslugComboBox.ValueMember = "ID_Stoymost_uslug";
        }

        private void ManagersTable_Load()
        {
            MySqlConnection connection = new MySqlConnection
                ("Server=127.0.0.1;Database=calldb;" +
                "Uid=frnicky;Pwd=111;SslMode=none;Charset=utf8;Convert Zero Datetime=True");
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter
                ("SELECT * FROM `manager`"
                , connection);
            DataTable loadDataTable = new DataTable();
            dataAdapter.Fill(loadDataTable);
            managersDataGridView.DataSource = loadDataTable;
        }
        
        private void AddManagerHandler(object sender, EventArgs e)
        {
            MySqlConnection connectionInstance = new MySqlConnection
               ("Server=127.0.0.1;Database=calldb;" +
               "Uid=frnicky;Pwd=111;SslMode=none;Charset=utf8");

            string managersNumberValue = Convert.ToString(managersNumber.Text);
            string managersFioValue = Convert.ToString(managersFio.Text);
            string dataNachalaUslugValue = dataNachalaUslug.Value.ToString("yyyy-MM-dd");
            int podcluchenieManageraValue = Convert.ToUInt16(podclucheniyeManageraComboBox.Text);
            int stoymostUslugValue = Convert.ToUInt16(stoymostUslugComboBox.Text);

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(
                "INSERT INTO `manager` (`Nomer_managera`, `FIO_Managera`, `Data_nachala_uslug`, `ID_Podcluchenie_managera`, `ID_Stoymost_uslug`) VALUES ('"
                + managersNumberValue + "', '"
                + managersFioValue + "', '"
                + dataNachalaUslugValue + "', '"
                + podcluchenieManageraValue + "', '"
                + stoymostUslugValue + "')"
                , connectionInstance);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            Close();
        }

        private void UpdateManagerHandler(object sender, EventArgs e)
        {
            MySqlConnection connectionInstance = new MySqlConnection
               ("Server=127.0.0.1;Database=calldb;" +
               "Uid=frnicky;Pwd=111;SslMode=none;Charset=utf8");

            int updateManagerIdValue = Convert.ToUInt16(updateManagersId.Text);
            string updateManagersNumberValue = Convert.ToString(updateManagersNumber.Text);
            string updateManagersFioValue = Convert.ToString(updateManagersFIO.Text);
            string updateDataNachalaUslugValue = dataNachalaUslug.Value.ToString("yyyy-MM-dd");
            int updatePodcluchenieManageraValue = Convert.ToUInt16(podclucheniyeManageraComboBox.Text);
            int updateStoymostUslugValue = Convert.ToUInt16(stoymostUslugComboBox.Text);

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(
                "UPDATE `manager` SET `Nomer_managera` = '"
                + updateManagersNumberValue + "', `FIO_Managera` = '"
                + updateManagersFioValue + "', `Data_nachala_uslug` = '"
                + updateDataNachalaUslugValue + "', `ID_Podcluchenie_managera` = '"
                + updatePodcluchenieManageraValue + "', `ID_Stoymost_uslug` = '"
                + updateStoymostUslugValue + "' WHERE ID_Manager= '" + updateManagerIdValue + "'"
                , connectionInstance);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            Close();
        }

        private void DeleteManagerHandler(object sender, EventArgs e)
        {
            MySqlConnection connectionInstance = new MySqlConnection
               ("Server=127.0.0.1;Database=calldb;" +
               "Uid=frnicky;Pwd=111;SslMode=none;Charset=utf8");

            int deleteManagerID = Convert.ToUInt16(deleteManagerId.Text);

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(
                "DELETE FROM `manager` WHERE `ID_Manager` = " + deleteManagerID
                , connectionInstance);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            Close();
        }
    }
}
