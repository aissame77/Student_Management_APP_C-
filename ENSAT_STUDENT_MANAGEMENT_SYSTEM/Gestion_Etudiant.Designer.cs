namespace ENSAT_STUDENT_MANAGEMENT_SYSTEM
{
    partial class Gestion_Etudiant
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
            this.GridEleveData = new System.Windows.Forms.DataGridView();
            this.CodeElev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.niveau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code_fil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnModifier = new System.Windows.Forms.Button();
            this.Btn_Rechercher = new System.Windows.Forms.Button();
            this.Btn_Supprimer = new System.Windows.Forms.Button();
            this.Btn_Ajouter = new System.Windows.Forms.Button();
            this.Btn_New = new System.Windows.Forms.Button();
            this.inputNiveau = new System.Windows.Forms.ComboBox();
            this.inputFiliere = new System.Windows.Forms.ComboBox();
            this.inputNom = new System.Windows.Forms.TextBox();
            this.inputPrenom = new System.Windows.Forms.TextBox();
            this.in_code = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Code = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridEleveData)).BeginInit();
            this.SuspendLayout();
            // 
            // GridEleveData
            // 
            this.GridEleveData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridEleveData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            this.GridEleveData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridEleveData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodeElev,
            this.nom,
            this.prenom,
            this.niveau,
            this.code_fil});
            this.GridEleveData.GridColor = System.Drawing.Color.White;
            this.GridEleveData.Location = new System.Drawing.Point(364, 161);
            this.GridEleveData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GridEleveData.Name = "GridEleveData";
            this.GridEleveData.RowHeadersWidth = 62;
            this.GridEleveData.Size = new System.Drawing.Size(963, 307);
            this.GridEleveData.TabIndex = 33;
            // 
            // CodeElev
            // 
            this.CodeElev.HeaderText = "CodeElev";
            this.CodeElev.MinimumWidth = 8;
            this.CodeElev.Name = "CodeElev";
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
            // niveau
            // 
            this.niveau.HeaderText = "niveau";
            this.niveau.MinimumWidth = 8;
            this.niveau.Name = "niveau";
            // 
            // code_fil
            // 
            this.code_fil.HeaderText = "code_fil";
            this.code_fil.MinimumWidth = 8;
            this.code_fil.Name = "code_fil";
            // 
            // BtnModifier
            // 
            this.BtnModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            this.BtnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModifier.ForeColor = System.Drawing.Color.White;
            this.BtnModifier.Location = new System.Drawing.Point(621, 85);
            this.BtnModifier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnModifier.Name = "BtnModifier";
            this.BtnModifier.Size = new System.Drawing.Size(208, 35);
            this.BtnModifier.TabIndex = 31;
            this.BtnModifier.Text = "Modifier";
            this.BtnModifier.UseVisualStyleBackColor = false;
            this.BtnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
            // 
            // Btn_Rechercher
            // 
            this.Btn_Rechercher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            this.Btn_Rechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Rechercher.ForeColor = System.Drawing.Color.White;
            this.Btn_Rechercher.Location = new System.Drawing.Point(856, 85);
            this.Btn_Rechercher.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Rechercher.Name = "Btn_Rechercher";
            this.Btn_Rechercher.Size = new System.Drawing.Size(219, 35);
            this.Btn_Rechercher.TabIndex = 30;
            this.Btn_Rechercher.Text = "Rechercher";
            this.Btn_Rechercher.UseVisualStyleBackColor = false;
            this.Btn_Rechercher.Click += new System.EventHandler(this.Btn_Rechercher_Click);
            // 
            // Btn_Supprimer
            // 
            this.Btn_Supprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            this.Btn_Supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Supprimer.ForeColor = System.Drawing.Color.White;
            this.Btn_Supprimer.Location = new System.Drawing.Point(1110, 85);
            this.Btn_Supprimer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Supprimer.Name = "Btn_Supprimer";
            this.Btn_Supprimer.Size = new System.Drawing.Size(217, 35);
            this.Btn_Supprimer.TabIndex = 29;
            this.Btn_Supprimer.Text = "Supprimer";
            this.Btn_Supprimer.UseVisualStyleBackColor = false;
            this.Btn_Supprimer.Click += new System.EventHandler(this.Btn_Supprimer_Click);
            // 
            // Btn_Ajouter
            // 
            this.Btn_Ajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            this.Btn_Ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ajouter.ForeColor = System.Drawing.Color.White;
            this.Btn_Ajouter.Location = new System.Drawing.Point(375, 85);
            this.Btn_Ajouter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Ajouter.Name = "Btn_Ajouter";
            this.Btn_Ajouter.Size = new System.Drawing.Size(217, 35);
            this.Btn_Ajouter.TabIndex = 28;
            this.Btn_Ajouter.Text = "Ajouter";
            this.Btn_Ajouter.UseVisualStyleBackColor = false;
            this.Btn_Ajouter.Click += new System.EventHandler(this.Btn_Ajouter_Click);
            // 
            // Btn_New
            // 
            this.Btn_New.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            this.Btn_New.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_New.ForeColor = System.Drawing.Color.White;
            this.Btn_New.Location = new System.Drawing.Point(153, 85);
            this.Btn_New.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_New.Name = "Btn_New";
            this.Btn_New.Size = new System.Drawing.Size(193, 35);
            this.Btn_New.TabIndex = 27;
            this.Btn_New.Text = "Nouveau";
            this.Btn_New.UseVisualStyleBackColor = false;
            this.Btn_New.Click += new System.EventHandler(this.Btn_New_Click);
            // 
            // inputNiveau
            // 
            this.inputNiveau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            this.inputNiveau.ForeColor = System.Drawing.Color.White;
            this.inputNiveau.FormattingEnabled = true;
            this.inputNiveau.Location = new System.Drawing.Point(153, 435);
            this.inputNiveau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputNiveau.Name = "inputNiveau";
            this.inputNiveau.Size = new System.Drawing.Size(180, 28);
            this.inputNiveau.TabIndex = 26;
            // 
            // inputFiliere
            // 
            this.inputFiliere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            this.inputFiliere.ForeColor = System.Drawing.Color.White;
            this.inputFiliere.FormattingEnabled = true;
            this.inputFiliere.Items.AddRange(new object[] {
            "GINF",
            "GSTR",
            "GIND",
            "GSEA",
            "G3EI",
            "AP"});
            this.inputFiliere.Location = new System.Drawing.Point(153, 366);
            this.inputFiliere.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputFiliere.Name = "inputFiliere";
            this.inputFiliere.Size = new System.Drawing.Size(180, 28);
            this.inputFiliere.TabIndex = 25;
            this.inputFiliere.SelectedIndexChanged += new System.EventHandler(this.inputFiliere_SelectedIndexChanged);
            // 
            // inputNom
            // 
            this.inputNom.Location = new System.Drawing.Point(151, 227);
            this.inputNom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputNom.Name = "inputNom";
            this.inputNom.Size = new System.Drawing.Size(182, 26);
            this.inputNom.TabIndex = 24;
            // 
            // inputPrenom
            // 
            this.inputPrenom.Location = new System.Drawing.Point(151, 294);
            this.inputPrenom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputPrenom.Name = "inputPrenom";
            this.inputPrenom.Size = new System.Drawing.Size(182, 26);
            this.inputPrenom.TabIndex = 23;
            // 
            // in_code
            // 
            this.in_code.Location = new System.Drawing.Point(151, 161);
            this.in_code.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.in_code.Name = "in_code";
            this.in_code.Size = new System.Drawing.Size(182, 26);
            this.in_code.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 443);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Niveau";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 367);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Filiere";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 294);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Prenom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 227);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nom";
            // 
            // Code
            // 
            this.Code.AutoSize = true;
            this.Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Code.Location = new System.Drawing.Point(13, 161);
            this.Code.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(64, 25);
            this.Code.TabIndex = 17;
            this.Code.Text = "Code";
            // 
            // Gestion_Etudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1468, 719);
            this.Controls.Add(this.GridEleveData);
            this.Controls.Add(this.BtnModifier);
            this.Controls.Add(this.Btn_Rechercher);
            this.Controls.Add(this.Btn_Supprimer);
            this.Controls.Add(this.Btn_Ajouter);
            this.Controls.Add(this.Btn_New);
            this.Controls.Add(this.inputNiveau);
            this.Controls.Add(this.inputFiliere);
            this.Controls.Add(this.inputNom);
            this.Controls.Add(this.inputPrenom);
            this.Controls.Add(this.in_code);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Code);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Gestion_Etudiant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestion_Etudiant";
            ((System.ComponentModel.ISupportInitialize)(this.GridEleveData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridEleveData;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeElev;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn niveau;
        private System.Windows.Forms.DataGridViewTextBoxColumn code_fil;
        private System.Windows.Forms.Button BtnModifier;
        private System.Windows.Forms.Button Btn_Rechercher;
        private System.Windows.Forms.Button Btn_Supprimer;
        private System.Windows.Forms.Button Btn_Ajouter;
        private System.Windows.Forms.Button Btn_New;
        private System.Windows.Forms.ComboBox inputNiveau;
        private System.Windows.Forms.ComboBox inputFiliere;
        private System.Windows.Forms.TextBox inputNom;
        private System.Windows.Forms.TextBox inputPrenom;
        private System.Windows.Forms.TextBox in_code;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Code;
    }
}