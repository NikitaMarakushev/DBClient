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
    public partial class DeleteClients : Form
    {
        public DeleteClients()
        {
            InitializeComponent();
        }

        private void updateRecordHandlerDelete_Click(object sender, EventArgs e)
        {
            MySqlConnection connectionInstance = new MySqlConnection
               ("Server=127.0.0.1;Database=calldb;" +
               "Uid=frnicky;Pwd=111;SslMode=none;Charset=utf8");

            int recordClientId = Convert.ToUInt16(Client_ID.Text);

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(
                "DELETE FROM `client` WHERE `ID_Client` = " + recordClientId
                , connectionInstance);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            Close();
        }
    }
}
