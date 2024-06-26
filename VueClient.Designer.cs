namespace VeloMax
{
    partial class VueClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        
    
        private DataGridView dataGridViewClients;
        private ComboBox ClientType;
        private TextBox tbNomBoutique;
        private TextBox tbNomContact;
        private TextBox tbPrenom;
        private TextBox tbNom;
        private TextBox tbAdresse;
        private TextBox tbVille;
        private TextBox tbCP;
        private TextBox tbProvince;
        private TextBox tbTelephone;
        private TextBox tbCourriel;
        private Button btnSave;
        private Button btnEdit;
        private Button btnDelete;

        private void InitializeComponent()
        {
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.ClientType = new System.Windows.Forms.ComboBox();
            this.tbNomBoutique = new System.Windows.Forms.TextBox();
            this.tbNomContact = new System.Windows.Forms.TextBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbAdresse = new System.Windows.Forms.TextBox();
            this.tbVille = new System.Windows.Forms.TextBox();
            this.tbCP = new System.Windows.Forms.TextBox();
            this.tbProvince = new System.Windows.Forms.TextBox();
            this.tbTelephone = new System.Windows.Forms.TextBox();
            this.tbCourriel = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.RowHeadersWidth = 62;
            this.dataGridViewClients.RowTemplate.Height = 24;
            this.dataGridViewClients.Size = new System.Drawing.Size(776, 200);
            this.dataGridViewClients.TabIndex = 0;
            this.dataGridViewClients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClients_CellContentClick);
            // 
            // ClientType
            // 
            this.ClientType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClientType.FormattingEnabled = true;
            this.ClientType.Items.AddRange(new object[] {
            "Individu",
            "Boutique"});
            this.ClientType.Location = new System.Drawing.Point(12, 230);
            this.ClientType.Name = "ClientType";
            this.ClientType.Size = new System.Drawing.Size(121, 33);
            this.ClientType.TabIndex = 1;
            this.ClientType.SelectedIndexChanged += new System.EventHandler(this.ClientType_SelectedIndexChanged_1);
            // 
            // tbNomBoutique
            // 
            this.tbNomBoutique.Location = new System.Drawing.Point(12, 280);
            this.tbNomBoutique.Name = "tbNomBoutique";
            this.tbNomBoutique.PlaceholderText = "Nom de la compagnie";
            this.tbNomBoutique.Size = new System.Drawing.Size(200, 31);
            this.tbNomBoutique.TabIndex = 2;
            // 
            // tbNomContact
            // 
            this.tbNomContact.Location = new System.Drawing.Point(230, 280);
            this.tbNomContact.Name = "tbNomContact";
            this.tbNomContact.PlaceholderText = "Nom de la personne de contact";
            this.tbNomContact.Size = new System.Drawing.Size(200, 31);
            this.tbNomContact.TabIndex = 3;
            // 
            // tbPrenom
            // 
            this.tbPrenom.Location = new System.Drawing.Point(12, 280);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.PlaceholderText = "Prénom";
            this.tbPrenom.Size = new System.Drawing.Size(200, 31);
            this.tbPrenom.TabIndex = 4;
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(230, 280);
            this.tbNom.Name = "tbNom";
            this.tbNom.PlaceholderText = "Nom";
            this.tbNom.Size = new System.Drawing.Size(200, 31);
            this.tbNom.TabIndex = 5;
            // 
            // tbAdresse
            // 
            this.tbAdresse.Location = new System.Drawing.Point(12, 320);
            this.tbAdresse.Name = "tbAdresse";
            this.tbAdresse.PlaceholderText = "Adresse";
            this.tbAdresse.Size = new System.Drawing.Size(200, 31);
            this.tbAdresse.TabIndex = 6;
            // 
            // tbVille
            // 
            this.tbVille.Location = new System.Drawing.Point(230, 320);
            this.tbVille.Name = "tbVille";
            this.tbVille.PlaceholderText = "Ville";
            this.tbVille.Size = new System.Drawing.Size(200, 31);
            this.tbVille.TabIndex = 7;
            // 
            // tbCP
            // 
            this.tbCP.Location = new System.Drawing.Point(450, 320);
            this.tbCP.Name = "tbCP";
            this.tbCP.PlaceholderText = "Code Postal";
            this.tbCP.Size = new System.Drawing.Size(100, 31);
            this.tbCP.TabIndex = 8;
            // 
            // tbProvince
            // 
            this.tbProvince.Location = new System.Drawing.Point(570, 320);
            this.tbProvince.Name = "tbProvince";
            this.tbProvince.PlaceholderText = "Province";
            this.tbProvince.Size = new System.Drawing.Size(100, 31);
            this.tbProvince.TabIndex = 9;
            // 
            // tbTelephone
            // 
            this.tbTelephone.Location = new System.Drawing.Point(12, 360);
            this.tbTelephone.Name = "tbTelephone";
            this.tbTelephone.PlaceholderText = "Téléphone";
            this.tbTelephone.Size = new System.Drawing.Size(200, 31);
            this.tbTelephone.TabIndex = 10;
            // 
            // tbCourriel
            // 
            this.tbCourriel.Location = new System.Drawing.Point(230, 360);
            this.tbCourriel.Name = "tbCourriel";
            this.tbCourriel.PlaceholderText = "Courriel";
            this.tbCourriel.Size = new System.Drawing.Size(200, 31);
            this.tbCourriel.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(450, 360);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 40);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(570, 360);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 40);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Modifier";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(690, 360);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 40);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // VueClient
            // 
            this.ClientSize = new System.Drawing.Size(823, 450);
            this.Controls.Add(this.dataGridViewClients);
            this.Controls.Add(this.ClientType);
            this.Controls.Add(this.tbNomBoutique);
            this.Controls.Add(this.tbNomContact);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.tbAdresse);
            this.Controls.Add(this.tbVille);
            this.Controls.Add(this.tbCP);
            this.Controls.Add(this.tbProvince);
            this.Controls.Add(this.tbTelephone);
            this.Controls.Add(this.tbCourriel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Name = "VueClient";
            this.Text = "Gestion des Clients";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}