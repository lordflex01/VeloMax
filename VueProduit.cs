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
    
    public partial class VueProduit : Form
    {
        Velo velo;
        public VueProduit()
        {
            InitializeComponent();
            LoadVelos();
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

        private void btnSaveVelo_Click(object sender, EventArgs e)
        {

            velo.NumeroProduit = tbNumeroProduit.Text;
            velo.Nom = tbNom.Text;
            velo.Grandeur = tbGrandeur.Text;
            velo.PrixUnitaire = decimal.Parse(tbPrixUnitaire.Text);
            velo.LigneProduit = (Velo.LigneProduitEnum)Enum.Parse(typeof(Velo.LigneProduitEnum), tbLigneProduit.Text);
            velo.DateIntroduction = tbDateIntro.Value;
            velo.DateDiscontinuation = tbDateOutro.Value;
            

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
    }
}
