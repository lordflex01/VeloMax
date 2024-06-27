namespace VeloMax
{
    public partial class VueEmploye : Form
    {
        Employe employe = new Employe();
        public VueEmploye()
        {
            InitializeComponent();
            LoadEmployes();
        }

        private void LoadEmployes()
        {
            try
            {
                List<Employe> employes = employe.GetAllEmployes();
                dataGridViewEmployees.DataSource = employes;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des employés : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            employe.Nom = tbNom.Text;
            employe.TypeContrat = (Employe.TypeContratEnum)Enum.Parse(typeof(Employe.TypeContratEnum), cbTypeContrat.SelectedItem.ToString(), true);
            employe.Role = cbRole.SelectedItem?.ToString();
            employe.Salaire = float.Parse(tbSalaire.Text);
            employe.Prime = string.IsNullOrEmpty(tbPrime.Text) ? null : (float?)float.Parse(tbPrime.Text);
        

            try
            {
                employe.AddEmploye();
                MessageBox.Show("Employé ajouté avec succès.", "Ajout réussi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadEmployes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'ajout de l'employé : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployees.CurrentRow == null)
                return;

            int idEmploye = (int)dataGridViewEmployees.CurrentRow.Cells["idEmploye"].Value;

            try
            {
                employe.DeleteEmploye(idEmploye);
                MessageBox.Show("Employé supprimé avec succès.", "Suppression réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                employe.GetAllEmployes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la suppression de l'employé : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
