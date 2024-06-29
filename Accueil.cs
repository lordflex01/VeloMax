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
            Login PageLogin = new Login();
            PageLogin.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            VueClient PageClient = new VueClient();
            PageClient.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            VueProduit PageProduit = new VueProduit();
            PageProduit.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            VueCommande PageCommande = new VueCommande();
            PageCommande.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            VueFournisseur PageFounisseur = new VueFournisseur();
            PageFounisseur.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            VueStatistique PageStatistique = new VueStatistique();
            PageStatistique.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            VueStock PageStock = new VueStock();
            PageStock.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            VueEmploye PageEmploye = new VueEmploye();
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
