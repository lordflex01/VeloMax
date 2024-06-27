namespace VeloMax
{
    partial class VueFournisseur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        private DataGridView dataGridViewFournisseurs;
        private TextBox tbSiret;
        private TextBox tbNomFournisseur;
        private TextBox tbContact;
        private TextBox tbAdresse;
        private ComboBox NiveauSatisfaction;
        private Button btnSave;
        private Button btnEdit;
        private Button btnDelete;

        private void InitializeComponent()
        {
            dataGridViewFournisseurs = new DataGridView();
            tbSiret = new TextBox();
            tbNomFournisseur = new TextBox();
            tbContact = new TextBox();
            tbAdresse = new TextBox();
            NiveauSatisfaction = new ComboBox();
            btnSave = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFournisseurs).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewFournisseurs
            // 
            dataGridViewFournisseurs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFournisseurs.Location = new Point(12, 12);
            dataGridViewFournisseurs.Name = "dataGridViewFournisseurs";
            dataGridViewFournisseurs.RowHeadersWidth = 62;
            dataGridViewFournisseurs.RowTemplate.Height = 24;
            dataGridViewFournisseurs.Size = new Size(776, 200);
            dataGridViewFournisseurs.TabIndex = 0;
            // 
            // tbSiret
            // 
            tbSiret.Location = new Point(12, 230);
            tbSiret.Name = "tbSiret";
            tbSiret.PlaceholderText = "Siret";
            tbSiret.Size = new Size(200, 23);
            tbSiret.TabIndex = 1;
            // 
            // tbNomFournisseur
            // 
            tbNomFournisseur.Location = new Point(230, 230);
            tbNomFournisseur.Name = "tbNomFournisseur";
            tbNomFournisseur.PlaceholderText = "Nom de l'entreprise";
            tbNomFournisseur.Size = new Size(200, 23);
            tbNomFournisseur.TabIndex = 2;
            // 
            // tbContact
            // 
            tbContact.Location = new Point(12, 270);
            tbContact.Name = "tbContact";
            tbContact.PlaceholderText = "Contact";
            tbContact.Size = new Size(200, 23);
            tbContact.TabIndex = 3;
            // 
            // tbAdresse
            // 
            tbAdresse.Location = new Point(230, 270);
            tbAdresse.Name = "tbAdresse";
            tbAdresse.PlaceholderText = "Adresse";
            tbAdresse.Size = new Size(200, 23);
            tbAdresse.TabIndex = 4;
            // 
            // NiveauSatisfaction
            // 
            NiveauSatisfaction.DropDownStyle = ComboBoxStyle.DropDownList;
            NiveauSatisfaction.FormattingEnabled = true;
            NiveauSatisfaction.Items.AddRange(new object[] { "TresBon", "Bon", "Moyen", "Mauvais" });
            NiveauSatisfaction.Location = new Point(12, 310);
            NiveauSatisfaction.Name = "NiveauSatisfaction";
            NiveauSatisfaction.Size = new Size(200, 23);
            NiveauSatisfaction.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(450, 260);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 40);
            btnSave.TabIndex = 6;
            btnSave.Text = "Ajouter";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(570, 260);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(100, 40);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "Modifier";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(690, 260);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 40);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Supprimer";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // VueFournisseur
            // 
            ClientSize = new Size(823, 450);
            Controls.Add(dataGridViewFournisseurs);
            Controls.Add(tbSiret);
            Controls.Add(tbNomFournisseur);
            Controls.Add(tbContact);
            Controls.Add(tbAdresse);
            Controls.Add(NiveauSatisfaction);
            Controls.Add(btnSave);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Name = "VueFournisseur";
            Text = "Gestion des Fournisseurs";
            ((System.ComponentModel.ISupportInitialize)dataGridViewFournisseurs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}