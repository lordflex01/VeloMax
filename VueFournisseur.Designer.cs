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
            this.dataGridViewFournisseurs = new System.Windows.Forms.DataGridView();
            this.tbSiret = new System.Windows.Forms.TextBox();
            this.tbNomFournisseur = new System.Windows.Forms.TextBox();
            this.tbContact = new System.Windows.Forms.TextBox();
            this.tbAdresse = new System.Windows.Forms.TextBox();
            this.NiveauSatisfaction = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFournisseurs)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFournisseurs
            // 
            this.dataGridViewFournisseurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFournisseurs.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewFournisseurs.Name = "dataGridViewFournisseurs";
            this.dataGridViewFournisseurs.RowHeadersWidth = 62;
            this.dataGridViewFournisseurs.RowTemplate.Height = 24;
            this.dataGridViewFournisseurs.Size = new System.Drawing.Size(776, 200);
            this.dataGridViewFournisseurs.TabIndex = 0;
            // 
            // tbSiret
            // 
            this.tbSiret.Location = new System.Drawing.Point(12, 230);
            this.tbSiret.Name = "tbSiret";
            this.tbSiret.PlaceholderText = "Siret";
            this.tbSiret.Size = new System.Drawing.Size(200, 31);
            this.tbSiret.TabIndex = 1;
            // 
            // tbNomFournisseur
            // 
            this.tbNomFournisseur.Location = new System.Drawing.Point(230, 230);
            this.tbNomFournisseur.Name = "tbNomFournisseur";
            this.tbNomFournisseur.PlaceholderText = "Nom de l\'entreprise";
            this.tbNomFournisseur.Size = new System.Drawing.Size(200, 31);
            this.tbNomFournisseur.TabIndex = 2;
            // 
            // tbContact
            // 
            this.tbContact.Location = new System.Drawing.Point(12, 270);
            this.tbContact.Name = "tbContact";
            this.tbContact.PlaceholderText = "Contact";
            this.tbContact.Size = new System.Drawing.Size(200, 31);
            this.tbContact.TabIndex = 3;
            // 
            // tbAdresse
            // 
            this.tbAdresse.Location = new System.Drawing.Point(230, 270);
            this.tbAdresse.Name = "tbAdresse";
            this.tbAdresse.PlaceholderText = "Adresse";
            this.tbAdresse.Size = new System.Drawing.Size(200, 31);
            this.tbAdresse.TabIndex = 4;
            // 
            // NiveauSatisfaction
            // 
            this.NiveauSatisfaction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NiveauSatisfaction.FormattingEnabled = true;
            this.NiveauSatisfaction.Items.AddRange(new object[] {
            "Très bon",
            "Bon",
            "Moyen",
            "Mauvais"});
            this.NiveauSatisfaction.Location = new System.Drawing.Point(12, 310);
            this.NiveauSatisfaction.Name = "NiveauSatisfaction";
            this.NiveauSatisfaction.Size = new System.Drawing.Size(200, 33);
            this.NiveauSatisfaction.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(450, 260);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 40);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Ajouter";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(570, 260);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 40);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Modifier";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(690, 260);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 40);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // VueFournisseur
            // 
            this.ClientSize = new System.Drawing.Size(823, 450);
            this.Controls.Add(this.dataGridViewFournisseurs);
            this.Controls.Add(this.tbSiret);
            this.Controls.Add(this.tbNomFournisseur);
            this.Controls.Add(this.tbContact);
            this.Controls.Add(this.tbAdresse);
            this.Controls.Add(this.NiveauSatisfaction);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Name = "VueFournisseur";
            this.Text = "Gestion des Fournisseurs";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFournisseurs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}