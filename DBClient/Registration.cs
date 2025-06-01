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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void RegistationHandler(object sender, EventArgs e)
        {
            MySqlConnection registrationConnection = new MySqlConnection
            ("Server=127.0.0.1;Database=rupor_users;" +
            "Uid=frnicky;Pwd=111;SslMode=none;Charset=utf8");

            MySqlDataAdapter authorizationDataAdapter = new MySqlDataAdapter
                ("SELECT login, password FROM `user` WHERE login='" + registrationLogin.Text + "' AND password = '"
                + BCrypt.Net.BCrypt.HashPassword(registrationPassword.Text) + "'", registrationConnection);

            DataTable authorizationDataTable = new DataTable();
            authorizationDataAdapter.Fill(authorizationDataTable);
            registrationConnection.Close();

            if (authorizationDataTable.Rows.Count == 0)
            {
                MySqlConnection registrationNewUserConnection = new MySqlConnection
            ("Server=127.0.0.1;Database=rupor_users;" +
            "Uid=frnicky;Pwd=111;SslMode=none;Charset=utf8");

                MySqlDataAdapter registerNewUserAdapter = new MySqlDataAdapter
                ("INSERT INTO `user` (`login`, `password`) VALUES ('"
                + registrationLogin.Text + "', '"
                + Convert.ToBase64String(Encoding.UTF8.GetBytes(Convert.ToString(registrationPassword.Text))) + "')",
                registrationNewUserConnection);

                DataTable registerNewUserDataTable = new DataTable();
                registerNewUserAdapter.Fill(registerNewUserDataTable);
                registrationConnection.Close();

                Rupor ruporForm = new Rupor();
                Hide();
                ruporForm.ShowDialog();
                registrationLogin.Clear();
                registrationPassword.Clear();
                Show();

            }

            else MessageBox.Show("Such user is already exists, please, try another login!!!");
        }
        private void RegistrationKeyDownHandler(object sender, KeyEventArgs keyEvent)
        {
            if (keyEvent.Control && keyEvent.Alt)
            {
                RegistationHandler(sender, keyEvent);
            }
        }
    }
}
