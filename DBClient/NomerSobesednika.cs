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
    public partial class NomerSobesednika : Form
    {
        public NomerSobesednika()
        {
            InitializeComponent();
            LoadNumberSobesednikaData();
        }

        private void LoadNumberSobesednikaData()
        {
            MySqlConnection nomerConnection = new MySqlConnection
                ("Server=127.0.0.1;Database=calldb;" +
                "Uid=frnicky;Pwd=111;SslMode=none;Charset=utf8;Convert Zero Datetime=True");
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter
                ("SELECT * FROM `nomer_sobesednika`"
                , nomerConnection);
            DataTable loadDataTable = new DataTable();
            dataAdapter.Fill(loadDataTable);
            nomerSovesednikaDataGridView.DataSource = loadDataTable;
        }
        private void addNomerSobesenikaHandler_Click(object sender, EventArgs e)
        {
            MySqlConnection connectionInstance = new MySqlConnection
              ("Server=127.0.0.1;Database=calldb;" +
              "Uid=frnicky;Pwd=111;SslMode=none;Charset=utf8");

            string number = Convert.ToString(addNomerSobesednikaInput.Text);

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(
                "INSERT INTO `nomer_sobesednika` (`Nomer`) VALUES ('"
                + number + "')"
                , connectionInstance);

            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            Close();
        }

        private void updateNomerSobesednikaHandler_Click(object sender, EventArgs e)
        {
            MySqlConnection connectionInstance = new MySqlConnection
               ("Server=127.0.0.1;Database=calldb;" +
               "Uid=frnicky;Pwd=111;SslMode=none;Charset=utf8");

            int updateId = Convert.ToInt16(updateNomerSobesednikaIdInput.Text);
            string updateNumber = Convert.ToString(updateNomerSobesednikaNewNomerInput.Text);

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(
                "UPDATE `nomer_sobesednika` SET `Nomer` = '"
                + updateNumber + "' WHERE ID_Nomer_sobesednika= '" + updateId + "'"
                , connectionInstance);

            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            Close();
        }

        private void DeleteNomerSobesednikaByIdHandler(object sender, EventArgs e)
        {
            MySqlConnection connectionInstance = new MySqlConnection
               ("Server=127.0.0.1;Database=calldb;" +
               "Uid=frnicky;Pwd=111;SslMode=none;Charset=utf8");

            int deleteNumberID = Convert.ToInt16(deletingNomerSobesednikaByIdInput.Text);

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(
                "DELETE FROM `nomer_sobesednika` WHERE `ID_Nomer_sobesednika` = " + deleteNumberID
                , connectionInstance);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            Close();
        }
    }
}
