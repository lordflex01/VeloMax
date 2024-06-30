using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static VeloMax.Velo;

namespace VeloMax
{
    
    public partial class VueProduit : Form
    {
        Velo velo = new Velo();
        Piece piece = new Piece();
        public VueProduit()
        {
            InitializeComponent();
            LoadVelos();
            LoadPieces();
            InitializeFournisseur();
        }

        private void LoadVelos()
        {
            try
            {
                List<Velo> velos = velo.GetAllVelos();
                dataGridViewVelos.DataSource = velos;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des vélos : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadPieces()
        {
            try
            {
                List<Piece> pieces = piece.GetAllPieces();
                dataGridViewPieces.DataSource = pieces;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des pieces : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void InitializeFormVelo()
        {
            tbNumeroProduit.Text = "";
            tbNom.Text = "";
            tbGrandeur.SelectedItem = "";
            tbPrixUnitaire.Text = "";
            tbLigneProduit.SelectedItem = "";
            tbDateIntro.Text = "";
            tbDateOutro.Text = "";
        }
        public void InitializeFormPiece()
        {
            tbNumeroProduitCatalogue.Text = "";
            tbDateApprov.Text = "";
            tbDescription.Text = "";
            tbPrixPiece.Text = "";
            tbNomFournisseur.SelectedItem = "";
            tbDateIntroPiece.Text = "";
            tbDateOutroPiece.Text = "";
            tbQuantite.Text = "";
        }

        private List<Fournisseur> GetAllFournisseurs()
        {
            
            Fournisseur service = new Fournisseur();
            return service.GetAllFournisseurs();
        }
        public void InitializeFournisseur()
        {
            tbNomFournisseur.Items.Clear();

            // Récupérer la liste des fournisseurs
            List<Fournisseur> fournisseurs = GetAllFournisseurs();

            foreach (var fournisseur in fournisseurs)
            {
                tbNomFournisseur.Items.Add(fournisseur.Siret);
            }
        }
        private void btnSaveVelo_Click(object sender, EventArgs e)
        {

            velo.NumeroProduit = tbNumeroProduit.Text;
            velo.Nom = tbNom.Text;
            velo.Grandeur = tbGrandeur.SelectedItem.ToString();
            velo.PrixUnitaire = decimal.Parse(tbPrixUnitaire.Text);
            velo.LigneProduit = (Velo.LigneProduitEnum)Enum.Parse(typeof(Velo.LigneProduitEnum), tbLigneProduit.SelectedItem.ToString());
            velo.DateIntroduction = tbDateIntro.Value;
            velo.DateDiscontinuation = tbDateOutro.Value;

            if (dataGridViewVelos.CurrentRow == null)
            {

                try
                {
                    velo.AddVelo();
                    MessageBox.Show("Vélo ajouté avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadVelos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors de l'ajout du vélo : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                string numeroProduit = (string)dataGridViewVelos.CurrentRow.Cells["numeroproduit"].Value;
                velo.UpdateVelo(numeroProduit);
            }
            InitializeFormVelo();
            LoadVelos();
        }

        private void btnDeleteVelo_Click(object sender, EventArgs e)
        {
            if (dataGridViewVelos.CurrentRow == null)
                return;

            string numeroProduit = (string)dataGridViewVelos.CurrentRow.Cells["NumeroProduit"].Value;

            try
            {
                velo.DeleteVelo(numeroProduit);
                MessageBox.Show("Vélo supprimé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadVelos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la suppression du vélo : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            InitializeFormVelo();
            LoadVelos();
        }

        private void btnUpdateVelo_Click(object sender, EventArgs e)
        {
            if (dataGridViewVelos.CurrentRow == null)
                return;
            tbNumeroProduit.Text = (string)dataGridViewVelos.CurrentRow.Cells["NumeroProduit"].Value;
            tbNom.Text = (string)dataGridViewVelos.CurrentRow.Cells["nom"].Value;
            tbGrandeur.SelectedItem = (string)dataGridViewVelos.CurrentRow.Cells["grandeur"].Value;
            tbPrixUnitaire.Text = ((decimal)dataGridViewVelos.CurrentRow.Cells["PrixUnitaire"].Value).ToString();
            tbLigneProduit.SelectedItem = ((LigneProduitEnum)dataGridViewVelos.CurrentRow.Cells["LigneProduit"].Value).ToString();
            tbDateIntro.Text = ((DateTime)dataGridViewVelos.CurrentRow.Cells["dateintroduction"].Value).ToString("d");
            tbDateOutro.Text = ((DateTime)dataGridViewVelos.CurrentRow.Cells["datediscontinuation"].Value).ToString("d");
        }

        private void btnSavePiece_Click(object sender, EventArgs e)
        {
            piece.NumeroProduit = tbNumeroProduitCatalogue.Text;
            piece.Description = tbDescription.Text;
            piece.PrixUnitaire = decimal.Parse(tbPrixPiece.Text);
            piece.DelaiFournisseur = int.Parse(tbDateApprov.Text);
            piece.DateIntroduction = tbDateIntroPiece.Value;
            piece.DateDiscontinuation = tbDateOutroPiece.Value;
            piece.SiretFournisseur = tbNomFournisseur.SelectedItem.ToString();
            piece.Quantite = float.Parse(tbQuantite.Text);

            try
            {
                piece.AddPiece();
                MessageBox.Show("Piece ajoutée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPieces();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'ajout de la piece : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            InitializeFormPiece();
            LoadPieces();
        }

        private void btnDeletePiece_Click(object sender, EventArgs e)
        {
            if (dataGridViewPieces.CurrentRow == null)
                return;

            string numeroProduit = (string)dataGridViewPieces.CurrentRow.Cells["NumeroProduit"].Value;

            try
            {
                piece.DeletePiece(numeroProduit);
                MessageBox.Show("Piece supprimée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadVelos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la suppression de la piece : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            LoadPieces();
        }

        private void btnUpdatePiece_Click(object sender, EventArgs e)
        {
            if (dataGridViewPieces.CurrentRow == null)
                return;
            tbNumeroProduitCatalogue.Text = (string)dataGridViewPieces.CurrentRow.Cells["NumeroProduit"].Value;
            tbDescription.Text = (string)dataGridViewPieces.CurrentRow.Cells["description"].Value;
            tbPrixPiece.Text = (string)dataGridViewPieces.CurrentRow.Cells["PrixUnitaire"].Value;
            tbQuantite.Text = ((float)dataGridViewPieces.CurrentRow.Cells["Quantite"].Value).ToString();
            tbDateApprov.Text = dataGridViewPieces.CurrentRow.Cells["DelaiFournisseur"].Value.ToString();
            tbNomFournisseur.SelectedItem = dataGridViewPieces.CurrentRow.Cells["SiretFournisseur"].Value;
            tbDateIntroPiece.Text = ((DateTime)dataGridViewPieces.CurrentRow.Cells["dateintroduction"].Value).ToString("d");
            tbDateOutroPiece.Text = ((DateTime)dataGridViewPieces.CurrentRow.Cells["datediscontinuation"].Value).ToString("d");
        }
    }
}
