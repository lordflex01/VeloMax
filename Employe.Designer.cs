namespace VeloMax
{
    partial class Employe
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrime = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtSalaire = new System.Windows.Forms.TextBox();
            this.txtMagasin = new System.Windows.Forms.ListBox();
            this.txtPoste = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataEmploye = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtContrat = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataEmploye)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "RETOUR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(594, 181);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(180, 31);
            this.txtNom.TabIndex = 1;
            // 
            // txtPrime
            // 
            this.txtPrime.Location = new System.Drawing.Point(594, 389);
            this.txtPrime.Name = "txtPrime";
            this.txtPrime.Size = new System.Drawing.Size(180, 31);
            this.txtPrime.TabIndex = 2;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(957, 181);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(180, 31);
            this.txtPrenom.TabIndex = 3;
            // 
            // txtSalaire
            // 
            this.txtSalaire.Location = new System.Drawing.Point(957, 287);
            this.txtSalaire.Name = "txtSalaire";
            this.txtSalaire.Size = new System.Drawing.Size(180, 31);
            this.txtSalaire.TabIndex = 4;
            // 
            // txtMagasin
            // 
            this.txtMagasin.FormattingEnabled = true;
            this.txtMagasin.ItemHeight = 25;
            this.txtMagasin.Location = new System.Drawing.Point(811, 106);
            this.txtMagasin.Name = "txtMagasin";
            this.txtMagasin.Size = new System.Drawing.Size(180, 29);
            this.txtMagasin.TabIndex = 5;
            // 
            // txtPoste
            // 
            this.txtPoste.FormattingEnabled = true;
            this.txtPoste.ItemHeight = 25;
            this.txtPoste.Location = new System.Drawing.Point(594, 287);
            this.txtPoste.Name = "txtPoste";
            this.txtPoste.Size = new System.Drawing.Size(180, 29);
            this.txtPoste.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(726, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Magasin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(536, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(877, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Prénom";
            // 
            // dataEmploye
            // 
            this.dataEmploye.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEmploye.Location = new System.Drawing.Point(26, 181);
            this.dataEmploye.Name = "dataEmploye";
            this.dataEmploye.RowHeadersWidth = 62;
            this.dataEmploye.RowTemplate.Height = 33;
            this.dataEmploye.Size = new System.Drawing.Size(427, 305);
            this.dataEmploye.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(533, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Poste";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(888, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Salaire";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(531, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Prime";
            // 
            // txtContrat
            // 
            this.txtContrat.FormattingEnabled = true;
            this.txtContrat.ItemHeight = 25;
            this.txtContrat.Location = new System.Drawing.Point(957, 395);
            this.txtContrat.Name = "txtContrat";
            this.txtContrat.Size = new System.Drawing.Size(180, 29);
            this.txtContrat.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(880, 399);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Contrat";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(594, 493);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(162, 34);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "ENREGISTRER";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(899, 493);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(141, 34);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "SUPPRIMER";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(45, 110);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(244, 31);
            this.txtSearch.TabIndex = 18;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(295, 110);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(137, 34);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "RECHERCHER";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // Employe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 597);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtContrat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataEmploye);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPoste);
            this.Controls.Add(this.txtMagasin);
            this.Controls.Add(this.txtSalaire);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtPrime);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.button1);
            this.Name = "Employe";
            this.Text = "Employe";
            ((System.ComponentModel.ISupportInitialize)(this.dataEmploye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox txtNom;
        private TextBox txtPrime;
        private TextBox txtPrenom;
        private TextBox txtSalaire;
        private ListBox txtMagasin;
        private ListBox txtPoste;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dataEmploye;
        private Label label4;
        private Label label5;
        private Label label6;
        private ListBox txtContrat;
        private Label label7;
        private Button btnSave;
        private Button btnDelete;
        private TextBox txtSearch;
        private Button btnSearch;
    }
}