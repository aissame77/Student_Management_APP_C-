namespace ENSAT_STUDENT_MANAGEMENT_SYSTEM
{
    partial class Bilan
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
            this.BtnRechercher = new System.Windows.Forms.Button();
            this.dataGridViewBilan = new System.Windows.Forms.DataGridView();
            this.code_matiere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TextMoyenneAnnuel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputEtudiant = new System.Windows.Forms.ComboBox();
            this.inputNiveau = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inputFiliere = new System.Windows.Forms.ComboBox();
            this.ComboFiliere = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBilan)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnRechercher
            // 
            this.BtnRechercher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            this.BtnRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRechercher.ForeColor = System.Drawing.Color.White;
            this.BtnRechercher.Location = new System.Drawing.Point(29, 252);
            this.BtnRechercher.Name = "BtnRechercher";
            this.BtnRechercher.Size = new System.Drawing.Size(121, 31);
            this.BtnRechercher.TabIndex = 19;
            this.BtnRechercher.Text = "Rechercher";
            this.BtnRechercher.UseVisualStyleBackColor = false;
            this.BtnRechercher.Click += new System.EventHandler(this.BtnRechercher_Click);
            // 
            // dataGridViewBilan
            // 
            this.dataGridViewBilan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBilan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            this.dataGridViewBilan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBilan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code_matiere,
            this.designation,
            this.semestre,
            this.note});
            this.dataGridViewBilan.GridColor = System.Drawing.Color.White;
            this.dataGridViewBilan.Location = new System.Drawing.Point(185, 69);
            this.dataGridViewBilan.Name = "dataGridViewBilan";
            this.dataGridViewBilan.RowHeadersWidth = 62;
            this.dataGridViewBilan.Size = new System.Drawing.Size(666, 220);
            this.dataGridViewBilan.TabIndex = 18;
            // 
            // code_matiere
            // 
            this.code_matiere.HeaderText = "code_matiere";
            this.code_matiere.MinimumWidth = 8;
            this.code_matiere.Name = "code_matiere";
            // 
            // designation
            // 
            this.designation.HeaderText = "designation";
            this.designation.MinimumWidth = 8;
            this.designation.Name = "designation";
            // 
            // semestre
            // 
            this.semestre.HeaderText = "semestre";
            this.semestre.MinimumWidth = 8;
            this.semestre.Name = "semestre";
            // 
            // note
            // 
            this.note.HeaderText = "note";
            this.note.MinimumWidth = 8;
            this.note.Name = "note";
            // 
            // TextMoyenneAnnuel
            // 
            this.TextMoyenneAnnuel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            this.TextMoyenneAnnuel.ForeColor = System.Drawing.Color.White;
            this.TextMoyenneAnnuel.Location = new System.Drawing.Point(403, 366);
            this.TextMoyenneAnnuel.Name = "TextMoyenneAnnuel";
            this.TextMoyenneAnnuel.Size = new System.Drawing.Size(140, 20);
            this.TextMoyenneAnnuel.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(405, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Moyenne annuel";
            // 
            // inputEtudiant
            // 
            this.inputEtudiant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            this.inputEtudiant.ForeColor = System.Drawing.Color.White;
            this.inputEtudiant.FormattingEnabled = true;
            this.inputEtudiant.Location = new System.Drawing.Point(17, 215);
            this.inputEtudiant.Name = "inputEtudiant";
            this.inputEtudiant.Size = new System.Drawing.Size(155, 21);
            this.inputEtudiant.TabIndex = 15;
            // 
            // inputNiveau
            // 
            this.inputNiveau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            this.inputNiveau.ForeColor = System.Drawing.Color.White;
            this.inputNiveau.FormattingEnabled = true;
            this.inputNiveau.Location = new System.Drawing.Point(17, 156);
            this.inputNiveau.Name = "inputNiveau";
            this.inputNiveau.Size = new System.Drawing.Size(155, 21);
            this.inputNiveau.TabIndex = 14;
            this.inputNiveau.SelectedIndexChanged += new System.EventHandler(this.inputNiveau_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Etudiant";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Niveau";
            // 
            // inputFiliere
            // 
            this.inputFiliere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            this.inputFiliere.ForeColor = System.Drawing.Color.White;
            this.inputFiliere.FormattingEnabled = true;
            this.inputFiliere.Items.AddRange(new object[] {
            "GINF",
            "GSTR",
            "GSEA",
            "GIND",
            "G3EI",
            "AP"});
            this.inputFiliere.Location = new System.Drawing.Point(17, 91);
            this.inputFiliere.Name = "inputFiliere";
            this.inputFiliere.Size = new System.Drawing.Size(155, 21);
            this.inputFiliere.TabIndex = 11;
            this.inputFiliere.SelectedIndexChanged += new System.EventHandler(this.inputFiliere_SelectedIndexChanged);
            // 
            // ComboFiliere
            // 
            this.ComboFiliere.AutoSize = true;
            this.ComboFiliere.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboFiliere.Location = new System.Drawing.Point(64, 68);
            this.ComboFiliere.Name = "ComboFiliere";
            this.ComboFiliere.Size = new System.Drawing.Size(58, 20);
            this.ComboFiliere.TabIndex = 10;
            this.ComboFiliere.Text = "Filiere";
            // 
            // Bilan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 463);
            this.Controls.Add(this.BtnRechercher);
            this.Controls.Add(this.dataGridViewBilan);
            this.Controls.Add(this.TextMoyenneAnnuel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputEtudiant);
            this.Controls.Add(this.inputNiveau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputFiliere);
            this.Controls.Add(this.ComboFiliere);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Bilan";
            this.Text = "Bilan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBilan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRechercher;
        private System.Windows.Forms.DataGridView dataGridViewBilan;
        private System.Windows.Forms.DataGridViewTextBoxColumn code_matiere;
        private System.Windows.Forms.DataGridViewTextBoxColumn designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn semestre;
        private System.Windows.Forms.DataGridViewTextBoxColumn note;
        private System.Windows.Forms.TextBox TextMoyenneAnnuel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox inputEtudiant;
        private System.Windows.Forms.ComboBox inputNiveau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox inputFiliere;
        private System.Windows.Forms.Label ComboFiliere;
    }
}