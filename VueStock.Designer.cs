namespace VeloMax
{
    partial class VueStock
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


        private DataGridView dataGridViewStock;
        private ComboBox cbMagasin;
        private ComboBox cbPiece;
        private ComboBox cbFournisseur;
        private ComboBox cbVelo;
        private ComboBox cbCategorie;
        private ComboBox cbMarque;
        private Button btnFiltre;

        private void InitializeComponent()
        {
            this.dataGridViewStock = new DataGridView();
            this.cbMagasin = new ComboBox();
            this.cbPiece = new ComboBox();
            this.cbFournisseur = new ComboBox();
            this.cbVelo = new ComboBox();
            this.cbCategorie = new ComboBox();
            this.cbMarque = new ComboBox();
            this.btnFiltre = new Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStock)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStock
            // 
            this.dataGridViewStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStock.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewStock.Name = "dataGridViewStock";
            this.dataGridViewStock.Size = new System.Drawing.Size(760, 250);
            this.dataGridViewStock.TabIndex = 0;
            // 
            // cbMagasin
            // 
            this.cbMagasin.FormattingEnabled = true;
            this.cbMagasin.Location = new System.Drawing.Point(12, 280);
            this.cbMagasin.Name = "cbMagasin";
            this.cbMagasin.Size = new System.Drawing.Size(121, 21);
            this.cbMagasin.TabIndex = 1;
            // 
            // cbPiece
            // 
            this.cbPiece.FormattingEnabled = true;
            this.cbPiece.Location = new System.Drawing.Point(150, 280);
            this.cbPiece.Name = "cbPiece";
            this.cbPiece.Size = new System.Drawing.Size(121, 21);
            this.cbPiece.TabIndex = 2;
            // 
            // cbFournisseur
            // 
            this.cbFournisseur.FormattingEnabled = true;
            this.cbFournisseur.Location = new System.Drawing.Point(288, 280);
            this.cbFournisseur.Name = "cbFournisseur";
            this.cbFournisseur.Size = new System.Drawing.Size(121, 21);
            this.cbFournisseur.TabIndex = 3;
            // 
            // cbVelo
            // 
            this.cbVelo.FormattingEnabled = true;
            this.cbVelo.Location = new System.Drawing.Point(426, 280);
            this.cbVelo.Name = "cbVelo";
            this.cbVelo.Size = new System.Drawing.Size(121, 21);
            this.cbVelo.TabIndex = 4;
            // 
            // cbCategorie
            // 
            this.cbCategorie.FormattingEnabled = true;
            this.cbCategorie.Location = new System.Drawing.Point(564, 280);
            this.cbCategorie.Name = "cbCategorie";
            this.cbCategorie.Size = new System.Drawing.Size(121, 21);
            this.cbCategorie.TabIndex = 5;
            // 
            // cbMarque
            // 
            this.cbMarque.FormattingEnabled = true;
            this.cbMarque.Location = new System.Drawing.Point(701, 280);
            this.cbMarque.Name = "cbMarque";
            this.cbMarque.Size = new System.Drawing.Size(121, 21);
            this.cbMarque.TabIndex = 6;
            // 
            // btnFiltre
            // 
            this.btnFiltre.Location = new System.Drawing.Point(12, 320);
            this.btnFiltre.Name = "btnFiltre";
            this.btnFiltre.Size = new System.Drawing.Size(75, 23);
            this.btnFiltre.TabIndex = 7;
            this.btnFiltre.Text = "Appliquer les filtres";
            this.btnFiltre.UseVisualStyleBackColor = true;
            // 
            // StockForm
            // 
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.btnFiltre);
            this.Controls.Add(this.cbMarque);
            this.Controls.Add(this.cbCategorie);
            this.Controls.Add(this.cbVelo);
            this.Controls.Add(this.cbFournisseur);
            this.Controls.Add(this.cbPiece);
            this.Controls.Add(this.cbMagasin);
            this.Controls.Add(this.dataGridViewStock);
            this.Name = "VueStock";
            this.Text = "Gestion des stocks";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStock)).EndInit();
            this.ResumeLayout(false);

        }
    }
}