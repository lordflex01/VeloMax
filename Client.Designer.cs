namespace VeloMax
{
    partial class Client
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRetour = new System.Windows.Forms.Button();
            this.dataClient = new System.Windows.Forms.DataGridView();
            this.nom = new System.Windows.Forms.TextBox();
            this.prenom = new System.Windows.Forms.TextBox();
            this.adresse = new System.Windows.Forms.TextBox();
            this.tel = new System.Windows.Forms.TextBox();
            this.cp = new System.Windows.Forms.TextBox();
            this.ville = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.Recherche = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.typeclienti = new System.Windows.Forms.RadioButton();
            this.typeclientb = new System.Windows.Forms.RadioButton();
            this.remise = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataClient)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(22, 12);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(112, 34);
            this.btnRetour.TabIndex = 0;
            this.btnRetour.Text = "RETOUR";
            this.btnRetour.UseVisualStyleBackColor = true;
            // 
            // dataClient
            // 
            this.dataClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataClient.Location = new System.Drawing.Point(22, 137);
            this.dataClient.Name = "dataClient";
            this.dataClient.RowHeadersWidth = 62;
            this.dataClient.RowTemplate.Height = 33;
            this.dataClient.Size = new System.Drawing.Size(413, 420);
            this.dataClient.TabIndex = 1;
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(651, 186);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(117, 31);
            this.nom.TabIndex = 2;
            // 
            // prenom
            // 
            this.prenom.Location = new System.Drawing.Point(651, 249);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(117, 31);
            this.prenom.TabIndex = 3;
            // 
            // adresse
            // 
            this.adresse.Location = new System.Drawing.Point(651, 308);
            this.adresse.Name = "adresse";
            this.adresse.Size = new System.Drawing.Size(391, 31);
            this.adresse.TabIndex = 4;
            // 
            // tel
            // 
            this.tel.Location = new System.Drawing.Point(892, 186);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(150, 31);
            this.tel.TabIndex = 5;
            // 
            // cp
            // 
            this.cp.Location = new System.Drawing.Point(651, 368);
            this.cp.Name = "cp";
            this.cp.Size = new System.Drawing.Size(102, 31);
            this.cp.TabIndex = 6;
            // 
            // ville
            // 
            this.ville.Location = new System.Drawing.Point(890, 368);
            this.ville.Name = "ville";
            this.ville.Size = new System.Drawing.Size(152, 31);
            this.ville.TabIndex = 7;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(892, 249);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(150, 31);
            this.email.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(586, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(564, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Prénom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(563, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Adresse";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(605, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "CP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(837, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ville";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(849, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tel";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(827, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Email";
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.LimeGreen;
            this.save.Location = new System.Drawing.Point(1124, 249);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(132, 34);
            this.save.TabIndex = 16;
            this.save.Text = "ENREGISTRER";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Red;
            this.delete.Location = new System.Drawing.Point(1124, 306);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(132, 34);
            this.delete.TabIndex = 17;
            this.delete.Text = "SUPPRIMER";
            this.delete.UseVisualStyleBackColor = false;
            // 
            // Recherche
            // 
            this.Recherche.Location = new System.Drawing.Point(22, 77);
            this.Recherche.Name = "Recherche";
            this.Recherche.Size = new System.Drawing.Size(226, 31);
            this.Recherche.TabIndex = 18;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.LightSeaGreen;
            this.search.Location = new System.Drawing.Point(254, 75);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(131, 34);
            this.search.TabIndex = 19;
            this.search.Text = "RECHERCHER";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // typeclienti
            // 
            this.typeclienti.AutoSize = true;
            this.typeclienti.Location = new System.Drawing.Point(651, 119);
            this.typeclienti.Name = "typeclienti";
            this.typeclienti.Size = new System.Drawing.Size(101, 29);
            this.typeclienti.TabIndex = 20;
            this.typeclienti.TabStop = true;
            this.typeclienti.Text = "Individu";
            this.typeclienti.UseVisualStyleBackColor = true;
            this.typeclienti.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // typeclientb
            // 
            this.typeclientb.AutoSize = true;
            this.typeclientb.Location = new System.Drawing.Point(827, 119);
            this.typeclientb.Name = "typeclientb";
            this.typeclientb.Size = new System.Drawing.Size(108, 29);
            this.typeclientb.TabIndex = 21;
            this.typeclientb.TabStop = true;
            this.typeclientb.Text = "Boutique";
            this.typeclientb.UseVisualStyleBackColor = true;
            // 
            // remise
            // 
            this.remise.Location = new System.Drawing.Point(651, 431);
            this.remise.Name = "remise";
            this.remise.Size = new System.Drawing.Size(150, 31);
            this.remise.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(570, 434);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 25);
            this.label8.TabIndex = 23;
            this.label8.Text = "Remise";
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1286, 580);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.remise);
            this.Controls.Add(this.typeclientb);
            this.Controls.Add(this.typeclienti);
            this.Controls.Add(this.search);
            this.Controls.Add(this.Recherche);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.email);
            this.Controls.Add(this.ville);
            this.Controls.Add(this.cp);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.adresse);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.dataClient);
            this.Controls.Add(this.btnRetour);
            this.Name = "Client";
            this.Text = "Client";
            ((System.ComponentModel.ISupportInitialize)(this.dataClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnRetour;
        private DataGridView dataClient;
        private TextBox nom;
        private TextBox prenom;
        private TextBox adresse;
        private TextBox tel;
        private TextBox cp;
        private TextBox ville;
        private TextBox email;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button save;
        private Button delete;
        private TextBox Recherche;
        private Button search;
        private RadioButton typeclienti;
        private RadioButton typeclientb;
        private TextBox remise;
        private Label label8;
    }
}