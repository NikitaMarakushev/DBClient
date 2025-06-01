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
    public partial class Nomer : Form
    {
        public Nomer()
        {
            InitializeComponent();
            LoadNumberData();
        }

        private void LoadNumberData()
        {
            MySqlConnection nomerConnection = new MySqlConnection
                ("Server=127.0.0.1;Database=calldb;" +
                "Uid=frnicky;Pwd=111;SslMode=none;Charset=utf8;Convert Zero Datetime=True");
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter
                ("SELECT * FROM `nomer`"
                , nomerConnection);
            DataTable loadDataTable = new DataTable();
            dataAdapter.Fill(loadDataTable);
            nomerDataDridView.DataSource = loadDataTable;
        }

        private void addNomerHandler_Click(object sender, EventArgs e)
        {
            MySqlConnection connectionInstance = new MySqlConnection
               ("Server=127.0.0.1;Database=calldb;" +
               "Uid=frnicky;Pwd=111;SslMode=none;Charset=utf8");

            string number = Convert.ToString(addNumberInput.Text);

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(
                "INSERT INTO `nomer` (`Nomer`) VALUES ('"
                + number + "')"
                , connectionInstance);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            Close();
        }

        private void updateNomerHandler_Click(object sender, EventArgs e)
        {
            MySqlConnection connectionInstance = new MySqlConnection
               ("Server=127.0.0.1;Database=calldb;" +
               "Uid=frnicky;Pwd=111;SslMode=none;Charset=utf8");

            int updateId = Convert.ToInt16(updateNewNomerInputId.Text);
            string updateNumber = Convert.ToString(updateNewNomerInput.Text);

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(
                "UPDATE `nomer` SET `Nomer` = '"
                + updateNumber + "' WHERE ID_Nomer= '" + updateId + "'"
                , connectionInstance);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            Close();
        }

        private void deleteNomerHandler_Click(object sender, EventArgs e)
        {
            MySqlConnection connectionInstance = new MySqlConnection
               ("Server=127.0.0.1;Database=calldb;" +
               "Uid=frnicky;Pwd=111;SslMode=none;Charset=utf8");

            int deleteNumberID = Convert.ToInt16(deleteNomerInputId.Text);

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(
                "DELETE FROM `nomer` WHERE `ID_Nomer` = " + deleteNumberID
                , connectionInstance);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            Close();
        }
    }
}
