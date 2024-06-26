namespace VeloMax
{
    partial class VueProduit
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


        private DataGridView dataGridViewVelos;
        private DataGridView dataGridViewPieces;
        private TextBox tbNumeroProduit;
        private TextBox tbNom;
        private TextBox tbGrandeur;
        private TextBox tbPrixUnitaire;
        private TextBox tbLigneProduit;
        private DateTimePicker tbDateIntro;
        private DateTimePicker tbDateOutro;
        private TextBox tbDescription;
        private TextBox tbNomFournisseur;
        private TextBox tbNumeroProduitCatalogue;
        private TextBox tbPrixPiece;
        private TextBox tbDateIntroPiece;
        private TextBox tbDateOutroPiece;
        private TextBox tbDateApprov;
        private Button btnSaveVelo;
        private Button btnUpdateVelo;
        private Button btnDeleteVelo;
        private Button btnSavePiece;
        private Button btnUpdatePiece;
        private Button btnDeletePiece;


        private void InitializeComponent()
        {
            this.dataGridViewVelos = new System.Windows.Forms.DataGridView();
            this.dataGridViewPieces = new System.Windows.Forms.DataGridView();
            this.tbNumeroProduit = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbGrandeur = new System.Windows.Forms.TextBox();
            this.tbPrixUnitaire = new System.Windows.Forms.TextBox();
            this.tbLigneProduit = new System.Windows.Forms.TextBox();
            this.tbDateIntro = new System.Windows.Forms.DateTimePicker();
            this.tbDateOutro = new System.Windows.Forms.DateTimePicker();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbNomFournisseur = new System.Windows.Forms.TextBox();
            this.tbNumeroProduitCatalogue = new System.Windows.Forms.TextBox();
            this.tbPrixPiece = new System.Windows.Forms.TextBox();
            this.tbDateIntroPiece = new System.Windows.Forms.TextBox();
            this.tbDateOutroPiece = new System.Windows.Forms.TextBox();
            this.tbDateApprov = new System.Windows.Forms.TextBox();
            this.btnSaveVelo = new System.Windows.Forms.Button();
            this.btnUpdateVelo = new System.Windows.Forms.Button();
            this.btnDeleteVelo = new System.Windows.Forms.Button();
            this.btnSavePiece = new System.Windows.Forms.Button();
            this.btnUpdatePiece = new System.Windows.Forms.Button();
            this.btnDeletePiece = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVelos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPieces)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewVelos
            // 
            this.dataGridViewVelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVelos.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewVelos.Name = "dataGridViewVelos";
            this.dataGridViewVelos.RowHeadersWidth = 62;
            this.dataGridViewVelos.RowTemplate.Height = 24;
            this.dataGridViewVelos.Size = new System.Drawing.Size(1220, 200);
            this.dataGridViewVelos.TabIndex = 0;
            // 
            // dataGridViewPieces
            // 
            this.dataGridViewPieces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPieces.Location = new System.Drawing.Point(12, 230);
            this.dataGridViewPieces.Name = "dataGridViewPieces";
            this.dataGridViewPieces.RowHeadersWidth = 62;
            this.dataGridViewPieces.RowTemplate.Height = 24;
            this.dataGridViewPieces.Size = new System.Drawing.Size(1220, 200);
            this.dataGridViewPieces.TabIndex = 1;
            // 
            // tbNumeroProduit
            // 
            this.tbNumeroProduit.Location = new System.Drawing.Point(12, 450);
            this.tbNumeroProduit.Name = "tbNumeroProduit";
            this.tbNumeroProduit.PlaceholderText = "Numéro de produit";
            this.tbNumeroProduit.Size = new System.Drawing.Size(200, 31);
            this.tbNumeroProduit.TabIndex = 2;
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(230, 450);
            this.tbNom.Name = "tbNom";
            this.tbNom.PlaceholderText = "Nom";
            this.tbNom.Size = new System.Drawing.Size(200, 31);
            this.tbNom.TabIndex = 3;
            // 
            // tbGrandeur
            // 
            this.tbGrandeur.Location = new System.Drawing.Point(450, 450);
            this.tbGrandeur.Name = "tbGrandeur";
            this.tbGrandeur.PlaceholderText = "Grandeur";
            this.tbGrandeur.Size = new System.Drawing.Size(200, 31);
            this.tbGrandeur.TabIndex = 4;
            // 
            // tbPrixUnitaire
            // 
            this.tbPrixUnitaire.Location = new System.Drawing.Point(12, 490);
            this.tbPrixUnitaire.Name = "tbPrixUnitaire";
            this.tbPrixUnitaire.PlaceholderText = "Prix unitaire";
            this.tbPrixUnitaire.Size = new System.Drawing.Size(200, 31);
            this.tbPrixUnitaire.TabIndex = 5;
            // 
            // tbLigneProduit
            // 
            this.tbLigneProduit.Location = new System.Drawing.Point(230, 490);
            this.tbLigneProduit.Name = "tbLigneProduit";
            this.tbLigneProduit.PlaceholderText = "Ligne de produit";
            this.tbLigneProduit.Size = new System.Drawing.Size(200, 31);
            this.tbLigneProduit.TabIndex = 6;
            // 
            // tbDateIntro
            // 
            this.tbDateIntro.Location = new System.Drawing.Point(450, 490);
            this.tbDateIntro.Name = "tbDateIntro";
            this.tbDateIntro.Size = new System.Drawing.Size(200, 31);
            this.tbDateIntro.TabIndex = 7;
            // 
            // tbDateOutro
            // 
            this.tbDateOutro.Location = new System.Drawing.Point(12, 530);
            this.tbDateOutro.Name = "tbDateOutro";
            this.tbDateOutro.Size = new System.Drawing.Size(200, 31);
            this.tbDateOutro.TabIndex = 8;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(12, 650);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.PlaceholderText = "Description";
            this.tbDescription.Size = new System.Drawing.Size(200, 31);
            this.tbDescription.TabIndex = 9;
            // 
            // tbNomFournisseur
            // 
            this.tbNomFournisseur.Location = new System.Drawing.Point(230, 650);
            this.tbNomFournisseur.Name = "tbNomFournisseur";
            this.tbNomFournisseur.PlaceholderText = "Nom du fournisseur";
            this.tbNomFournisseur.Size = new System.Drawing.Size(200, 31);
            this.tbNomFournisseur.TabIndex = 10;
            // 
            // tbNumeroProduitCatalogue
            // 
            this.tbNumeroProduitCatalogue.Location = new System.Drawing.Point(12, 570);
            this.tbNumeroProduitCatalogue.Name = "tbNumeroProduitCatalogue";
            this.tbNumeroProduitCatalogue.PlaceholderText = "Numéro de produit catalogue";
            this.tbNumeroProduitCatalogue.Size = new System.Drawing.Size(300, 31);
            this.tbNumeroProduitCatalogue.TabIndex = 11;
            // 
            // tbPrixPiece
            // 
            this.tbPrixPiece.Location = new System.Drawing.Point(330, 570);
            this.tbPrixPiece.Name = "tbPrixPiece";
            this.tbPrixPiece.PlaceholderText = "Prix unitaire de la pièce";
            this.tbPrixPiece.Size = new System.Drawing.Size(200, 31);
            this.tbPrixPiece.TabIndex = 12;
            // 
            // tbDateIntroPiece
            // 
            this.tbDateIntroPiece.Location = new System.Drawing.Point(550, 570);
            this.tbDateIntroPiece.Name = "tbDateIntroPiece";
            this.tbDateIntroPiece.PlaceholderText = "Date d\'introduction de la pièce";
            this.tbDateIntroPiece.Size = new System.Drawing.Size(300, 31);
            this.tbDateIntroPiece.TabIndex = 13;
            // 
            // tbDateOutroPiece
            // 
            this.tbDateOutroPiece.Location = new System.Drawing.Point(12, 610);
            this.tbDateOutroPiece.Name = "tbDateOutroPiece";
            this.tbDateOutroPiece.PlaceholderText = "Date de discontinuation de la pièce";
            this.tbDateOutroPiece.Size = new System.Drawing.Size(300, 31);
            this.tbDateOutroPiece.TabIndex = 14;
            // 
            // tbDateApprov
            // 
            this.tbDateApprov.Location = new System.Drawing.Point(330, 610);
            this.tbDateApprov.Name = "tbDateApprov";
            this.tbDateApprov.PlaceholderText = "Délai d\'approvisionnement (jours)";
            this.tbDateApprov.Size = new System.Drawing.Size(300, 31);
            this.tbDateApprov.TabIndex = 15;
            // 
            // btnSaveVelo
            // 
            this.btnSaveVelo.Location = new System.Drawing.Point(670, 450);
            this.btnSaveVelo.Name = "btnSaveVelo";
            this.btnSaveVelo.Size = new System.Drawing.Size(150, 40);
            this.btnSaveVelo.TabIndex = 16;
            this.btnSaveVelo.Text = "Ajouter Vélo";
            this.btnSaveVelo.UseVisualStyleBackColor = true;
            this.btnSaveVelo.Click += new System.EventHandler(this.btnSaveVelo_Click);
            // 
            // btnUpdateVelo
            // 
            this.btnUpdateVelo.Location = new System.Drawing.Point(850, 450);
            this.btnUpdateVelo.Name = "btnUpdateVelo";
            this.btnUpdateVelo.Size = new System.Drawing.Size(150, 40);
            this.btnUpdateVelo.TabIndex = 17;
            this.btnUpdateVelo.Text = "Modifier Vélo";
            this.btnUpdateVelo.UseVisualStyleBackColor = true;
            // 
            // btnDeleteVelo
            // 
            this.btnDeleteVelo.Location = new System.Drawing.Point(1070, 450);
            this.btnDeleteVelo.Name = "btnDeleteVelo";
            this.btnDeleteVelo.Size = new System.Drawing.Size(150, 40);
            this.btnDeleteVelo.TabIndex = 18;
            this.btnDeleteVelo.Text = "Supprimer Vélo";
            this.btnDeleteVelo.UseVisualStyleBackColor = true;
            // 
            // btnSavePiece
            // 
            this.btnSavePiece.Location = new System.Drawing.Point(650, 650);
            this.btnSavePiece.Name = "btnSavePiece";
            this.btnSavePiece.Size = new System.Drawing.Size(150, 40);
            this.btnSavePiece.TabIndex = 19;
            this.btnSavePiece.Text = "Ajouter Pièce";
            this.btnSavePiece.UseVisualStyleBackColor = true;
            // 
            // btnUpdatePiece
            // 
            this.btnUpdatePiece.Location = new System.Drawing.Point(850, 650);
            this.btnUpdatePiece.Name = "btnUpdatePiece";
            this.btnUpdatePiece.Size = new System.Drawing.Size(150, 40);
            this.btnUpdatePiece.TabIndex = 20;
            this.btnUpdatePiece.Text = "Modifier Pièce";
            this.btnUpdatePiece.UseVisualStyleBackColor = true;
            // 
            // btnDeletePiece
            // 
            this.btnDeletePiece.Location = new System.Drawing.Point(1070, 650);
            this.btnDeletePiece.Name = "btnDeletePiece";
            this.btnDeletePiece.Size = new System.Drawing.Size(150, 40);
            this.btnDeletePiece.TabIndex = 21;
            this.btnDeletePiece.Text = "Supprimer Pièce";
            this.btnDeletePiece.UseVisualStyleBackColor = true;
            // 
            // VueProduit
            // 
            this.ClientSize = new System.Drawing.Size(1250, 700);
            this.Controls.Add(this.btnDeletePiece);
            this.Controls.Add(this.btnUpdatePiece);
            this.Controls.Add(this.btnSavePiece);
            this.Controls.Add(this.btnDeleteVelo);
            this.Controls.Add(this.btnUpdateVelo);
            this.Controls.Add(this.btnSaveVelo);
            this.Controls.Add(this.tbDateApprov);
            this.Controls.Add(this.tbDateOutroPiece);
            this.Controls.Add(this.tbDateIntroPiece);
            this.Controls.Add(this.tbPrixPiece);
            this.Controls.Add(this.tbNumeroProduitCatalogue);
            this.Controls.Add(this.tbNomFournisseur);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbDateOutro);
            this.Controls.Add(this.tbDateIntro);
            this.Controls.Add(this.tbLigneProduit);
            this.Controls.Add(this.tbPrixUnitaire);
            this.Controls.Add(this.tbGrandeur);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.tbNumeroProduit);
            this.Controls.Add(this.dataGridViewPieces);
            this.Controls.Add(this.dataGridViewVelos);
            this.Name = "VueProduit";
            this.Text = "Gestion des Produits";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVelos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPieces)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}