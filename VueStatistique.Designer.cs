namespace VeloMax
{
    partial class VueStatistique
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

        private ComboBox cbTypeStatistique;
        private Button btnGenerer;
        private DataGridView dataGridViewReport;

        private void InitializeComponent()
        {
            this.cbTypeStatistique = new ComboBox();
            this.btnGenerer = new Button();
            this.dataGridViewReport = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTypeStatistique
            // 
            this.cbTypeStatistique.FormattingEnabled = true;
            this.cbTypeStatistique.Location = new System.Drawing.Point(12, 12);
            this.cbTypeStatistique.Name = "cbTypeStatistique";
            this.cbTypeStatistique.Size = new System.Drawing.Size(200, 21);
            this.cbTypeStatistique.TabIndex = 0;
            // 
            // btnGenerer
            // 
            this.btnGenerer.Location = new System.Drawing.Point(230, 12);
            this.btnGenerer.Name = "btnGenerer";
            this.btnGenerer.Size = new System.Drawing.Size(100, 23);
            this.btnGenerer.TabIndex = 1;
            this.btnGenerer.Text = "Générer le rapport";
            this.btnGenerer.UseVisualStyleBackColor = true;
            // 
            // dataGridViewReport
            // 
            this.dataGridViewReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReport.Location = new System.Drawing.Point(12, 50);
            this.dataGridViewReport.Name = "dataGridViewReport";
            this.dataGridViewReport.Size = new System.Drawing.Size(760, 400);
            this.dataGridViewReport.TabIndex = 2;
            // 
            // StatisticsForm
            // 
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.dataGridViewReport);
            this.Controls.Add(this.btnGenerer);
            this.Controls.Add(this.cbTypeStatistique);
            this.Name = "VueStatistique";
            this.Text = "Module Statistiques";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).EndInit();
            this.ResumeLayout(false);

        }

    }
}