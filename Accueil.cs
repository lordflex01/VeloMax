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
    public partial class Accueil : Form
    {
        
        public Accueil()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Client PageClient = new Client();
            PageClient.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Depot PageDepot = new Depot();
            PageDepot.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Vente PageVente = new Vente();
            PageVente.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Fournisseur PageFournisseur = new Fournisseur();
            PageFournisseur.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Statistique PageStatistique = new Statistique();
            PageStatistique.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Stock PageStock = new Stock();
            PageStock.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Employe PageEmploye = new Employe();
            PageEmploye.Show();
        }

        private void Accueil_Load(object sender, EventArgs e)
        {
            Login PageLogin = new Login();
            PageLogin.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Login PageLogin = new Login();
            PageLogin.Show();
        }
    }
}
