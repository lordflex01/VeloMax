namespace VeloMax
{
    partial class VueEmploye
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>


        private DataGridView dataGridViewEmployees;
        private ComboBox cbTypeContrat;
        private TextBox tbNom;
        private ComboBox cbRole;
        private TextBox tbSalaire;
        private TextBox tbPrime;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnDelete;

        private void InitializeComponent()
        {
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.cbTypeContrat = new System.Windows.Forms.ComboBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.tbSalaire = new System.Windows.Forms.TextBox();
            this.tbPrime = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.RowHeadersWidth = 62;
            this.dataGridViewEmployees.Size = new System.Drawing.Size(760, 200);
            this.dataGridViewEmployees.TabIndex = 0;
            this.dataGridViewEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmployees_CellContentClick);
            // 
            // cbTypeContrat
            // 
            this.cbTypeContrat.FormattingEnabled = true;
            this.cbTypeContrat.Items.AddRange(new object[] {
            "Plein_Temps",
            "Temps_Partiel"});
            this.cbTypeContrat.Location = new System.Drawing.Point(12, 230);
            this.cbTypeContrat.Name = "cbTypeContrat";
            this.cbTypeContrat.Size = new System.Drawing.Size(120, 33);
            this.cbTypeContrat.TabIndex = 1;
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(12, 270);
            this.tbNom.Name = "tbNom";
            this.tbNom.PlaceholderText = "Nom de l\'employé";
            this.tbNom.Size = new System.Drawing.Size(150, 31);
            this.tbNom.TabIndex = 2;
            // 
            // cbRole
            // 
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Items.AddRange(new object[] {
            "Gérant",
            "Vendeur"});
            this.cbRole.Location = new System.Drawing.Point(12, 310);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(121, 33);
            this.cbRole.TabIndex = 3;
            // 
            // tbSalaire
            // 
            this.tbSalaire.Location = new System.Drawing.Point(12, 350);
            this.tbSalaire.Name = "tbSalaire";
            this.tbSalaire.PlaceholderText = "Salaire";
            this.tbSalaire.Size = new System.Drawing.Size(120, 31);
            this.tbSalaire.TabIndex = 4;
            // 
            // tbPrime
            // 
            this.tbPrime.Location = new System.Drawing.Point(12, 390);
            this.tbPrime.Name = "tbPrime";
            this.tbPrime.PlaceholderText = "Prime";
            this.tbPrime.Size = new System.Drawing.Size(120, 31);
            this.tbPrime.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(170, 230);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 40);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Ajouter";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(170, 270);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 40);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Modifier";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(170, 310);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 40);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // VueEmploye
            // 
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbPrime);
            this.Controls.Add(this.tbSalaire);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.cbTypeContrat);
            this.Controls.Add(this.dataGridViewEmployees);
            this.Name = "VueEmploye";
            this.Text = "Gestion des employés";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}