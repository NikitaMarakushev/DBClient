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
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void AuthorizationHandler(object sender, EventArgs e)
        {
            MySqlConnection authorizationConnection = new MySqlConnection
            ("Server=127.0.0.1;Database=rupor_users;" +
            "Uid=frnicky;Pwd=111;SslMode=none;Charset=utf8");

            MySqlDataAdapter authorizationDataAdapter = new MySqlDataAdapter
                ("SELECT login, password FROM `user` WHERE login='" + authorizeLoginInput.Text + "' AND password = '"
                + Convert.ToBase64String(Encoding.UTF8.GetBytes(Convert.ToString(authorizePasswordInput.Text))) + "'" , authorizationConnection);

            DataTable authorizationDataTable = new DataTable();
            authorizationDataAdapter.Fill(authorizationDataTable);
            authorizationConnection.Close();
            
            if (authorizationDataTable.Rows.Count > 0)
            {
                Rupor ruporForm = new Rupor();
                Hide();
                ruporForm.ShowDialog();
                authorizeLoginInput.Clear();
                authorizePasswordInput.Clear();
                Show();

            }

            else MessageBox.Show("Wrong entered login or password!!!");
        }

        private void OpenRegistrationForm(object sender, EventArgs e)
        {
            Registration registrationForm = new Registration();
            registrationForm.ShowDialog();
        }

        private void AuthorizationKeyDownHandler(object sender, KeyEventArgs keyEvent)
        {
            if (keyEvent.Control && keyEvent.Alt)
            {
                AuthorizationHandler(sender, keyEvent);
            }
        }
    }
}
