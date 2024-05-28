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

namespace VeloMax
{
    public partial class Client : Form
    {
        Clients client = new Clients();
        public Client()
        {
            InitializeComponent();
        }

        private void FormaterListe()
        {
            dataClient.Columns["IDCLIENT"].Visible = false;
            dataClient.Columns["ADRESSE"].HeaderText = "Adresse";
            dataClient.Columns["ADRESSE"].Width = 80;
            dataClient.Columns["TELEPHONE"].HeaderText = "Tel";
            dataClient.Columns["TELEPHONE"].Width = 100;
            dataClient.Columns["COURRIEL"].HeaderText = "Email";
            dataClient.Columns["COURRIEL"].Width = 135;
            dataClient.MultiSelect = false;
            dataClient.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataClient.ReadOnly = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            
            bool IsOK = true;

            if (adresse.Text.Length == 0)
            {
               
                IsOK = false;
            }
            else client.ADRESSE = adresse.Text;

            if (tel.Text.Length == 0)
            {
               
                IsOK = false;
            }
            else
                client.TELEPHONE = tel.Text;

            if (Tools.VeriferMail(email.Text))
                client.COURRIEL = email.Text;
            else
            {
                
                IsOK = false;
            }

            if (IsOK)
                client.Save();

            MessageBox.Show("Enregistrement effectué");
        }

        private void search_Click(object sender, EventArgs e)
        {
            DBConnection dbCon = new DBConnection();
            if (dbCon.IsConnect())
            {
                if (Recherche.Text.Length != 0)
                {
                    string query = "SELECT IDCLIENT, Adresse, Telephone, Courriel FROM client where Adresse LIKE ?adresse ORDER BY Adresse";
                    query = Tools.PrepareLigne(query, "?adresse", Tools.PrepareChamp(Recherche.Text, "Chaine"));

                    var cmd = new MySqlCommand(query, dbCon.Connection);
                    var reader = cmd.ExecuteReader();//Remplissage du curseur
                    List<Clients> LesClients = new List<Clients>();
                    while (reader.Read())
                    {
                        Clients client = new Clients
                        {
                            IDCLIENT = (int)reader["IDCLIENT"],
                            ADRESSE = (string)reader["ADRESSE"],
                            TELEPHONE = (string)reader["TELEPHONE"],
                            COURRIEL = (string)reader["COURRIEL"],
                        };
                        LesClients.Add(client);
                    }

                    dataClient.DataSource = null;
                    dataClient.DataSource = LesClients;
                    FormaterListe();
                    reader.Close();
                    dbCon.Close();
                    dataClient.Visible = true;
                } else
                {
                    string query = "SELECT IDCLIENT, Adresse, Telephone, Courriel FROM client ORDER BY Adresse";
                   
                    var cmd = new MySqlCommand(query, dbCon.Connection);
                    var reader = cmd.ExecuteReader();//Remplissage du curseur
                    List<Clients> LesClients = new List<Clients>();
                    while (reader.Read())
                    {
                        Clients client = new Clients
                        {
                            IDCLIENT = (int)reader["IDCLIENT"],
                            ADRESSE = (string)reader["ADRESSE"],
                            TELEPHONE = (string)reader["TELEPHONE"],
                            COURRIEL = (string)reader["COURRIEL"],
                        };
                        LesClients.Add(client);
                    }

                    dataClient.DataSource = null;
                    dataClient.DataSource = LesClients;
                    FormaterListe();
                    reader.Close();
                    dbCon.Close();
                    dataClient.Visible = true;
                }
            }
        }
    }
}
