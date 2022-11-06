namespace ENSAT_STUDENT_MANAGEMENT_SYSTEM
{
    partial class Consultation_notes
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
            this.label4 = new System.Windows.Forms.Label();
            this.inputMoyenne = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.inputMatiere = new System.Windows.Forms.ComboBox();
            this.inputNiveau = new System.Windows.Forms.ComboBox();
            this.InputFiliere = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(369, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "Moyenne de classe";
            // 
            // inputMoyenne
            // 
            this.inputMoyenne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            this.inputMoyenne.Location = new System.Drawing.Point(387, 348);
            this.inputMoyenne.Name = "inputMoyenne";
            this.inputMoyenne.Size = new System.Drawing.Size(124, 20);
            this.inputMoyenne.TabIndex = 18;
            this.inputMoyenne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code,
            this.nom,
            this.prenom,
            this.note});
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(169, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(665, 187);
            this.dataGridView1.TabIndex = 17;
            // 
            // code
            // 
            this.code.HeaderText = "code";
            this.code.MinimumWidth = 8;
            this.code.Name = "code";
            // 
            // nom
            // 
            this.nom.HeaderText = "nom";
            this.nom.MinimumWidth = 8;
            this.nom.Name = "nom";
            // 
            // prenom
            // 
            this.prenom.HeaderText = "prenom";
            this.prenom.MinimumWidth = 8;
            this.prenom.Name = "prenom";
            // 
            // note
            // 
            this.note.HeaderText = "note";
            this.note.MinimumWidth = 8;
            this.note.Name = "note";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(43, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 29);
            this.button1.TabIndex = 16;
            this.button1.Text = "Rechercher";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputMatiere
            // 
            this.inputMatiere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            this.inputMatiere.ForeColor = System.Drawing.Color.White;
            this.inputMatiere.FormattingEnabled = true;
            this.inputMatiere.Location = new System.Drawing.Point(43, 198);
            this.inputMatiere.Name = "inputMatiere";
            this.inputMatiere.Size = new System.Drawing.Size(121, 21);
            this.inputMatiere.TabIndex = 15;
            // 
            // inputNiveau
            // 
            this.inputNiveau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            this.inputNiveau.ForeColor = System.Drawing.Color.White;
            this.inputNiveau.FormattingEnabled = true;
            this.inputNiveau.Location = new System.Drawing.Point(43, 137);
            this.inputNiveau.Name = "inputNiveau";
            this.inputNiveau.Size = new System.Drawing.Size(121, 21);
            this.inputNiveau.TabIndex = 14;
            this.inputNiveau.SelectedIndexChanged += new System.EventHandler(this.inputNiveau_SelectedIndexChanged);
            // 
            // InputFiliere
            // 
            this.InputFiliere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            this.InputFiliere.ForeColor = System.Drawing.Color.White;
            this.InputFiliere.FormattingEnabled = true;
            this.InputFiliere.Items.AddRange(new object[] {
            "GINF",
            "GSTR",
            "GSEA",
            "GIND",
            "G3EI",
            "AP"});
            this.InputFiliere.Location = new System.Drawing.Point(43, 81);
            this.InputFiliere.Name = "InputFiliere";
            this.InputFiliere.Size = new System.Drawing.Size(121, 21);
            this.InputFiliere.TabIndex = 13;
            this.InputFiliere.SelectedIndexChanged += new System.EventHandler(this.InputFiliere_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Matiere";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Niveau";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Filiere";
            // 
            // Consultation_notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 521);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputMoyenne);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputMatiere);
            this.Controls.Add(this.inputNiveau);
            this.Controls.Add(this.InputFiliere);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Consultation_notes";
            this.Text = "Consultation_notes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputMoyenne;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn note;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox inputMatiere;
        private System.Windows.Forms.ComboBox inputNiveau;
        private System.Windows.Forms.ComboBox InputFiliere;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}