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
    public partial class VueCommande : Form
    {
        Commande commande = new Commande();
        DetailPiece detailpiece = new DetailPiece();
        DetailVelo detailvelo = new DetailVelo();
        Velo velo = new Velo();
        Piece piece = new Piece();
        Client client = new Client();
        Employe employe = new Employe();
        public VueCommande()
        {
            InitializeComponent();
            InitializeClient();
            InitializeEmploye();
            InitializeVelo();
            InitializePiece();
        }

        private List<Client> GetAllClients(){
            Client client = new Client();
            return client.GetAllClients();
        }
        public void InitializeClient()
        {
            cbClient.Items.Clear();

            // Récupérer la liste des fournisseurs
            List<Client> clients = GetAllClients();

            foreach (var leclient in clients)
            {
                cbClient.Items.Add(leclient.IdClient);
            }
        }
        private List<Employe> GetAllEmployes()
        {
            Employe employe = new Employe();
            return employe.GetAllEmployes();
        }
        public void InitializeEmploye()
        {
            cbEmploye.Items.Clear();

            // Récupérer la liste des fournisseurs
            List<Employe> employes = GetAllEmployes();

            foreach (var unemploye in employes)
            {
                cbEmploye.Items.Add(unemploye.IdEmploye);
            }
        }
        private List<Piece> GetAllPieces()
        {
            Piece piece = new Piece();
            return piece.GetAllPieces();
        }
        public void InitializePiece()
        {
            cbNumeroPiece.Items.Clear();

            // Récupérer la liste des fournisseurs
            List<Piece> pieces = GetAllPieces();

            foreach (var lapiece in pieces)
            {
                cbNumeroPiece.Items.Add(lapiece.NumeroProduit);
            }
        }
        private List<Velo> GetAllVelos()
        {
            Velo velo = new Velo();
            return velo.GetAllVelos();
        }
        public void InitializeVelo()
        {
            cbNumeroVelo.Items.Clear();

            // Récupérer la liste des fournisseurs
            List<Velo> velos = GetAllVelos();

            foreach (var levelo in velos)
            {
                cbNumeroVelo.Items.Add(levelo.NumeroProduit);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            commande.AdresseLivraison = tbAdresseLivraison.Text;
            commande.DateLivraison = tbDateLivraison.Value;
            commande.DateCommande = tbDateCommande.Value;
            commande.PrixTotal = decimal.Parse(tbPrixTotal.Text);
            commande.ClientId = int.Parse(cbClient.SelectedItem.ToString());
            commande.EmployeId = int.Parse(cbEmploye.SelectedItem.ToString());

            commande.AddCommande();

            if(cbNumeroPiece.SelectedItem != null && tbQuantitePiece.Text != null)
            {
                detailpiece.NumeroProduit = cbNumeroPiece.SelectedItem.ToString();
                detailpiece.Quantite = int.Parse(tbQuantitePiece.Text);
                detailpiece.NumeroCommande = commande.NumeroCommande;

                detailpiece.AddDetailCommandePiece();
            }

            if (cbNumeroVelo.SelectedItem != null && tbQuantiteVelo.Text != null)
            {
                detailvelo.NumeroProduit = cbNumeroVelo.SelectedItem.ToString();
                detailvelo.Quantite = int.Parse(tbQuantiteVelo.Text);
                detailvelo.NumeroCommande = commande.NumeroCommande;

                detailvelo.AddDetailCommandeVelo();
            }
        }
    }
}
