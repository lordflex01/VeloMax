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
    public partial class Login : Form
    {
        Auth auth = new Auth();
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool IsOK = true;

            if (txtLogin.Text.Length == 0)
            {

                IsOK = false;
            }
            else
                auth.login = txtLogin.Text;

            if (txtMDP.Text.Length == 0)
            {

                IsOK = false;
            }
            else
                auth.mdp = txtMDP.Text;

            if (IsOK)
            {
                if(auth.Authentication())
                {
                    Accueil PageAccueil = new Accueil();
                    PageAccueil.Show();

                    Login PageLogin = new Login();
                    PageLogin.Hide();
                }
            }
            
        }
    }
}