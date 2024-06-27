using MySqlX.XDevAPI;
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
    public partial class VueClient : Form
    {
        Client unClient = new Client();
        private List<Client> clients = new List<Client>();
        public VueClient()
        {
            InitializeComponent();
            InitializeDataGridView();
            InitializeClientTypeComboBox();
        }

        private void InitializeDataGridView()
        {
            try
            {
                List<Client> clients = unClient.GetAllClients();
                dataGridViewClients.DataSource = clients;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des clients : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeClientTypeComboBox()
        {
            ClientType.SelectedIndex = 0;
        }

        private void InitializeForm()
        {
            tbAdresse.Text = "";
            tbCourriel.Text = "";
            tbCP.Text = "";
            tbProvince.Text = "";
            tbTelephone.Text = "";
            tbVille.Text = "";
            
            tbNomBoutique.Text = "";
            tbNomContact.Text = "";

            tbPrenom.Text = "";
            tbNom.Text = "";
        }

        private void dataGridViewClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ClientType_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            bool isBoutique = ClientType.SelectedItem.ToString() == "Boutique";

            tbNomBoutique.Visible = isBoutique;
            tbNomContact.Visible = isBoutique;

            tbPrenom.Visible = !isBoutique;
            tbNom.Visible = !isBoutique;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ClientType.SelectedItem.ToString() == "Boutique")
            {
                unClient.Type = (Client.ClientTypeEnum)Enum.Parse(typeof(Client.ClientTypeEnum), ClientType.SelectedItem.ToString(), true);
                unClient.NomBoutique = tbNomBoutique.Text;
                unClient.NomContact = tbNomContact.Text;
                unClient.Adresse = tbAdresse.Text;
                unClient.Ville = tbVille.Text;
                unClient.CP = tbCP.Text;
                unClient.Province = tbProvince.Text;
                unClient.Telephone = tbTelephone.Text;
                unClient.Courriel = tbCourriel.Text;
               
                unClient.SaveClient();
            }
            else
            {
                unClient.Type = (Client.ClientTypeEnum)Enum.Parse(typeof(Client.ClientTypeEnum), ClientType.SelectedItem.ToString(), true);
                unClient.Prenom = tbPrenom.Text;
                unClient.Nom = tbNom.Text;
                unClient.Adresse = tbAdresse.Text;
                unClient.Ville = tbVille.Text;
                unClient.CP = tbCP.Text;
                unClient.Province = tbProvince.Text;
                unClient.Telephone = tbTelephone.Text;
                unClient.Courriel = tbCourriel.Text;
                
                unClient.SaveClient();
            }
            InitializeDataGridView();
            InitializeForm();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewClients.CurrentRow != null)
            {
                var selectedClient = dataGridViewClients.CurrentRow.DataBoundItem as Client;
                if (selectedClient != null)
                {
                    if (selectedClient.Type is Client.ClientTypeEnum.Boutique)
                    {
                        ClientType.SelectedItem = "Boutique";
                        tbNomBoutique.Text = unClient.NomBoutique;
                        tbNomContact.Text = unClient.NomContact;
                        tbAdresse.Text = unClient.Adresse;
                        tbVille.Text = unClient.Ville;
                        tbCP.Text = unClient.CP;
                        tbProvince.Text = unClient.Province;
                        tbTelephone.Text = unClient.Telephone;
                        tbCourriel.Text = unClient.Courriel;
                    }
                    else if (selectedClient.Type is Client.ClientTypeEnum.Individu)
                    {
                        ClientType.SelectedItem = "Individu";
                        tbPrenom.Text = unClient.Prenom;
                        tbNom.Text = unClient.Nom;
                        tbAdresse.Text = unClient.Adresse;
                        tbVille.Text = unClient.Ville;
                        tbCP.Text = unClient.CP;
                        tbProvince.Text = unClient.Province;
                        tbTelephone.Text = unClient.Telephone;
                        tbCourriel.Text = unClient.Courriel;
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewClients.CurrentRow != null)
            {
                var selectedClient = dataGridViewClients.CurrentRow.DataBoundItem as Client;
                if (selectedClient != null)
                {
                    int id = selectedClient.IdClient;
                    unClient.DeleteClient(id);
                }
            }
            InitializeForm();
            InitializeDataGridView();
        }
    }
}
