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
        Clients client;
        public Client()
        {
            InitializeComponent();
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
    }
}
