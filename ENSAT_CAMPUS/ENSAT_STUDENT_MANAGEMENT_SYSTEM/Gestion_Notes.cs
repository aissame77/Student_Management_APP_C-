using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using miniProjet_dll;
using ENSAT_STUDENT_MANAGEMENT_SYSTEM.Models;
using Student_Management_2022_Project.Models;

namespace ENSAT_STUDENT_MANAGEMENT_SYSTEM
{
    public partial class Gestion_Notes : Form
    {
        public Gestion_Notes()
        {
            InitializeComponent();
        }
        private void Clean()
        {
            this.inputNote.Text = "";

            inputCodeEleve.Text = "";
            inputMatiere.Text = "";
        }
        private void Btn_Ajouter_Click(object sender, EventArgs e)
        {
            Connexion.Connect("Sql");
            string code_eleve = inputCodeEleve.Text;
            try
            {

                double not = Double.Parse(this.inputNote.Text);

                string mat = inputMatiere.Text;

                Notes note = new Notes();
                note.code_eleve = code_eleve;
                note.code_mat = mat;
                note.note = not;

                int suc = note.save("InsertNote");
                if (suc != 0)
                {
                    MessageBox.Show("ajouter avec succes");
                    this.Clean();
                }
                else
                {
                    MessageBox.Show("L'ajout a echoue");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("erreur produit");
            }
            int matcount = 0, notcount = 0;
            string req = " select count(*) from Notes N where N.code_eleve=+" + "'" + code_eleve + "'";

            SqlDataReader dp = (SqlDataReader)Connexion.Select(req);

            dp.Read();
            notcount = (int)dp[0];
            dp.Close();

            matcount = this.inputMatiere.Items.Count;

            if (matcount == notcount)
            {
                Moyennes Moy = new Moyennes();
                Moy.code_eleve = code_eleve;
                double MOY;
                SqlDataReader dr = (SqlDataReader)Connexion.Select("select AVG(note) from Notes where code_eleve=" + "'" + code_eleve + "'");
                dr.Read();
                MOY = (Double)dr[0];
                dr.Close();
                Moy.code_fil = "GINF";
                Moy.niveau = "GINF2";
                Moy.moyenne = MOY;

                Moy.save();

            }
        }

        private void Btn_Supprimer_Click(object sender, EventArgs e)
        {
            Connexion.Connect("Sql");
            string code = this.inputCodeEleve.Text;
            string mat = inputMatiere.Text;
            string sql = "select id from Notes where code_eleve=" + "'" + code + "' and code_mat=" + "'" + mat + "' ;";
            SqlDataReader dr = (SqlDataReader)Connexion.Select(sql);
            dr.Read();
            Notes note = new Notes();
            note.id = (int)dr["id"];
            dr.Close();
            int succes = note.delete();
            //int succes = note.delete("DeleteNote");
            if (succes != 0)
            {
                MessageBox.Show("Supprime avec succe");
                Clean();
            }
            else
            {
                MessageBox.Show("La suppression a echoue");

            }
        }

        private void Btn_Modifier_Click(object sender, EventArgs e)
        {
            string code = inputCodeEleve.Text;
            string mat = inputMatiere.Text;
            double not = Double.Parse(this.inputNote.Text);
            try
            {
                Connexion.Connect("Sql");
                string sql = "select id from  Notes where note=" + not + " and code_eleve=" + "'" + code + "' and code_mat=" + "'" + mat + "' ;";
                SqlDataReader dr = (SqlDataReader)Connexion.Select(sql);
                dr.Read();
                Notes N = new Notes();
                N.code_eleve = code;
                N.code_mat = mat;
                N.note = not;
                N.id = (int)dr[0];
                dr.Close();
                int succes = N.save();
                if (succes != 0)
                {
                    MessageBox.Show("modifier avec succes");
                    Clean();
                }
                else
                {
                    MessageBox.Show("La modification a echoue");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("un erreur est produit");
            }
        }

        private void Btn_Rechercher_Click(object sender, EventArgs e)
        {
            string code = this.inputCodeEleve.Text;
            string mat = inputMatiere.Text;
            try
            {
                Connexion.Connect("Sql");
                string sql = "select id from Notes where code_eleve=" + "'" + code + "' and code_mat=" + "'" + mat + "' ;";
                SqlDataReader dr = (SqlDataReader)Connexion.Select(sql);
                dr.Read();
                int id = (int)dr[0];

                dr.Close();
                Notes N = new Notes();
                N.id = id;
                dynamic dic = N.find();
                Dictionary<string, object> dict = new Dictionary<string, object>();
                dict = N.ToDictionary<object>(dic);
                inputNote.Text = dict["note"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("la note rechercher n'existe pas essayer une autre");
            }

        }

        private void Btn_Nouveu_Click(object sender, EventArgs e)
        {
            this.Clean();
        }

        private void inputCodeEleve_TextChanged(object sender, EventArgs e)
        {
            this.inputMatiere.Items.Clear();
            string code = this.inputCodeEleve.Text;
            string sql1 = "select id from Eleves where code=" + "'" + code + "'";
            if (code.Length>=3)
            {

                try
                {
                    Connexion.Connect("Sql");
                    string sql = "select id from Eleves where code=" + "'" + code + "'";
                    SqlDataReader dr = (SqlDataReader)Connexion.Select(sql);
                    dr.Read();
                    int id = Int32.Parse(dr[0].ToString());

                    dr.Close();
                    Model ev = new Eleves();
                    ev.id = id;

                    dynamic dic = ev.find();

                    Dictionary<string, object> dictionary = new Dictionary<string, object>();
                    dictionary = ev.ToDictionary<object>(dic);
                    string fil = dictionary["code_fil"].ToString();
                    string niv = dictionary["niveau"].ToString();

                    string req = "select Mat.code from Matieres Mat,Modules M where Mat.code_module=M.code and M.code_fil=" + "'" + fil + "'" + " and  M.niveau=" + "'" + niv + "' ;";
                    SqlDataReader mydr = (SqlDataReader)Connexion.Select(req);

                    if (mydr.HasRows)
                    {
                        while (mydr.Read())
                        {
                            inputMatiere.Items.Add(mydr[0].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("le code de l'eleve peut etre n'existe pas ou vous avez tapez un erreur essayer un autre");
                }



            }
        }
    }
}
