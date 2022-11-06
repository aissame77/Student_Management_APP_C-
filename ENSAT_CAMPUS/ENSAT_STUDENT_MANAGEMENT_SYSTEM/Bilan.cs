using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENSAT_STUDENT_MANAGEMENT_SYSTEM.Models;
using miniProjet_dll;
using Student_Management_2022_Project.Models;

namespace ENSAT_STUDENT_MANAGEMENT_SYSTEM
{
    public partial class Bilan : Form
    {
        public Bilan()
        {
            InitializeComponent();
        }

        private void inputFiliere_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.inputNiveau.Items.Clear();

            string fil = this.inputFiliere.Text;
            if (fil.Equals("AP"))
            {
                this.inputNiveau.Items.Add(fil + "1");
                this.inputNiveau.Items.Add(fil + "2");
            }
            else
            {
                this.inputNiveau.Items.Add(fil + "1");
                this.inputNiveau.Items.Add(fil + "2");
                this.inputNiveau.Items.Add(fil + "3");
            }

        }

        private void inputNiveau_SelectedIndexChanged(object sender, EventArgs e)
        {
            string niv = inputNiveau.Text;
            Connexion.Connect("Sql");

            string sql = "select code,nom,prenom from Eleves where niveau=" + "'" + niv + "' ;";
            SqlDataReader dr = (SqlDataReader)Connexion.Select(sql);
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    inputEtudiant.Items.Add(dr[0] + ":  " + dr[1] + " " + dr[2]);
                }
                dr.Close();
            }
            else
            {
                MessageBox.Show("la demande n'existe pas pour le moument");
            }
        }

        private void BtnRechercher_Click(object sender, EventArgs e)
        {
            Connexion.Connect("Sql");
            this.dataGridViewBilan.Rows.Clear();
            string fil = inputFiliere.Text;
            string niv = inputNiveau.Text;
            double som = 0.0;
            int count = 0;
            Moyennes Moy = new Moyennes();

            double MoyAn;
            string[] eleV = inputEtudiant.Text.Split(':');
            Moy.code_eleve = eleV[0];
            Moy.code_fil = fil;
            Moy.niveau = niv;
            try
            {

                string sql = "select Mat.code,Mat.designation,Mo.semestre,N.note from Matieres Mat, Modules Mo,Notes N where Mat.code_module = Mo.code and Mo.niveau =" + "'" + niv + "'" + " and N.code_mat = Mat.code and N.code_eleve =" + "'" + eleV[0] + "'" + " and Mo.code_fil =" + "'" + fil + "' ;";
                SqlDataReader dr = (SqlDataReader)Connexion.Select(sql);
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        dataGridViewBilan.Rows.Add(dr[0], dr[1], dr[2], dr[3]);
                        som += Double.Parse(dr[3].ToString());
                        count++;
                    }
                    dr.Close();
                    string sqlm = "select moyenne from Moyennes where code_eleve=" + "'" + eleV[0] + "'";
                    SqlDataReader drm = (SqlDataReader)Connexion.Select(sql);
                    MoyAn = som / count;
                    
                    TextMoyenneAnnuel.Text = MoyAn.ToString();
                   
                }
                else
                {
                    MessageBox.Show("la demande n'existe pas pour le moument");
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("la moyenne existe");
            }
        }
    }
}
