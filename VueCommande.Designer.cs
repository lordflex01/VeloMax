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
        private TextBox tbCommandeID;
        private TextBox tbDateCommande;
        private TextBox tbAdresseLivraison;
        private TextBox tbDateLivraison;
        private TextBox tbPrixTotal;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;

        private void InitializeComponent()
        {
            this.dataGridViewOrders = new DataGridView();
            this.dataGridViewOrderItems = new DataGridView();
            this.tbCommandeID = new TextBox();
            this.tbDateCommande = new TextBox();
            this.tbAdresseLivraison = new TextBox();
            this.tbDateLivraison = new TextBox();
            this.tbPrixTotal = new TextBox();
            this.btnAdd = new Button();
            this.btnUpdate = new Button();
            this.btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderItems)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.Size = new System.Drawing.Size(760, 150);
            this.dataGridViewOrders.TabIndex = 0;
            // 
            // dataGridViewOrderItems
            // 
            this.dataGridViewOrderItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderItems.Location = new System.Drawing.Point(12, 180);
            this.dataGridViewOrderItems.Name = "dataGridViewOrderItems";
            this.dataGridViewOrderItems.Size = new System.Drawing.Size(760, 150);
            this.dataGridViewOrderItems.TabIndex = 1;
            // 
            // tbCommandeID
            // 
            this.tbCommandeID.Location = new System.Drawing.Point(12, 350);
            this.tbCommandeID.Name = "tbCommandeID";
            this.tbCommandeID.Size = new System.Drawing.Size(100, 20);
            this.tbCommandeID.TabIndex = 2;
            // 
            // tbDateCommande
            // 
            this.tbDateCommande.Location = new System.Drawing.Point(12, 390);
            this.tbDateCommande.Name = "tbDateCommande";
            this.tbDateCommande.Size = new System.Drawing.Size(180, 20);
            this.tbDateCommande.TabIndex = 3;
            this.tbDateCommande.PlaceholderText = "Date de commande";
            // 
            // tbAdresseLivraison
            // 
            this.tbAdresseLivraison.Location = new System.Drawing.Point(12, 430);
            this.tbAdresseLivraison.Name = "tbAdresseLivraison";
            this.tbAdresseLivraison.Size = new System.Drawing.Size(180, 20);
            this.tbAdresseLivraison.TabIndex = 4;
            this.tbAdresseLivraison.PlaceholderText = "Adresse de livraison";
            // 
            // tbDateLivraison
            // 
            this.tbDateLivraison.Location = new System.Drawing.Point(12, 470);
            this.tbDateLivraison.Name = "tbDateLivraison";
            this.tbDateLivraison.Size = new System.Drawing.Size(180, 20);
            this.tbDateLivraison.TabIndex = 5;
            this.tbDateLivraison.PlaceholderText = "Date de livraison";
            // 
            // tbPrixTotal
            // 
            this.tbPrixTotal.Location = new System.Drawing.Point(12, 510);
            this.tbPrixTotal.Name = "tbPrixTotal";
            this.tbPrixTotal.Size = new System.Drawing.Size(100, 20);
            this.tbPrixTotal.TabIndex = 6;
            this.tbPrixTotal.PlaceholderText = "Total";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(250, 350);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 40);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(250, 390);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(130, 40);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Modifier";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(250, 430);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 40);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // SalesForm
            // 
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbPrixTotal);
            this.Controls.Add(this.tbDateLivraison);
            this.Controls.Add(this.tbAdresseLivraison);
            this.Controls.Add(this.tbDateCommande);
            this.Controls.Add(this.tbCommandeID);
            this.Controls.Add(this.dataGridViewOrderItems);
            this.Controls.Add(this.dataGridViewOrders);
            this.Name = "VueCommande";
            this.Text = "Gestion des ventes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}