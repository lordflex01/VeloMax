namespace VeloMax
{
    partial class VueCommande
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

  

        private DataGridView dataGridViewOrders;
        private DataGridView dataGridViewOrderItems;
        private ComboBox cbEmploye;
        private DateTimePicker tbDateCommande;
        private TextBox tbAdresseLivraison;
        private DateTimePicker tbDateLivraison;
        private TextBox tbPrixTotal;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private ComboBox cbNumeroPiece;
        private TextBox tbQuantitePiece;
        private ComboBox cbNumeroVelo;
        private TextBox tbQuantiteVelo;
        private ComboBox cbClient;

        private void InitializeComponent()
        {
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.dataGridViewOrderItems = new System.Windows.Forms.DataGridView();
            this.cbEmploye = new System.Windows.Forms.ComboBox();
            this.tbDateCommande = new System.Windows.Forms.DateTimePicker();
            this.tbAdresseLivraison = new System.Windows.Forms.TextBox();
            this.tbDateLivraison = new System.Windows.Forms.DateTimePicker();
            this.tbPrixTotal = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbNumeroPiece = new System.Windows.Forms.ComboBox();
            this.tbQuantitePiece = new System.Windows.Forms.TextBox();
            this.cbNumeroVelo = new System.Windows.Forms.ComboBox();
            this.tbQuantiteVelo = new System.Windows.Forms.TextBox();
            this.cbClient = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderItems)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.RowHeadersWidth = 62;
            this.dataGridViewOrders.Size = new System.Drawing.Size(760, 150);
            this.dataGridViewOrders.TabIndex = 0;
            // 
            // dataGridViewOrderItems
            // 
            this.dataGridViewOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderItems.Location = new System.Drawing.Point(12, 180);
            this.dataGridViewOrderItems.Name = "dataGridViewOrderItems";
            this.dataGridViewOrderItems.RowHeadersWidth = 62;
            this.dataGridViewOrderItems.Size = new System.Drawing.Size(760, 150);
            this.dataGridViewOrderItems.TabIndex = 1;
            // 
            // cbEmploye
            // 
            this.cbEmploye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmploye.FormattingEnabled = true;
            this.cbEmploye.Location = new System.Drawing.Point(12, 350);
            this.cbEmploye.Name = "cbEmploye";
            this.cbEmploye.Size = new System.Drawing.Size(100, 33);
            this.cbEmploye.TabIndex = 2;
            // 
            // tbDateCommande
            // 
            this.tbDateCommande.Location = new System.Drawing.Point(12, 390);
            this.tbDateCommande.Name = "tbDateCommande";
            this.tbDateCommande.Size = new System.Drawing.Size(270, 31);
            this.tbDateCommande.TabIndex = 3;
            // 
            // tbAdresseLivraison
            // 
            this.tbAdresseLivraison.Location = new System.Drawing.Point(12, 430);
            this.tbAdresseLivraison.Name = "tbAdresseLivraison";
            this.tbAdresseLivraison.PlaceholderText = "Adresse de livraison";
            this.tbAdresseLivraison.Size = new System.Drawing.Size(270, 31);
            this.tbAdresseLivraison.TabIndex = 4;
            // 
            // tbDateLivraison
            // 
            this.tbDateLivraison.Location = new System.Drawing.Point(12, 470);
            this.tbDateLivraison.Name = "tbDateLivraison";
            this.tbDateLivraison.Size = new System.Drawing.Size(270, 31);
            this.tbDateLivraison.TabIndex = 5;
            // 
            // tbPrixTotal
            // 
            this.tbPrixTotal.Location = new System.Drawing.Point(12, 510);
            this.tbPrixTotal.Name = "tbPrixTotal";
            this.tbPrixTotal.PlaceholderText = "Total";
            this.tbPrixTotal.Size = new System.Drawing.Size(100, 31);
            this.tbPrixTotal.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(600, 350);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 40);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(600, 390);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(130, 40);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Modifier";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(600, 430);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 40);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // cbNumeroPiece
            // 
            this.cbNumeroPiece.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNumeroPiece.FormattingEnabled = true;
            this.cbNumeroPiece.Location = new System.Drawing.Point(300, 390);
            this.cbNumeroPiece.Name = "cbNumeroPiece";
            this.cbNumeroPiece.Size = new System.Drawing.Size(180, 33);
            this.cbNumeroPiece.TabIndex = 10;
            // 
            // tbQuantitePiece
            // 
            this.tbQuantitePiece.Location = new System.Drawing.Point(300, 430);
            this.tbQuantitePiece.Name = "tbQuantitePiece";
            this.tbQuantitePiece.PlaceholderText = "Quantité de piece";
            this.tbQuantitePiece.Size = new System.Drawing.Size(180, 31);
            this.tbQuantitePiece.TabIndex = 11;
            // 
            // cbNumeroVelo
            // 
            this.cbNumeroVelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNumeroVelo.FormattingEnabled = true;
            this.cbNumeroVelo.Location = new System.Drawing.Point(300, 470);
            this.cbNumeroVelo.Name = "cbNumeroVelo";
            this.cbNumeroVelo.Size = new System.Drawing.Size(180, 33);
            this.cbNumeroVelo.TabIndex = 12;
            // 
            // tbQuantiteVelo
            // 
            this.tbQuantiteVelo.Location = new System.Drawing.Point(300, 510);
            this.tbQuantiteVelo.Name = "tbQuantiteVelo";
            this.tbQuantiteVelo.PlaceholderText = "Quantité de velo";
            this.tbQuantiteVelo.Size = new System.Drawing.Size(180, 31);
            this.tbQuantiteVelo.TabIndex = 13;
            // 
            // cbClient
            // 
            this.cbClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClient.FormattingEnabled = true;
            this.cbClient.Location = new System.Drawing.Point(120, 350);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(100, 33);
            this.cbClient.TabIndex = 14;
            // 
            // VueCommande
            // 
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbPrixTotal);
            this.Controls.Add(this.tbDateLivraison);
            this.Controls.Add(this.tbAdresseLivraison);
            this.Controls.Add(this.tbDateCommande);
            this.Controls.Add(this.cbEmploye);
            this.Controls.Add(this.dataGridViewOrderItems);
            this.Controls.Add(this.dataGridViewOrders);
            this.Controls.Add(this.cbNumeroPiece);
            this.Controls.Add(this.cbNumeroVelo);
            this.Controls.Add(this.tbQuantitePiece);
            this.Controls.Add(this.tbQuantiteVelo);
            this.Controls.Add(this.cbClient);
            this.Name = "VueCommande";
            this.Text = "Gestion des ventes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}