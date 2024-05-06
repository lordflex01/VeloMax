namespace VeloMax
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Accueil PageAccueil = new Accueil();
            PageAccueil.Show();
        }
    }
}