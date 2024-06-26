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
    public partial class VueFournisseur : Form
    {
        Fournisseur fournisseur = new Fournisseur();
        public VueFournisseur()
        {
            InitializeComponent();
            LoadFournisseurs();
        }

        private void LoadFournisseurs()
        {
            try
            {
                List<Fournisseur> fournisseurs = fournisseur.GetAllFournisseurs();
                dataGridViewFournisseurs.DataSource = fournisseurs;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des fournisseurs : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            fournisseur.Siret = tbSiret.Text;
            fournisseur.Contact = tbContact.Text;
            fournisseur.Adresse = tbAdresse.Text;
            fournisseur.NomFournisseur = tbNomFournisseur.Text;
            fournisseur.Reactivite = (Fournisseur.ReactiviteEnum)Enum.Parse(typeof(Fournisseur.ReactiviteEnum), NiveauSatisfaction.SelectedItem.ToString(), true);

            fournisseur.AddFournisseur();
            LoadFournisseurs();
        }
    }
}
